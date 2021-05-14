using System;
using System.Windows;
using System.Windows.Media;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for BookSeats.xaml
    /// </summary>
    public partial class BookSeats : Window
    {
        public static int indexValue;
        public class Seat
        {
            public string customerName = "";
            public bool indicator = false;
            public string seatNumber = "";
        }
        public Seat[] seatObj = new Seat[16];
        public BookSeats()
        {
            InitializeComponent();
            for (int i = 0; i < 16; i++)
            {
                seatObj[i] = new Seat();
            }
            btnSeatA1.Background = Brushes.White;
            btnSeatA2.Background = Brushes.White;
            btnSeatA3.Background = Brushes.White;
            btnSeatA4.Background = Brushes.White;
            btnSeatB1.Background = Brushes.White;
            btnSeatB2.Background = Brushes.White;
            btnSeatB3.Background = Brushes.White;
            btnSeatB4.Background = Brushes.White;
            btnSeatC1.Background = Brushes.White;
            btnSeatC2.Background = Brushes.White;
            btnSeatC3.Background = Brushes.White;
            btnSeatC4.Background = Brushes.White;
            btnSeatD1.Background = Brushes.White;
            btnSeatD2.Background = Brushes.White;
            btnSeatD3.Background = Brushes.White;
            btnSeatD4.Background = Brushes.White;
        }
        private void BookSeatsBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EnterName.Text == null || EnterName.Text == "")
                {
                    MessageBox.Show("Please enter customer name");
                }
                else
                {
                    string choice = SeatNumber.Text;
                    switch (choice)
                    {
                        case "A1":
                            if (btnSeatA1.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 0;
                            }
                            break;

                        case "A2":
                            if (btnSeatA2.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 1;
                            }
                            break;

                        case "A3":
                            if (btnSeatA3.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 2;
                            }
                            break;

                        case "A4":
                            if (btnSeatA4.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 3;
                            }
                            break;

                        case "B1":
                            if (btnSeatB1.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 4;
                            }
                            break;

                        case "B2":
                            if (btnSeatB2.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 5;
                            }
                            break;

                        case "B3":
                            if (btnSeatB3.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 6;
                            }
                            break;

                        case "B4":
                            if (btnSeatB4.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 7;
                            }
                            break;

                        case "C1":
                            if (btnSeatC1.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 8;
                            }
                            break;

                        case "C2":
                            if (btnSeatC2.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 9;
                            }
                            break;

                        case "C3":
                            if (btnSeatC3.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 10;
                            }
                            break;

                        case "C4":
                            if (btnSeatC4.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 11;
                            }
                            break;

                        case "D1":
                            if (btnSeatD1.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 12;
                            }
                            break;

                        case "D2":
                            if (btnSeatD2.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 13;
                            }
                            break;

                        case "D3":
                            if (btnSeatD3.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 14;
                            }
                            break;

                        case "D4":
                            if (btnSeatD4.Background == Brushes.Black)
                            {
                                MessageBox.Show("Sorry" + "\n " + "This seat is already reserved.");
                            }
                            else
                            {
                                indexValue = 15;
                            }
                            break;

                        default:MessageBox.Show("Wrong input");
                            break;
                    }
                    if (seatObj[indexValue].indicator == false)
                    {
                        string name = EnterName.Text;
                        string seatNum = SeatNumber.Text;
                        seatObj[indexValue].customerName = name;
                        seatObj[indexValue].seatNumber = seatNum;
                        seatObj[indexValue].indicator = true;
                        MessageBox.Show("Thank you:)" + " " + name + "\n " + "Your Seat" + " " + seatNum + " " + "is Booked");

                        switch (indexValue)
                        {
                            case 0:
                                btnSeatA1.Background = Brushes.Black;
                                btnSeatA1.Foreground = Brushes.White;
                                btnSeatA1.Content = name;
                                break;

                            case 1:
                                btnSeatA2.Background = Brushes.Black;
                                btnSeatA2.Foreground = Brushes.White;
                                btnSeatA2.Content = name;
                                break;

                            case 2:
                                btnSeatA3.Background = Brushes.Black;
                                btnSeatA3.Foreground = Brushes.White;
                                btnSeatA3.Content = name;
                                break;

                            case 3:
                                btnSeatA4.Background = Brushes.Black;
                                btnSeatA4.Foreground = Brushes.White;
                                btnSeatA4.Content = name;
                                break;

                            case 4:
                                btnSeatB1.Background = Brushes.Black;
                                btnSeatB1.Foreground = Brushes.White;
                                btnSeatB1.Content = name;
                                break;

                            case 5:
                                btnSeatB2.Background = Brushes.Black;
                                btnSeatB2.Foreground = Brushes.White;
                                btnSeatB2.Content = name;
                                break;

                            case 6:
                                btnSeatB3.Background = Brushes.Black;
                                btnSeatB3.Foreground = Brushes.White;
                                btnSeatB3.Content = name;
                                break;

                            case 7:
                                btnSeatB4.Background = Brushes.Black;
                                btnSeatB4.Foreground = Brushes.White;
                                btnSeatB4.Content = name;
                                break;

                            case 8:
                                btnSeatC1.Background = Brushes.Black;
                                btnSeatC1.Foreground = Brushes.White;
                                btnSeatC1.Content = name;
                                break;

                            case 9:
                                btnSeatC2.Background = Brushes.Black;
                                btnSeatC2.Foreground = Brushes.White;
                                btnSeatC2.Content = name;
                                break;

                            case 10:
                                btnSeatC3.Background = Brushes.Black;
                                btnSeatC3.Foreground = Brushes.White;
                                btnSeatC3.Content = name;
                                break;

                            case 11:
                                btnSeatC4.Background = Brushes.Black;
                                btnSeatC4.Foreground = Brushes.White;
                                btnSeatC4.Content = name;
                                break;

                            case 12:
                                btnSeatD1.Background = Brushes.Black;
                                btnSeatD1.Foreground = Brushes.White;
                                btnSeatD1.Content = name;
                                break;

                            case 13:
                                btnSeatD2.Background = Brushes.Black;
                                btnSeatD2.Foreground = Brushes.White;
                                btnSeatD2.Content = name;
                                break;

                            case 14:
                                btnSeatD3.Background = Brushes.Black;
                                btnSeatD3.Foreground = Brushes.White;
                                btnSeatD3.Content = name;
                                break;

                            case 15:
                                btnSeatD4.Background = Brushes.Black;
                                btnSeatD4.Foreground = Brushes.White;
                                btnSeatD4.Content = name;
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured" + ex.Message);
            }
        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            int indexSelected = SeatNumber.SelectedIndex;
            if (seatObj[indexSelected].indicator == true)
            {
                string nameFound = seatObj[indexSelected].customerName;
                string foundSeat = seatObj[indexSelected].seatNumber;
                MessageBox.Show("Name:"+nameFound +"\n"+"Seat number:"+ foundSeat);
            }
            else
            {
                MessageBox.Show("No record found "+"\n"+"Please book the seat first");
            }
        }
        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
        {
            int indexSelected = SeatNumber.SelectedIndex;
            if (seatObj[indexSelected].indicator == true)
            {
                seatObj[indexSelected].customerName = null;
                seatObj[indexSelected].seatNumber = null;
                seatObj[indexSelected].indicator = false;
                MessageBox.Show("Record is deleted Successfully");
                if (indexSelected == 0)
                {
                    btnSeatA1.Background = Brushes.White;
                    btnSeatA1.Foreground = Brushes.Black;
                    btnSeatA1.Content = "A1";
                }
                else if (indexSelected == 1)
                {
                    btnSeatA2.Background = Brushes.White;
                    btnSeatA2.Foreground = Brushes.Black;
                    btnSeatA2.Content = "A2";
                }
                else if (indexSelected == 2)
                {
                    btnSeatA3.Background = Brushes.White;
                    btnSeatA3.Foreground = Brushes.Black;
                    btnSeatA3.Content = "A3";
                }
                else if (indexSelected == 3)
                {
                    btnSeatA4.Background = Brushes.White;
                    btnSeatA4.Foreground = Brushes.Black;
                    btnSeatA4.Content = "A4";
                }
                else if (indexSelected == 4)
                {
                    btnSeatB1.Background = Brushes.White;
                    btnSeatB1.Foreground = Brushes.Black;
                    btnSeatB1.Content = "B1";
                }
                else if (indexSelected == 5)
                {
                    btnSeatB2.Background = Brushes.White;
                    btnSeatB2.Foreground = Brushes.Black;
                    btnSeatB2.Content = "B2";
                }
                else if (indexSelected == 6)
                {
                    btnSeatB3.Background = Brushes.White;
                    btnSeatB3.Foreground = Brushes.Black;
                    btnSeatB3.Content = "B3";
                }
                else if (indexSelected == 7)
                {
                    btnSeatB4.Background = Brushes.White;
                    btnSeatB4.Foreground = Brushes.Black;
                    btnSeatB4.Content = "B4";
                }
                else if (indexSelected == 8)
                {
                    btnSeatC1.Background = Brushes.White;
                    btnSeatC1.Foreground = Brushes.Black;
                    btnSeatC1.Content = "C1";
                }
                else if (indexSelected == 9)
                {
                    btnSeatC2.Background = Brushes.White;
                    btnSeatC2.Foreground = Brushes.Black;
                    btnSeatC2.Content = "C2";
                }
                else if (indexSelected == 10)
                {
                    btnSeatC3.Background = Brushes.White;
                    btnSeatC3.Foreground = Brushes.Black;
                    btnSeatC3.Content = "C3";
                }
                else if (indexSelected == 11)
                {
                    btnSeatC4.Background = Brushes.White;
                    btnSeatC4.Foreground = Brushes.Black;
                    btnSeatC4.Content = "C4";
                }
                else if (indexSelected == 12)
                {
                    btnSeatD1.Background = Brushes.White;
                    btnSeatD1.Foreground = Brushes.Black;
                    btnSeatD1.Content = "D1";
                }
                else if (indexSelected == 13)
                {
                    btnSeatD2.Background = Brushes.White;
                    btnSeatD2.Foreground = Brushes.Black;
                    btnSeatD2.Content = "D2";
                }
                else if (indexSelected == 14)
                {
                    btnSeatD3.Background = Brushes.White;
                    btnSeatD3.Foreground = Brushes.Black;
                    btnSeatD3.Content = "D3";
                }
                else if (indexSelected == 15)
                {
                    btnSeatD4.Background = Brushes.White;
                    btnSeatD4.Foreground = Brushes.Black;
                    btnSeatD4.Content = "D4";
                }
            }
            else
            {
                MessageBox.Show("Sorry..!!! No record found");
            }
        }

    }
}