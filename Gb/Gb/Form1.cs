using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Gb
{
    public partial class Form1 : Form
    {
        public IWebDriver Browser;
        public Form1()
        {
            InitializeComponent();
            try
            {
                File.ReadAllText("bankLine.txt");
            }
            catch (Exception) { File.WriteAllText("bankLine.txt", ""); }
            try
            {
                File.ReadAllText("cord.txt");
            }
            catch (Exception) { File.WriteAllText("cord.txt", ""); }
         

            try
            {
                File.ReadAllText("area.txt");
            }
            catch (Exception) { File.WriteAllText("area.txt", ""); }
            try
            {
                File.ReadAllText("errorList.txt");
            }
            catch (Exception) { File.WriteAllText("errorList.txt", ""); }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOpt = new ChromeOptions();
            chromeOpt.AddArguments("--headless");
            chromeOpt.AddArguments("--disable-gpu");
            Browser = new ChromeDriver(driverService, chromeOpt);
            Browser.Quit();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean bl = false;
            string[] lines = File.ReadAllLines("bankLine.txt");
            foreach (string line in lines)
                if (line == "*****")
                    bl = true;
            if (bl)
                textBox1.Text = "Необходимо удалить предыдущие адреса";
            else
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button4.Enabled = false;

                // создаем новый поток
                Thread myThread = new Thread(new ThreadStart(pars));
                myThread.Start(); // запускаем поток
                timer1.Start();
            }
        }

        public void pars()
        {
            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOpt = new ChromeOptions();
                chromeOpt.AddArguments("--headless");
                chromeOpt.AddArguments("--disable-gpu");
                Browser = new ChromeDriver(driverService, chromeOpt);
                Browser.Navigate().GoToUrl("https://2gis.ru");


            }
            catch (Exception)
            {
                Browser.Quit();
            }

            WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));

            wait.Until(d => Browser.FindElements(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[2]/div/div/div[1]/div/div/div/div/div[2]/form/div/input")).Count > 0);
            IWebElement Belement = Browser.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[2]/div/div/div[1]/div/div/div/div/div[2]/form/div/input"));

            Belement.SendKeys(textBox2.Text + ", " + textBox4.Text); // ввод города и объекта
            Belement.SendKeys(OpenQA.Selenium.Keys.Enter);

            wait.Until(d => Browser.FindElements(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[2]/div/div/div[2]/div/div/div/div[2]/div[2]/div[1]/div/div/div[1]/div[1]/div/div[1]/div/div[3]")).Count > 0);
            Belement = Browser.FindElement(By.XPath("/html/body/div/div/div/div[1]/div[1]/div[2]/div/div/div[2]/div/div/div/div[2]/div[2]/div[1]/div/div/div[1]/div[1]/div/div[1]/div/div[3]"));
            Belement.Click();

            IWebElement main_Belement = Browser.FindElement(By.ClassName("_vvdth55"));

            Belement = main_Belement.FindElement(By.CssSelector("footer > div._euwdl0 > svg"));
            Belement.Click();

            Belement = Browser.FindElement(By.ClassName("_18lf326a"));
            int max = Convert.ToInt32(Belement.Text);



            main_Belement = Browser.FindElement(By.ClassName("_3zzdxk"));
            int i = 0;
            while (i < 13)
            {
                i++;
                try
                {
                    if (i == 3)
                        i++;
                    Belement = main_Belement.FindElement(By.CssSelector("div > div > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(" + i.ToString() + ") > div > div._4l12l8 > span > span:nth-child(1) > div > span"));
                    File.AppendAllText("bankLine.txt", " " + Belement.Text + '\r' + '\n');
                    max--;
                    if (i == 13)
                    {
                        Belement = main_Belement.FindElement(By.CssSelector("div > div > div:nth-child(1) > div._12wz8vf > div._5i4ljs > div:nth-child(2) > svg"));
                        ((IJavaScriptExecutor)Browser).ExecuteScript("arguments[0].scrollIntoView();", Belement);
                        Belement.Click();
                    }
                }
                catch (Exception)
                { }


            }
            i = 0;

            wait.Until(d => Browser.FindElements(By.ClassName("_3zzdxk")).Count > 0);
            main_Belement = Browser.FindElement(By.ClassName("_3zzdxk"));
            while (max > 0)
            {

                i++;
                try
                {


                    Belement = main_Belement.FindElement(By.CssSelector("div > div > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(" + i.ToString() + ") > div > div._4l12l8 > span > span:nth-child(1) > div > span"));
                    File.AppendAllText("bankLine.txt", Belement.Text + '\r' + '\n');

                    max--;
                }
                catch (Exception)
                { max--; }


                try
                {
                    if (i == 12)
                    {

                        Belement = main_Belement.FindElement(By.CssSelector("div > div > div:nth-child(1) > div._12wz8vf > div._5i4ljs > div:nth-child(2) > svg"));
                        ((IJavaScriptExecutor)Browser).ExecuteScript("arguments[0].scrollIntoView();", Belement);
                        i = 0;
                        Belement.Click();
                        Thread.Sleep(700);

                    }
                }catch(Exception)
                { }
                   
            }


            File.AppendAllText("bankLine.txt", "*****");

        }


        private void button3_Click(object sender, EventArgs e)
        {
            Boolean bl = false;
            string[] lines = File.ReadAllLines("cord.txt");
            foreach (string line in lines)
                if (line == "*****")
                    bl = true;
            if (bl)
                textBox3.Text = "Необходимо удалить предыдущие координаты";
            else
            {
                textBox3.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = false;

                // создаем новый поток
                Thread myThread = new Thread(new ThreadStart(convAd));
                myThread.Start(); // запускаем поток
                timer2.Start();
            }
        }

        public void convAd()
        {
            try
            {

                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOpt = new ChromeOptions();
                chromeOpt.AddArguments("--headless");
                chromeOpt.AddArguments("--disable-gpu");
                Browser = new ChromeDriver(driverService, chromeOpt);
                Browser.Navigate().GoToUrl("https://yandex.ru/maps/213/moscow/house/luchnikov_pereulok_2/Z04YcARhTEYFQFtvfXt0eX1ibQ==/?ll=37.633383%2C55.755895&z=16.66");

                WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));
                WebDriverWait shortwait = new WebDriverWait(Browser, TimeSpan.FromSeconds(3));


                string[] lines = File.ReadAllLines("bankLine.txt");



                try
                {
                    foreach (string line in lines)
                    {

                        try
                        {
                            wait.Until(d => Browser.FindElements(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div[2]/div/span/span")).Count > 0);
                            IWebElement Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div[2]/div/span/span"));
                            Belement.Click();

                            Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div[2]/div/span/span/input"));
                            Belement.SendKeys(line);

                            Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div[3]/button/span/div"));
                            Belement.Click();

                            shortwait.Until(d => Browser.FindElements(By.XPath("/html/body/div[1]/div[2]/div[4]/div[1]/div[1]/div[1]/div/div[1]/div/div[3]/div[2]/div/div/div")).Count > 0);
                            Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[4]/div[1]/div[1]/div[1]/div/div[1]/div/div[3]/div[2]/div/div/div"));
                            File.AppendAllText("cord.txt", Belement.Text + '\r' + '\n');


                            Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div[5]/button/span/div"));
                            Belement.Click();
                        }
                        catch (Exception)
                        {
                            Browser.Navigate().GoToUrl("https://yandex.ru/maps/213/moscow/house/luchnikov_pereulok_2/Z04YcARhTEYFQFtvfXt0eX1ibQ==/?ll=37.633383%2C55.755895&z=16.66");

                        }


                    }


                }
                catch (Exception)
                {
                }


            }
            catch (Exception)
            {
                Browser.Quit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string bufstr;
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("bankLine.txt");
                if (bufstr != lines[lines.Length - 1])
                    textBox1.Text = lines[lines.Length - 1] + '\r' + '\n' + textBox1.Text;
                bufstr = lines[lines.Length - 1];
                if (bufstr == "*****")
                {
                    button1.Enabled = true;
                    button4.Enabled = true;
                    textBox1.Enabled = true;
                    timer1.Stop();
                }

            }
            catch (Exception)
            { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            File.Delete("bankLine.txt");
            File.WriteAllText("bankLine.txt", "");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("cord.txt");
                if (bufstr != lines[lines.Length - 1])
                    textBox3.Text = lines[lines.Length - 1] + '\r' + '\n' + textBox3.Text;
                bufstr = lines[lines.Length - 1];
                if (bufstr == "*****")
                {
                    button3.Enabled = true;
                    button5.Enabled = true;
                    textBox3.Enabled = true;
                    timer2.Stop();
                }

            }
            catch (Exception)
            { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            File.Delete("cord.txt");
            File.WriteAllText("cord.txt", ""); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                textBox5.Enabled = false;
                button2.Enabled = false;
            button6.Enabled = false;

            // создаем новый поток
            Thread myThread = new Thread(new ThreadStart(get_area));
                myThread.Start(); // запускаем поток
                timer3.Start();
            
        }

        public void get_area()
        {
            try
            {

                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                ChromeOptions chromeOpt = new ChromeOptions();
                chromeOpt.AddArguments("--headless");
                chromeOpt.AddArguments("--disable-gpu");
                Browser = new ChromeDriver(driverService, chromeOpt);
                Browser.Navigate().GoToUrl("https://raionpoadresu.ru/");
            }
            catch (Exception)
            {
                Browser.Quit(); ;
            }

            try
            {

                WebDriverWait wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(10));

                string[] lines = File.ReadAllLines("bankLine.txt");
                string[] area = lines;

                int i = -1;
                foreach (string line in lines)
                {
                    i++;

                    try
                    {
                        wait.Until(d => Browser.FindElements(By.Id("address")).Count > 0);
                        IWebElement Belement = Browser.FindElement(By.Id("address"));
                        Belement.Clear();
                        Belement.SendKeys(textBox2.Text + ", " + line);
                        Belement.SendKeys(OpenQA.Selenium.Keys.Enter);
                        Thread.Sleep(500);

                        wait.Until(d => Browser.FindElements(By.XPath("/html/body/div[1]/div/div[4]/div[1]/div/span/a")));
                        Belement = Browser.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div[1]/div/span/a"));
                        if (Belement.Text != "")
                        {
                            File.AppendAllText("area.txt", Belement.Text + '\r' + '\n');
                            area[i] = Belement.Text;

                        }                    
                    }
                    catch (Exception)
                    {
                        File.AppendAllText("errorList.txt", "error pars area" + " " + i.ToString() + '\r' + '\n');
                    }

                }
                File.AppendAllText("area.txt", "*****");
            }
            catch (Exception)
            {
            }


        }

        private void res()
        {
            string[] area = File.ReadAllLines("area.txt");

            int i = 0;
            while (i < area.Length)
            {
                int j = i;
                if (area[i] == "" || area[i] == " ") //clear 
                    while (j < area.Length)
                    {
                        area[j] = area[j++];
                        j++;
                    }
                i++;
            }
            
            i = 0;
            while (i < area.Length)
            {
                int point = Convert.ToInt32( File.ReadAllText("point.txt"));
                int j = 0;
                while (j < area.Length)
                {
                    if (i == j && i == area.Length - 1)
                        break;
                    if (i == j)
                        j++;

                    if (area[i] == area[j])
                    {
                        point = point + point;
                        area[j] = "***";
                    }                 
                        j++;
                 
                }
                area[i] = point.ToString() + "   " + area[i];
                i++;

            }
           

            i = 0;

            int a;
            int b;
            string st;
            while (i < area.Length - 1)
            {
                int j = 0;
                while (j < area.Length )
                {
                    a = area[i].ToCharArray()[0];
                    b = area[j].ToCharArray()[0];

                    if (Char.IsDigit(area[i].ToCharArray()[1]))
                        a = a * 10 + area[i].ToCharArray()[1];

                    if (Char.IsDigit(area[i].ToCharArray()[2]))
                        a = a * 10 + area[i].ToCharArray()[2];

                    if (Char.IsDigit(area[j].ToCharArray()[1]))
                        b = b * 10 + area[j].ToCharArray()[1];

                    if (Char.IsDigit(area[j].ToCharArray()[2]))
                        b = b * 10 + area[j].ToCharArray()[2];


                    if (a > b)
                    {
                        st = area[i];
                        area[i] = area[j];
                        area[j] = st;
                    }
                    j++;
                }
                  
                i++;
            }
       

            i = -1;
            while (i++ < area.Length - 1)
                try
                {
                    if (!area[i].Contains("***"))
                    File.AppendAllText("1.txt", area[i] + '\r' + '\n');
                }catch(Exception)
                { }

            File.AppendAllText(File.ReadAllText("index.txt") + ".txt", "*****");

        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("area.txt");      
               
                if (bufstr != lines[lines.Length - 1] && "" != lines[lines.Length - 1])
                textBox5.Text = lines[lines.Length - 1] + '\r' + '\n' + textBox5.Text;              
                if (lines[lines.Length - 1] == "*****")
                {
                    button2.Enabled = true;
                    textBox5.Enabled = true;
                    button6.Enabled = true;
                    timer3.Stop();
                }
                bufstr = lines[lines.Length - 1];

            }
            catch (Exception)
            { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("point.txt", textBox6.Text);          
          
            File.WriteAllText("index.txt", textBox7.Text);
            File.WriteAllText( textBox7.Text + ".txt", "");

            Thread myThread = new Thread(new ThreadStart(res));
            myThread.Start(); // запускаем поток  
            textBox5.Text = "";
            timer4.Start();
            
        }

         public int ind = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
               
            try
            {
                timer4.Interval = 100;
                string[] lines = File.ReadAllLines(textBox7.Text + ".txt");
                textBox5.Text = (lines[lines.Length - 1 - ind] + '\r' + '\n' + textBox5.Text);
            ind++;
            if (lines[ind] == "*****")
            {
                timer4.Stop();
                button2.Enabled = true;
            }
            }catch(Exception)
            { }

           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            File.Delete("area.txt");
            File.WriteAllText("area.txt", ""); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
           File.WriteAllText("fin.txt", "");
            /* 
            Thread myThread = new Thread(new ThreadStart(final));
            myThread.Start(); // запускаем поток  
            textBox5.Text = "";
            timer5.Start();*/

            /* }


             private void final()
             {*/

          
            int tmi = 0;

           while (true)
            {
                try
                {
                    tmi++;
                    string[] lines = File.ReadAllLines(tmi.ToString() + ".txt");
                }
                catch (Exception) { break; }
            }
            tmi--;
            int tempj = 0 ;


            while (tempj++ < tmi - 1)
            {
                string[] a = File.ReadAllLines(tempj.ToString() + ".txt");

               
                string[] b = File.ReadAllLines((tempj + 1).ToString() + ".txt");           
                int ai = 0;
                int bi = 0;
                char[] arr_a;
                char[] arr_b;
                foreach (string fstl in a)
                {
                   

                    arr_a = fstl.ToCharArray();
                    int ii = 0;
                    while(ii < arr_a.Length) //get num
                    { 
                        if (arr_a[ii] > '0' && arr_a[ii] < '9')
                        {
                            ai = (int)(arr_a[0] - '0');
                            textBox5.Text = textBox5.Text + ai.ToString() + '\n';


                            /* int k = 0;
                             while (k < arr_a.Length - 1)
                             {
                                 arr_a[k] = arr_a[k + 1];
                                 k++;
                             }*/


                        }
                        ii++;

                    }
                   



                    /* foreach (string secl in b)
                     {
                         arr_b = secl.ToCharArray();
                         ii = 0;
                         while (ii < arr_b.Length) //get num
                         {
                             if (arr_b[ii] > '0' && arr_b[ii] < '9')
                             {
                                 bi = bi * 10 + Convert.ToInt32(arr_b[ii]);
                                 int k = 0;
                                 while (k < arr_b.Length - 1)
                                 {
                                     arr_b[k] = arr_b[k + 1];
                                     k++;
                                 }

                             }

                         }

                         if (arr_a == arr_b) //clean if like
                         {
                             int k = 0;
                             while (k < b.Length - 1)
                             {
                                 b[k] = b[k + 1];
                                 ai = ai + bi;
                                 k++;
                             }


                         }





                     }
                     int u = -1;
                     while (u++ < a.Length - 1)
                         try
                         {
                             File.AppendAllText("fin.txt", (ai).ToString() + " " + arr_a + '\r' + '\n');
                         }
                         catch (Exception)
                         { }*/


                }

              



            }

        }

     
    }
}
