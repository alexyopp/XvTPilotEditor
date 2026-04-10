using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTPilotEditor.Utilities
{
    public class NotifyingInt : NotifyingBase
    {
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    OnPropertyChanged(nameof(Value));
                }
            }
        }

        public NotifyingInt(int initialValue)
        {
            _value = initialValue;
        }
    }
}
