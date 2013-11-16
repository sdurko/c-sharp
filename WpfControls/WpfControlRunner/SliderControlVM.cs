using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows.Data;
using System.Windows.Threading;

namespace WpfControlRunner
{
    abstract class PropertyNotifier : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void Notify(string propertyName) 
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    class Employee : PropertyNotifier
    {
        private string _firstName, _lastName;

        public string FirstName
        {
            get { return _firstName; }
            set 
            {
                this._firstName = value;
                this.Notify("FirstName");
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                this._lastName = value;
                this.Notify("LastName");
            }
        }

        public Employee(string first, string last)
        {
            _firstName = first;
            _lastName = last;
        }
    }

    public class NameConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string result = null;

            foreach (var value in values)
            {
                result += value;
                result += " ";
            }

            return result;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }


    class SliderControlVM
    {
        private readonly ObservableCollection<Employee> _employees = new ObservableCollection<Employee>();

        readonly DispatcherTimer _timer = new DispatcherTimer();

        private static readonly object _locker = new object();
    
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
        }

        public SliderControlVM(Dispatcher dispatcher)
        {
            _employees.Add(new Employee("King","Candy"));
            _employees.Add(new Employee("Wreck-It", "Ralph"));
            _employees.Add(new Employee("Venelope", "Von Schweets"));
            _employees.Add(new Employee("Fix It Felix", "Jr"));
            _employees.Add(new Employee("Q","Bert"));

            //Register for cross-thread access at the right time, before any dependent objects are created
            BindingOperations.CollectionRegistering +=BindingOperations_CollectionRegistering;


            var test = dispatcher.CheckAccess();

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(3000);

                while (true)
                {







                    for (int x = 0; x < 1000; x++)
                    {
                        dispatcher.Invoke(DispatcherPriority.Normal, new Action(() =>
                        {
                            _employees.Add(new Employee(x.ToString(), x.ToString()));
                        }));
                    }


                }




                //while (true)
                //{
                //    for (int x = 0; x < 10; x++)
                //    {
                //        _employees.Add(new Employee(x.ToString(), x.ToString()));
                //    }

                //    //Thread.Sleep(3000);
                //}
            });

            //_timer.Interval = new TimeSpan(0,0,0,0,3000);
            //_timer.Tick += (sender, args) =>
            //                   {
            //                       for (int x = 0; x < 10; x++)
            //                       {
            //                           _employees.Add(new Employee(x.ToString(),x.ToString()));
            //                       }
            //                   };

            //_timer.Start();

        }

        void BindingOperations_CollectionRegistering(object sender, CollectionRegisteringEventArgs e)
        {
           // BindingOperations.EnableCollectionSynchronization(_employees, _locker);
        }
    }
}
