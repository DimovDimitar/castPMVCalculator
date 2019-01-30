using System;
using System.Drawing;
using System.Windows.Forms;
using LinqToExcel;
using LinqToExcel.Attributes;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Collections.Generic;

namespace PMV_Tool
{
    public partial class Form1 : Form
    {
        ExcelOne excelClass = new ExcelOne();
        double totalPMV = 0;
        double siteLabour;
        double siteSupervision;
        double materials;
        double plant;
        double correction;
        private string cat1radiobuttonVariable;
        private string cat2radiobuttonVariable;
        private string cat3radiobuttonVariable;
        //private var concated =0;
        private string cat5ListBoxVariable;
        private string cat6ListBoxVariable;
        private string cat7ListBoxVariable;

        public Form1()
        {
            //  private void addNumbers(double categoryNumber, double siteLabourLocal, double siteSupervisionLocal, double Materials, double Plant)
            this.Size = new Size(1400, 1000);
            BackColor = Color.FromArgb(208, 16, 58);
            InitializeComponent();

            //this.questStrucCompComboBox = new ComboBox();

            questStrucCompLabel.Visible = false;
            questStrucCompComboBox.Visible = false;
            structComponentsGroupBox.Visible = false;

            nonStructuralChBox.Visible = false;
            chooseMaterialLabel2.Visible = false;
            chooseMaterialComboBox1.Visible = false;

            Cat1groupBox1.Visible = false;
            Cat2groupBox.Visible = false;
            Cat3groupBox3.Visible = false;
            chart1.Visible = false;

            specifylabel2.Visible = false;
            specifyTextBox1.Visible = false;
         
            nonStructuralLabel.Visible = false;
            nonStructuralDropdown.Visible = false;
          
            Cat5checkedListBox1.Visible = false;
            Cat6checkedListBox1.Visible = false;
            Cat7ChBox.Visible = false;

            specifylabel2.Visible = false;

            specifyTextBox1.Visible = false;
            chart1.Series.Add("Materials");
            chart1.Series.Add("Site Labour");
            chart1.Series.Add("Site Supervision");
            chart1.Series.Add("Plant");

            finalPMVLabel.Visible = false;
            percentLabel.Visible = false;
            PMVtxtBox.Visible = false;
        }

        //-----------------------------------BUILDING TYPOLOGY --------------------------------------------//
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (buildingTypologyLabelcomboBox.SelectedIndex == 0 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 1 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 2 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 3 
                )
            {
                questStrucCompLabel.Visible = true;
                questStrucCompComboBox.Visible = true;                 
            }
            
          }
       
        //-----------------------------------DO YOU USE STRUCT MATERIALS --------------------------------------//
        private void questStrucCompComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (questStrucCompComboBox.SelectedIndex == 0 ||
                questStrucCompComboBox.SelectedIndex == 1 ||
                questStrucCompComboBox.SelectedIndex == 2 ||
                questStrucCompComboBox.SelectedIndex == 3
                )
            {
                
                nonStructuralLabel.Visible = true;
                nonStructuralDropdown.Visible = true;

            }

            else if (questStrucCompComboBox.SelectedIndex == 2)
            {
                structComponentsGroupBox.Visible = false;
            }

