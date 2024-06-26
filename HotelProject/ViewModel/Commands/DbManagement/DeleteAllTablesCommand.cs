﻿using HotelProject.ViewModel.Helpers;
using System;
using System.Windows.Input;

namespace HotelProject.ViewModel.Commands.DbManagement
{
    class DeleteAllTablesCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            DbManagementMethods.DeleteAllTables();
        }
    }
}
