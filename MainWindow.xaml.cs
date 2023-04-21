using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Text;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// https://learn.microsoft.com/en-us/dotnet/desktop/wpf/data/binding-declarations-overview?view=netdesktop-7.0
// https://www.syncfusion.com/forums/143362/xaml-to-code
// https://stackoverflow.com/questions/5559397/set-multibinding-for-a-xaml-element-in-code-behind

namespace demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataManager dm = new DataManager();
            List<PartyData> cd = dm.GetCaseData(1);
            McDataGrid.DataContext = MappingTools.AddFormattingInfo(cd);
            McDataGrid.Columns.Add(GetDataGridTextColumns("Member", "Member"));
            McDataGrid.Columns.Add(GetDataGridTextColumns("Title", "Title"));
            McDataGrid.Columns.Add(GetDataGridTextColumns("Given Names", "GivenNames"));
            McDataGrid.Columns.Add(GetDataGridTextColumns("Surname", "Surname"));



        }

        public DataGridTextColumn GetDataGridTextColumns(string ColumnName, string ElementName)
        {
            DataGridTextColumn IDColumn = new DataGridTextColumn();
            IDColumn.Header = ColumnName;
            //IDColumn.Width = new DataGridLength(200);
            IDColumn.FontSize = 12;
            IDColumn.Binding = new Binding(ElementName) { Converter = new CellTextConverter()};

            Style IDStyle = new Style(typeof(TextBlock));
            IDStyle.Setters.Add(new Setter(TextBlock.BackgroundProperty, new Binding(ElementName) { Converter = new CellColourConverter() }));
            IDColumn.ElementStyle = IDStyle;

            return IDColumn;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }

    public class CellColourConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string[] elements = ((string)values).Split('_');
            return elements[0];
        }
        public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    public class CellTextConverter : IValueConverter
    {
        public object Convert(object values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string[] elements = ((string)values).Split('_');
            if (elements.Length > 1)
            { return elements[1]; }
            return elements[0];
        }
        public object ConvertBack(object value, Type targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
