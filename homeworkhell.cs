using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Image data address : ");
            string imageData = @"TextFile1.txt";
            double[,] ImageDataFromFile = ReadImageDataFromFile(imageData);
            string convolution = @"TextFile2.txt";
            double[,] convolutionDataFromFile = ReadImageDataFromFile(convolution);
            double[,] AddArray = new double[7, 7];

            for (int i = 1; i <= AddArray.GetLength(0); i++) 
            {
                for (int j = 1; j <= AddArray.GetLength(1); j++) 
                {
                    AddArray[i, j] = ImageDataFromFile[i - 1, j - 1];

                    if (i == 6 && j == 1 || i == 6 && j == 6 || i == 1 && j == 6)
                    {
                        AddArray[i, j] = AddArray[1, 1];
                    }
                    if (i == 1 && j == 0 || i == 6 && j == 0 || i == 6 && j == 5) 
                    {
                        AddArray[i, j] = AddArray[1, 5];
                    }
                    if (i == 5 && j == 6 || i == 0 && j == 1 || i == 0 && j == 6)
                    {
                        AddArray[i, j] = AddArray[5, 1];
                    }
                    if (i == 5 && j == 0 || i == 0 && j == 5 || i == 0 && j == 0)
                    {
                        AddArray[i, j] = AddArray[5, 5];
                    }

                    if (i == 0) 
                    {
                        for (int s = 2; s < 5; s++) 
                        {
                            AddArray[i, s] = AddArray[5,s];
                        }
                    }
                    if (i == 6)
                    {
                        for (int s = 2; s < 5; s++)
                        {
                            AddArray[i, s] = AddArray[1, s];
                        }
                    }
                    if (j == 0)
                    {
                        for (int s = 2; s < 5; s++)
                        {
                            AddArray[s, j] = AddArray[s, 5];
                        }
                    }
                    if (j == 6)
                    {
                        for (int s = 2; s < 5; s++)
                        {
                            AddArray[s, j] = AddArray[s, 1];
                        }
                    }
                }  
            }

            double[,] conv = new double[5, 5];
            int f = 0;
            for (int i = 0; i < 5; i++) 
            {
                int a = 0;

                for (int j = 0; j < 5; j++) 
                {
                    int b = 0;

                    for (int c = 0 + f ; c < 3 + f ; c++) 
                    {
                        int d = 0;

                        for (int e = 0 + a ; e < 3 + a ; e++) 
                        {
                            conv[i, j] += AddArray[c, e] * convolutionDataFromFile[b, d];
                            d++;
                        }
                        b++;
                    }
                    a++;
                }
                f++;
            }
            string output = @"Textfile3.txt";
            WriteImageDataToFile(output, conv);



        }
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,
                                         double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }


    }
}
