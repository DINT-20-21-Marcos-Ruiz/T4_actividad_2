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

namespace T4_actividad_2
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Superheroe superheroe;
        List<Superheroe> lista = Superheroe.GetSamples();
        int contador;
        int posicion = 0;
        public MainWindow()
        {
            InitializeComponent();
            //superheroe_Grid.DataContext = Superheroe.GetSamples();   
            totalPag_TextBlock.Text = Convert.ToString(Superheroe.GetSamples().Count);
            pagActual_TextBlock.Text = "1";
        }

        public void Limpiar_Click(object sender, RoutedEventArgs e)
        {
            nombreHero_textBox.Clear();
            imagenHero_textBox.Clear();
            heroe_RadioButton.IsChecked = true;
            villano_RadioButton.IsChecked = false;
            vengadores_CheckBox.IsChecked = false;
            xmen_CheckBox.IsChecked = false;

        }
 
        public void Aceptar_Click(object sender, RoutedEventArgs e)
        {
            superheroe = new Superheroe(nombreHero_textBox.Text, imagenHero_textBox.Text, vengadores_CheckBox.IsChecked.Value, xmen_CheckBox.IsChecked.Value, heroe_RadioButton.IsChecked.Value, villano_RadioButton.IsChecked.Value);
            Superheroe.GetSamples().Add(superheroe);
            contador = Convert.ToInt32(totalPag_TextBlock.Text) + 1;
            totalPag_TextBlock.Text = Convert.ToString(contador);

        }
        public void Avanzar_MouseUp(object sender, MouseEventArgs e)
        {
            if (posicion+1 < Superheroe.GetSamples().Count) {
                posicion += 1;
                superheroe_Grid.DataContext = Superheroe.GetSamples()[posicion];
                pagActual_TextBlock.Text = Convert.ToString(posicion+1);
            }      
        }
        public void Retroceder_MouseUp(object sender, MouseEventArgs e)
        {
            if (posicion > 0) {
                posicion -= 1;
                superheroe_Grid.DataContext = Superheroe.GetSamples()[posicion];
                pagActual_TextBlock.Text = Convert.ToString(posicion+1);
            } 
        }
    }
}
