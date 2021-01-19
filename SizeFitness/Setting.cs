using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SizeFitness
{
    [Serializable]
    public class Setting
    {
        private static Setting instance;
        public static Setting GetInstance() => instance ?? (instance = new());

        public BindingList<ProfileInfo> Profiles { get; set; } = new();
    }
}
