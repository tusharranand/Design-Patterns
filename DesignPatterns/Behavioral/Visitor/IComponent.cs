﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
