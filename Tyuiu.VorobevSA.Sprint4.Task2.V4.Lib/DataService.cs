﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.VorobevSA.Sprint4.Task2.V4.Lib
{
    public class DataService : ISprint4Task2V4
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 1)
                {
                    sum += array[i];
                }
            }
            return sum;
        }
    }
}
