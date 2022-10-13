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
namespace GameOfLife
{
    public partial class GameOfLife : Form
    {
        static int maxDim = 2;      //set the size of the game to maxDim x maxDim
        int gen = 0;                //save the generation number
        Button[,] buttons = new Button[maxDim, maxDim];//create an array for the buttons
        Cell[,] cells = new Cell[maxDim, maxDim];//create an array for the cells

        public GameOfLife()
        {
            
            InitializeComponent();
            CreateBoard();
            ResetCells(); //reset the game
        }

        private void CreateBoard()
        {
            int cellNum = 0;    //start cell numbering at 0
            int x = 200;        //starting point of button placement
            int y = 40;         //starting point of button placement
            int size = 400 / maxDim;//set size of all buttons within 400
            buttons = new Button[maxDim, maxDim];
            cells = new Cell[maxDim, maxDim];

            SizeLabel.Text = "Size:" + maxDim.ToString() + "x" + maxDim.ToString();//set the text of the size and gen labels
            GenLabel.Text = "Gen:" + gen.ToString();
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

        private void ResetCells()
        {
            gen = 0;//set generation to 0 and update the label
            GenLabel.Text = "Gen:" + gen.ToString();
            for (int i = 0; i < maxDim; i++) //repeat for all cells
            {
                for (int j = 0; j < maxDim; j++)
                {
                    buttons[i, j].BackColor = Color.Black; //set the color of the cell to black (dead)
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
                        if (cells[i, j].status) x.BackColor = Color.Green; //if the cell is alive now turn green
                        else x.BackColor = Color.Black; //if the cell is dead now turn black
                    }
                }
            }
        }

        private void Next_Gen(object sender, EventArgs e)
        {
            int[,] changes = new int[maxDim, maxDim];//create an array to store the changes
            for (int i = 0; i < maxDim; i++) //repeat for all cells
                for (int j = 0; j < maxDim; j++) changes[i, j] = 0; //reset the changes to 0 by default
            changes = findChanges(changes); //find the changes that need to be made to the board
            updateCellStatus(changes);//update the cell status based on the changes calculated
            updateCells();//update the on screen cells
            gen++; //increase generation
            GenLabel.Text = "Gen:" + gen.ToString();//update generation 
        }

        private void ResetCells(object sender, EventArgs e)
        {
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
                    {
                        if (0 <= x && x < maxDim) //check if row is within the dimensions of the game
                        {
                            if (j - 1 >= 0) //check if the column exists
                                if (cells[x, j - 1].status) neighbors++; //if the cell is alive, increase neighbors
                            if (j + 1 < maxDim) //check if the column is in range of the game
                                if (cells[x, j + 1].status) neighbors++;//if the cell is alive, increase neighbors
                            if (x != i) //check the middle cell if it is not the checking cell
                                if (cells[x, j].status) neighbors++; //if the cell is alive, increase neighbors
                        }
                    }

                    if (cells[i, j].status) //if the checked cell is alive
                    {
                        if (neighbors == 2 || neighbors == 3) changes[i, j] = 1; //if the cell has 2 or 3 neighbors, it will be alive
                    }
                    else
                    {
                        if (neighbors == 3) changes[i, j] = 1; //if the dead cell has 3 neighbors, it will be alive
                    }
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
                    if (x.status) x.cellButton.BackColor = Color.Green; //if cell is alive paint green
                    else x.cellButton.BackColor = Color.Black; //if cell is dead paint black
                }
            }
        }

        public void updateCellStatus(int[,] changes)
        {
            for (int i = 0; i < maxDim; i++) //repeat for all cells
                for (int j = 0; j < maxDim; j++) cells[i, j].set(changes[i, j]); //update the cell status to the changes found
        }

        private void saveGame(object sender, EventArgs e)
        {
            saveGame();
        }

        private void saveGame()
        {
            if (File.Exists("gameData.txt")) File.Delete("gameData.txt");

            StreamWriter file = new StreamWriter("gameData.txt", append: true);

            file.WriteLine(maxDim.ToString());
            file.WriteLine(gen.ToString());
            for (int i = 0; i < maxDim; i++) //check for all cells
            {
                for (int j = 0; j < maxDim; j++)
                    file.WriteLine( cells[i, j].getStatus());
            }
            file.Close();
        }

        private void loadGame(object sender, EventArgs e)
        {
            loadGame();
        }

        private void loadGame()
        {   
            try
            {
                StreamReader file = new StreamReader("gameData.txt");

                for (int i = 0; i < maxDim; i++) //check for all cells
                    for (int j = 0; j < maxDim; j++)
                        Controls.Remove(buttons[i, j]);

                maxDim = Int32.Parse(file.ReadLine());
                gen = Int32.Parse(file.ReadLine());
                int[,] changes = new int[maxDim, maxDim];

                for (int i = 0; i < maxDim; i++) //check for all cells
                    for (int j = 0; j < maxDim; j++)
                        changes[i, j] = Int32.Parse(file.ReadLine());

                file.Close();
                CreateBoard();
                updateCellStatus(changes);
                updateCells();

            }
            catch (Exception) { return; }
        }
    }
}
