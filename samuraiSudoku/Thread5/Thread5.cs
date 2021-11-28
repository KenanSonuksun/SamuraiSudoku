using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace samuraiSudoku
{
    public partial class Thread5 : Form
    {
        //for thread 5
        static List<Data> graphic1 = new List<Data>();
        //to get text from the desktop
        static readonly string textFilePath = "C:/Users/Kenan/Desktop/okul/samuraiSudoku/samuraiSudoku/Values/Sudoku.txt";
        //to write the all conclusion to the selected text for thread 5
        static string filePathForThread5 = @"C:/Users/Kenan/Desktop/okul/samuraiSudoku/samuraiSudoku/Values/Thread5.txt";
        static FileStream fileStremForThread5 = new FileStream(filePathForThread5, FileMode.OpenOrCreate, FileAccess.Write);
        static StreamWriter streamWriterForThread5 = new StreamWriter(fileStremForThread5);
        //a box's sizes
        int width = 20;
        int height = 20;
        //to save that how many boxes are filled for thread 5
        static int counter = 0;
        //keeping the time for thread 5
        static Stopwatch timeKeeperForThread5 = new Stopwatch();
        //to save all sudokus
        TextBox[,] textList = new TextBox[21, 21];
        //to save sudokus
        static char[,] sudoku1 = new char[9, 9];
        static char[,] sudoku2 = new char[9, 9];
        static char[,] sudoku3 = new char[9, 9];
        static char[,] sudoku4 = new char[9, 9];
        static char[,] sudoku5 = new char[9, 9];
        public Thread5()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadText();
            start();
        }
        //to read text from the desktop
        public void ReadText()
        {

            string[] lines = File.ReadAllLines(textFilePath);

            for (int i = 0; i < 21; i++)
            {
                var a = lines[i].ToCharArray();
                for (int j = 0, b = 0, d = 0; j < 21; j++, b++, d++)
                {
                    if (a.Length == 18)
                    {

                        if (j == 9 || j == 10 || j == 11)
                        {
                            b--;
                        }
                        else
                        {
                            if (a[b] == '*')
                            {
                                textList[i, j] = new TextBox();
                                textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);
                                sudokuHarita.Controls.Add(textList[i, j]);

                            }
                            else
                            {

                                textList[i, j] = new TextBox();
                                textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);


                                textList[i, j].Text = a[b].ToString();
                                sudokuHarita.Controls.Add(textList[i, j]);
                            }
                        }
                    }

                    if (a.Length == 21)
                    {

                        if (a[j] == '*')
                        {
                            textList[i, j] = new TextBox();
                            textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);

                            sudokuHarita.Controls.Add(textList[i, j]);
                        }
                        else
                        {

                            textList[i, j] = new TextBox();
                            textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);


                            textList[i, j].Text = a[j].ToString();
                            sudokuHarita.Controls.Add(textList[i, j]);
                        }
                    }
                    if (a.Length == 9)
                    {

                        if (j == 0 || j == 1 || j == 2 || j == 3 || j == 4 || j == 5 || j == 15 || j == 16 || j == 17 || j == 18 || j == 19 || j == 20)
                        {
                            d--;
                        }
                        else
                        {
                            if (a[d] == '*')
                            {
                                textList[i, j] = new TextBox();
                                textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);
                                sudokuHarita.Controls.Add(textList[i, j]);

                            }
                            else
                            {

                                textList[i, j] = new TextBox();
                                textList[i, j].SetBounds(20 + j * width, 20 + i * height, width, height);


                                textList[i, j].Text = a[d].ToString();
                                sudokuHarita.Controls.Add(textList[i, j]);

                            }
                        }

                    }

                }
            }

        }
        //to convert the sent matrix's elements to char 
        public void convertToChar(char[,] sudoku, int col1, int col2, int row1, int row2)
        {
            for (int i = col1, a = 0; i < col2; i++, a++)
            {
                for (int j = row1, b = 0; j < row2; j++, b++)
                {
                    if (textList[i, j].Text.Length != 0)
                    {
                        sudoku[a, b] = char.Parse(textList[i, j].Text);
                    }
                    else
                    {
                        sudoku[a, b] = '.';
                    }
                }
            }
        }

        //to solve sudoku
        public static void solveSudoku(char[,] matrix)
        {
            if (matrix == null || matrix.Length == 0)
                return;
            solve(matrix);
        }
        private static bool solve(char[,] matrix)
        {
            //to check all elements from the sent sudoku matrix 
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    //to check that the box is blank or not (dot s mean is the box is blank)
                    if (matrix[i, j] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            //to write the selected text in desktop
                            //streamWriterForThread5.WriteLine("matrisin " + i.ToString() + "-" + j.ToString() + " konumu için denenen değer = " + c.ToString());
                            //streamWriterForThread5.Flush();
                            //to check that the selected number is valid for the box or not
                            if (isValid(matrix, i, j, c))
                            {
                                //to assign the selected number to the box
                                matrix[i, j] = c;
                                if (solve(matrix))
                                {
                                    counter++;
                                    timeKeeperForThread5.Stop();
                                    TimeSpan totalTime = timeKeeperForThread5.Elapsed;
                                    string conculusion = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", totalTime.Hours, totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds).Substring(9);

                                    //to write the selected text in desktop
                                    Data v = new Data()
                                    {
                                        square = counter,
                                        time = conculusion
                                    };
                                    streamWriterForThread5.WriteLine("*****" + "matrisin " + i.ToString() + "-" + j.ToString() + " konumu için seçilen değer = " + c.ToString());
                                    streamWriterForThread5.Flush();
                                    graphic1.Add(v);
                                    timeKeeperForThread5.Start();
                                    return true;
                                }
                                else
                                    matrix[i, j] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }
        //a controlling function to check elements that are correct or not
        private static bool isValid(char[,] matrix, int row, int col, char c)
        {
            //to check the all rows and columns
            for (int i = 0; i < 9; i++)
            {
                //to check columns
                //if there is a number that is equal with the selected number in the matrix's columns, returns false
                if (matrix[i, col] != '.' && matrix[i, col] == c)
                    return false;
                //to check rows
                //if there is a number that is equal with the selected number in the matrix's rows, returns false
                if (matrix[row, i] != '.' && matrix[row, i] == c)
                    return false;
                //to check sub-blocks that are 3x3
                if (matrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] != '.' && matrix[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] == c)
                    return false;
            }
            return true;
        }
        public void fill(char[,] sudoku, int col1, int col2, int row1, int row2)
        {
            for (int i = col1, a = 0; i < col2; i++, a++)
            {
                for (int j = row1, b = 0; j < row2; j++, b++)
                {
                    if (textList[i, j].Text.Length == 0)
                    {
                        textList[i, j].Text = sudoku[a, b].ToString();
                        textList[i, j].ForeColor = Color.Red;
                    }

                }

            }

        }

        //to call the converToChar Function for the all sudokus
        public void start()
        {
            convertToChar(sudoku1, 0, 9, 0, 9);
            convertToChar(sudoku2, 12, 21, 0, 9);
            convertToChar(sudoku5, 6, 15, 6, 15);
            convertToChar(sudoku3, 0, 9, 12, 21);
            convertToChar(sudoku4, 12, 21, 12, 21);
        }

        public void draw()
        {
            fill(sudoku1, 0, 9, 0, 9);
            fill(sudoku2, 12, 21, 0, 9);
            fill(sudoku5, 6, 15, 6, 15);
            fill(sudoku3, 0, 9, 12, 21);
            fill(sudoku4, 12, 21, 12, 21);
        }
        //to save methods
        public void function1()
        {
            solveSudoku(sudoku1);
        }
        public void function2()
        {
            solveSudoku(sudoku2);
        }
        public void function3()
        {
            solveSudoku(sudoku3);
        }
        public void function4()
        {
            solveSudoku(sudoku4);
        }
        public void function5()
        {
            solveSudoku(sudoku5);
        }

        //to start thread (5)
        public void solveWith5Thread()
        {
            timeKeeperForThread5.Start();
            Console.WriteLine("5 thread");

            Thread th = new Thread(function1);
            th.Start();
            Thread th1 = new Thread(function2);
            th1.Start();
            Thread th2 = new Thread(function3);
            th2.Start();
            Thread th3 = new Thread(function4);
            th3.Start();
            Thread th4 = new Thread(function5);
            th4.Start();

            th.Join();
            th1.Join();
            th2.Join();
            th3.Join();
            th4.Join();
        }
        private void solveButtonForThread5_Click(object sender, EventArgs e)
        {
            solveWith5Thread();
            draw();
            foreach (var i in graphic1)
            {
                chart1.Series["zamanKare"].Points.AddXY(i.time, i.square);

            }
            TimeSpan totalTime = timeKeeperForThread5.Elapsed;
            string conculusion = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", totalTime.Hours, totalTime.Minutes, totalTime.Seconds, totalTime.Milliseconds).Substring(9);
            label1.Text = "Total Time = " + conculusion + " ms";
        }

    }
}
