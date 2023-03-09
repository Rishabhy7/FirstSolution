using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Property
    {
        int _Custid; bool _status; string _Cname, _State ; double _Balance; Cities _City;

        public Property(int Custid, bool status, string Cname, double Balance, Cities City, String State) 
        {
            _Custid = Custid;
            _status = status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
            _State = State;
         }

        public int Custid
        {
            get { return _Custid; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set {    if (_status == true)
                    _Cname = value; }
         }
        public double Balance
        {
            get { return _Balance; }
            set {if (_status == true)
                {
                    if (value >= 500)
                        _Balance = value;
                }
            }

        }
        public Cities City
        {
            get { return _City; }
            set
            {
                if (_status == true)
                    _City = value;
            }
        }
        public String State
        {
            get { return _State; }
            protected set
            {
                if (_status == true)
                    _State = value;
            }
        }
        //Auto-Implemented or Automatic Property
        //Auto-Property Initializer
        public String Country { get; } = "India"; 

    }
    class TestConsumer
    {
        static void Main()
        {
            Property p = new Property(10, true, "apple", 5000, Cities.Hyderabad,"Telangana");
            //p.Status = false;
            if (p.Status == true)
                Console.WriteLine("Active");
            else
                Console.WriteLine("In-Active");
            Console.WriteLine(p.Cname);
            p.Cname += " Smith";
            Console.WriteLine("Modified name "+p.Cname);
            p.Balance -= 4600;
            Console.WriteLine("Modiefied Balance: "+p.Balance);
            Console.WriteLine(p.City);
            p.City = Cities.Kolkata;
            Console.WriteLine("Modiefied City: " + p.City);
            Console.WriteLine(p.State);
            //p.State = "West Bengal";  //will not work bcz for potected member it only accessable in child class only
            Console.WriteLine("Modiefied State: " + p.State);
            Console.WriteLine(p.Country);
        }

    }
}
