using System;
using Payments.Models;

namespace Payments
{
    class Program
    {
        static void Main(string[] args)
        {
            var room = new Room(3);
            room.RoomSoldOut += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }
        static void OnRoomSoldOut(object sender, EventArgs eventArgs)
        { 
            Console.WriteLine("SALA Lotada!!!");
        }
    }
    public class Room
    {
        public Room(int seats)
        {
            this.Seats = seats;
            this.seatsInUse = 0;
        }
        private int seatsInUse = 0;
        public int Seats { get; set; }

        public void ReserveSeat()
        {
            seatsInUse++;
            if (seatsInUse >= Seats)
            {
                //evento fechado
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento Reservado");
            }
        }
        public event EventHandler RoomSoldOut;//assinatura
        protected virtual void OnRoomSoldOut(EventArgs e)
        {
            EventHandler handler = RoomSoldOut;
            handler?.Invoke(this, e);
        }
    }
}
