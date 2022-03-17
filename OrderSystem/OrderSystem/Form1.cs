using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace OrderSystem
{
    #region MainMenu

    public partial class OrderSystem : Form
    {

        #region Methods
        #region LoadOfProgram
        private void OrderSystem_Load(object sender, EventArgs e)
        {
            payButton.BackColor = Color.LightBlue;
            ChangeButtonsColorsDisabled();
            DisablePictureBoxes();
            DisableButtons();
            LoadDateAndTimeInMenu();
            LoadMenuMealsDescriptions();
            LoadMenuDrinksDescriptions();
            LoadMenuPictures();
          
        }
        #endregion
        #region EnableButtons
        public void EnableButtons()
        {

            removeItemButton.Enabled = true;
            printButton.Enabled = true;
            button10.Enabled = true;
            removeItemButton.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            buttonC.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
        }




        #endregion      
        #region DisableButtons
        public void DisableButtons()
        {

            payButton.Enabled = false;
            methodOfPaymentBox.Enabled = false;
            removeItemButton.Enabled = false;
            printButton.Enabled = false;
            button10.Enabled = false;
            button13.Enabled = false;
            removeItemButton.Enabled = false;         
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            buttonC.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
        }
        #endregion
        #region EnableMealPictureBoxes
        public void EnablePictureBoxes()
        {
            PictureOfMeal1.Enabled = true;
            PictureOfMeal2.Enabled = true;
            PictureOfMeal3.Enabled = true;
            PictureOfMeal4.Enabled = true;
            PictureOfMeal5.Enabled = true;
            PictureOfMeal6.Enabled = true;
            PictureOfDrink1.Enabled = true;
            PictureOfDrink2.Enabled = true;
            PictureOfDrink3.Enabled = true;
            PictureOfDrink4.Enabled = true;
            PictureOfDrink5.Enabled = true;
            PictureOfDrink6.Enabled = true;
        }
        #endregion
        #region DisablePictureBoxes
        public void DisablePictureBoxes()
        {
            PictureOfMeal1.Enabled = false;
            PictureOfMeal2.Enabled = false;
            PictureOfMeal3.Enabled = false;
            PictureOfMeal4.Enabled = false;
            PictureOfMeal5.Enabled = false;
            PictureOfMeal6.Enabled = false;
            PictureOfDrink1.Enabled = false;
            PictureOfDrink2.Enabled = false;
            PictureOfDrink3.Enabled = false;
            PictureOfDrink4.Enabled = false;
            PictureOfDrink5.Enabled = false;
            PictureOfDrink6.Enabled = false;
        }

        #endregion
        #region ChangeButtonsColorsDisabled
        public void ChangeButtonsColorsDisabled()
        {

            removeItemButton.BackColor = Color.LightBlue;
            printButton.BackColor = Color.LightBlue;
            button10.BackColor = Color.LightBlue;
            removeItemButton.BackColor = Color.LightBlue;
            button13.BackColor = Color.LightBlue;
        }

        #endregion
        #region ChangeButtonsColorsEnabled
        public void ChangeButtonsColorsEnabled()
        {

            removeItemButton.BackColor = Color.DodgerBlue;
            printButton.BackColor = Color.DodgerBlue;
            button10.BackColor = Color.DodgerBlue;
            removeItemButton.BackColor = Color.DodgerBlue;
            button13.BackColor = Color.DodgerBlue;
        }

        #endregion
        #region RefreshTextBoxes
        public void RefreshTextBoxes()
        {
            costLabel.Text = "0";
            changeLabel.Text = "0";
            subTotalLabel.Text = "";
            pvmLabel.Text = "";
            totalLabel.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            methodOfPaymentBox.Text = " ";
            label4.Text = "";
        }
        #endregion
        #region LoadDateAndTimeInMenu
        public void LoadDateAndTimeInMenu()
        {
            datelabel.Text = DateTime.Now.ToShortDateString();
            timelabel.Text = DateTime.Now.ToShortTimeString();
        }
        #endregion
        #region LoadMenuDescriptions
        public void LoadMenuMealsDescriptions()
        {
            var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
            foreach (var line in lines)
            {
                var itemName = line.Split(',');
                mealLabel1.Text = itemName[0];
                mealLabel2.Text = itemName[2];
                mealLabel3.Text = itemName[4];
                mealLabel4.Text = itemName[6];
                mealLabel5.Text = itemName[8];
                mealLabel6.Text = itemName[10];
            }
        }
        #endregion
        #region LoadMenuDescriptions
        public void LoadMenuDrinksDescriptions()
        {
            var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
            foreach (var line in lines)
            {
                var itemName = line.Split(',');
                drinkLabel1.Text = itemName[0];
                drinkLabel2.Text = itemName[2];
                drinkLabel3.Text = itemName[4];
                drinkLabel4.Text = itemName[6];
                drinkLabel5.Text = itemName[8];
                drinkLabel6.Text = itemName[10];
            }
        }
        #endregion
        #region LoadMenuPictures
        public void LoadMenuPictures()
        {
            PictureOfMeal1.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal1.jpg";
            PictureOfMeal2.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal2.jpg";
            PictureOfMeal3.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal3.jpg";
            PictureOfMeal4.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal4.jpg";
            PictureOfMeal5.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal5.jpg";
            PictureOfMeal6.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Meals\meal6.jpg";
            PictureOfDrink1.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink1.jpg";
            PictureOfDrink2.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink2.jpg";
            PictureOfDrink3.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink3.jpg";
            PictureOfDrink4.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink4.jpg";
            PictureOfDrink5.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink5.jpg";
            PictureOfDrink6.ImageLocation = @"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Data\Pictures\Drinks\drink6.jpg";
        }
        #endregion
        #region GeneratePrintReview
        public void GeneratePrintReview()
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
            dataGridView1.Height = height;
        }
        #endregion
        #region AddValuesToMethodOfPaymentBox
        public void AddValuesToMethodOfPaymentBox()
        {
            methodOfPaymentBox.Items.Add("Cash");
            methodOfPaymentBox.Items.Add("Credit Card");
        }
        #endregion
        #region FinalRecieptGenerator
        public void FinalRecieptGenerator()
        {
            var myUniqueFileName = $@"{DateTime.Now.Ticks}.txt";

            using (StreamWriter file = new StreamWriter($"OrderReciept_{myUniqueFileName}"))
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        {
                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if (c != dataGridView1.Columns.Count - 1)
                            {

                                sLine = sLine + ".";
                            }
                        }
                        file.WriteLine(sLine);
                        sLine = "";
                    }
                    file.WriteLine($"Reciept generated: {DateTime.Now.ToString()} ");
                    file.Close();
                    System.Windows.Forms.MessageBox.Show("1 Reciept for restaurant generated! File generated in Debug folder!", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
        }
        #endregion
        #region FinalRecieptGeneratorForGuest
        public void FinalRecieptGeneratorForGuest()
        {
            if (checkBox7.Checked == true)
            { 
            var myUniqueFileName = $@"{DateTime.Now.Ticks}.txt";

            using (StreamWriter file = new StreamWriter($"OrderReciept_Guest{myUniqueFileName}"))
                try
                {
                    string sLine = "";
                    for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                    {
                        for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        {
                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if (c != dataGridView1.Columns.Count - 1)
                            {

                                sLine = sLine + ".";
                            }
                        }
                        file.WriteLine(sLine);
                        sLine = "";
                    }
                    file.WriteLine($"Reciept generated: {DateTime.Now.ToString()} ");
                    file.Close();
                    System.Windows.Forms.MessageBox.Show("2 Reciept for guest generated! File generated in Debug folder!", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }
        }
        #endregion
        #region Add1MealItemToGrid
        public void Add1MealItemToGrid()
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[0];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[1], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();

            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        #endregion
        #region Add2MealItemToGrid
        public void Add2MealItemToGrid()
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[2];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[3], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }

        #endregion
        #region AdditionalInfoAdderToCheck
        public void AdditionalInfoAdderToCheck()
        {
            if (methodOfPaymentBox.Text == "Cash")
            {
                string sumoforder = totalLabel.Text;
                string cost = costLabel.Text;
                string change = changeLabel.Text;
                string methodofPay = methodOfPaymentBox.Text;
                string table = label4.Text;
                dataGridView1.Rows.Add($"Table: {table}");
                dataGridView1.Rows.Add($"Total:{sumoforder}");
                dataGridView1.Rows.Add($"Cost:{cost}€");
                dataGridView1.Rows.Add($"Change: {change}");
                dataGridView1.Rows.Add($"Payment by: {methodofPay}");
                dataGridView1.Rows.Add($"-------","Thank You!", "-------");
                payButton.Enabled = false;
                button10.Enabled = false;
                removeItemButton.Enabled = false;
            }
            if (methodOfPaymentBox.Text == "Credit Card")
            {
                string sumoforder = totalLabel.Text;
                string cost = costLabel.Text;
                string change = changeLabel.Text;
                string methodofPay = methodOfPaymentBox.Text;
                string table = label4.Text;
                dataGridView1.Rows.Add($"Table: {table}");
                dataGridView1.Rows.Add($"Total:{sumoforder}");
                dataGridView1.Rows.Add($"Payment by: {methodofPay}");
                dataGridView1.Rows.Add($"-------", "Thank You!", "-------");
                payButton.Enabled = false;
                button10.Enabled = false;
                removeItemButton.Enabled = false;
            }
        }
        #endregion
        #region CalculateCostOfItems
        public double CostOfItems()
        {
            double sum = 0;
            int i = 0;

            for (i = 0; i < (dataGridView1.Rows.Count);
            i++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return sum;
        }
        #endregion        
        #region AddCost
        private void AddCost()
        {
            Double pvm, q;
            pvm = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                //pakeisti i eur
                pvmLabel.Text = String.Format("{0:c2}", ((CostOfItems() * pvm) / 100));
                subTotalLabel.Text = String.Format("{0:c2}", CostOfItems());
                q = ((CostOfItems() * pvm / 100));
                totalLabel.Text = String.Format("{0:c2}", CostOfItems() + q);
                //barCodeLabel.Text = Convert.ToString(q + CostOfItems());

            }
        }
        #endregion
        #region ChangeCalculator
        private void Change()
        {
            Double pvm, q, c;
            pvm = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((CostOfItems() * pvm / 100)) + CostOfItems();
                c = Convert.ToInt32(costLabel.Text);
                changeLabel.Text = String.Format("{0:c2}", c - q);
            }
        }
        #endregion
        #region CheckNumbersOnly
        public void CheckNumbersOnly()
        {

        }

        #endregion
        #region CheckBoxChecker
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            {
                if (checkBox1.Checked == true)
                {
                    label4.Text = "Table 1";
                    table1Label.Text = "BUSY";

                }

                if (checkBox1.Checked == false)
                {
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                    checkBox5.Enabled = true;
                    checkBox6.Enabled = true;
                    label4.Text = "";
                    table1Label.Text = "FREE";
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            if (checkBox2.Checked == true)
            {
                label4.Text = "Table 2";
                table2Label.Text = "BUSY";
            }

            if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                label4.Text = "";
                table2Label.Text = "FREE";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            if (checkBox3.Checked == true)
            {
                label4.Text = "Table 3";
                table3Label.Text = "BUSY";

            }

            if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                label4.Text = "";
                table3Label.Text = "FREE";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            if (checkBox4.Checked == true)
            {
                label4.Text = "Table 4";
                table4Label.Text = "BUSY";

            }

            if (checkBox4.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                label4.Text = "";
                table4Label.Text = "FREE";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox6.Enabled = false;
            if (checkBox5.Checked == true)
            {
                label4.Text = "Table 5";
                table5Label.Text = "BUSY";

            }

            if (checkBox5.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox6.Enabled = true;
                label4.Text = "";
                table5Label.Text = "FREE";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox5.Enabled = false;
            if (checkBox6.Checked == true)
            {
                label4.Text = "Table 6";
                table6Label.Text = "BUSY";
            }

            if (checkBox6.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                label4.Text = "";
                table6Label.Text = "FREE";
            }
        }
        #endregion
        #region PayMethodChecker
        public void PayMethodChecker()
        {
            if (methodOfPaymentBox.Text == "Cash")
            {
                Change();
            }
            else
            {
                changeLabel.Text = "";
                costLabel.Text = "0";
            }
        }
        #endregion
        #region RemoveItemsOrNewOrder
        public void RemoveItemsOrNewOrder()
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            if (methodOfPaymentBox.Text == "Cash")
            {
                Change();
            }
            else
            {
                changeLabel.Text = "";
                costLabel.Text = "0";
            }
        }

        #endregion
        #region DisplayInfoMessageToSelectTable
        public void DisplayInfoMessageToSelectTable()
        {
            try
            {
                System.Windows.Forms.MessageBox.Show("Please select table for order!", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
        #region DisplayInfoMessageToPay
        public void DisplayInfoMessageToPay()
        {
            try
            {
                System.Windows.Forms.MessageBox.Show("Ordering finished! Now you can proceed to payment! Select payment method!", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
        #region DisplayInfoMessageToGenerateReciept
        public void DisplayInfoMessageToGenerateReciept()
        {
            try
            {
                System.Windows.Forms.MessageBox.Show("Payed! Now You can generate reciept by clicking button 'Generate Reciept', and if you want you can select checkbox for guest reciept generation", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion

        #endregion

        public OrderSystem()
        {
            InitializeComponent();
        }
        Bitmap bitmap;
        private double price;
        private string nameofitem;
        #region Buttons
        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                GeneratePrintReview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void resetButton_Click(object sender, EventArgs e)
        {
            ChangeButtonsColorsEnabled();
            payButton.Enabled = false;
            DisplayInfoMessageToSelectTable();
            EnablePictureBoxes();
            EnableButtons();
            try
            {
                RefreshTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            AddValuesToMethodOfPaymentBox();
        }
        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (costLabel.Text == "0")
            {
                costLabel.Text = "";
                costLabel.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!costLabel.Text.Contains("."))
                {
                    costLabel.Text = costLabel.Text + b.Text;
                }
            }
            else
                costLabel.Text = costLabel.Text + b.Text;
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            costLabel.Text = "0";
        }
        private void payButton_Click(object sender, EventArgs e)
        {
            DisplayInfoMessageToGenerateReciept();
            PayMethodChecker();
            button13.Enabled = true;
            checkBox7.Enabled = true;
        }
        private void removeItemButton_Click(object sender, EventArgs e)
        {
            RemoveItemsOrNewOrder();
        }
        private void pictureOfMeal1_Click(object sender, EventArgs e)
        {
            Add1MealItemToGrid();
        }
        private void mealPictureBox1(object sender, EventArgs e)
        {
            Add2MealItemToGrid();
        }
        private void mealPictureBox3(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[4];
                }
                return nameofitem;
            }
            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[5], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void mealPictureBox4(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[6];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[7], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void mealPictureBox5(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[8];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[9], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void mealPictureBox6(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[10];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Meals.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[11], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void button10_Click_1(object sender, EventArgs e)
        {

            DisplayInfoMessageToPay();
            DisablePictureBoxes();

            methodOfPaymentBox.Enabled = true;
            payButton.Enabled = false;
            button10.Enabled = false;
            removeItemButton.Enabled = false;

        }
        private void methodOfPaymentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(methodOfPaymentBox.SelectedIndex == 0)
            {
                payButton.Enabled = true;
                payButton.BackColor = Color.DodgerBlue;

            }
            else if(methodOfPaymentBox.SelectedIndex == 1)
            {
                payButton.Enabled = true;
                payButton.BackColor = Color.DodgerBlue;
            }
            
        }
        private void button13_Click(object sender, EventArgs e)
        {
            AdditionalInfoAdderToCheck();
            FinalRecieptGenerator();
            FinalRecieptGeneratorForGuest();
        }
        private void PictureOfDrink1_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[0];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[1], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void PictureOfDrink2_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[2];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[3], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void PictureOfDrink3_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[4];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[5], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void PictureOfDrink4_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[6];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[7], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void PictureOfDrink5_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[8];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[9], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }
        private void PictureOfDrink6_Click(object sender, EventArgs e)
        {
            string ReturnItemName()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    nameofitem = itemName[10];
                }
                return nameofitem;
            }

            double ReturnPrice()
            {
                var lines = File.ReadAllLines(@"C:\Users\eiman\OneDrive\Stalinis kompiuteris\CodeAcademy\OrderSystem\OrderSystem\Properties\DataSources\Drinks.txt");
                foreach (var line in lines)
                {
                    var itemName = line.Split(',');
                    price = double.Parse(itemName[11], CultureInfo.InvariantCulture);
                }
                return price;
            }

            double CostOfItem = ReturnPrice();
            string Name = ReturnItemName();
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = Name))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = double.Parse((string)row.Cells[1].Value) * CostOfItem;
                }
            }
            dataGridView1.Rows.Add(Name, "1", CostOfItem);
            AddCost();
        }      
    }
}
#endregion
#endregion