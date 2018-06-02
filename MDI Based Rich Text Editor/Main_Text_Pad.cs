using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Based_Rich_Text_Editor
{
    public partial class Main_Text_Pad : Form
    {
        public Main_Text_Pad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the Form and Initialises the combo boxes in toolstrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Text_Pad_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                tscbx_Fontfamily.Items.Add(family.Name);
            }
            tscbx_Fontfamily.SelectedIndex = 0;

            for (int i = 1; i <= 72; i++)
            {
                tscbx_Fontsize.Items.Add(i);
            }
            tscbx_Fontsize.SelectedIndex = 11;
        }

        /// <summary>
        /// Event Handler for Creating a new file MDI parent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text_Viewer text_Viewer = new Text_Viewer();
            text_Viewer.MdiParent = this;
            text_Viewer.Show();
        }


        /// <summary>
        /// Event handler for opening an existing file from drive.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd_OpenFile.Filter = "RTF Files (.rtf) | *.rtf";
            if(ofd_OpenFile.ShowDialog()==DialogResult.OK)
            {
                Text_Viewer text_View;
                if(this.ActiveMdiChild!=null)
                {
                    text_View = (Text_Viewer)this.ActiveMdiChild;
                    text_View.file_Path = ofd_OpenFile.FileName;
                    text_View.Load_File();
                }
                else
                {
                    text_View = new Text_Viewer();
                    text_View.file_Path = ofd_OpenFile.FileName;
                    text_View.MdiParent = this;
                    text_View.Show();
                }
            }
        }

        /// <summary>
        /// Event handler for saving an open document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                Text_Viewer text_View = (Text_Viewer)this.ActiveMdiChild;
                text_View.Save_File();
            }
        }



        /// <summary>
        /// Combined event handler for Cut Copy and Pasting the selected text.
        /// It will call the CUT_COPY_PASTE function in the actual Rich Text Viewer form to manipulate the rich text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Copy_Paste_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            if (this.ActiveMdiChild != null)
            {
                Text_Viewer text_View = (Text_Viewer)this.ActiveMdiChild;
                text_View.Cut_Copy_Paste(item.Text);
            }
        }


        /// <summary>
        /// Event Handler to to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Combined event handler for handling all the buttons on tool strip.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void format_Text_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripButton pressed_Btn = (ToolStripButton)sender;
                //For BOLD, ITALIC, UNDERLINE, STRIKE THROUGH.
                if (pressed_Btn == tsb_Bold || pressed_Btn == tsb_Italic || pressed_Btn == tsb_UnderLine || pressed_Btn == tsb_StrikeThrough)
                {
                    if (this.ActiveMdiChild != null)
                    {
                        Text_Viewer textView = (Text_Viewer)this.ActiveMdiChild;
                        Font temp_Font = textView.selected_Font_Settings;
                        if (pressed_Btn == tsb_Bold)
                        {
                            if (temp_Font.Bold)
                            {
                                FontStyle style = FontStyle.Regular;
                                if (temp_Font.Italic)
                                {
                                    style = style | FontStyle.Italic;
                                }
                                if (temp_Font.Underline)
                                {
                                    style = style | FontStyle.Underline;
                                }
                                if (temp_Font.Strikeout)
                                {
                                    style = style | FontStyle.Strikeout;
                                }



                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, style), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                            else
                            {
                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, temp_Font.Style | FontStyle.Bold), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                        }

                        if (pressed_Btn == tsb_Italic)
                        {
                            if (temp_Font.Italic)
                            {
                                FontStyle style = FontStyle.Regular;
                                if (temp_Font.Bold)
                                {
                                    style = style | FontStyle.Bold;
                                }
                                if (temp_Font.Underline)
                                {
                                    style = style | FontStyle.Underline;
                                }
                                if (temp_Font.Strikeout)
                                {
                                    style = style | FontStyle.Strikeout;
                                }


                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, style), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                            else
                            {
                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, temp_Font.Style | FontStyle.Italic), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                        }

                        if (pressed_Btn == tsb_UnderLine)
                        {
                            if (temp_Font.Underline)
                            {
                                FontStyle style = FontStyle.Regular;
                                if (temp_Font.Bold)
                                {
                                    style = style | FontStyle.Bold;
                                }
                                if (temp_Font.Italic)
                                {
                                    style = style | FontStyle.Italic;
                                }
                                if (temp_Font.Strikeout)
                                {
                                    style = style | FontStyle.Strikeout;
                                }



                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, style), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                            else
                            {
                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, temp_Font.Style | FontStyle.Underline), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                        }

                        if (pressed_Btn == tsb_StrikeThrough)
                        {
                            if (temp_Font.Strikeout)
                            {
                                FontStyle style = FontStyle.Regular;
                                if (temp_Font.Bold)
                                {
                                    style = style | FontStyle.Bold;
                                }
                                if (temp_Font.Underline)
                                {
                                    style = style | FontStyle.Underline;
                                }
                                if (temp_Font.Italic)
                                {
                                    style = style | FontStyle.Italic;
                                }



                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, style), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                            else
                            {
                                textView.format_Font(new Font(temp_Font.FontFamily, temp_Font.Size, temp_Font.Style | FontStyle.Strikeout), textView.selected_BackColor, textView.selected_ForeColor);
                            }
                        }
                    }
                }
                else if (pressed_Btn == tsb_AlignLeft || pressed_Btn == tsb_AlignCenter || pressed_Btn == tsb_AlignRight)
                {//For ALIGN LEFT, ALIGN CENTER, ALIGN RIGHT.
                    if (this.ActiveMdiChild != null)
                    {
                        Text_Viewer text_view = (Text_Viewer)this.ActiveMdiChild;
                        text_view.format_Paragraph(pressed_Btn.Text, text_view.selected_Bullets);
                    }
                }
                else if (pressed_Btn == tsb_IncreaseIndent || pressed_Btn == tsb_DecreaseIndent)
                {//For INCREASE DECREASE INDENT.
                    if (this.ActiveMdiChild != null)
                    {
                        Text_Viewer text_view = (Text_Viewer)this.ActiveMdiChild;
                        if (pressed_Btn == tsb_IncreaseIndent)
                            text_view.increase_decrease_Indent(true);
                        else
                            text_view.increase_decrease_Indent(false);
                    }
                }
                else if (pressed_Btn == tsb_Bullet)
                {//For ENABLING/DISABLING BULLETS.
                    if (this.ActiveMdiChild != null)
                    {
                        Text_Viewer text_view = (Text_Viewer)this.ActiveMdiChild;
                        if (text_view.selected_Bullets)
                        {
                            text_view.format_Paragraph(text_view.selected_Alignment.ToString(), false);
                        }
                        else
                        {
                            text_view.format_Paragraph(text_view.selected_Alignment.ToString(), true);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Cannot Handle Multiple Fonts and Size");
            }
        }


        /// <summary>
        /// Combined Event Handler for Formatting a FONT when pressed from the TOP MENU.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setFontFormat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem item = null;
                //This check is only for checking whether the color event is called from TOP MENU or from tool strip.
                if (sender.Equals(setFontFormat_ToolStripMenuItem) || sender.Equals(foreColor_ToolStripMenuItem) || sender.Equals(backgroundColor_ToolStripMenuItem))
                {
                    item = (ToolStripMenuItem)sender;
                }
                else
                {
                    ToolStripButton tempitem = (ToolStripButton)sender;
                    if (tempitem.Text == "Fore Color")
                        item = foreColor_ToolStripMenuItem;
                    else
                        item = backgroundColor_ToolStripMenuItem;
                }


                if (this.ActiveMdiChild != null)
                {
                    Text_Viewer text_View = (Text_Viewer)this.ActiveMdiChild;
                    if (item.Text == "Set Font Format") // When Font Format is Pressed
                    {
                        fd_Text.Font = text_View.selected_Font_Settings;
                        if (fd_Text.ShowDialog() == DialogResult.OK)
                        {
                            text_View.format_Font(fd_Text.Font, text_View.selected_BackColor, text_View.selected_ForeColor);
                        }
                    }
                    else if (item.Text == "Fore Color") // When Fore Color is pressed.
                    {
                        cd_Text.Color = text_View.selected_ForeColor;
                        if (cd_Text.ShowDialog() == DialogResult.OK)
                        {
                            text_View.format_Font(text_View.selected_Font_Settings, text_View.selected_BackColor, cd_Text.Color);
                        }
                    }
                    else if (item.Text == "Background Color") // When Background color is pressed
                    {
                        cd_Text.Color = text_View.selected_BackColor;
                        if (cd_Text.ShowDialog() == DialogResult.OK)
                        {
                            text_View.format_Font(text_View.selected_Font_Settings, cd_Text.Color, text_View.selected_ForeColor);
                        }
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Cannot handle multiple Fonts and Size");
            }
        }


        /// <summary>
        /// Combined Event Handler for Formatting a PARAGRAPH except Indentation (DONE in Rich Text Viewer Form) when pressed from the TOP MENU.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setParagraphFormat_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.ActiveMdiChild!=null)
            {
                Text_Viewer text_View = (Text_Viewer)this.ActiveMdiChild;
                Paragraph_Format para_Format = new Paragraph_Format((Text_Viewer)this.ActiveMdiChild);
                para_Format.set_Dialog_State(text_View.selected_Alignment, text_View.selected_Bullets);
                para_Format.ShowDialog();
                if(para_Format.DialogResult==DialogResult.OK)
                { 
                    text_View.format_Paragraph(para_Format.curr_Para_Aligment, para_Format.is_Bullets_Applied);
                }
            }
        }


        /// <summary>
        /// When FONT Family or SIZE is changed is changed from tool strip 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontFamily_Size_Index_Changed(object sender, EventArgs e)
        {
            ToolStripComboBox item = (ToolStripComboBox)sender;
            if (this.ActiveMdiChild != null)
            {
                Text_Viewer text_View = (Text_Viewer)this.ActiveMdiChild;
                if(item==tscbx_Fontfamily)
                {
                    text_View.format_Font(new Font(item.SelectedItem.ToString(), text_View.selected_Font_Settings.SizeInPoints, text_View.selected_Font_Settings.Style), text_View.selected_BackColor, text_View.selected_ForeColor);
                }
                else
                {
                    text_View.format_Font(new Font(text_View.selected_Font_Settings.FontFamily, (int)item.SelectedItem, text_View.selected_Font_Settings.Style), text_View.selected_BackColor, text_View.selected_ForeColor);
                }
            }
        }
    }
}
