using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using System.Diagnostics;


namespace WindowsFormsControlLibrary1
{
    [Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class UserControl1: UserControl
    {

        [Browsable(true)]
        [Description("Edit Number TextBox")]
        [Category("Appearance")]
        public string NoTxtBox
        {
            get
            {
                return this.NoTxt.Text;
            }
            set
            {
                this.NoTxt.Text = value;
            }
        }

        [Browsable(true)]
        [Description("Edit Tag TextBox")]
        [Category("Appearance")]
        public string TagTxtBox
        {
            get
            {
                return this.TagTxt.Text;
            }
            set
            {
                this.TagTxt.Text = value;
            }
        }

        [Browsable(true)]
        [Description("Edit Register TextBox")]
        [Category("Appearance")]
        public string RegisterTxtBox
        {
            get
            {
                return this.RegisterTxt.Text;
            }
            set
            {
                this.RegisterTxt.Text = value;
            }
        }
                
        [Browsable(true)]
        [Description("Edit Status TextBox")]
        [Category("Appearance")]
        public string StatusTxtBox
        {
            get
            {
                return this.ValueTxt.Text;
            }
            set
            {
                this.ValueTxt.Text = value;
            }
        }

        DxpSimpleAPI.DxpSimpleClass opc;

        public UserControl1(DxpSimpleAPI.DxpSimpleClass opc)
        {
            this.opc = opc;
            InitializeComponent();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try 
            { 
                    Analog_Value(Convert.ToInt32(ValueTxt.Text));
            }
            catch(Exception)
            {
            }
        }

        private void Analog_Value(int value)
        {
           // PCDCS_Testing_Tool.Form1 log = new PCDCS_Testing_Tool.Form1();
          // LogUserControl.UserControl1 log = new LogUserControl.UserControl1();
            try
            {               
                string[] target = new string[] { RegisterTxt.Text };
                object[] val = new object[] { value };
                int[] nErrorArray;

                opc.Write(target, val, out nErrorArray);
                if (nErrorArray[0] != 0)
                {
                    ValueTxt.Text = "Write Error";
                    return;
                }

                short[] wQualityArray;
                OpcRcw.Da.FILETIME[] fTimeArray;

                if (opc.Read(target, out val, out wQualityArray, out fTimeArray, out nErrorArray) == true)
                {
                    ValueTxt.Text = ReadValCopy(val[0], 0, nErrorArray[0]);
                }
             //   log.LogHistory(DateTime.Now, TagTxt.Text, RegisterTxt.Text, StatusTxt.Text, "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            //    log.LogHistory(DateTime.Now, TagTxt.Text, RegisterTxt.Text, StatusTxt.Text, "Error");
            }
        }

        private string ReadValCopy(object oVal, int n, int nError)
        {
            if (nError != 0)
            {
                return "Read Error";
            }

            return oVal.ToString();
        }


        private void Btn0_Click(object sender, EventArgs e)
        {
            int value = 0;
            Analog_Value(value);

        }

        private void Btn5_Click(object sender, EventArgs e)
        {

            int value = 5000;
            Analog_Value(value);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {

            int value = 10000;
            Analog_Value(value);
        }
    }
}
