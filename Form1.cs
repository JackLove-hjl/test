using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace 菜单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool b = false;
        bool s = true;

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //获取当前文本字数
            int n = richTextBox1.Text.Length;
            toolStripStatusLabel1.Text = "字数：" + n;

            //获取当前光标所在行和列
            int index = this.richTextBox1.GetFirstCharIndexOfCurrentLine();
            int lines = this.richTextBox1.GetLineFromCharIndex(this.richTextBox1.TextLength) + 1;
            int line = this.richTextBox1.GetLineFromCharIndex(index) + 1;
            int column = this.richTextBox1.SelectionStart - index + 1;
            toolStripStatusLabel2.Text = "第" + line + "行，" + "第" + column + "列";
            chexiaoToolStripMenuItem.Enabled = true;

            s = false;

        }

        public void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength != 0)
            {
                String result1 = richTextBox1.SelectedText;
                int n = result1.Length;
                toolStripStatusLabel1.Text = "字数：" + n;
                jianqieToolStripMenuItem.Enabled = true;
                fuzhiToolStripMenuItem.Enabled = true;
                if (fuzhiToolStripMenuItem.Enabled == true)
                {
                    zhantieToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void fuzhiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void jianqieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void zhantieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void chexiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                richTextBox1.Undo();
            }

        }
        private void 全选AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void 新建NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }

        private void dakaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            if(b==true ||richTextBox1 .Text .Trim ()!="")
            {
                if(s==false )
                {
                    String result;
                    result = MessageBox.Show("文件尚未保存，是否保存？", "保存文件", MessageBoxButtons.YesNoCancel).ToString();
                    if (result == "Yes")
                    {
                        if (b == true)
                        {
                            richTextBox1.SaveFile(openFileDialog1.FileName);

                        }
                        else if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName);
                           
                        }
                        s = true;
                      
                    }
                    if (result == "No")
                    {
                        b = false;
                        richTextBox1.Text = "";
                    }
                }
            }
            openFileDialog1.RestoreDirectory = true;
            if((openFileDialog1 .ShowDialog ()==DialogResult.OK )&&openFileDialog1 .FileName !="")
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                treeView1.Nodes.Add(openFileDialog1 .FileName );
                b = true;
            }
            s = true;
        }

        private void baocunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (b==true &&richTextBox1 .Modified ==true )
            {
                richTextBox1.SaveFile(openFileDialog1.FileName);
                s = true;
            }
            else if(b==false &&richTextBox1 .Text .Trim ()!=""&&saveFileDialog1 .ShowDialog() ==DialogResult .OK )
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
                s = true;
                b = true;
                openFileDialog1.FileName = saveFileDialog1.FileName;
            }
        }

        private void lingcunAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            if (saveFileDialog1 .ShowDialog ()==DialogResult.OK )
            {
                //richTextBox1.SaveFile(saveFileDialog1.FileName);
                StreamWriter sw = File.AppendText(saveFileDialog1.FileName);
                    sw.Write(richTextBox1.Text);
                    sw.Flush();
                    sw.Close();
                s = true;
            }
        }



        private void riqiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(System.DateTime.Now.ToString());
        }

        private void zitiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if(fontDialog1 .ShowDialog ()==DialogResult.OK )
            {
                richTextBox1.SelectionColor = fontDialog1.Color;
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm A = new AboutForm();
            A.Show();
        }

        private void zidongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zidongWToolStripMenuItem .Checked ==false  )
            {
                zidongWToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
            else
            {
                zidongWToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void zhuangtaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(zhuangtaiToolStripMenuItem .Checked ==true )
            {
                zhuangtaiToolStripMenuItem.Checked = false;
                statusStrip1.Visible = false;
                richTextBox1.Height += statusStrip1.Height;
            }
            else
            {
                zhuangtaiToolStripMenuItem.Checked = true;
                statusStrip1.Visible = true;
                richTextBox1.Height -= statusStrip1.Height;
            }
        }
        private void gongjuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Point point;
            if(gongjuToolStripMenuItem .Checked ==true )
            {
                point = new Point(0, 24);
                gongjuToolStripMenuItem.Checked = false;
                menuStrip1.Visible = false;
                richTextBox1.Location = point;
                richTextBox1.Height += menuStrip1.Height;
            }
            else
            {
                point = new Point(0, 49);
                gongjuToolStripMenuItem.Checked = true;
                menuStrip1.Visible = true;
                richTextBox1.Location = point;
                richTextBox1.Height -= menuStrip1.Height;
            }
            
        }

        private void toolStripButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void shouqi_Click(object sender, EventArgs e)
        {
                Point point;  
            if(shouqi.Checked ==true )
            {
                point = new Point(0, 61);
                treeView1.Visible = false;
                shouqi.Checked = false;
                richTextBox1.Location = point;
                richTextBox1.Width += treeView1.Width;
                shouqi.Image = imageList1.Images[1];
                shouqi.Text = "展开侧栏";
            }
            else
            {
                shouqi.Checked = true;
                treeView1.Visible = true;
                point = new Point(120, 61);
                richTextBox1.Location = point;
                richTextBox1.Width -= treeView1.Width;
                shouqi.Image = imageList1.Images[0];
                shouqi.Text = "收起侧栏";
            }                
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            if (b == true || richTextBox1.Text.Trim() != "")
            {
                if (s == false)
                {
                    String result;
                    result = MessageBox.Show("文件尚未保存，是否保存？", "保存文件", MessageBoxButtons.YesNoCancel).ToString();
                    if (result == "Yes")
                    {
                        if (b == true)
                        {
                            richTextBox1.SaveFile(openFileDialog1.FileName);

                        }
                        else if (openFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(saveFileDialog1.FileName);

                        }
                        s = true;

                    }
                    if (result == "No")
                    {
                        b = false;
                        richTextBox1.Text = "";
                    }
                }
            }
            openFileDialog1.RestoreDirectory = true;
            if ((openFileDialog1.ShowDialog() == DialogResult.OK) && openFileDialog1.FileName != "")
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);

                b = true;
            }
            s = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "文本文件|*.txt|所有文件|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = File.AppendText(saveFileDialog1.FileName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
                s = true;
            }
        }

        
        private void treeView1_AfterCheck(object sender, TreeViewEventArgs e)
        {
            treeView1.SelectedNode.Checked = true;
            if(treeView1.SelectedNode.Checked ==true)
            {
                richTextBox1.LoadFile(treeView1.SelectedNode.Text, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
