﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class algo
    {
        public string month_id_method(string s)
        {
            int[] t = new int[2];
            int x = 0;
            string z = "";
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '/')
                {
                    t[x] = c[i + 1] - 48;
                    z = z + t[x].ToString();
                    x++;
                }


            }

            z = z + "016";
            return z;
        }




        public string month_name_method(string s)
        {
            string[] months = new string[] { " ", "Januray", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int[] t = new int[2];
            int x = 0;
            string z = "";
            char[] c = s.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == '/')
                {
                    t[x] = c[i + 1] - 48;
                    x++;
                }


            }

            for (int i = 1; i <= 12; i++)
            {
                if (i == t[0])
                {
                    z = months[i];
                }

            }
            return z;
        }




    }
}
