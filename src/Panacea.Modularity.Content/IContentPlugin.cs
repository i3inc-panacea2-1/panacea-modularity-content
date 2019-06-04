using Panacea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panacea.Modularity.Content
{
    public interface IContentPlugin
    {
        Task OpenItemAsync(ServerItem item);
    }
}
