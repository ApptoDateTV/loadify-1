﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loadify.Spotify;

namespace loadify.Event
{
    public class DataRefreshDisposal
    {
        public LoadifySession Session { get; set; }

        public DataRefreshDisposal(LoadifySession session)
        {
            Session = session;
        }
    }
}
