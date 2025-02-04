﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms
{
    class BubbleSort<T> where T : IComparable
    {
        public T[] Sort(T[] arr)
        {
            T temp;
            int n = arr.Length;
            //sorting the elements 
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {    
                    if (arr[j].CompareTo(arr[j+1]) > 0)
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            return arr;
        }
        //Printing the array in ascending order
        public void Display(T [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
