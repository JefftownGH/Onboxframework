﻿using System;
using System.Threading.Tasks;

namespace Onbox.Mvc.V7
{
    public interface IViewMvc
    {
        void RunOnInitFunc(Func<Task> func, Action<string> error = null, Action complete = null);
        void SetOwner(object owner);
        void SetTitle(string title);
        bool? ShowDialog();
    }
}