            else
            {
                structComponentsGroupBox.Visible = false;
                Cat1groupBox1.Visible = false;
                Cat2groupBox.Visible = false;
                Cat3groupBox3.Visible = false;
            }
        }

        //-----------------------------------NON STRUCTURAL QUESTION -----------------------------------//
        private void nonStructuralDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nonStructuralDropdown.SelectedIndex == 0 ||
                nonStructuralDropdown.SelectedIndex == 1 )
            {
                nonStructuralChBox.Visible = true;
                chooseMaterialLabel2.Visible = true;
                chooseMaterialComboBox1.Visible = true;
            }
            

            else if (nonStructuralDropdown.SelectedIndex == 2)
            {
                chooseMaterialLabel2.Visible = true;
                chooseMaterialComboBox1.Visible = true;
                nonStructuralChBox.Visible = false;
                Cat5checkedListBox1.Visible = false;
                Cat6checkedListBox1.Visible = false;
                Cat7ChBox.Visible = false;
            }
            else
            {
                chooseMaterialComboBox1.Visible = false;
                chooseMaterialLabel2.Visible = false;
            }



        }

        //-----------------------------------NON STRUCTURAL COMPONENT BOX ------------------------------//
        private void nonStructuralChBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nonStructuralChBox.SelectedIndex == 1)
            {
                Cat5checkedListBox1.Visible = true;
            }


            if (nonStructuralChBox.SelectedIndex == 2)
            {
                Cat6checkedListBox1.Visible = true;
            }


            if (nonStructuralChBox.SelectedIndex == 3)
            {
                Cat7ChBox.Visible = true;
            }
            
        }
      
        //-----------------------------------MATERIALS' CHOICE DROPDOWN ---------------------------------------//
        private void chooseMaterialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chooseMaterialComboBox1.SelectedIndex == 0 ||
                chooseMaterialComboBox1.SelectedIndex == 1 ||
                chooseMaterialComboBox1.SelectedIndex == 2 ||
                chooseMaterialComboBox1.SelectedIndex == 3 ||
                chooseMaterialComboBox1.SelectedIndex == 4 ||
                chooseMaterialComboBox1.SelectedIndex == 5 ||
                chooseMaterialComboBox1.SelectedIndex == 6
                )
            {
                structComponentsGroupBox.Visible = true;
            }
        }

        //-----------------------------------CALCULATE BUTTON --------------------------------------------//
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
          
            chart1.Visible = true;
            finalPMVLabel.Visible = true;
            percentLabel.Visible = true;
            PMVtxtBox.Visible = true;
                 
            foreach (var series in chart1.Series)
            {
              series.Points.Clear();
            }
           
            chart1.Legends.Clear();
            chart1.Series["Materials"].Points.Clear();
            chart1.Series["Site Labour"].Points.Clear();
            chart1.Series["Site Supervision"].Points.Clear();
            chart1.Series["Plant"].Points.Clear();

            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 110;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 5;

            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0; 
            chart1.ChartAreas[0].AxisX.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisX.MinorTickMark.Enabled = false;

            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorTickMark.Enabled = false;
            chart1.ChartAreas[0].AxisY.LineColor = chart1.BackColor;

            // SITE LABOUR 
            siteLabour = 30 ; 

            chart1.Series["Site Labour"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Site Labour"]["PixelPointWidth"] = "130";
            chart1.Series["Site Labour"].Points.AddXY(0.5, siteLabour);

            //SITE SUPERVISION
            siteSupervision = 25;

            chart1.Series["Site Supervision"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Site Supervision"]["PixelPointWidth"] = "130";
            chart1.Series["Site Supervision"].Points.AddXY(1.5, siteSupervision) ;

            //MATERIALS
            materials = 40;

            chart1.Series["Materials"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Materials"]["PixelPointWidth"] = "130";
            chart1.Series["Materials"].Points.AddXY(3.5, materials);

            //PLANT & TEMPORARY WORKS
            plant = 5 ;

            chart1.Series["Plant"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Plant"]["PixelPointWidth"] = "130";
            chart1.Series["Plant"].Points.AddXY(4, plant);

            PMVtxtBox.Text = materials.ToString();
            
            chart1.Series["Site Labour"].Label = "Labour " + siteLabour.ToString() + "%";
            chart1.Series["Site Supervision"].Label = "Site Supervision " + siteSupervision.ToString() + "%";
            chart1.Series["Materials"].Label = "Materials " + materials.ToString() + "%";
            chart1.Series["Plant"].Label = "Plant & Temporary" + Environment.NewLine + "Works " + plant.ToString() + "%";

            excelActions();
        }
        
        //-----------------------------------UNCHECK COMMAND -----------------------------------------//
        private void clearButton_Click(object sender, EventArgs e)
        {
           
            
            siteLabour = 0;
            siteSupervision = 0;
            materials = 0;
            plant = 0;
            PMVtxtBox.Text = materials.ToString();

            chart1.Series["Materials"].Points.Clear();
            chart1.Series["Site Labour"].Points.Clear();
            chart1.Series["Site Supervision"].Points.Clear();
            chart1.Series["Plant"].Points.Clear();

           
            structComponentsGroupBox.Visible = false;
            nonStructuralChBox.Visible = false;
            Cat1groupBox1.Visible = false;
            Cat2groupBox.Visible = false;
            Cat3groupBox3.Visible = false;
            Cat5checkedListBox1.Visible = false;
            Cat6checkedListBox1.Visible = false;
            Cat7ChBox.Visible = false;

            foreach (Control c in Cat5checkedListBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        cb.Checked = false;

                    }

                }
            }
            foreach (Control c in Cat6checkedListBox1.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        cb.Checked = false;

                    }

                }
            }
            foreach (Control c in Cat7ChBox.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox cb = (CheckBox)c;
                    if (cb.Checked == true)
                    {
                        cb.Checked = false;

                    }

                }
            }
            
            foreach (Control qs in structComponentsGroupBox.Controls)
            {
         
                if (qs is RadioButton)
                {
                    RadioButton cbw = (RadioButton)qs;
                    if (cbw.Checked == true)
                    {
                        cbw.Checked = false;
                    }
                }
            }

            foreach (Control qs in Cat1groupBox1.Controls)
            {


                if (qs is RadioButton)
                {
                    RadioButton cbw = (RadioButton)qs;
                    if (cbw.Checked == true)
                    {
                        cbw.Checked = false;
                    }
                }
            }
            foreach (Control qs in Cat2groupBox.Controls)
            {


                if (qs is RadioButton)
                {
                    RadioButton cbw = (RadioButton)qs;
                    if (cbw.Checked == true)
                    {
                        cbw.Checked = false;
                    }
                }
            }
            foreach (Control qs in Cat3groupBox3.Controls)
            {


                if (qs is RadioButton)
                {
                    RadioButton cbw = (RadioButton)qs;
                    if (cbw.Checked == true)
                    {
                        cbw.Checked = false;
                    }
                }
            }

            foreach (int i in nonStructuralChBox.CheckedIndices)
            {
                nonStructuralChBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (int i in Cat5checkedListBox1.CheckedIndices)
             {
                 Cat5checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
             }
            
            foreach (int i in Cat6checkedListBox1.CheckedIndices)
            {
                Cat6checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            foreach (int i in Cat7ChBox.CheckedIndices)
            {
                Cat7ChBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            Cat5checkedListBox1.ClearSelected();
            Cat6checkedListBox1.ClearSelected();
            Cat7ChBox.ClearSelected();

        }

        //-----------------------------------RADIO BUTTONS--------------------------------------------//
        private void cat1radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cat1radioButton.Checked)
            {
                chooseMaterialLabel2.Visible = true;
                chooseMaterialComboBox1.Visible = true;

                //nonStructuralLabel.Visible = true;
              //  nonStructuralDropdown.Visible = true;
                Cat1groupBox1.Visible = true;

                foreach (Control c in Cat2groupBox.Controls)
                {
                    if (c is RadioButton)
                    {
                       RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
                foreach (Control c in Cat3groupBox3.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
            }
            else
            {
                Cat1groupBox1.Visible = false;
                           }
        }
        private void Cat2radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat2radioButton.Checked)
            {
                chooseMaterialLabel2.Visible = true;
                chooseMaterialComboBox1.Visible = true;
                Cat2groupBox.Visible = true;
                foreach (Control c in Cat1groupBox1.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
                foreach (Control c in Cat3groupBox3.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
            }
            else
            {
                Cat2groupBox.Visible = false;
            }
               
        }
        private void Cat3radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat3radioButton.Checked)
            {
                chooseMaterialLabel2.Visible = true;
                chooseMaterialComboBox1.Visible = true;
                Cat3groupBox3.Visible = true;
                foreach (Control c in Cat1groupBox1.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
                foreach (Control c in Cat2groupBox.Controls)
                {
                    if (c is RadioButton)
                    {
                        RadioButton cb = (RadioButton)c;
                        if (cb.Checked == true)
                        {
                            cb.Checked = false;

                        }

                    }
                }
            }
        
            else
            {
                Cat3groupBox3.Visible = false;
            }
        }
        private void Cat4radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat4radioButton.Checked && nonStructuralDropdown.Text == "No")
            {
                //chooseMaterialLabel2.Visible = true;
                //chooseMaterialComboBox1.Visible = true;
                chooseMaterialComboBox1.SelectedIndex = chooseMaterialComboBox1.FindStringExact("CONCRETE & CEMENT DERIVED ( C )");
            }
                  
        }

        //-----------------------------------SAVE RESULTS BUTTON ---------------------------------------//
        private void saveResultsButton_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("Results.txt");

            // add the type of building

            if (buildingTypologyLabelcomboBox.SelectedIndex == 0 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 1 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 2 ||
                buildingTypologyLabelcomboBox.SelectedIndex == 3)
            {
                string buildTypo = buildingTypologyLabelcomboBox.Text;
                sw.WriteLine(buildTypo);
            }

            // add the materials used
            if (chooseMaterialComboBox1.SelectedIndex == 0 ||
                chooseMaterialComboBox1.SelectedIndex == 1 ||
                chooseMaterialComboBox1.SelectedIndex == 2 ||
                chooseMaterialComboBox1.SelectedIndex == 3 ||
                chooseMaterialComboBox1.SelectedIndex == 4 ||
                chooseMaterialComboBox1.SelectedIndex == 5 ||
                chooseMaterialComboBox1.SelectedIndex == 6)
            {
                string combo = chooseMaterialComboBox1.Text;
                sw.WriteLine(combo);
            }

            foreach (RadioButton cmb in structComponentsGroupBox.Controls)
            {
                if (cmb.Checked)
                {
                    string firstLine = " \r\n Items selected are: ";
                    string chkname = "\r\n" + cmb.Text;
                    sw.WriteLine(firstLine);
                    sw.WriteLine(chkname, Environment.NewLine);
                }
            }

            foreach (RadioButton cmb in Cat1groupBox1.Controls)
                {
                    
                    if (cmb.Checked)
                    {
                    string chkname = cmb.Text;
                    sw.WriteLine(chkname, Environment.NewLine);
                    }
                }

            foreach (RadioButton cmb in Cat2groupBox.Controls)
                    {
                if (cmb.Checked)
                {
                    string chkname = cmb.Text;
                    sw.WriteLine(chkname, Environment.NewLine);
                }
            }
           
            foreach (object itemChecked in nonStructuralChBox.CheckedItems)
            {
                  string chkname = itemChecked.ToString();
                    sw.WriteLine(chkname, Environment.NewLine);
            }

            foreach (object itemChecked in Cat5checkedListBox1.CheckedItems)
            {
                string chkname = itemChecked.ToString();
                sw.WriteLine(chkname, Environment.NewLine);
            }

            foreach (object itemChecked in Cat6checkedListBox1.CheckedItems)
            {
                string chkname = itemChecked.ToString();
                sw.WriteLine(chkname, Environment.NewLine);
            }

            foreach (object itemChecked in Cat7ChBox.CheckedItems)
            {
                string chkname = itemChecked.ToString();
                sw.WriteLine(chkname, Environment.NewLine);
            }

            // final PMV value

            sw.WriteLine("\r\n" + "And your total PMV % is: " + totalPMV.ToString() + "%");

            sw.Close();
        }


        //----------------------------------READING FROM EXCEL FILE HERE----------------------------//
        private void excelActions()
        {
            string concated;
            var labourVar = 0;
            var materialsVar = 0;
            var siteSupervisionVar = 0;
            var plantVar = 0;

            cat1radiobuttonVariable = getRadioButtonCat1();
            cat2radiobuttonVariable = getRadioButtonCat2();
            cat3radiobuttonVariable = getRadioButtonCat3();

            cat5ListBoxVariable = getCat5ListBox();
            cat6ListBoxVariable = getCat6ListBox();
            cat7ListBoxVariable = getCat7ListBox();

            concated = cat1radiobuttonVariable + cat2radiobuttonVariable + cat3radiobuttonVariable
                + cat5ListBoxVariable + cat6ListBoxVariable + cat7ListBoxVariable;
            Console.WriteLine(concated);



            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, "MMC.xlsx");

            //---------Select the Excel File---------//
            ConnexionExcel ConxObject = new ConnexionExcel(path);
            var query2 = from a in ConxObject.UrlConnexion.Worksheet<ExcelCategories>("PMV Scenarios Cat 1")
                         select a;

            foreach (var result in query2)
            {

                //Console.WriteLine(result.UniqueID);

                if ((result.UniqueID).ToString() == concated )
                {   
                    //labourVar = result.Labour;
                    //materialsVar = result.Materials;
                    //siteSupervisionVar = result.siteSupervision;
                    //plantVar = result.PlantAndTemporaryWorks;

                    string product = "{0:0.000}, {1:0.000}, {2:0.000}, {3:0.000}";
                    MessageBox.Show(string.Format(product, result.Labour, result.siteSupervision,
                      result.Materials, result.PlantAndTemporaryWorks));

                }
                
            }

        }
        
        
        //---------------------------------- READ SELECTED OPTIONS FUNCTIONS HERE -------------------//
        private String getRadioButtonCat1()
        {
            foreach (Control c in Cat1groupBox1.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text.Substring(0,2);
                }
            }
            return "";
        }
        private String getRadioButtonCat2()
        {
            foreach(Control c in Cat2groupBox.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text.Substring(0, 2);
                }
            }
            return "";
        }
        private String getRadioButtonCat3()
        {
            foreach (Control c in Cat3groupBox3.Controls)
            {
                if (c is RadioButton && ((RadioButton)c).Checked == true)
                {
                    return c.Text.Substring(0, 2);
                }
            }
            return "";
        }
        private String getCat5ListBox()
        {
            List<string> List = new List<string>();
            foreach (object itemChecked in Cat5checkedListBox1.CheckedItems)
            {
                List.Add(itemChecked.ToString().Substring(0, 2));
            }

            Console.WriteLine(List);
           
            string s = String.Join("",List.ToArray());
            var combined = s.ToString(); 
            return combined;
        }
        private String getCat6ListBox()
        {
            List<string> List = new List<string>();
            foreach (object itemChecked in Cat6checkedListBox1.CheckedItems)
            {
                List.Add(itemChecked.ToString().Substring(0, 2));
            }

            Console.WriteLine(List);

            string s = String.Join("", List.ToArray());
            var combined = s.ToString();
            return combined;
        }
        private String getCat7ListBox()
        {
            List<string> List = new List<string>();
            foreach (object itemChecked in Cat7ChBox.CheckedItems)
            {
                List.Add(itemChecked.ToString().Substring(0, 2));
            }

            Console.WriteLine(List);

            string s = String.Join("", List.ToArray());
            var combined = s.ToString();
            return combined;
        }

        //string s = List.Aggregate((i, j) => i + j).ToString();
        

        //-----------------------------------STRUCTURAL CATEGORIES OPTIONS---------------------------------------------//
        // Category 1 
        private void Cat1aRadioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat1aRadioButton9.Checked == true && nonStructuralDropdown.Text == "No")
            {

                for (int i = 10; i < 13; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }
       
            }

        }
        private void Cat1bRadioButton10_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat1bRadioButton10.Checked == true && nonStructuralDropdown.Text == "No")
            {
                //cat1bradiobuttonVariable = Cat1bRadioButton10.Text;
                //cat1bradiobuttonVariable = cat1bradiobuttonVariable.Substring(0, 2);
            }
        }

        private void Cat1cRadioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat1cRadioButton.Checked == true && nonStructuralDropdown.Text == "No")
            {

                for (int i = 5; i < 12; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

            }

            else if (Cat1cRadioButton.Checked)
            {
                for (int i = 5; i < 12; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }
            }


            else if (Cat1cRadioButton.Checked == false)
            {



                for (int i = 5; i < 12; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }
            }

            }
        private void Cat1dradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat1dradioButton1.Checked && nonStructuralDropdown.Text == "No")
            {
                for (int i = 0; i < 4; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

               
            }

            else if (Cat1dradioButton1.Checked) {
                for (int i = 0; i < 4; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

           
            }

            else if (Cat1dradioButton1.Checked == false)
            {
                
             

                for (int i = 0; i < 4; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

                for (int i = 0; i < 5; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

            }

        }

        // Category 2

        //2c
        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked && nonStructuralDropdown.Text == "No")
            {
           
                for (int i = 0; i < 7; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

               

            }

            else if (radioButton1.Checked)
            {
                for (int i = 0; i < 7; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }
         
            }

            else if (radioButton2.Checked)
            {
               
            }

            else if (radioButton1.Checked == false)
            {
                for (int i = 0; i < 7; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

             
            }
        }
        //2b
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked && nonStructuralDropdown.Text == "No")
            {
                
              }
          
        }
        //2a
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (cat2aRadioButton.Checked && nonStructuralDropdown.Text == "No")
            {
                
                for (int i = 10; i < 13; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 3; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

            }

            else if (cat2aRadioButton.Checked)
            {
                for (int i = 10; i < 13; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

                for (int i = 0; i < 3; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Indeterminate);
                }

            }
            else if (cat2aRadioButton.Checked == false)
            {
                for (int i = 10; i < 13; i++)
                {
                    Cat5checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

                for (int i = 0; i < 3; i++)
                {
                    Cat6checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                }

            }

        }

        // Category 3
        private void Cat3aradioButton17_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3aradioButton17.Checked && nonStructuralDropdown.Text == "No")
            {
             
            }

       
        }
        private void Cat3bradioButton16_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3bradioButton16.Checked && nonStructuralDropdown.Text == "No")
            {
          
            }

         
        }
        private void Cat3cradioButton15_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3cradioButton15.Checked && nonStructuralDropdown.Text == "No")
            {
        
         
            }

        }
        private void Cat3dradioButton18_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3dradioButton18.Checked && nonStructuralDropdown.Text == "No")
            {
              
            }

         

        }
        private void Cat3eradioButton19_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3eradioButton19.Checked && nonStructuralDropdown.Text == "No")
            {
                
            }

        }
        private void Cat3fradioButton20_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Cat3fradioButton20.Checked && nonStructuralDropdown.Text == "No")
            {
                
           
            }

         
        }
        private void Cat3gradioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (Cat3gradioButton21.Checked && nonStructuralDropdown.Text == "No")
            {
            }
        }

        //-----------------------------------NON STRUCTURAL CATEGORIES OPTIONS------------------------------------------//

        // Cat 5 Checklist 
        private void Cat5checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //a
        }

        // Cat 6 Checklist 
        private void Cat6checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //b
        }

        // Cat 7 Checklist 
        private void Cat7ChBox_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        
        //-----------------------------------VOID FUNCTIONS  ------------------------------------------//

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
         }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Cat6aradioButton16_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void Cat6groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void finalPMVLabel_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void specifyTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void specifylabel2_Click_1(object sender, EventArgs e)
        {

        }
   
        private void structComponentsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void nonStructComponentsGroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void projectSumLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cat1groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cat2groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Cat3groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void questStrucCompLabel_Click(object sender, EventArgs e)
        {

        }
        
        private void Cat4bradioButton_CheckedChanged(object sender, EventArgs e)
        {
        }
   
        private void Cat5OthersradioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void buildingTypologyLabel_Click(object sender, EventArgs e)
        {

        }

        private void CAt7radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cat6radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void specifylabel2_Click(object sender, EventArgs e)
        {

        }

        private void specifyTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Cat7bradioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nonStructuralLabel_Click(object sender, EventArgs e)
        {

        }
        private void chBox3D_2_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
