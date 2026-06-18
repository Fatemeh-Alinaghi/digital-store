using System;
using System.Collections.Generic;
namespace DigitalStoreWarehouse.DataStructures
{
    public class SortedSetManual<T> where T : IComparable<T>
    {
        private List<T> items = new List<T>();// list dakheli baraye zakhire item ha
        public int Count => items.Count;
        public void Add(T item)
        {
            int index = 0;
            while (index < items.Count && items[index].CompareTo(item) < 0)
                index++;
        // ta zamani k b enteha list nareside  v  item gadid az aitem jari < ast ..>index afzayesh bede
            if (index < items.Count && items[index].CompareTo(item) == 0)
                return;
            items.Insert(index, item);
        }     //add new item 

       
        public bool Remove(T item) => items.Remove(item);
        //hazf yek item az majmooe
        public List<T> GetAll() => new List<T>(items);
    //bargardandane ye copy az hame item ha (be soorate List jadid)....> jologiri az taghir nakhaste
        public T GetMin() => items.Count == 0 ? default : items[0];
        public T GetMax() => items.Count == 0 ? default : items[items.Count - 1];
    }     //bargardandane bozorgtarin item (akharie list)
}