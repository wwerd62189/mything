using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _333333
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int q = int.Parse(b.Text);
            int w = int.Parse(c.Text);

             if (q == 1 && w >= 21 && w <= 31)
            {
                d.Text = "水瓶座\r\n幸運色:深棕\r\n桃花指數:★★";
            }
            else if (q == 2 && w <= 19)
            {
                d.Text = "水瓶座\r\n幸運色:深棕\r\n桃花指數:★★";
            }
            else if (q == 2 && w >= 20 && w <= 29)
            {
                d.Text = "雙魚座\r\n幸運色:淡粉\r\n桃花指數:★★";
            }
            if (q == 3 && w <= 20)
            {
                d.Text = "雙魚座\r\n幸運色:淡粉\r\n桃花指數:★★";
            }

            else if (q == 3 && w >= 21 && w <= 31)
            {
                d.Text = "白羊座\r\n幸運色:綠色\r\n桃花指數:★★★★";
            }
            if (q == 4 && w <= 19)
            {
                d.Text = "白羊座\r\n幸運色:綠色\r\n桃花指數:★★★★";
            }
            else if (q == 4 && w >= 20 && w <= 30)
            {
                d.Text = "金牛座\r\n幸運色:紅色\r\n桃花指數:★★★★★";
            }
            else if (q == 5 && w <= 20)
            {
                d.Text = "金牛座\r\n幸運色:紅色\r\n桃花指數:★★★★★";
            }
            if (q == 5 && w >= 21 && w <= 31)
            {
                d.Text = "雙子座\r\n幸運色:天藍\r\n桃花指數:★★★★☆";
            }
            else if (q == 6 && w <= 21)
            {
                d.Text = "雙子座\r\n幸運色:天藍\r\n桃花指數:★★★★☆";
            }
            else if (q == 6 && w >= 22 && w <= 30)
            {
                d.Text = "巨蟹座\r\n幸運色:金黃\r\n桃花指數:★★★";
            }
            else if (q == 7 && w <= 22)
            {
                d.Text = "巨蟹座\r\n幸運色:金黃\r\n桃花指數:★★★";
            }
            else if (q == 7 && w >= 23 && w <= 31)
            {
                d.Text = "獅子座\r\n幸運色:橘色\r\n桃花指數:★★☆";
            }
            else if (q == 8 && w <= 22)
            {
                d.Text = "獅子座\r\n幸運色:橘色\r\n桃花指數:★★☆";
            }
            else if (q == 8 && w >= 23 && w <= 31)
            {
                d.Text = "處女座\r\n幸運色:鵝黃\r\n桃花指數:★★☆";
            }
            else if (q == 9 && w <= 23)
            {
                d.Text = "處女座\r\n幸運色:鵝黃\r\n桃花指數:★★☆";
            }

            else if (q == 9 && w >= 23 && w <= 30)
            {
                d.Text = "天秤座\r\n幸運色:深藍\r\n桃花指數:★★★";
            }

            else if (q == 10 && w <= 23)
            {
                d.Text = "天秤座\r\n幸運色:深藍\r\n桃花指數:★★★";
            }
            else if (q == 10 && w >= 24 && w <= 31)
            {
                d.Text = "天蠍座\r\n幸運色:酒紅\r\n桃花指數:★☆";
            }
            else if (q == 11 && w <= 21)
            {
                d.Text = "天蠍座\r\n幸運色:酒紅\r\n桃花指數:★☆";
            }
            else if (q == 11 && w >= 22 && w <= 30)
            {
                d.Text = "射手座\r\n幸運色:咖啡\r\n桃花指數:★☆";
            }
            else if (q == 12 && w <= 20)
            {
                d.Text = "射手座\r\n幸運色:咖啡\r\n桃花指數:★☆";
            }
            else if (q == 12 && w >= 21 && w <= 31)
            {
                d.Text = "魔羯座\r\n幸運色:桃紅\r\n桃花指數:★★★☆";
            }
            else if (q == 1 && w <= 20)
            {
                d.Text = "魔羯座\r\n幸運色:桃紅\r\n桃花指數:★★★☆";
            }
            else
            {
                MessageBox.Show("請輸入正確數值");
            }

        }

    } }
