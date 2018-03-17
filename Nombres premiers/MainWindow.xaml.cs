using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Nombres_premiers
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Vérifier_Click(object sender, RoutedEventArgs e)
        {
            Divisibilités.Items.Clear();
            Réponse.Content = "";
            calculs();
        }

        void calculs()
        {
            Int64 nombre_a_verifier = Convert.ToInt64(Nombre.Text);
            Int64 diviseur;
            Int64 resultat;
            Int64 compteur = 0;

            for (diviseur = 1; diviseur <= nombre_a_verifier; diviseur++)
            {
                resultat = nombre_a_verifier % diviseur;
                if (resultat == 0)
                {
                    Divisibilités.Items.Add(diviseur);
                    compteur++;
                }
            }

            if (compteur == 2)
            {
                Réponse.Content = "Ce nombre est premier !";
            }
        }

        void listing()
        {
            Int64 quantite_nombres = Convert.ToInt64(Combien.Text);
            Int64 diviseur=0;
            Int64 resultat;
            Int64 compteur = 0;
            Int64 increment = 0;
            Int64 nombre_a_tester = 1;
            
            while (quantite_nombres > increment)
            {
                   for (diviseur = 1; diviseur <= nombre_a_tester; diviseur++)
                {
                    resultat = nombre_a_tester % diviseur;
                    if (resultat == 0)
                    {
                        compteur++;
                    }
                    
                }
                   if (compteur == 2)
                   {
                       Liste.Items.Add(nombre_a_tester);
                       increment++;
                       compteur = 0;
                   }
                   else
                       compteur = 0;
                  
                nombre_a_tester++; 
                           
            }

        }
        private void Chercher_Click(object sender, RoutedEventArgs e)
        {
            Liste.Items.Clear();
            listing();
        }
    }
    
}
