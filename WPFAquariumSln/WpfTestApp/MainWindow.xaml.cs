using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFAquariumObjects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Test();
        }

        public static void Test()
        {
            Aquarium aquarium = new Aquarium();
            Aquarium.SetIsBubbleSource(aquarium, true);
            bool isBubbleSource = Aquarium.GetIsBubbleSource(aquarium);
            Debug.WriteLine($"Is bubble source: {isBubbleSource}");
        }

        public class Aquarium : AquariumObject
        {
            protected override Geometry DefiningGeometry => throw new NotImplementedException();
        }
    }
}
