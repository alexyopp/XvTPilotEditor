using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace XvTPilotEditor.ViewModels
{
    public class PilotDataViewModelBase : ViewModelBase
    {
        protected internal string SetStringProperty(string newValue, uint maxLength)
        {
            if (newValue.Length > maxLength)
            {
                MessageBox.Show("Pilot name must be no more than " + maxLength + " characters long.", "Invalid Pilot Name");
            }

            return newValue;
        }

        protected internal int SetIntProperty(string newValue)
        {
            int intValue;
            if (int.TryParse(newValue, out intValue))
            {
                return intValue;
            }
            else
            {
                throw new ArgumentException($"{newValue} must be an integer");
            }
        }

        protected internal uint SetUIntProperty(string newValue)
        {
            uint uintValue;
            if (uint.TryParse(newValue, out uintValue))
            {
                return uintValue;
            }
            else
            {
                throw new ArgumentException($"{newValue} must be an unsigned integer");
            }
        }
    }
}
