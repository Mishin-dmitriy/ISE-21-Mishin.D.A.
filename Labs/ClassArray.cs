﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class ClassArray<T> where T : ITransport
	{
		private T defaultValue;
        private Dictionary<int,T> places;
        private int maxCount;

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

		public ClassArray(int size, T defVal)
		{
			defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
		}

		public static int operator +(ClassArray<T> p, T car)
		{
			if(p.places.Count == p.maxCount)
            {
                return -1;
            }
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p.places.Add(i, car);
                    return i;
                }
            }
            p.places.Add(p.places.Count, car);
            return p.places.Count - 1;
		}

		public static T operator -(ClassArray<T> p, int index)
		{
            if (p.places.ContainsKey(index))
            {
                T car = p.places[index];
                p.places.Remove(index);
                return car;
            }
            return p.defaultValue;
		}

        public bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }
	}
}
