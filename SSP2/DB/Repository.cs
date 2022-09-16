using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.ComponentModel;

namespace SSP2.DB
{
    internal class Repository
    {
        SoccerContext db;
        public Repository()
        {

        }
        public void SendMessangeFronSoket(string name, int points)
        {
            byte[] bytes = new byte[1024];

            // Соединяемся с удаленным устройством
            int port = 11000;
            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);
            string message = "0 " + name + " " + Convert.ToString(points);


            byte[] msg = Encoding.UTF8.GetBytes(message);
            sender.Send(msg);
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }
        public void SenPlayer(string name, int points)
        {


            {
                SendMessangeFronSoket(name, points);
            }



        }

        public BindingList<Player> GetPlayers()
        {

            byte[] bytes = new byte[1024];

            // Соединяемся с удаленным устройством
            int port = 11000;
            // Устанавливаем удаленную точку для сокета
            IPHostEntry ipHost = Dns.GetHostEntry("localhost");
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, port);

            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            // Соединяем сокет с удаленной точкой
            sender.Connect(ipEndPoint);
            string message = "1 ";


            byte[] msg = Encoding.UTF8.GetBytes(message);
            sender.Send(msg);
            int bytesRec = sender.Receive(bytes);
            string DataGrid = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            string[] DataStr = DataGrid.Split(';');
            BindingList<Player> ret = new BindingList<Player>();
            for (int i = 0; i < DataStr.Length - 1; i++)
            {
                string[] spl = DataStr[i].Split(',');
                Player pl = new Player();
                pl.Id = Convert.ToInt32(spl[0]);
                pl.Name = (spl[1]);
                pl.Points = Convert.ToInt32(spl[2]);
                ret.Add(pl);
            }
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            return ret;
        }
    }
}
