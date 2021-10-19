using System.ComponentModel;

namespace Lecture_8_Solutions
{
    public class Customer : INotifyPropertyChanged
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        public event PropertyChangedEventHandler PropertyChanged;

        public int ID
        {
            get { return _id; }
            set
            {
                int previousValue = _id;

                _id = value;

                if (value != previousValue)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ID"));
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                string previousValue = _firstName;

                _firstName = value;

                if (value != previousValue)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FirstName"));
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                string previousValue = _lastName;

                _lastName = value;

                if (value != previousValue)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LastName"));
            }
        }
    }
}