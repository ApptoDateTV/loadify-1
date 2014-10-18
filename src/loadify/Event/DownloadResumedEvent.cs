﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using loadify.Spotify;

namespace loadify.Event
{
    public class DownloadResumedEvent : SessionEvent
    {
        public int DownloadIndex { get; set; }

        public DownloadResumedEvent(LoadifySession session, int downloadIndex = 0):
            base(session)
        {
            DownloadIndex = downloadIndex;
        }
    }
}