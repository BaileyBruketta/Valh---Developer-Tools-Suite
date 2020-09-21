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

namespace ValhCreationSuiteCharacterCreationApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        public int CharacterNumber;
        public string Charactername;
        public int CharacterAge;
        public string CharacterGender;
        public string CharacterSkinTone;
        public string CountryOfOrigin;
        public string ProvinceOfResidence;
        public string CityOfResidence;
        public string Occupation;
        public string MaleParent;
        public string FemaleParent;
        public string OutputText;
        public string filepath;
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, RoutedEventArgs e)
        {
            filepath = OutputFilepathInput.Text;

            using (FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(OutputText);
                }
            }
        }

        public void UpdateCheck()
        {
            CharacterNumber = int.Parse(IDInput.Text);
            Charactername   = NameInput.Text;
            CharacterAge    = int.Parse(AgeInput.Text);
            MaleParent      = MPInput.Text;
            FemaleParent    = FPInput.Text;
            Occupation      = OccupationInput.Text;

            OutputText = CharacterNumber.ToString() + ", " +
                         Charactername + ", " +
                         CharacterAge.ToString() + ", " +
                         CharacterGender + ", " +
                         CharacterSkinTone + ", " +
                         CountryOfOrigin + ", " +
                         ProvinceOfResidence + ", " +
                         CityOfResidence + ", " +
                         Occupation + ", " +
                         FemaleParent + " F & " + MaleParent + " M";

            DisplayModular.Text = OutputText;
        }

        private void MaleButton_Click(object sender, RoutedEventArgs e){CharacterGender = "Male"; UpdateCheck();}
        private void FemaleButton_Click(object sender, RoutedEventArgs e){CharacterGender = "Female"; UpdateCheck();}
        private void WhiteInput_Click(object sender, RoutedEventArgs e){CharacterSkinTone = "White"; UpdateCheck();}
        private void BrownInput_Click(object sender, RoutedEventArgs e){CharacterSkinTone = "Brown"; UpdateCheck();}
        private void TanInput_Click(object sender, RoutedEventArgs e){CharacterSkinTone = "Tan"; UpdateCheck();}
        private void BlackInput_Click(object sender, RoutedEventArgs e){CharacterSkinTone = "Brown"; UpdateCheck();}

        private void EftonInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "United Federation of Communal Tuldonian States (Efton)"; UpdateCheck();}
        private void UCFTHelnaInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "United Federation of Communal Tuldonian States (Helna)"; UpdateCheck();}
        private void TahidInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Jerbrarian Council of Affiliated States (Tahid)"; UpdateCheck();}
        private void JerthroInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Jerbrarian Council of Affiliated States (Jerthro)"; UpdateCheck();}
        private void HabusInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Jerbrarian Council of Affiliated States (Habus)"; UpdateCheck();}
        private void ALchoranInput_Click(object sender, RoutedEventArgs e) { CountryOfOrigin = "The Holy Second Kingdom of West Alchoron"; UpdateCheck(); }
        private void UCSAlchorInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "The United Communal States of Alchor";UpdateCheck();}
        private void AlchorInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Alchor";UpdateCheck();}
        private void TuldoniaInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "East Tuldonia";UpdateCheck();}
        private void TendoronInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Tendoron";UpdateCheck();}
        private void ValhInput_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Valh"; UpdateCheck();}
        private void Jarrono_Click(object sender, RoutedEventArgs e){CountryOfOrigin = "Jarrono";UpdateCheck();}

        private void ShtaltonInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "Shtalton";UpdateCheck();}
        private void HelpeliaInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "Helpelia"; UpdateCheck();}
        private void ShrionInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "Shrion"; UpdateCheck();}

        private void CebwonInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Cebwon";UpdateCheck();}
        private void BlitzkrauInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Blitzkrau"; UpdateCheck();}
        private void EastpointeInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Eastpointe"; UpdateCheck();}
        private void HarbortownInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Harbortown"; UpdateCheck();}
        private void DovilleInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Doville"; UpdateCheck();}
        private void WildsInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Wilds"; UpdateCheck();}
        private void FalessaInput_Click(object sender, RoutedEventArgs e) { CityOfResidence = "Falessa"; UpdateCheck(); }
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateCheck(); 
        }

        private void DackleroyInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "Dackleroy"; UpdateCheck();}
        private void EastWindInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "EastWind"; UpdateCheck();}
        private void CitySpeakInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "CitySpeak"; UpdateCheck();}
        private void FalkisCoreInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "FalkisCore"; UpdateCheck();}
        private void GroveInput_Click(object sender, RoutedEventArgs e){ProvinceOfResidence = "Grove"; UpdateCheck();}

        private void SouthvileInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "SouthVille"; UpdateCheck();}
        private void HighPointeInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "HighPointe"; UpdateCheck();}

        private void BergIslandInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Berg Island"; UpdateCheck();}

        private void MetropolisInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Metropolis"; UpdateCheck();}

        private void SkribCityInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Skrib City"; UpdateCheck();}

        private void FarplainInput_Click(object sender, RoutedEventArgs e){CityOfResidence = "Farplain"; UpdateCheck();}

        private void Honeyville_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Honeyville"; UpdateCheck();
        }

        private void ShackleheartInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Shackleheart"; UpdateCheck();
        }

        private void GreatWraithInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Great Wraith"; UpdateCheck();
        }

        private void FortHeadsworthInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Fort Headsworth"; UpdateCheck();
        }

        private void BowsmithInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Bowsmith"; UpdateCheck();
        }

        private void KuplineInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Kupline"; UpdateCheck();
        }

        private void CrowCityInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "CrowCity"; UpdateCheck();
        }

        private void LionsToothInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Lion's Tooth"; UpdateCheck();
        }

        private void OasisInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Oasis"; UpdateCheck();
        }

        private void DorsalVillageInput_Click(object sender, RoutedEventArgs e)
        {
            CityOfResidence = "Dorsal Village"; UpdateCheck();
        }
    }
}
