using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using LumenWorks.Framework.IO.Csv;

/*
 * Nathan Tai
 * P148535
 * 08/06/2021
 * Programming III, Activity 6
 * Climate Sensors to CSV
 * 
 * "JMC receives output from many different climate sensors 
 * in CSV format you must write a program to display this data. 
 * You need to create a program that uses an external 3rd party 
 * library to read and write data to a CSV format. You program 
 * must have an open and save dialog box interface so the user 
 * can select a file to be displayed in a GUI (a table is fine)."
 */

namespace ClimateSensors
{
    public partial class ClimateSensorsForm : Form
    {
        public ClimateSensorsForm()
        {
            InitializeComponent();

            //Disable buttons until file opened to avoid errors
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnSearch.Enabled = false;

            //Text boxes ReadOnly until file opened
            tbTemp.ReadOnly = true;
            tbHumidity.ReadOnly = true;
            tbWindSpeed.ReadOnly = true;
        }

        #region Globals

        //Sets initial directory for open file dialog, relative path
        string initialDirectory = "..\\debug";

        //Global variable for filePath
        string filePath;

        #endregion Globals

        #region Methods

        //Clear textboxes
        private void ClearTextBoxes()
        {
            tbTemp.Clear();
            tbHumidity.Clear();
            tbWindSpeed.Clear();
        }

        //Write to CSV file
        public void CSVWriteFile(string data, string fileName)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fileName, append: true);
                sw.WriteLine(data);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        //Find a certain temperature reading
        private void FindTemp(string target)
        {
            if (!string.IsNullOrEmpty(target))
            {
                target += "°C"; //Match table formatting
                try
                {
                    //Get list
                    ITypedList tList = (ITypedList)((IListSource)dataGrid1.DataSource).GetList();
                    IBindingList bList = (IBindingList)tList;

                    //Get index
                    int index = bList.Find(tList.GetItemProperties(null)[0], target);

                    //Highlight found entry
                    dataGrid1.Rows[index].Selected = true;
                }
                catch
                {
                    MessageBox.Show("Not found");
                }
            }
            else
            {
                MessageBox.Show("Temperature field empty");
            }
        }

        //Save data to CSV
        private void Save()
        {
            //Check for empty fields
            if ((!string.IsNullOrEmpty(tbTemp.Text))
                && (!string.IsNullOrEmpty(tbHumidity.Text))
                && (!string.IsNullOrEmpty(tbWindSpeed.Text)))
            {
                //Write to CSV
                CSVWriteFile(StringFormat(tbTemp.Text, tbHumidity.Text, tbWindSpeed.Text), filePath);

                //Display CSV in table using global filePath variable
                ShowCSV(filePath);

                //Guess what this does
                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("One or more fields empty");
            }
        }

        //Method to display data from CSV in table
        private void ShowCSV(string filePath)
        {
            using (CachedCsvReader csv = new CachedCsvReader(new StreamReader(filePath), true))
            {
                dataGrid1.DataSource = csv;
            }
        }

        //Adds formatting to user inputs for display
        private string StringFormat(string temp, string humidity, string windSpeed)
        {
            string data = temp + "°C" + "," + humidity + "%" + "," + windSpeed + "km/h";
            return data;
        }

        //Method to select and open CSV files
        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //Setting directory parameters
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    string file = openFileDialog.FileName;

                    //Set global filePath variable for other methods
                    filePath = file;

                    //Display in table
                    ShowCSV(filePath);

                    //Enable buttons if file opened
                    btnSave.Enabled = true;
                    btnClear.Enabled = true;
                    btnSearch.Enabled = true;

                    //Set text boxes ReadOnly status to false
                    tbTemp.ReadOnly = false;
                    tbHumidity.ReadOnly = false;
                    tbWindSpeed.ReadOnly = false;
                }
            }
        }

        //For testing
        /*private string WriteHeader()
		{
			string header = "Temperature" + "," + "Humidity" + "," + "Wind Speed";
			return header;
		}*/

        #endregion Methods

        #region Buttons

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            ClearTextBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindTemp(tbTemp.Text);
            ClearTextBoxes();
        }

        #endregion Buttons

    }
}
