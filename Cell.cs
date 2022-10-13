using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    class Cell
    {
        public bool status { get; private set; }    //Stores whether the cell is alive or dead.
        public int cellNumber { get; private set; }   //ID number for the cell.
        public Button cellButton { get; set; }      //Refernce to the button associated with the cell

        public Cell(int number)                     //Constructor for the cell, takes in an ID number
        {
            cellNumber = number;                    //Set cell number 
            status = false;                         //Set default status to false (dead)
        }

        public void toggle()
        {
            status = !status;                       //inverts the status of the cell
        }

        public void set(int x)
        {
            if (x == 1) status = true;            //if the number is 1, set status to true (alive) else false (dead)
            else status = false;
        }

        public string getStatus()
        { 
            return status ? "1" : "0";
        }
    }
}
