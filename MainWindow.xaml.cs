using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace bankkkkkk
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        { 
           
            InitializeComponent();
           
        }
        private void tbFIO_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Разрешить ввод только букв и пробелов
            e.Handled = !char.IsLetter(e.Text[0]) && !char.IsWhiteSpace(e.Text[0]);
        }
        private void tbPhone_Loaded(object sender, RoutedEventArgs e)
        {
            tbPhone.PreviewTextInput += tbPhone_PreviewTextInput;
        }

        private void tbPhone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Разрешить ввод только цифр
            e.Handled = !char.IsDigit(e.Text[0]);
        }
       
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {

            string fio = tbFIO.Text;
            string numPhone = tbPhone.Text;
            string sum = slSum.Value.ToString();
            string dataEnd = dpData.Text;
            string type = cmbType.Text;
            string currentData = DateTime.Today.ToShortDateString();

            List<Deposit> persona = new List<Deposit>
                {
                new Deposit{FIO=fio, NumPhone=numPhone,Sum=sum,DataEnd=dataEnd,Type=type}
                

                };
            dataGrid.ItemsSource = persona;

            if (!string.IsNullOrEmpty(fio) && !string.IsNullOrEmpty(numPhone) &&  !string.IsNullOrEmpty(dataEnd) && !string.IsNullOrEmpty(type))
            {
                
                if (tbPhone.Text.Length < 11) 
                { 
                    MessageBox.Show("Введите номер телефона");
                   
                }
                else
                {
                    string text = $"ФИО: {fio}; Номер телефона: {numPhone}; Сумма вклада: {sum}; Дата оформления вклада: {currentData}; Дата окончания вклада: {dataEnd}; Тип вклада: {type}";
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\user\\Desktop\\мои коды\\bankkkkkk\\File\\Info.txt", true))
                    {
                        // Запись текста в файл
                        writer.WriteLine(text);
                    }
                } 
                
            }
            else
            {
                MessageBox.Show("Введите данные");
            }
        }

        private void FontSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            
        }
    }
}
