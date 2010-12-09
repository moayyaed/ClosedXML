﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.IO;

namespace ClosedXML_Examples
{
    public class LoadFiles
    {
        public static void LoadAllFiles()
        {
            var forLoadingFolder = @"C:\Excel Files\Created";
            var forSavingFolder = @"C:\Excel Files\Modified";

            foreach (var file in Directory.GetFiles(forLoadingFolder))
            {
                var fileInfo = new FileInfo(file);
                var fileName = fileInfo.Name;
                LoadAndSaveFile(forLoadingFolder + @"\" + fileName, forSavingFolder + @"\" + fileName);
            }

            //LoadAndSaveFile(forLoadingFolder + @"\DataTypes.xlsx", forSavingFolder + @"\DataTypes.xlsx");
        }

        private static void LoadAndSaveFile(String input, String output)
        {
            var wb = new XLWorkbook(input);
            wb.SaveAs(output);
        }
    }
}