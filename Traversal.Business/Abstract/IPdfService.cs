using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Business.Abstract
{
    public interface IPdfService
    {
        byte[] GenerateTestReport();
        byte[] GenerateGuideReport();
    }
}
