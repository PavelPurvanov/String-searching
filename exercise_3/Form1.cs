﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace exercise_3
{
    public partial class Form1 : Form
    {
        private string myString;
        private List<int> myList = new List<int>();
        private int counter = 0;
        Stopwatch myTimer = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var streamReader = new StreamReader(@"C:\Users\boysa\Documents\Visual Studio 2012\Projects\exercise_3_17621736_SIT\stringFile.txt", Encoding.UTF8))
            {
                myString = streamReader.ReadToEnd();
            }  
            richTextBox1.Text = myString;
        }

        private void searchWord() 
        {
            counter = 0;

            if (searchBox.Text == string.Empty)
            {
                MessageBox.Show("Put something in TextBox !", "TextBox is empty !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                myTimer.Start();
                
                int s_start = richTextBox1.SelectionStart, startIndex = 0, index;
        
                while ((index = richTextBox1.Text.ToLower().IndexOf(searchBox.Text.ToLower(), startIndex)) != -1)
                {
                    
                    richTextBox1.Select(index, searchBox.TextLength);
                    richTextBox1.SelectionColor = Color.Red;
                    startIndex = index + searchBox.TextLength;

                    myList.Add(index);

                    counter++;
                }

                myTimer.Stop();
                labelTiming.Text = myTimer.Elapsed.ToString();
            }

            foreach (var element in myList)
            {
                textBoxPosition.Text += element.ToString() + System.Environment.NewLine;    
            }
            labelCounter.Text = counter.ToString();     
        }

        private static string clear(string setString)
        {
            StringBuilder stringBuilder = new StringBuilder(setString);
            stringBuilder.Replace("  ", " ");
            stringBuilder.Replace(Environment.NewLine, " ");
            stringBuilder.Replace("\\t", string.Empty);
            stringBuilder.Replace("(", " ");
            stringBuilder.Replace(")", " ");
            stringBuilder.Replace(": ", " ");
            stringBuilder.Replace(",", " ");
            stringBuilder.Replace(";", " ");
            stringBuilder.Replace(".", " ");
            stringBuilder.Replace("-", " ");
            stringBuilder.Replace("!", " ");
            stringBuilder.Replace("?", " ");
            stringBuilder.Replace("  ", " ");
            return stringBuilder.ToString();
        }

        private void clearWindow() 
        {
            labelTiming.Text = "";
            labelCounter.Text = "";
            textBoxPosition.Clear();
            searchBox.Clear();
            richTextBox1.Text = myString;
            myList.Clear();  
        }

        private void button1_Clear_Click_1(object sender, EventArgs e)
        {
            clearWindow();
        }

        private void button2_search_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Form1.clear(richTextBox1.Text);
            searchBox.Text = Form1.clear(searchBox.Text);
            searchWord();
        }

        

    }
}
