using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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

            cbUmschulung.ItemsSource = verwaltung.Umschulungen;

            cbKostentraeger.ItemsSource = verwaltung.KostentraegerListe;

            cbStatus.Items.Add("Aktiv");
            cbStatus.Items.Add("Pausiert");
            cbStatus.Items.Add("Abgeschlossen");
        }

        private void dgTeilnehmer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgTeilnehmer.SelectedItem is Teilnehmer teilnehmer)
            {
                txtVorname.Text = teilnehmer.Vorname;
                txtNachname.Text = teilnehmer.Nachname;
                txtEmail.Text = teilnehmer.Email;

                dpGeburtsdatum.SelectedDate = teilnehmer.Geburtsdatum;

                cbStatus.Text = teilnehmer.Status;

                cbUmschulung.SelectedItem = teilnehmer.Umschulung;

                cbKostentraeger.SelectedItem = teilnehmer.Kostentraeger;
            }
        }
        private void btnNeu_Click(object sender, RoutedEventArgs e)
        {
            txtVorname.Clear();
            txtNachname.Clear();
            txtEmail.Clear();

            dpGeburtsdatum.SelectedDate = null;

            cbStatus.SelectedIndex = -1;
            cbUmschulung.SelectedIndex = -1;
            cbKostentraeger.SelectedIndex = -1;

            dgTeilnehmer.UnselectAll();
        }

        private void btnSpeichern_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVorname.Text))
            {
                MessageBox.Show("Vorname ist erforderlich.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNachname.Text))
            {
                MessageBox.Show("Nachname ist erforderlich.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text)
                || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Bitte eine gültige E-Mail eingeben.");
                return;
            }

            if (cbUmschulung.SelectedItem == null)
            {
                MessageBox.Show("Bitte eine Umschulung auswählen.");
                return;
            }

            if (cbKostentraeger.SelectedItem == null)
            {
                MessageBox.Show("Bitte einen Kostenträger auswählen.");
                return;
            }

            if (dgTeilnehmer.SelectedItem != null)
            {
                Teilnehmer teilnehmer =
                    (Teilnehmer)dgTeilnehmer.SelectedItem;

                teilnehmer.Vorname = txtVorname.Text;
                teilnehmer.Nachname = txtNachname.Text;
                teilnehmer.Email = txtEmail.Text;

                teilnehmer.Geburtsdatum =
                    dpGeburtsdatum.SelectedDate ?? DateTime.Today;

                teilnehmer.Status = cbStatus.Text;

                teilnehmer.Umschulung =
                    (Umschulung)cbUmschulung.SelectedItem;

                teilnehmer.Kostentraeger =
                    (Kostentraeger)cbKostentraeger.SelectedItem;

                dgTeilnehmer.Items.Refresh();

                MessageBox.Show("Teilnehmer wurde aktualisiert.");
            }
            else
            {
                int neueNummer =
                    verwaltung.TeilnehmerListe.Max(t => t.TeilnehmerNr) + 1;

                Teilnehmer neuerTeilnehmer = new Teilnehmer
                {
                    TeilnehmerNr = neueNummer,
                    Vorname = txtVorname.Text,
                    Nachname = txtNachname.Text,
                    Email = txtEmail.Text,

                    Geburtsdatum =
                        dpGeburtsdatum.SelectedDate ?? DateTime.Today,

                    Status = cbStatus.Text,

                    Umschulung =
                        (Umschulung)cbUmschulung.SelectedItem,

                    Kostentraeger =
                        (Kostentraeger)cbKostentraeger.SelectedItem
                };

                verwaltung.TeilnehmerListe.Add(neuerTeilnehmer);

                MessageBox.Show("Teilnehmer wurde gespeichert.");
            }
        }

        private void btnLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (dgTeilnehmer.SelectedItem == null)
            {
                MessageBox.Show("Bitte zuerst einen Teilnehmer auswählen.");
                return;
            }

            Teilnehmer teilnehmer =
                (Teilnehmer)dgTeilnehmer.SelectedItem;

            MessageBoxResult ergebnis =
                MessageBox.Show(
                    $"Soll Teilnehmer {teilnehmer.Vorname} {teilnehmer.Nachname} wirklich gelöscht werden?",
                    "Teilnehmer löschen",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

            if (ergebnis == MessageBoxResult.Yes)
            {
                verwaltung.TeilnehmerListe.Remove(teilnehmer);

                MessageBox.Show("Teilnehmer wurde gelöscht.");

                txtVorname.Clear();
                txtNachname.Clear();
                txtEmail.Clear();

                dpGeburtsdatum.SelectedDate = null;

                cbStatus.SelectedIndex = -1;
                cbUmschulung.SelectedIndex = -1;
                cbKostentraeger.SelectedIndex = -1;
            }
        }
    }

}
