using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOpenCart.Utilities
{
    public class DataSource
    {
        
        public static object[] ValidRegisterData()
        {
            string[] data = new string[4];
            data[0] = "Aarya";
            data[1] = "Deoke";
            data[2] = "aarya@123.com";
            data[3] = "aarya123";
            

            string[] data1 = new string[4];
            data1[0] = "Dhanu";
            data1[1] = "Khandare";
            data1[2] = "dhanuk@123.com";
            data1[3] = "Dhanu@123";
            

            string[] data2 = new string[4];
            data2[0] = "Deva";
            data2[1] = "Gawande";
            data2[2] = "devag@123.com";
            data2[3] = "Deva@123";
          

            object[] alldata = new object[3];

            alldata[0] = data;
            alldata[1] = data1;
            alldata[2] = data2;

            return alldata;
        }

        public static object[] ValidLoginData1()
        {
            string[] data = new string[2];
            data[0] = "aara@123.com";
            data[1] = "aarya@123";

            string[] data1 = new string[2];
            data1[0] = "devag@123.com";
            data1[1] = "Deva@123";

            string[] data2 = new string[2];
            data2[0] = "dhanuk@123.com";
            data2[1] = "Dhanu@123";

            object[] alldata = new object[3];
            alldata[0] = data;
            alldata[1] = data1;
            alldata[2] = data2;
            return alldata;
        }

        

        public static object[] InvalidRegisterData()
        {
            string[] data = new string[4];
            data[0] = "Aarya1";
            data[1] = "Deo@ke";
            data[2] = "aarya@123.com";
            data[3] = "aarya123";


            string[] data1 = new string[4];
            data1[0] = "Dha@nu";
            data1[1] = "Kha1ndare";
            data1[2] = "dhanuk@123.com";
            data1[3] = "Dhanu@123";


            string[] data2 = new string[4];
            data2[0] = "Dev2a";
            data2[1] = "Gaw@ande";
            data2[2] = "devag@123.com";
            data2[3] = "Deva@123";


            object[] alldata = new object[3];

            alldata[0] = data;
            alldata[1] = data1;
            alldata[2] = data2;

            return alldata;

            
        }

        public static object[] InvalidLoginData1()
        {
            string[] data = new string[2];
            data[0] = "diya@123.com";
            data[1] = "diya@123";

            string[] data1 = new string[2];
            data1[0] = "devg@123.com";
            data1[1] = "Dev@123";

            string[] data2 = new string[2];
            data2[0] = "komal@123.com";
            data2[1] = "komal@123";

            object[] alldata = new object[3];
            alldata[0] = data;
            alldata[1] = data1;
            alldata[2] = data2;
            return alldata;
        }

        public static object[] ExcelValidData()
        {
            object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\artig\Desktop\CSharp\AutomationSeleniumProject1\DemoOpenCart\Test Data\DemoOpenCart.xlsx", "ValidateRegisterTest");
            return data;
        }
    }
}
