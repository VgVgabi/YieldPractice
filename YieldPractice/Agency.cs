using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



namespace YieldPractice
{
    internal class Agency
    {
        public IEnumerator GetEnumerator()
        {
            foreach (Car car in Cars)
            {                
                yield return car;                
            }
        }
        //
        public IEnumerable<Car> Cars;                        
        public IEnumerable GetCars(int modelYear) {
            foreach (Car car in Cars)
            {
                if (car.ModelYear == modelYear )
                    yield return car;
            }
        }   
        public IEnumerable GetCars(string maker) {
            foreach (Car car in Cars)
            {
                if (car.Maker == maker)
                    yield return car;
            }
        }     
    }
}

