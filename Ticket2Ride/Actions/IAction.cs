﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket2Ride.Enums;

namespace Ticket2Ride.Actions
{
    public interface IAction
    {
        ActionType ActionType { get; }
    }
}
