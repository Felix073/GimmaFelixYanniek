using System;
using System.Collections.Generic;
using System.Text;
using YanniekGimma.Interface;

namespace YanniekGimma.Models
{
    public class Score : ISkore
    {
        public string Name { get ; set ; }
        public int Points { get; set;  }
    }
}
