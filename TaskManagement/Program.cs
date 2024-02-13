﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Data;
using TaskManagement.Repositories;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services;
using TaskManagement.Services.Contracts;
using TaskManagement.Views;

namespace TaskManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ServiceLocator.Register<IMongoClient>(() => new MongoClient("mongodb+srv://jesriellayug:password027@cluster0.1yqsz2d.mongodb.net/?authMechanism=SCRAM-SHA-1"));
            ServiceLocator.Register<IDatabaseSetting>(() => new DatabaseSetting());

            // Register Repositories
            ServiceLocator.Register<IUserRepository>(() => new UserRepository(
                ServiceLocator.GetService<IMongoClient>(),
                ServiceLocator.GetService<IDatabaseSetting>()
                ));
            ServiceLocator.Register<ITaskRepository>(() => new TaskRepository(
                ServiceLocator.GetService<IMongoClient>(),
                ServiceLocator.GetService<IDatabaseSetting>()
                ));

            var userRepository = ServiceLocator.GetService<IUserRepository>();
            var taskRepository = ServiceLocator.GetService<ITaskRepository>();

            // Register Services
            ServiceLocator.Register<IAuthenticationService>(() => new AuthenticationService(
                userRepository
                ));
            ServiceLocator.Register<IUserService>(() => new UserService(
                userRepository
                ));
            ServiceLocator.Register<ITaskService>(() => new TaskService(
                taskRepository, userRepository
                ));


            var authenticationService = ServiceLocator.GetService<IAuthenticationService>();
            var userService = ServiceLocator.GetService<IUserService>();
            var taskService = ServiceLocator.GetService<ITaskService>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView(authenticationService, userService, taskService));
            
        }
    }
}