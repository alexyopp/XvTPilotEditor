using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XvTPilotEditor.Utilities
{
    public class NotifyingString : NotifyingBase
    {
        private string _value;
        public string Value
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

        public NotifyingString(string initialValue)
        {
            _value = initialValue;
        }
    }
}
