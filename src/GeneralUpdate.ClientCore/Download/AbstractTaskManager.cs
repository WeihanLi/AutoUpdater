﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralUpdate.ClientCore.Download
{
    /// <summary>
    /// Abstract task manager class.
    /// </summary>
    /// <typeparam name="T">'T' is the download task.</typeparam>
    public abstract class AbstractTaskManager<T> : ITaskManger<ITask<T>>
    {
        public abstract void Remove(ITask<T> task);

        public abstract void Add(ITask<T> task);
    }
}
