using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Based_Rich_Text_Editor
{
    public partial class Paragraph_Format : Form
    {
        Text_Viewer text_View; 

        public string curr_Para_Aligment { get; set; }
        public bool is_Bullets_Applied { get; set; }
        public Paragraph_Format()
        {
            InitializeComponent();
            this.curr_Para_Aligment = "Left";
            btn_Left.BackColor = Color.Black;
            btn_Left.ForeColor = Color.White;
        }

        public Paragraph_Format(Text_Viewer view)
        {
            InitializeComponent();
            this.curr_Para_Aligment = "Left";
            btn_Left.BackColor = Color.Black;
            btn_Left.ForeColor = Color.White;
            this.text_View = view;
        }

        private void Paragraph_Format_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Setting the Button Color and the alignment state according to formatting applied
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Set_Button_State(object sender, EventArgs e)
        {
            Button pressed_Btn = (Button)sender;
            if (pressed_Btn.Text!="I"&&pressed_Btn.Text!="D")
            {
                if(pressed_Btn.Text != "Bullet")
                {
                    if(pressed_Btn.Text=="Left")
                    {
                        this.curr_Para_Aligment = "Left";
                        btn_Left.BackColor = Color.Black;
                        btn_Left.ForeColor = Color.White;
                        btn_Right.BackColor = Color.LightGray;
                        btn_Right.ForeColor = Color.Black;
                        btn_Center.BackColor = Color.LightGray;
                        btn_Center.ForeColor = Color.Black;
                    }
                    else if(pressed_Btn.Text == "Right")
                    {
                        this.curr_Para_Aligment = "Right";
                        btn_Left.BackColor = Color.LightGray;
                        btn_Left.ForeColor = Color.Black;
                        btn_Right.BackColor = Color.Black;
                        btn_Right.ForeColor = Color.White;
                        btn_Center.BackColor = Color.LightGray;
                        btn_Center.ForeColor = Color.Black;
                    }
                    else if (pressed_Btn.Text == "Center")
                    {
                        this.curr_Para_Aligment = "Center";
                        btn_Left.BackColor = Color.LightGray;
                        btn_Left.ForeColor = Color.Black;
                        btn_Right.BackColor = Color.LightGray;
                        btn_Right.ForeColor = Color.Black;
                        btn_Center.BackColor = Color.Black;
                        btn_Center.ForeColor = Color.White;
                    }
                }
                else
                {
                    if(this.is_Bullets_Applied)
                    {
                        btn_Bullet.BackColor = Color.LightGray;
                        btn_Bullet.ForeColor = Color.Black;
                        this.is_Bullets_Applied = false;
                    }
                    else
                    {
                        this.is_Bullets_Applied = true;
                        btn_Bullet.BackColor = Color.Black;
                        btn_Bullet.ForeColor = Color.White;
                    }
                }
                
            }
            else
            {
                if (pressed_Btn.Text == "Increase")
                    text_View.increase_decrease_Indent(true);
                else if (pressed_Btn.Text == "Decrease")
                    text_View.increase_decrease_Indent(false);
            }
        }

        /// <summary>
        /// Setting the Button Color according to alignment current state of selected text before the dialog box is shown to user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void set_Dialog_State(HorizontalAlignment h_align,bool bullets_Applied)
        {
            if(h_align==HorizontalAlignment.Left)
            {
                this.curr_Para_Aligment = "Left";
                btn_Left.BackColor = Color.Black;
                btn_Left.ForeColor = Color.White;
                btn_Right.BackColor = Color.LightGray;
                btn_Right.ForeColor = Color.Black;
                btn_Center.BackColor = Color.LightGray;
                btn_Center.ForeColor = Color.Black;
            }
            else if(h_align==HorizontalAlignment.Right)
            {
                this.curr_Para_Aligment = "Right";
                btn_Left.BackColor = Color.LightGray;
                btn_Left.ForeColor = Color.Black;
                btn_Right.BackColor = Color.Black;
                btn_Right.ForeColor = Color.White;
                btn_Center.BackColor = Color.LightGray;
                btn_Center.ForeColor = Color.Black;
            }
            else if (h_align == HorizontalAlignment.Center)
            {
                this.curr_Para_Aligment = "Center";
                btn_Left.BackColor = Color.LightGray;
                btn_Left.ForeColor = Color.Black;
                btn_Right.BackColor = Color.LightGray;
                btn_Right.ForeColor = Color.Black;
                btn_Center.BackColor = Color.Black;
                btn_Center.ForeColor = Color.White;
            }



            if (!bullets_Applied)
            {
                btn_Bullet.BackColor = Color.LightGray;
                btn_Bullet.ForeColor = Color.Black;
                this.is_Bullets_Applied = false;
            }
            else
            {
                this.is_Bullets_Applied = true;
                btn_Bullet.BackColor = Color.Black;
                btn_Bullet.ForeColor = Color.White;
            }
        }


        /// <summary>
        /// Event Handler to set the Dialog Result State to OK on OK button is Pressed. Form is Closed after wards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paragraph_Format_Submit(object sender, EventArgs e)
        {
            Button pressed_Btn = (Button)sender;
            if(pressed_Btn.Text=="OK")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        
    }
}
