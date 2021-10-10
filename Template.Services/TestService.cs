using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Services.Interfaces;

namespace Template.Services
{
    public class TestService : ITestService
    {
        public string hi()
        {
            return ":)";
        }
    }
}
