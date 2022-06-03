using System;
namespace ClassLibrary
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _salary;

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value >= 250)
                    value = _salary;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                bool digits = false;
                bool capitalletter = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) == true)

                        digits = true;


                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i][0]) == true)
                    {
                        capitalletter = true;
                    }
                }
                if (!string.IsNullOrWhiteSpace(value) && digits == true && capitalletter == true)
                    value = _name;


            }
        }
        public string Surname
        {
            get
            {
                return _surname;

            }
            set
            {
                bool digits = false;
                bool capitalletter = false;
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsDigit(value[i]) == true)

                        digits = true;


                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (char.IsUpper(value[i][0]) == true)
                    {
                        capitalletter = true;
                    }
                }
                if (!string.IsNullOrWhiteSpace(value) && digits == true && capitalletter == true)
                    value = _surname;

            }



        }
    }
}
