using System;
using System.Collections.Generic;

namespace Lab_2
{
    public class Dress
    {
        private List<string> _parts = new List<string>();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public string ListParts()
        {
            string str = string.Empty;
            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }
            str = str.Remove(str.Length - 2);
            return "Info about dress : " + str;
        }
    }
}
