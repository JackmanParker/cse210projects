
using System.Collections.Generic;

namespace Develop02{
//
// The Responibiligy  is to contain the random prompts

    public class Jounal{
        public List<Entry> _entries;

        public Jounal()
        {
            _entries = new List<Entry>();
        }
        public void AddEntry(Entry entry)
        {
            if (!_entries.Contains(entry))
            {
                _entries.Add(entry);
            }
        }

        public List<Entry> GetAllEntries()
        {
            return this._entries;
        }
        public List<Entry> GetAllEntriesBackwards(){
            this._entries.Reverse();
            return this._entries;
        }
    }
}