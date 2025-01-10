using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace TextExtraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter path to your images ");
            string inputFolder = Console.ReadLine();
            List<Image> loadedImages = new List<Image>();

            Console.WriteLine("loading images ..... ");
            LoadImages(inputFolder, loadedImages);

        }
        public static void LoadImages(string path, List<Image> loadedImages)
        {
        }
    }
}