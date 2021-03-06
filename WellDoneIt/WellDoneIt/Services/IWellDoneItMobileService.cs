﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using WellDoneIt.Model;

namespace WellDoneIt.Services
{
    public interface IWellDoneItMobileService
    {
        Task Initialize();

        Task<IEnumerable<WellDoneItTask>>GetWellDoneItTasks();

        Task AddWellDoneItTask();

        Task UpdateWellDoneItTask(WellDoneItTask task);

        Task SyncTasks();
    }
}