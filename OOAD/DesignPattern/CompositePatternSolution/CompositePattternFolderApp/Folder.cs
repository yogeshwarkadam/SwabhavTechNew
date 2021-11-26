using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattternFolderApp
{
    class Folder : IStorageItem
    {
        private string _name;
        private List<IStorageItem> children = new List<IStorageItem>();

        public Folder(string name)
        {
            this._name = name;
        }

        public void AddChild(IStorageItem storage)
        {
            children.Add(storage);
        }
        public void Display()
        {
            Console.WriteLine(this._name);
            foreach (IStorageItem storageItem in children)
            {
                storageItem.Display();
            }
        }
    }
}
