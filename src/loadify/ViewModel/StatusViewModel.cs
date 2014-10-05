﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using loadify.Event;

namespace loadify.ViewModel
{
    public class StatusViewModel : ViewModelBase
    {
        private UserViewModel _LoggedInUser;
        public UserViewModel LoggedInUser
        {
            get { return _LoggedInUser; }
            set
            {
                if (_LoggedInUser == value) return;
                _LoggedInUser = value;
                NotifyOfPropertyChange(() => LoggedInUser);
            }
        }

        public StatusViewModel(UserViewModel loggedInUser, IEventAggregator eventAggregator):
            base(eventAggregator)
        {
            LoggedInUser = loggedInUser;
        }

        public StatusViewModel(IEventAggregator eventAggregator):
            this(new UserViewModel(), eventAggregator)
        { }

        public void RefreshData()
        {
            _EventAggregator.PublishOnUIThread(new DataRefreshRequest());
        }
    }
}
