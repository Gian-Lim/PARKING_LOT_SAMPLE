using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingLot
{
    public partial class Places : Form
    {
        Functions Con;
        public Places()
        {
            InitializeComponent();
            Con = new Functions();
            ShowPlaces();
        }

        private void ShowPlaces()
        {
            string Query = "SELECT * FROM PlaceTbl";
            PlacesDGV.DataSource = Con.GetData(Query);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (PositionTb.Text == "" || Status.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Position = PositionTb.Text;
                    string Stat = Status.SelectedItem.ToString();
                    string Query = "INSERT INTO PlaceTbl VALUES('{0}', '{1}')";
                    Query = string.Format(Query, Position, Stat, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Place Added!!!");
                    ShowPlaces();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        int Key = 0;
        private void PlacesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PositionTb.Text = PlacesDGV.SelectedRows[0].Cells[1].Value.ToString();
            Status.SelectedItem = PlacesDGV.SelectedRows[0].Cells[2].Value.ToString();
   

            if (PositionTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PlacesDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (PositionTb.Text == "" || Status.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Position = PositionTb.Text;
                    string Stat = Status.SelectedItem.ToString();

                    string Query = "UPDATE PlaceTbl SET Pposition = '{0}', PStatus = '{1}' WHERE PlNum = {2}";
                    Query = string.Format(Query, Position, Stat, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Place Updated!!!");
                    ShowPlaces();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (PositionTb.Text == "" || Status.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Data!!!");
            }
            else
            {
                try
                {
                    string Position = PositionTb.Text;
                    string Stat = Status.SelectedItem.ToString();

                    string Query = "DELETE FROM PlaceTbl WHERE PlNum = {0}";
                    Query = string.Format(Query, Key);
                    Con.SetData(Query);
                    MessageBox.Show("Place Deleted!!!");
                    ShowPlaces();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CarsMenu_Click(object sender, EventArgs e)
        {
            Cars Obj = new Cars();
            Obj.Show();
            this.Hide();
        }

        private void ParkingMenu_Click(object sender, EventArgs e)
        {
            Parking Obj = new Parking();
            Obj.Show();
            this.Hide();
        }

        private void ExitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutPictureBox_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }


    }
    }
