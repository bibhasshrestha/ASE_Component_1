using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;
 
namespace FirstComponent
{
    /// <summary>
    /// 
    /// </summary>
    public partial class FormMain : Form    
    {
        /// <summary>
        /// 
        /// </summary>
        public int positionX = 0;
        /// <summary>
        /// 
        /// </summary>
        public int positionY = 0;
        /// <summary>
        ///
        /// </summary>
        public FormMain()
        { 
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void PenMove(int x, int y)
        {
            Pen pen_move = new Pen(Color.Black, 3);
            positionX = x;
            positionY = y;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void DrawPen(int a, int b)
        {
            Pen penNew = new Pen(Color.Black, 3);
            Graphics g = MainPanel.CreateGraphics();
            g.DrawLine(penNew, positionX, positionY, a, b);
            positionX = a;
            positionY = b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsolePanel.Text = "";
            var command = mainBox.Text;
            string[] multiLine = command.Split('\n');

            for (int i = 0; i < multiLine.Length - 1; i++)
            {
                String abc = multiLine[i].Trim();
                string[] syntax = abc.Split('(');
                try
                {

                    if (string.Compare(syntax[0].ToLower(), "moveto") == 0)
                    {
                        String[] parameter1 = syntax[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        PenMove(int.Parse(p1), int.Parse(p2));

                    }
                    else if (syntax[0].Equals("\n"))
                    {

                    }
                    else if (string.Compare(syntax[0].ToLower(), "drawto") == 0)
                    {
                        String[] parameter1 = syntax[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        DrawPen(int.Parse(p1), int.Parse(p2));
                    }

                    else if (string.Compare(syntax[0].ToLower(), "clear") == 0)
                    {
                        clear();
                    }

                    else if (string.Compare(syntax[0].ToLower(), "clear") == 0)
                    {
                        reset();
                    }

                    else if (string.Compare(syntax[0].ToLower(), "rectangle") == 0)
                    {
                        String[] parameter1 = syntax[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];
                        rectangleDrawing(positionX, positionY, int.Parse(p1), int.Parse(p2));
                    }

                    else if (string.Compare(syntax[0].ToLower(), "circle") == 0)
                    {
                        String[] parameter2 = syntax[1].Split(')');
                        String p2 = parameter2[0];
                        circleDrawing(positionX, positionY, int.Parse(p2));
                    
                    }
                    else if(string.Compare(syntax[0].ToLower(),"triangle")==0)
                    {
                        String[] parameter1 = syntax[1].Split(',');
                        String[] parameter2 = parameter1[1].Split(')');
                        String p1 = parameter1[0];
                        String p2 = parameter2[0];

                        triangleDrawing(positionX, positionY, int.Parse(p1), int.Parse(p2));
                    }
                    else
                    {
                        ConsolePanel.Text = "";
                        ConsolePanel.Text= ("There is a syntax error on line: " + (i + 1));
                        MainPanel.Refresh();
                        break;

                    }
                }
                catch (Exception)
                {

                    ConsolePanel.Text = "";
                    ConsolePanel.Text = ("Wrong parameter passed on line: " + (i + 1));
                    MainPanel.Refresh();
                    break;
                   
                }
            }
        }
        private void clear()
        {
            MainPanel.Refresh();
            
        }
        private void reset()
        {
            positionX = 0;
            positionY = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public void rectangleDrawing(int a, int b, int c, int d)
        {
            Rectangle rectangleObj = new Rectangle();
            rectangleObj.saved_values(a, b, c, d);
            Graphics g = MainPanel.CreateGraphics();
            rectangleObj.ShapeDraw(g);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public void circleDrawing(int a, int b, int c)
        {
            Circle circleObj = new Circle();
            circleObj.ValueSaved(a, b, c);
            Graphics g = MainPanel.CreateGraphics();
            circleObj.ShapeDraw(g);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        public void triangleDrawing(int a,int b,int c,int d)
        {
            Triangle TrangleObj = new Triangle();
            TrangleObj.SavedValues(a, b, c, d);
            Graphics g = MainPanel.CreateGraphics();
            TrangleObj.ShapeDraw(g);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            ConsolePanel.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog loadFileDialog = new OpenFileDialog();
            loadFileDialog.Filter = "Text File (.txt)|*.txt";
            loadFileDialog.Title = "Load File";

            if(loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader streamReader = new System.IO.StreamReader(loadFileDialog.FileName);
                mainBox.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
        }
          
        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File (.txt)| *.txt";
            saveFileDialog.Title = "Save File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter fWriter = new StreamWriter(saveFileDialog.FileName);
                fWriter.Write(mainBox.Text);
                fWriter.Close();
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the 1st component of ASE assignment.", "Info");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}