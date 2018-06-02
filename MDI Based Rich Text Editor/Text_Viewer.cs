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
    public partial class Text_Viewer : Form
    {
        //-----------------------------Variables Declared-----------------------------------------
        public string file_Path { get; set; }  // TO save the current opened file.
        public Font selected_Font_Settings // To get selected text font settings. Applied to save the current formatting state of the text.
        {
            get
            {
                return rtb_FileData.SelectionFont;
            }
        }

        public Color selected_BackColor // To get selected text color settings. Applied to save the current color state of the text.
        {
            get
            {
                return rtb_FileData.SelectionBackColor;
            }
        }

        public Color selected_ForeColor // To get selected text color settings. Applied to save the current color state of the text.
        {
            get
            {
                return rtb_FileData.SelectionColor;
            }
        }

        public HorizontalAlignment selected_Alignment  // To get selected text alignment settings. Applied to save the current alignment state of the text.
        {
            get
            {
                return rtb_FileData.SelectionAlignment;
            }
        }

        public bool selected_Bullets // To get selected text bullet settings. Applied to save the current bullet settings of the text.
        {
            get
            {
                return rtb_FileData.SelectionBullet;
            }
        }
        //--------------------------------------------------------------------------------------------------
        public Text_Viewer()
        {
            InitializeComponent();
        }



        /// <summary>
        /// to set the file path on form load if a new document is created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Text_Viewer_Load(object sender, EventArgs e)
        {
            if (file_Path != null)
                this.Load_File();
            else
                this.Text = "New Rich Text Document.rtf";
        }


        /// <summary>
        /// Function to LOAD a FILE in Rich Text Box
        /// </summary>
        public void Load_File()
        {
            if(file_Path!=null)
            {
                DialogResult save = MessageBox.Show("Do you want to save the file?", "Warning", MessageBoxButtons.OKCancel);
                if (save == DialogResult.OK)
                {
                    this.Save_File();
                }
            }
            rtb_FileData.Clear();
            String[] fileName = file_Path.Split('\\');
            this.Text = fileName[fileName.Length-1];
            rtb_FileData.LoadFile(file_Path, RichTextBoxStreamType.RichText);
        }


        /// <summary>
        /// Function to SAVE a FILE on Hard Drive
        /// </summary>
        public void Save_File()
        {
            if (file_Path == null)
                sfd_SaveFile.FileName = this.Text;
            else
                sfd_SaveFile.FileName = file_Path;


            sfd_SaveFile.Filter = "RTF Files (.rtf) | *.rtf";
            if (sfd_SaveFile.ShowDialog() == DialogResult.OK)
            {
                this.file_Path = sfd_SaveFile.FileName;
                String[] fileName = file_Path.Split('\\');
                this.Text = fileName[fileName.Length - 1];
                rtb_FileData.SaveFile(this.file_Path, RichTextBoxStreamType.RichText);
            }
        }


        /// <summary>
        /// Actual LOGIC to Cut Copy Paste the selected text.
        /// </summary>
        /// <param name="action"></param>
        public void Cut_Copy_Paste(string action)
        {
            if (rtb_FileData.SelectedText!="")
            {
                if (action == "Cut")
                {
                    Clipboard.SetText(rtb_FileData.SelectedText, TextDataFormat.Rtf);
                    rtb_FileData.SelectedRtf = "";
                }
                else if (action == "Copy")
                    Clipboard.SetText(rtb_FileData.SelectedText, TextDataFormat.Rtf);
                else if (action == "Paste")
                    rtb_FileData.SelectedText = Clipboard.GetText(TextDataFormat.Rtf); 
            }
        }


        /// <summary>
        /// Function to set the FONT Settings , COLOR Settings on selected text passed from the Main Form.
        /// </summary>
        /// <param name="f_Temp">Font Settings Passed</param>
        /// <param name="back_color">Back Ground Color Passed</param>
        /// <param name="fore_color">Fore Color Passed</param>
        public void format_Font(Font f_Temp,Color back_color,Color fore_color)
        {
            rtb_FileData.SelectionFont = f_Temp;

            rtb_FileData.SelectionBackColor = back_color;

            rtb_FileData.SelectionColor = fore_color;
        }

        /// <summary>
        /// Function to set the PARAGRAPH FORMAT SETTINGS on selected text passed from the Main Form.
        /// </summary>
        /// <param name="align">Alignment Settings Passed </param>
        /// <param name="is_Bullets_Applied">Bullet Settings Passed</param>
        public void format_Paragraph(string align,bool is_Bullets_Applied)
        {
            if (align == "Left")
                rtb_FileData.SelectionAlignment = HorizontalAlignment.Left;
            else if(align=="Right")
                rtb_FileData.SelectionAlignment = HorizontalAlignment.Right;
            else if (align == "Center")
                rtb_FileData.SelectionAlignment = HorizontalAlignment.Center;


            rtb_FileData.SelectionBullet = is_Bullets_Applied;
        }

        /// <summary>
        /// Function to set the INDENT on selected text passed from the Main Form.
        /// </summary>
        /// <param name="indent">increase indent if true and vice versa</param>
        public void increase_decrease_Indent(bool indent)
        {
            if (indent)
                rtb_FileData.SelectionIndent += 15;
            else
                rtb_FileData.SelectionIndent -= 15;
        }


        /// <summary>
        /// ASK to Save the current file if the Rich Text Viewer is Closed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Text_Viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult save = MessageBox.Show("Do you want to save the file?", "Warning", MessageBoxButtons.OKCancel);
            if(save==DialogResult.OK)
            {
                this.Save_File();
            }
        }
    } 
}
