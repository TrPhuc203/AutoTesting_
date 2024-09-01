using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.Http;
using OpenQA.Selenium.Support.UI;

namespace _54_Phuc_N1_KTFB_BTL
{
    class MethodTestAll_54_Phuc
    {
        //Khởi tạo IWebDriver thêm thuộc tính public
        public IWebDriver driver_54_Phuc = new ChromeDriver();


        //Phương thức truy cập trang web Facebook
        public void TrangWebFB()
        {
            driver_54_Phuc.Navigate().GoToUrl("https://www.facebook.com/");
        }
        public void DangNhap_54_Phuc(string email, string pass)
        {
            //Gọi phương thức để truy cập trang web
            TrangWebFB();
            //Tạo đối tượng bằng Xpath click đăng nhập
            IWebElement e_Login_54_Phuc = driver_54_Phuc.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div/div[2]/ul/li[2]/a"));
            e_Login_54_Phuc.Click();
            //Tạo đối tượng băng Name nhập email
            IWebElement e_email_54_Phuc = driver_54_Phuc.FindElement(By.Name("email"));
            e_email_54_Phuc.SendKeys(email);
            //Tạo đối tượng băng Name nhập pass
            IWebElement e_pass_54_Phuc = driver_54_Phuc.FindElement(By.Name("pass"));
            e_pass_54_Phuc.SendKeys(pass);
            //Tạo đối tượng băng id nhấn nút đăng nhập
            IWebElement e_buttonLogin_54_Phuc = driver_54_Phuc.FindElement(By.Id("loginbutton"));
            e_buttonLogin_54_Phuc.Click();          
        }
        //public void NhapPass_2(string pass)
        //{
            
        //     IWebElement e_pass_54_Phuc = driver_54_Phuc.FindElement(By.Id("pass"));
        //    e_pass_54_Phuc.SendKeys(pass);
        //    IWebElement e_buttonLogin_54_Phuc = driver_54_Phuc.FindElement(By.Id("loginbutton"));
        //    e_buttonLogin_54_Phuc.Click();
        //}
        public string AlertMessageNoEmail_54_Phuc()
        {
            IWebElement e_alert_54_Phuc = driver_54_Phuc.FindElement(By.ClassName("_9ay7"));
            return e_alert_54_Phuc.Text;
        }
        public string AlertMessagePassFail_54_Phuc()
        {
            IWebElement e_alert_54_Phuc = driver_54_Phuc.FindElement(By.ClassName("_akzt"));
            return e_alert_54_Phuc.Text;
        }

        //Unit Test 2
        public void QuenMatKhau_54_Phuc(string email)
        {
            //Gọi phương thức để truy cập trang web
            TrangWebFB();
            //Tạo đối tượng bằng Linktext click quen mat khau
            IWebElement e_Forgot_54_Phuc = driver_54_Phuc.FindElement(By.XPath("/html/body/div[1]/div[1]/div[1]/div/div/div/div[2]/div/div[1]/form/div[3]/a"));
            e_Forgot_54_Phuc.Click();
            //Tạo đối tượng băng Name nhập email
            IWebElement e_NhapEmail_54_Phuc = driver_54_Phuc.FindElement(By.Name("email"));
            e_NhapEmail_54_Phuc.SendKeys(email);
            //Tạo đối tượng băng id nhấn nút tìm
            IWebElement e_buttonTim_54_Phuc = driver_54_Phuc.FindElement(By.XPath("//*[@id=\"did_submit\"]"));
            e_buttonTim_54_Phuc.Click();
        }
        public string AlertMessage_Test2()
        {
            IWebElement e_alertFor_54_Phuc = driver_54_Phuc.FindElement(By.ClassName("_9o4h"));
            return e_alertFor_54_Phuc.Text;
        }
    }
}
