using System;
using System.Collections.Generic;
using System.IO;
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

namespace ValhCreationSuiteCharacterScheduleApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string CurrentJob;
        public int CurrentCharNum;
        public string CurrentSleepLocation;
        public string CurrentWorkLocation;
        public string CurrentIdleLocation;
        public string filepath;
        public int wanderDistance;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Guard_Click(object sender, RoutedEventArgs e){CurrentJob = "guarding"; OccuData(); }
        private void Farm_Click(object sender, RoutedEventArgs e){CurrentJob = "plowing"; OccuData(); }
        private void Idle_Click(object sender, RoutedEventArgs e){ CurrentJob = "idle"; OccuData(); }
        private void Hammer_Click(object sender, RoutedEventArgs e){CurrentJob = "hammering"; OccuData(); }

        private void Monk_Click(object sender, RoutedEventArgs e) { CurrentJob = "meditating"; OccuData(); }

        //Change Display text for occupation data, which corresponds to default animation sequence at an NPC's "work" time
        private void OccuData() { OccupationInfo.Text = "Occupation: " + CurrentJob; Status.Text = "Changed occupation of " + CharacterNumber.Text; }

        private void NewScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentCharNum = int.Parse(CharacterNumber.Text);
            HeaderInfo.Text = "Now Serving Character #" + CharacterNumber.Text;
            Status.Text = "Changed Current Character";
        }

        private void ApplyChanges_Click(object sender, RoutedEventArgs e)
        {
            CurrentSleepLocation = InputSleepLocation.Text;
            CurrentWorkLocation = InputSleepLocation.Text;
            CurrentIdleLocation = InputIdleLocation.Text;

            WriteDataToFile();

        }

        private void WriteDataToFile()
        {
            String SleepPiece = CurrentCharNum.ToString() + ", " + "22:00,       5:00, " + CurrentSleepLocation + ", sleep, 0";
            String WakePiece  = CurrentCharNum.ToString() + ", " + " 5:00,       5:45, " + CurrentIdleLocation + ", idle, 3";
            String WorkPiece  = CurrentCharNum.ToString() + ", " + " 5:45,      17:00, " + CurrentWorkLocation + ", " + CurrentJob + ", " + wanderDistance;
            String EvenPiece  = CurrentCharNum.ToString() + ", " + "17:00,      22:00, " + CurrentIdleLocation + ", idle, 3";

            filepath = OutputInput.Text; 

            using (FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(SleepPiece);
                    sw.WriteLine(WakePiece);
                    sw.WriteLine(WorkPiece);
                    sw.WriteLine(EvenPiece);

                }
            }

            Status.Text = "Wrote data for character number " + CharacterNumber.Text + " to file.";
        }
    }
}
