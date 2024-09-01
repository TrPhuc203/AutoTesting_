using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;
using System.Threading;

namespace _54_Phuc_N1_KTFB_BTL
{
    
    [TestClass]
    public class UniTest1_DangNhap_54_Phuc
    {
        //Tạo đối tượng
        private static MethodTestAll_54_Phuc testMethod_54_Phuc = new MethodTestAll_54_Phuc();
        //Khai báo tạo đối tượng get set cho TestContext
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                    @".\TestDataDangNhap_54_Phuc.csv", "TestDataDangNhap_54_Phuc#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestLoginTrue_54_Phuc()
        {
            //Lấy email từ file .csv
            string email_54_Phuc = TestContext.DataRow[0].ToString();
            //lấy pass từ file.csv
            string pass_54_Phuc = TestContext.DataRow[1].ToString();
            //Nhập vào email và pass từ .csv tự động
            testMethod_54_Phuc.DangNhap_54_Phuc(email_54_Phuc, pass_54_Phuc);
            //Lấy URL mong muốn
            string expect_54_Phuc = "https://www.facebook.com/";
            //Lấy URL khi nhấn nút đăng nhập
            string actual_54_Phuc = testMethod_54_Phuc.driver_54_Phuc.Url;
            // So sánh URL mong muốn so với thực tế
            Assert.AreEqual(expect_54_Phuc, actual_54_Phuc);
            //Dừng 8 giây
            Thread.Sleep(8000);
            //Đóng web sau khi chạy test case
            //testMethod_54_Phuc.driver_54_Phuc.Quit();
            
        }
        //Khai báo input data source cho testcase1_2
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   @".\TestDataEmailFalse_54_Phuc.csv", "TestDataEmailFalse_54_Phuc#csv", DataAccessMethod.Sequential)]

        [TestMethod]      
        public void UtestEmailFalse_54_Phuc()
        {
            //Lấy email từ file .csv
            string email_54_Phuc = TestContext.DataRow[0].ToString();
            //lấy pass từ file.csv
            string pass_54_Phuc = TestContext.DataRow[1].ToString();
            //Nhập vào email và pass từ .csv tự động
            testMethod_54_Phuc.DangNhap_54_Phuc(email_54_Phuc, pass_54_Phuc);
            //Lấy URL mong muốn
            string expect_54_Phuc = "The email address you entered isn't connected to an account. Find your account and log in.";
            //Cảnh báp khi nhấn nút đăng nhập
            string actual_54_Phuc = testMethod_54_Phuc.AlertMessageNoEmail_54_Phuc();
            // So sánh URL mong muốn so với thực tế
            Assert.AreEqual(expect_54_Phuc, actual_54_Phuc);
            //Dừng 8 giây
            Thread.Sleep(8000);
            //Đóng web sau khi chạy test case
            testMethod_54_Phuc.driver_54_Phuc.Quit();

        }
        //Khai báo input data source cho testcase1_3
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                   @".\TestDataPassFalse_54_Phuc.csv", "TestDataPassFalse_54_Phuc#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void VtestPassFalse_54_Phuc()
        {
            //Lấy email từ file .csv
            string email_54_Phuc = TestContext.DataRow[0].ToString();
            //lấy pass từ file.csv
            string pass_54_Phuc = TestContext.DataRow[1].ToString();
            //Nhập vào email và pass từ .csv tự động
            testMethod_54_Phuc.DangNhap_54_Phuc(email_54_Phuc, pass_54_Phuc);
            //Lấy URL mong muốn
            string expect_54_Phuc = "The password you've entered is incorrect.";
            //Cảnh báp khi nhấn nút đăng nhập
            string actual_54_Phuc = testMethod_54_Phuc.AlertMessagePassFail_54_Phuc();
            // So sánh URL mong muốn so với thực tế
            Assert.AreEqual(expect_54_Phuc, actual_54_Phuc);
            //Dừng 10 giây
            Thread.Sleep(10000);
            //Đóng web sau khi chạy test case
            testMethod_54_Phuc.driver_54_Phuc.Quit();

        }
    }
}
