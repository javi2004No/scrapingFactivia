using System;
using System.Collections.Generic;
using System.Text;
using IronXL;

namespace scrapingFactivia.ExcelOutput
{
    internal class WriteToExcel
    {
        public void createExcel(List<ExcelStructure> excelStructures, string name)
        {
            WorkBook workBook = WorkBook.Create();
            WorkSheet sheet = workBook.CreateWorkSheet(name);
            int i = 0;
            foreach (ExcelStructure excelStructure in excelStructures)
            {
                string rangeLetter = getAddressLetter(i);
                string range = rangeLetter + "1:" + rangeLetter + (excelStructure.Data.Count + 1);
                foreach(var cell in sheet[range])
                {
                    if(cell.RowIndex == 0)
                    {
                        cell.Text = excelStructure.Header;
                    }
                    else
                    {
                        cell.Text = excelStructure.Data[cell.RowIndex - 1];
                    }
                }
                i++;
            }
            workBook.SaveAs("D:\\ExcelOutputs\\" + name + ".xlsx");
        }

        private string getAddressLetter(int addressNumber)
        {
            string addressLetter = "";
            if(addressNumber/26 > 0)
            {
                addressLetter = getAddressLetter(addressNumber % 26);
                addressNumber /= 26;
            }
            switch (addressNumber)
            {
                case 0:
                    addressLetter = "A" + addressLetter;
                    break;
                case 1:
                    addressLetter = "B" + addressLetter;
                    break;
                case 2:
                    addressLetter = "C" + addressLetter;
                    break;
                case 3:
                    addressLetter = "D" + addressLetter;
                    break;
                case 4:
                    addressLetter = "E" + addressLetter;
                    break;
                case 5:
                    addressLetter = "F" + addressLetter;
                    break;
                case 6:
                    addressLetter = "G" + addressLetter;
                    break;
                case 7:
                    addressLetter = "H" + addressLetter;
                    break;
                case 8:
                    addressLetter = "I" + addressLetter;
                    break;
                case 9:
                    addressLetter = "J" + addressLetter;
                    break;
                case 10:
                    addressLetter = "K" + addressLetter;
                    break;
                case 11:
                    addressLetter = "L" + addressLetter;
                    break;
                case 12:
                    addressLetter = "M" + addressLetter;
                    break;
                case 13:
                    addressLetter = "N" + addressLetter;
                    break;
                case 14:
                    addressLetter = "O" + addressLetter;
                    break;
                case 15:
                    addressLetter = "P" + addressLetter;
                    break;
                case 16:
                    addressLetter = "Q" + addressLetter;
                    break;
                case 17:
                    addressLetter = "R" + addressLetter;
                    break;
                case 18:
                    addressLetter = "S" + addressLetter;
                    break;
                case 19:
                    addressLetter = "T" + addressLetter;
                    break;
                case 20:
                    addressLetter = "U" + addressLetter;
                    break;
                case 21:
                    addressLetter = "V" + addressLetter;
                    break;
                case 22:
                    addressLetter = "W" + addressLetter;
                    break;
                case 23:
                    addressLetter = "X" + addressLetter;
                    break;
                case 24:
                    addressLetter = "Y" + addressLetter;
                    break;
                case 25:
                    addressLetter = "Z" + addressLetter;
                    break;
            }
            return addressLetter;
        }
    }
}
