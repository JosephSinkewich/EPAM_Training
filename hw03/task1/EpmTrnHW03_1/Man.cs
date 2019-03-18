using System;

namespace EpmTrnHW03_1
{
    class Man
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("Age most be not-negative value");
                }
            }
        }
        
        private Gender _gender;
        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        private double _weight;
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value >= 0)
                {
                    _weight = value;
                }
                else
                {
                    throw new Exception("Weight most be not-negative value");
                }
            }
        }

        public Man(string name, int age, Gender gender, double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }
    }
}
