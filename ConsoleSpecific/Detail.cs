using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSpecific
{
    public class Detail
    {
        private int distance;

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        private int _length;
        public int Lenght
        {
            get { return _length; }
            set { _length = value; }
        }

        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private int _many;
        public int Many
        {
            get { return _many; }
            set { _many = value; }
        }

        private int _rotate;
        public int Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }

        private int _tborder;
        public int TBorder
        {
            get { return _tborder; ;}
            set { _tborder = value; }
        }

        private int _bborder;
        public int BBorder
        {
            get { return _bborder; }
            set { _bborder = value; }
        }

        private int _lborder;
        public int LBorder
        {
            get { return _lborder; }
            set { _lborder = value; }
        }

        private int _rborder;
        public int RBorder
        {
            get { return _rborder; }
            set { _rborder = value; }
        }

        public int Material { get; set; }

        //Ctor
        public Detail(){}
        public Detail( int length, int width, int many,
            int rotate, int tborder, int bborder, int lborder, int rborder,string name)
        {
            _name = name;
            _length = length;
            _many = many;
            _rotate = rotate;
            _tborder = tborder;
            _bborder = bborder;
            _lborder = lborder;
            _rborder = rborder;
        }

      



    }
}
