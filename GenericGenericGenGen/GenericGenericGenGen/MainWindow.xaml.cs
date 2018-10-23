using System;
using System.Collections;
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
using MyClasses;

namespace GenericGenericGenGen {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            //int[] arr = { 34, 6, 17, 8, 29, 42 };
            //ArrayList aList = new ArrayList();
            //aList.Add(34);
            //aList.Add(6);
            //aList.Add(17);
            //aList.Add(8);
            //aList.Add(29);
            //aList.Add(42);

            //arr[5] = 78;
            ////arr[3] = "one";

            //aList.Add(78);
            ////aList.Add("one");
            ////aList.Add(new Button());

            //int sum1 = 0, sum2 = 0;
            //foreach (int a in arr) {
            //    sum1 += a;
            //}

            //foreach (int a in aList) {
            //    sum2 += a;
            //}

            //MessageBox.Show(String.Format("{0} | {1}", sum1, sum2));

        }

        private void btnMakeCitizens_Click(object sender, RoutedEventArgs e) {

            Citizen c = new Citizen("Billy","Bo");

            Button b = (Button)this.FindName("btnMakeCitizens");

            for (int i = 0; i < 9; i++) {
                Button btn = (Button)this.FindName("btn_" + i);
            }
        }
    }
}
