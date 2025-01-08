using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
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

namespace OOP_JanExam
{
    //https://github.com/calvin-r05/OOP_JanExam.git
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Ticket> tickets = new List<Ticket>();
        List<Event> events = new List<Event>();
        List<Ticket> relatedTickets = new List<Ticket>();
        List<Event> relatedEvents = new List<Event> ();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            lbxEvents.ItemsSource = null;
            relatedEvents.Clear();
            foreach (Event event1 in events)
            {
                //if (event1.Name[0] == tbxSearch.Text)
            }
        

        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ticket selectedTicket = lbxTickets.SelectedItem as Ticket;
            if (selectedTicket != null)
            {
                if (int.TryParse(tbxNoOfTickets.Text, out int noOfTickets))
                {
                    if (noOfTickets != null && selectedTicket.AvailableTickets >= noOfTickets)
                    {
                        selectedTicket.AvailableTickets -= noOfTickets;
                        UpdateTickets();
                        tbxSuccess.Text = $"Success! {noOfTickets} tickets have been purchased!";
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Ticket t1 = new Ticket("Early Bird", 100m, 100);
            Ticket t2 = new Ticket("Platinum", 150m, 100);

            VipTicket vipT1 = new VipTicket("Ticket and Hotel Package", 150m, 100, "4* Hotel", 100m);
            VipTicket vipT2 = new VipTicket("Weekend Ticket", 200m, 100, "with camping", 100m);
            Event e1 = new Event("Oasis Croke Park", new DateTime(2025, 06, 20), new List<Ticket> {t1, vipT1}, EventType.Music);
            Event e2 = new Event("Electric Picnic", new DateTime(2025, 08, 20), new List<Ticket> { t2, vipT2 }, EventType.Music);


            events.Add(e1);
            events.Add(e2);
            lbxEvents.ItemsSource = events;



            
        }

        private void lbxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTickets();
        }

        private void UpdateTickets()
        {
            lbxTickets.ItemsSource = null;
            relatedTickets.Clear();
            Event selectedEvent = lbxEvents.SelectedItem as Event;

            if (selectedEvent != null)
            {
                foreach (Ticket ticket in selectedEvent.Tickets)
                {
                    relatedTickets.Add(ticket);
                }
                lbxTickets.ItemsSource = relatedTickets;
            }
        }
    }
}