using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_6
{
    public interface IAbc
    {
        string Name { get; set; } // Свойства есть
        //bool B; //полей нет
        void Ab();
    }

    public interface IWorker
    {
        public bool IsWorking { get; set; }
        public string Work();
    }
    public interface IManager
    {
        public string Manager();
    }

    //Интерфейсы и их методы
    //IEnumerable  : Current() return object, MoveNext() return bool, Reset() void, GetEnumerated() return IEnumerated.
    //IComparable  : CompareTo(object) return int
    //IComparer  : Compare(object, object)\
    //ICloneable  : Clone() return object

    
   
}
