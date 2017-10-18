﻿using HealthyEating.Client.Core.Contracts;
using HealthyEating.Client.Data;
using HealthyEating.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyEating.Client.Core.Commands.GoalCommands
{
    public class DeleteGoalCommand : ICommand
    {
        private readonly IDatabase db;
        private readonly User user;

        public DeleteGoalCommand(IDatabase db, User user)
        {
            this.db = db;
            this.user = user;
        }

        public string Execute(IList<string> commandLine)
        {
            throw new NotImplementedException();
        }
    }
}
