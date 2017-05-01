
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace FindDigitsInRawTextData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           char[][] textData= ReadAllLines(@"C: \Users\ranjith\Desktop\NumberParserExtended.txt ");


            string [][] textData2 = ReadAllLines2(@"C: \Users\ranjith\Desktop\NumberParserExtended.txt ");

            Console.WriteLine("Original Data");

            foreach (var VARIABLE in textData)
            {
                
                Console.WriteLine(VARIABLE);
            }
            

            var digits = textData.Take(textData.Length / 2).ToArray().ToArray();

            var CopyodDigits = digits;

            foreach (var VARIABLE in CopyodDigits)
            {

                Console.WriteLine(VARIABLE);
            }


            for (int row = 0; row < 4; row++)
            {
                var eachRow = CopyodDigits[row].Length;


                for (int column = 0; column < eachRow; column++)
                {
                    char c = CopyodDigits[row][column];

                    while ( c == '\t' || c == ' ' || Char.IsWhiteSpace(c))
                    {

                        try
                        {

                            var datacolumn = MatrixExtensions.GetCol(CopyodDigits, column);


                            if (datacolumn.Contains('$'))
                            {
                               char[] colvector = new char[] { '$','$','$','$'};
                                
                                MatrixExtensions.SetCol(CopyodDigits, column, colvector);
                            }
                            bool result = Array.TrueForAll(datacolumn, eachColChar => eachColChar == '\t' || eachColChar == ' ' || Char.IsWhiteSpace(eachColChar));


                            if (result)
                            {

                                
                                    CopyodDigits[row][column] = '$';
                                
                                

                            }

                            else
                            {
                                //if( )

                            }

                            break;

                        }
                        catch (Exception e)
                        {
                            break;
                            Console.WriteLine(e);
                           // throw;
                        }

                      
                    }

                }
            }


            Console.WriteLine("Digits Data using Linq");
            foreach (var VARIABLE in CopyodDigits)
            {

                Console.WriteLine(VARIABLE);
            }




            //for (int i = 0; i < 26; i++)
            //{


            //    if (digits.All(c => c[i] == '\t') || digits.All(c => c[i] == ' ') || digits.All(c => Char.IsWhiteSpace(c[i])))
            //    {

            //        digits[0][i] = digits[0][i - 1] == '$' ? ' ' : '$';

            //        digits[1][i] = digits[1][i - 1] == '$' ? ' ' : '$';

            //        digits[2][i] = digits[2][i - 1] == '$' ? ' ' : '$';

            //        digits[3][i] = digits[3][i - 1] == '$' ? ' ' : '$';

            //    }



            //}








            Console.WriteLine("Digits Data using Linq");
            foreach (var VARIABLE in textData)
            {

                Console.WriteLine(VARIABLE);
            }




            ////for (int i = 0; i < 26; i++)
            ////{
            ////    bool all = false;

            ////    for (int j = 0; j < 4; j++)
            ////    {
            ////        if ((CopyodDigits[j][i] == '\t') || (CopyodDigits[j][i] == ' ') || (Char.IsWhiteSpace(CopyodDigits[j][i])))
            ////        {
            ////            all = true;
            ////        }
            ////        else
            ////        {
            ////            all = false;
            ////        }
            ////        if (all)
            ////        {

            ////            CopyodDigits[0][i] = '$';

            ////            CopyodDigits[1][i] = '$';
            ////            CopyodDigits[2][i] = '$';
            ////            CopyodDigits[3][i] = '$';
            ////        }
            ////    }
            ////}

            //Console.WriteLine("CopyodDigits Data");
            //foreach (var VARIABLE in CopyodDigits)
            //{

            //    Console.WriteLine(VARIABLE);
            //}








        }

        private void btnOpenFile_Click(object sender, RoutedEventArgs e)
        {

            var openFileDialog = new OpenFileDialog
            {
                
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == true)
            {
               

                var fullName = openFileDialog.FileName;
                var fileName = System.IO.Path.GetFileName(fullName);

                //try
                //{
                    
                    txtEditor.Text = File.ReadAllText(openFileDialog.FileName);

                  var datainlist=  File.ReadAllLines(openFileDialog.FileName).ToList();


              // var  firstArray = datainlist.Take(datainlist.Count / 2).ToArray();


              var allchars=  ReadAllLines(openFileDialog.FileName);


                var digits = allchars.Take(allchars.Length / 2).ToArray();


                for (int i = 0; i < 26; i++)
                {
                    //bool all = false;

                    //for (int j = 0; j < 4; j++)
                    //{
                    //    if ((digits[j][i] == '\t') || (digits[j][i] == ' ') || (Char.IsWhiteSpace(digits[j][i])))
                    //    {
                    //        all = true;
                    //    }
                    //    else
                    //    {
                    //        all = false;
                    //    }
                    //    ////if (digits.All(c=>c[i]== '\t')|| digits.All(c => c[i] == ' '))
                    //}
                   // if (all)

                    //if (digits.All(c=>c[i]== '\t')|| digits.All(c => c[i] == ' ') || digits.All(c => Char.IsWhiteSpace(c[i])))
                    //{

                    //    digits[0][i]=  digits[0][i-1] == '$' ? ' ' : '$';

                    //    digits[1][i] = digits[1][i - 1] == '$' ? ' ' : '$';

                    //    digits[2][i] = digits[2][i - 1] == '$' ? ' ' : '$';

                    //    digits[3][i] = digits[3][i - 1] == '$' ? ' ' : '$';  
                    //    //digits[0][i] = '$';

                    //    //digits[1][i] = '$';
                    //    //digits[2][i] = '$';
                    //    //digits[3][i] = '$';
                    //}
                    


                }
                foreach (var VARIABLE in digits)
                {

                    Console.WriteLine(VARIABLE);
                }

                var getLastRow = digits.LastOrDefault();


                


               

                var rows = File.ReadAllLines(openFileDialog.FileName).Select(l => l.Split(new char[] { '\r', '\n' })).ToArray();

                
               
            }
        }



        private static string[][] ReadAllLines2(string filename)
        {
            string[] allFileLines = File.ReadAllLines(filename);

            string[][] arr = new string[allFileLines.Length][];

            for (int rowIndex = 0; rowIndex < allFileLines.Length; rowIndex++)
            {
                char[] delimiters = new char[] { ' ', '\t' };
                string[] parts = allFileLines[rowIndex].Split(delimiters,
                                 StringSplitOptions.None);


                arr[rowIndex] = parts;
            }

            return arr;
        }



        private static char[][] ReadAllLines(string filename)
        {
            string[] allFileLines = File.ReadAllLines(filename);

            char[][] arr = new char[allFileLines.Length][];

            for (int rowIndex = 0; rowIndex < allFileLines.Length; rowIndex++)
            {

                arr[rowIndex] = allFileLines[rowIndex].ToCharArray();
            }

            return arr;
        }

        //public void PrepareData(List<string> data)
        //{

        //    List<string> formatedString = new List<string>();

        //    foreach (var line in data)
        //    {

        //        char[] array = line.TrimEnd().TrimStart().ToCharArray();

        //        Queue<char> formatedLine = new Queue<char>();

        //        foreach (var eachChar in array)
        //        {
        //           // Stack<char> formatedLine = new Stack<char>();
        //            bool digitBreak = false;

        //            if (eachChar == '/' || eachChar == '\\' || eachChar == '_' || eachChar == '-' || eachChar == '|'|| eachChar == ' '|| eachChar == '\t')
        //            {


        //                if (eachChar == ' ' || eachChar == '\t')
        //                {
        //                    if (formatedLine.Count > 0)
        //                    {
        //                        if (formatedLine.Last() != '$')
        //                    {
        //                        formatedLine.Enqueue('$');
        //                    }
        //                   }
        //                }
        //                else
        //                {
        //                    formatedLine.Enqueue(eachChar);
        //                }
        //            } 
        //        }

        //        if (formatedLine.Count >= 0)
        //        {

        //            var fromOtherEnd = new string(formatedLine.ToArray());

        //            formatedString.Add(fromOtherEnd);
        //        }




        //    }

        //}

    }

    public static class ArrayExtensions
    {
        // In order to convert any 2d array to jagged one
        // let's use a generic implementation
        public static T[][] ToJagged<T>(this T[,] value)
        {
            if (Object.ReferenceEquals(null, value))
                return null;

            // Jagged array creation
            T[][] result = new T[value.GetLength(0)][];

            for (int i = 0; i < value.GetLength(0); ++i)
                result[i] = new T[value.GetLength(1)];

            // Jagged array filling
            for (int i = 0; i < value.GetLength(0); ++i)
                for (int j = 0; j < value.GetLength(1); ++j)
                    result[i][j] = value[i, j];

            return result;
        }
    }


}
