using System;
using System.Collections.Generic;
namespace Depth.GenericeType
{
    public class Group<T> where T : Person
    {
        private List<T> personList;

        public Group() {
            personList = new List<T>();
        }

        public List<T> PersonList {
            get => personList;
            set => personList = value;
        }

        public void Print() {
            personList.ForEach(member => member.Print());
        }

        public void Add(T member) {
            personList.Add(member);
        }

        public T this[int index] {
            get => personList[index];
        }
    }
}
