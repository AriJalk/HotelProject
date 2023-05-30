﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HotelProject.ViewModel.Commands.FloorRoomCommand
{
    class NewRoomCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private EditFloorRoomViewVM _vm;

        public NewRoomCommand(EditFloorRoomViewVM vm)
        {
            _vm = vm;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.NewRoom();
        }
    }
}
