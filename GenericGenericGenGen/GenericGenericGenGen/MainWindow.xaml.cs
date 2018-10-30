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

            SuperHero s1 = new SuperHero("Bat", "Man") { Height = 74 };
            SuperHero s2 = new SuperHero("Squirrel","Girl") { Height = 54 };
            SuperHero s3 = new SuperHero("Cat","Woman") { Height = 58 };
            SuperHero s4 = new SuperHero("The","Flash") { Height = 66 };
            SuperHero s5 = new SuperHero("Ant","Man") { Height = 64 };
            SuperHero s6 = new SuperHero("Aqua","Man") { Height = 72 };
            SuperHero s7 = new SuperHero("Wonder","Woman") { Height = 76 };
            SuperHero s8 = new SuperHero("Spider","Man") { Height = 62 };

            List<int> lst = new List<int>();

            HideOut<SuperHero> hallOfJustice = new HideOut<SuperHero>();
            hallOfJustice.Members.Add(s1);
            hallOfJustice.Members.Add(s2);
            hallOfJustice.Members.Add(s3);
            hallOfJustice.Members.Add(s4);
            hallOfJustice.Members.Add(s5);
            hallOfJustice.Members.Add(s6);
            hallOfJustice.Members.Add(s7);
            hallOfJustice.Members.Add(s8);

            Villian v1 = new Villian();
            v1.FirstName = "Joker";
            Villian v2 = new Villian { FirstName = "Lex", LastName = "Luther" };

            HideOut<Villian> hallOfDoom = new HideOut<Villian>();
            hallOfDoom.Members.Add(v1);
            hallOfDoom.Members.Add(v2);

            HideOut<Person> cityHall = new HideOut<Person>();
            cityHall.Members.Add(s1);
            cityHall.Members.Add(v1);
            cityHall.Members.Add(c);

            Prison<Villian,SuperHero> arkhamAsylum = new Prison<Villian,SuperHero>();
            arkhamAsylum.Jailor = s1;
            arkhamAsylum.Inmates.Add(v1);

            Prison<SuperHero,Villian> hallOfDoomPrison = new Prison<SuperHero,Villian>();
            hallOfDoomPrison.Jailor = v2;
            hallOfDoomPrison.Inmates.Add(s4);


            Prison<Person,Citizen > alcatraz = new Prison<Person,Citizen>();

            var listOfMans = hallOfJustice.Members.Where(m => m.LastName == "Man");

            List<SuperHero> mans = new List<SuperHero>();
            foreach (SuperHero m in hallOfJustice.Members) {
                if(m.LastName == "Man") {
                    mans.Add(m);
                }
            }

            double mxHeight = hallOfJustice.Members.Max(m => m.Height);
            MessageBox.Show(mxHeight.ToString());

            SuperHero shorty = hallOfJustice.Members.FirstOrDefault(sup => sup.Height == 54);
            MessageBox.Show(shorty.FullName);

            


            string s = "";
            foreach (SuperHero sup in listOfMans) {
                s += sup.FullName + ", ";
            }
            MessageBox.Show(s);





            //Button b = (Button)this.FindName("btnMakeCitizens");

            //for (int i = 0; i < 9; i++) {
            //    Button btn = (Button)this.FindName("btn_" + i);
            //}
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e) {
            TextBox txt = (TextBox)sender;
            txt.Text = "";
            tbOutput.Text = txt.Text;
            //MessageBox.Show(txt.Text);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e) {
            //MessageBox.Show(e.Key.ToString());

            //tbOutput.Text = Enum.GetName(typeof(Key), e.Key+1).ToString();
            int keyValue = (int)e.Key;
            tbOutput.Text = keyValue.ToString();
            Thickness thk = brdOutline.BorderThickness;

            //if (e.Key == Key.A) {
            //    brdOutline.BorderBrush = new SolidColorBrush(Colors.Blue);
            //} else {
            //    brdOutline.BorderBrush = new SolidColorBrush(Colors.Green);
            //}

            if (e.Key == Key.NumPad8)
                thk.Top++;
            else if (e.Key == Key.NumPad2)
                thk.Bottom++;

            brdOutline.BorderThickness = thk;

        }
    }
}
