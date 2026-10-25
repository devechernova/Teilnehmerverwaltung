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
using Teilnehmerverwaltung.Models;
using Teilnehmerverwaltung.Services;

namespace Teilnehmerverwaltung
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TeilnehmerVerwaltung verwaltung;
        public MainWindow()
        {
            InitializeComponent();

            verwaltung = new TeilnehmerVerwaltung();

            dgTeilnehmer.ItemsSource = verwaltung.TeilnehmerListe;
        }

        private void dgTeilnehmer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgTeilnehmer.SelectedItem is Teilnehmer teilnehmer)
            {
                txtVorname.Text = teilnehmer.Vorname;
                txtNachname.Text = teilnehmer.Nachname;
                txtEmail.Text = teilnehmer.Email;

                dpGeburtsdatum.SelectedDate = teilnehmer.Geburtsdatum;
            }
        }
    }

}
