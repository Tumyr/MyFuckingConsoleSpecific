using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSpecific
{
    public class SawingCenter 
    {
        private int SetLengthBorder()
        {
            Console.WriteLine("Input length border");
            int inputLengthBorder = Convert.ToInt32(Console.ReadLine());
            return inputLengthBorder;
        }
        public int GetLengthBorder()
        {
            return SetLengthBorder(); ;
        }

        private int SetWidthBorder()
        {
            Console.WriteLine("Input length border");
            int inputWidthBorder = Convert.ToInt32(Console.ReadLine());
            return inputWidthBorder;
        }
        public int GetWidthBorder()
        {
            return SetWidthBorder();
        }

        private int GetDistance()
        {
            Console.WriteLine("Input distance");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public int ShowDistance()
        {
            return GetDistance();
        }

        private string SetName()
        {
            Console.WriteLine("Input name of part");
            string inputName = Console.ReadLine();
            return inputName;
        }

        public string GetName()
        {
            return SetName();
        }

        private int SetRotate()
        {
            Console.WriteLine("Input distance");
            int inputRotate = Convert.ToInt32(Console.ReadLine());
            return inputRotate;
        }
        public int GetRotate()
        {
            return SetRotate();
        }

        private int SetMany()
        {
            Console.WriteLine("Input distance");
            int inputMany = Convert.ToInt32(Console.ReadLine());
            return inputMany;
        }
        public int GetMany()
        {
            return GetMany();
        }


        Detail detail = new Detail();

        public List<Detail> CreateDetail()
        {
            detail.Name = GetName();
            detail.Lenght = ShowDistance();
            detail.Width = ShowDistance();
            detail.Many = GetMany();
            detail.Rotate = GetRotate();
            detail.TBorder = GetLengthBorder();
            detail.BBorder = GetLengthBorder();
            detail.LBorder = GetWidthBorder();
            detail.RBorder = GetWidthBorder();

            
            List<Detail> dt = new List<Detail>();
            dt.Add(new Detail(detail.Lenght,detail.Width, detail.Many,
                detail.Rotate,detail.TBorder,detail.BBorder,detail.LBorder,detail.RBorder,detail.Name));
            return dt;
            
        }

        public void FuckThemAll()
        {
            Console.WriteLine("Это для второго комита");
        }


    }
}
