﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt ";
            Console.WriteLine("GetDirectoryName : " + Path.GetDirectoryName(path));
            Console.WriteLine("PathSeparator : " + Path.PathSeparator);
            Console.WriteLine("DirectorySeparatorChar : " + Path.DirectorySeparatorChar);
            Console.WriteLine("GetFileName : " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension : " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension : " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath : " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath : " + Path.GetTempPath());
            Console.ReadKey();
        }
    }
}
