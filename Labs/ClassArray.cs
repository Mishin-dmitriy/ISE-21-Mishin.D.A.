using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class ClassArray<T> : IEnumerator<T>,IEnumerable<T>,IComparable<ClassArray<T>>
	{
		private T defaultValue;
        private Dictionary<int,T> places;
        private int maxCount;
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

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
            Reset();
		}

		public static int operator +(ClassArray<T> p, T car)
		{
            bool isUltraShip =  car is UltaMegaBuffSuperMotorShip;
			if(p.places.Count == p.maxCount)
            {
                throw new DockOverflowException();
            }
            int index = p.places.Count;
            for(int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if(car.GetType() == p.places[i].GetType())
                {
                    if (isUltraShip)
                    {
                        if((car as UltaMegaBuffSuperMotorShip).Equals(p.places[i]))
                        {
                            throw new DockAlreadyHaveException();
                        }
                    }
                    else if ((car as MotorShip).Equals(p.places[i]))
                    {
                        throw new DockAlreadyHaveException();
                    }
                }
            }
            if(index != p.places.Count)
            {
                p.places.Add(index, car);
                return index;
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
            throw new DockIndexOutOfRangeException();
		}

        public bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if(currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if(this.Count() > other.Count())
            {
                return -1;
            }
            else if(this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for(int i = 0; i < this.places.Count; ++i)
                {
                    if(this.places[thisKeys[i]] is MotorShip && 
                        other.places[otherKeys[i]] is UltaMegaBuffSuperMotorShip)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is UltaMegaBuffSuperMotorShip &&
                        other.places[otherKeys[i]] is MotorShip)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is MotorShip &&
                       other.places[otherKeys[i]] is MotorShip)
                    {
                        return (this.places[thisKeys[i]] is MotorShip)
                            .CompareTo(other.places[otherKeys[i]] is MotorShip);
                    }
                    if (this.places[thisKeys[i]] is UltaMegaBuffSuperMotorShip &&
                       other.places[otherKeys[i]] is UltaMegaBuffSuperMotorShip)
                    {
                        return (this.places[thisKeys[i]] is UltaMegaBuffSuperMotorShip)
                            .CompareTo(other.places[otherKeys[i]] is UltaMegaBuffSuperMotorShip);
                    }
                }
            }
            return 0;
        }
    }
}
