﻿// This file is part of HangFire.
// Copyright © 2013-2014 Sergey Odinokov.
// 
// HangFire is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as 
// published by the Free Software Foundation, either version 3 
// of the License, or any later version.
// 
// HangFire is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public 
// License along with HangFire. If not, see <http://www.gnu.org/licenses/>.

using System;
using HangFire.Storage;

namespace HangFire.States
{
    public class StateMachineFactory : IStateMachineFactory
    {
        private readonly IStateChangeProcess _stateChangeProcess;

        public StateMachineFactory(JobStorage storage)
        {
            if (storage == null) throw new ArgumentNullException("storage");

            var handlers = new StateHandlerCollection();
            handlers.AddRange(GlobalStateHandlers.Handlers);
            handlers.AddRange(storage.GetStateHandlers());
            
            _stateChangeProcess = new StateChangeProcess(handlers);
        }

        public IStateMachine Create(IStorageConnection connection)
        {
            if (connection == null) throw new ArgumentNullException("connection");
            
            return new StateMachine(connection, _stateChangeProcess);
        }
    }
}