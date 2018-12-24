using System.Runtime.InteropServices;
using App1.Interfaces;

namespace App1.Droid.Services
{
    public class StringProvider : IStringProvider
    {
        private readonly string _parameter;

        public StringProvider(string parameter)
        {
            _parameter = parameter;
        }

        public string GetString()
        {
            return _parameter;
        }
    }
}