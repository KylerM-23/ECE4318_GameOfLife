using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace GameOfLife
{
    public partial class GameOfLife : Form
    {
        static int maxDim = 5;      //set the size of the game to maxDim x maxDim
        int gen = 0;                //save the generation number
        Button[,] buttons = new Button[maxDim, maxDim];//create an array for the buttons
        Cell[,] cells = new Cell[maxDim, maxDim];//create an array for the cells
        string alive_color ="green"; // used to control cell colors
        string dead_color ="black";  // green and black are default colors; incorrect input colors will automatically display white

        public GameOfLife()
        {
            
            InitializeComponent();  //init GUI
            CreateBoard();          //create the cell buttons
            ResetCells();           //reset the game
        }

        private void CreateBoard()
        {
            int cellNum = 0;    //start cell numbering at 0
            int x = 200;        //starting point of button placement
            int y = 40;         //starting point of button placement
            int size = 400 / maxDim;//set size of all buttons within 400
            buttons = new Button[maxDim, maxDim];
            cells = new Cell[maxDim, maxDim];

            SizeLabel.Text = "Size:";//set the text of the size and gen labels
            GenLabel.Text = "Gen: " + gen.ToString();
            SizeBox.Text = maxDim.ToString();
            for (int i = 0; i < maxDim; i++)//repeat for all possible cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    Button b = new Button();    //create a button and place it at an offset of x + size * placement in row
                    b.Location = new Point(x + size * j, y + size * i);
                    b.Height = size;    //create a size x size button
                    b.Width = size;
                    b.FlatStyle = FlatStyle.Flat;//set button style 
                    b.FlatAppearance.BorderSize = 1;
                    b.FlatAppearance.BorderColor = Color.Gray;
                    b.Click += new EventHandler(Cell_Click); //add method Cell_Click to button
                    Controls.Add(b);//add button to the form
                    cells[i, j] = new Cell(cellNum); //create a new cell
                    cells[i, j].cellButton = b; //assign button to the cell
                    buttons[i, j] = b; // save the button to the array
                    cellNum++; //increase cell number
                }
            }
        }

        private void destroyBoard()
        {
            for (int i = 0; i < maxDim; i++) //check for all cells
                for (int j = 0; j < maxDim; j++)
                    Controls.Remove(buttons[i, j]); //remove the button from the GUI
        }

        private void ResetCells()
        {
            Extinction_Score.Text = "Extinction Score:0";
            gen = 0;//set generation to 0 and update the label
            GenLabel.Text = "Gen: " + gen.ToString();
            for (int i = 0; i < maxDim; i++) //repeat for all cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    buttons[i, j].BackColor = Color.FromName(dead_color); //set the color of the cell to dead_color
                    cells[i, j].set(0);//0 sets the cell to dead
                }
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button x = (Button)sender; //save the button that was clicked
            for (int i = 0; i < maxDim; i++) //check for all cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    if (x == cells[i, j].cellButton) //if the button matches the cell
                    {
                        cells[i, j].toggle(); //invert the status of the cell
                        if (cells[i, j].status) x.BackColor = Color.FromName(alive_color); //if the cell is alive now turn to alive_color
                        else x.BackColor = Color.FromName(dead_color); //if the cell is dead now turn to dead_color
                    }
                }
            }
        }

        private void Next_Gen(object sender, EventArgs e)
        {
            Next_Gen(); 
        }
        
        private void Next_Gen() 
        {
            int[,] changes = new int[maxDim, maxDim];//create an array to store the changes
            for (int i = 0; i < maxDim; i++) //repeat for all cells
                for (int j = 0; j < maxDim; j++) changes[i, j] = 0; //reset the changes to 0 by default
            changes = findChanges(changes); //find the changes that need to be made to the board
            updateCellStatus(changes);//update the cell status based on the changes calculated
            updateCells();//update the on screen cells
            gen++; //increase generation
            GenLabel.Text = "Gen: " + gen.ToString();//update generation 
        }

        private void ResetCells(object sender, EventArgs e)
        {

            int test;
            bool valid = Int32.TryParse(SizeBox.Text, out test); //find the new size

            if (test != maxDim && valid) //if the parse was a success & the dimensions changed
            {
                destroyBoard();          //destroy the board
                maxDim = test;           //update the board size
                CreateBoard();           //create new board
            }

            ResetCells(); //Reset the game
        }

        public int[,] findChanges(int[,] changes)
        {
            int neighbors = 0; //declare a varaible neighbors
            for (int i = 0; i < maxDim; i++) //repeat for all cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    neighbors = 0; //set neighbors to 0
                    for (int x = i - 1; x < i + 2; x++) //check all possible rows
                        if (0 <= x && x < maxDim) //check if row is within the dimensions of the game
                        {
                            if (j - 1 >= 0) //check if the column exists
                                neighbors += (cells[x, j - 1].status) ? 1:0; //if the cell is alive, increase neighbors
                            if (j + 1 < maxDim) //check if the column is in range of the game
                                neighbors += (cells[x, j + 1].status) ? 1 : 0;//if the cell is alive, increase neighbors
                            if (x != i) //check the middle cell if it is not the checking cell
                                neighbors += (cells[x, j].status) ? 1 : 0;//if the cell is alive, increase neighbors
                        }

                    if (cells[i, j].status) { //if the checked cell is alive
                        if (neighbors == 2 || neighbors == 3) changes[i, j] = 1; } //if the cell has 2 or 3 neighbors, it will be alive
                    else {
                        if (neighbors == 3) changes[i, j] = 1; } //if the dead cell has 3 neighbors, it will be alive

                }
            }
            return changes; //return the changes to be made
        }

        public void updateCells()
        {
            for (int i = 0; i < maxDim; i++)//repeat for all cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    Cell x = cells[i, j]; //save cell into variable
                    if (x.status) x.cellButton.BackColor = Color.FromName(alive_color); //if cell is alive paint alive_color
                    else x.cellButton.BackColor = Color.FromName(dead_color); //if cell is dead paint dead_color
                }
            }
        }

        public void updateCellStatus(int[,] changes)
        {
            for (int i = 0; i < maxDim; i++) //repeat for all cells
                for (int j = 0; j < maxDim; j++) cells[i, j].set(changes[i, j]); //update the cell status to the changes found
        }


        private void loadGame(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();   //open file dialog
            dialog.Multiselect = false;                     //only select one file
            dialog.Filter = "Game Of Life|*.gol";           //only allow game of life files
            dialog.DefaultExt = ".gol";                     //game of life extension
            if (dialog.ShowDialog() == DialogResult.OK)     //if the user selects a file
                loadGame(dialog.FileNames[0]);              //call load game function and pass file path
        }

        private void saveGame(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog(); //Create dialog window
            dialog.Filter = "Game Of Life|*.gol";         //only view Game of Life save files
            dialog.DefaultExt = ".gol";         
            if (dialog.ShowDialog() == DialogResult.OK)   //if a file was selected
                saveGame(dialog.FileNames[0]);            //call the saveGame function and pass the file path
        }

        private void saveGame(string fp)
        {
            try
            {
                if (File.Exists(fp)) File.Delete(fp);                   //if the game exists, delete

                StreamWriter file = new StreamWriter(fp, append: true); //create writer

                file.WriteLine(maxDim.ToString());                      //save board size on first line
                file.WriteLine(gen.ToString());                         //save generations on second line
                for (int i = 0; i < maxDim; i++) //check for all cells
                    for (int j = 0; j < maxDim; j++)
                        file.WriteLine(cells[i, j].getStatus());        //save the cell status on the line
                file.Close();                                           //close file
            }
            catch (Exception) { return; } //if something goes wrong, do not make changes.
        }

        private void loadGame(string fp)
        {   
            try
            {
                StreamReader file = new StreamReader(fp); //create file reader
                destroyBoard();                           

                maxDim = Int32.Parse(file.ReadLine());    //first line is the dimensions
                gen = Int32.Parse(file.ReadLine());       //second line is the generations
                int[,] changes = new int[maxDim, maxDim];
                
                for (int i = 0; i < maxDim; i++) //check for all cells
                    for (int j = 0; j < maxDim; j++)
                        changes[i, j] = Int32.Parse(file.ReadLine()); //Read the line and store in a changes list

                file.Close(); //close the file
                CreateBoard(); //create board based on save file size
                updateCellStatus(changes); //update cells
                updateCells(); //display changes
            }
            catch (Exception) { return; } //if something goes wrong, do not make changes.
        }
        
        private async void FastForward(object sender, EventArgs e) // basically repeats Next_Gen() ?num_gen? times
        {
            int num_gen = 0; // will hold desired number of generations to fast forward
            bool valid = Int32.TryParse(Forward_Textbox.Text, out num_gen); // get desired number of generations to fast forward
            if (valid && num_gen>0) // if input number is valid and over 0
            {
                int delay_time = 500; // delay time between generations
                for (int gen_idx = 0; gen_idx < num_gen; ++gen_idx) // loops for desired number of generations
                {
                    Next_Gen(); // do one generation
                    GenLabel.Text = "Gen: " + gen.ToString(); // update Gen label
                    await Task.Delay(delay_time); // delay
                }
            }
        }
        
        private async void Extinction(object sender, EventArgs e)
        {   // game where you initialize your cell community and hope it survives
            // you get a score based on how many cells survived
            GenLabel.Text = "Gen: " + gen.ToString();     // get current gen label
            Extinction_Score.Text = "Extinction Score:0"; // set score to 0
            await Task.Delay(1); // brief delay
            for (int gen_idx = 0; gen_idx < 10000; ++gen_idx) Next_Gen(); // spam Next_Gen() to simulate an extinction
            Extinction_Score.Text = "Extinction Score:" + Count_Alive_Cells().ToString(); // return score
        }

        public int Count_Alive_Cells()
        {
            int score = 0;
            for (int i = 0; i < maxDim; i++)     //repeat for all cells
                for (int j = 0; j < maxDim; j++) //
                    score += cells[i, j].status ? 1 : 0; // check status and add up alive cells
            return score;
        }
        
        private void Set_Cell_Colors(object sender, EventArgs e) // change cell colors AND ALSO board size
        {
            // set colors for both alive and dead cells from user input
            alive_color = Alive_Color_Textbox.Text;
            dead_color = Dead_Color_Textbox.Text;
            
            
            int test; // TEST stands for: The End-user's Size Text i.e. the desired size
            bool valid = Int32.TryParse(SizeBox.Text, out test); //read the new dimensions

            if (test != maxDim && valid) //if the user entered a valid response and the dimensions changed
            {
                destroyBoard();         //destroy the board
                maxDim = test;          //update the size
                CreateBoard();          //create the new board
                ResetCells();           //Reset the game
            }

            // update cell colors immediately after
            updateCells();
        }

        private void GameOfLife_Load(object sender, EventArgs e)
        {

        }
    }
}
