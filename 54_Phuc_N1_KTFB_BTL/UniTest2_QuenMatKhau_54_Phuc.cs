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
    public class UniTest2_QuenMatKhau_54_Phuc
    {
        //Tạo đối tượng
        private static MethodTestAll_54_Phuc testMethod_54_Phuc = new MethodTestAll_54_Phuc();
        //Khai báo tạo đối tượng get set cho TestContext
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @".\TestDataQuenMkTrue_54_Phuc.csv", "TestDataQuenMkTrue_54_Phuc#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void TestMkEmailTrue_54_Phuc()
        {
            //Lấy email từ file .csv
            string email_54_Phuc = TestContext.DataRow[0].ToString();
            //Nhập vào email và pass từ .csv tự động
            testMethod_54_Phuc.QuenMatKhau_54_Phuc(email_54_Phuc);
            //Lấy URL mong muốn
            string expect_54_Phuc = "https://www.facebook.com/login/identify/?ctx=recover&ars=facebook_login&from_login_screen=0";
            //Lấy URL khi nhấn nút đăng nhập
            string actual_54_Phuc = testMethod_54_Phuc.driver_54_Phuc.Url;
            // So sánh URL mong muốn so với thực tế
            Assert.AreEqual(expect_54_Phuc, actual_54_Phuc);
            //Dừng 8 giây
            Thread.Sleep(8000);
            //Đóng web sau khi chạy test case
            //testMethod_54_Phuc.driver_54_Phuc.Quit();

        }
        // Test Case 2_2
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                        @".\TestDataForgotEfail_54_Phuc.csv", "TestDataForgotEfail_54_Phuc#csv", DataAccessMethod.Sequential)]

        [TestMethod]
        public void WtestEmailFalse_54_Phuc()
        {
            //Lấy email từ file .csv
            string email_54_Phuc = TestContext.DataRow[0].ToString();
            //Nhập vào email và pass từ .csv tự động
            testMethod_54_Phuc.QuenMatKhau_54_Phuc(email_54_Phuc);
            //Chờ 10 giây để có thể tìm thấy element
            Thread.Sleep(10000);
            //Lấy URL mong muốn
            string expect_54_Phuc = "https://www.facebook.com/login/identify/?ctx=recover&ars=facebook_login&from_login_screen=0";
            //Lấy URL khi nhấn nút đăng nhập
            string actual_54_Phuc = testMethod_54_Phuc.driver_54_Phuc.Url;
            //Lấy cảnh báo mong muốn
            string expectAlert_54_Phuc = "Your search did not return any results. Please try again with other information.";
            //Lấy cảnh báo thực tế khi nhấn nút 
            string actualAlert_54_Phuc = testMethod_54_Phuc.AlertMessage_Test2();
            // So sánh URL mong muốn so với thực tế
            Assert.AreEqual(expect_54_Phuc, actual_54_Phuc);
            // So sánh cảnh báo mong muốn so với thực tế
            Assert.AreEqual(expectAlert_54_Phuc, actualAlert_54_Phuc);
            //Dừng 8 giây
            Thread.Sleep(8000);
            //Đóng web sau khi chạy test case
            //testMethod_54_Phuc.driver_54_Phuc.Quit();

        }
    }
}
