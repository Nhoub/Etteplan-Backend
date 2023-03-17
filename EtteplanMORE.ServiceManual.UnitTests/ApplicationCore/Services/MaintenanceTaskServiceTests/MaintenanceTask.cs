﻿/*using EtteplanMORE.ServiceManual.ApplicationCore.Interfaces;
using EtteplanMORE.ServiceManual.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = NUnit.Framework.Assert;

namespace EtteplanMORE.ServiceManual.UnitTests.ApplicationCore.Services.MaintenanceTaskServiceTests
{
    public class MaintenanceTask
    {
        [TestFixture]
        public class MaintenanceTasksControllerTests
        {
            private MaintenanceTaskController _controller;
            private Mock<IMaintenanceTasksService> _serviceMock;

            [SetUp]
            public void SetUp()
            {
                _serviceMock = new Mock<IMaintenanceTasksService>();
                _controller = new MaintenanceTaskController(_serviceMock.Object);
            }

            /// <summary>
            /// Test to look if a task exists and returns the Ok result when using the Get method
            /// </summary>
            [Test]
            public void GetTask_WhenTaskExists_ReturnsOkResult()
            {
                // Arrange
                int id = 1;
                MaintenanceTask task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = _controller.GetTask(id);

                // Assert
                Assert.IsInstanceOf<OkObjectResult>(result);
            }

            /// <summary>
            /// Test to look if a task exists and returning the task, using the Get method
            /// </summary>
            [Test]
            public void GetTask_WhenTaskExists_ReturnsTask()
            {
                // Arrange
                int id = 1;
                var task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = (OkObjectResult)_controller.GetTask(id);

                // Assert
                Assert.AreEqual(task, result.Value);
            }

            /// <summary>
            /// Test to look if a task does not exist and therefore returning Not Found, using the Get method
            /// </summary>
            [Test]
            public void GetTask_WhenTaskDoesNotExist_ReturnsNotFoundResult()
            {
                // Arrange
                int id = 1;
                _serviceMock.Setup(x => x.Get(id)).Returns((MaintenanceTask)null);

                // Act
                var result = _controller.GetTask(id);

                // Assert
                Assert.IsInstanceOf<NotFoundObjectResult>(result);
            }

            /// <summary>
            /// Test to look when task does not exist to return error message, using the Get method
            /// </summary>
            [Test]
            public void GetTask_WhenTaskDoesNotExist_ReturnsErrorMessage()
            {
                // Arrange
                int id = 1;
                _serviceMock.Setup(x => x.Get(id)).Returns((MaintenanceTask)null);

                // Act
                var result = (NotFoundObjectResult)_controller.GetTask(id);

                // Assert
                Assert.AreEqual("No maitenance found against this id.", result.Value);
            }


            /// <summary>
            /// Test to look to see when task exists to return Ok result, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_WhenTaskExists_ReturnsOkResult()
            {
                // Arrange
                int id = 1;
                var task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = _controller.DeleteTask(id);

                // Assert
                Assert.IsInstanceOf<OkObjectResult>(result);
            }

            /// <summary>
            /// Test to look when task exists to delete the task, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_WhenTaskExists_DeletesTask()
            {
                // Arrange
                int id = 1;
                var task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = _controller.DeleteTask(id);

                // Assert
                _serviceMock.Verify(x => x.DeleteTask(id), Times.Once);
            }

            /// <summary>
            /// Test to look when task exists to return a success message, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_WhenTaskExists_ReturnsSuccessMessage()
            {
                // Arrange
                int id = 1;
                var task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = (OkObjectResult)_controller.DeleteTask(id);

                // Assert
                Assert.AreEqual("Maitenance task has been deleted", result.Value);
            }

            /// <summary>
            /// Test to look when does not exists to return Not Found, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_WhenTaskDoesNotExist_ReturnsNotFoundResult()
            {
                // Arrange
                int id = 1;
                _serviceMock.Setup(x => x.Get(id)).Returns((MaintenanceTask)null);

                // Act
                var result = _controller.DeleteTask(id);

                // Assert
                Assert.IsInstanceOf<NotFoundObjectResult>(result);
            }

            /// <summary>
            /// Test to look when task does not exist to not delete anything, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_WhenTaskDoesNotExist_DoesNotDeleteTask()
            {
                // Arrange
                int id = 1;
                _serviceMock.Setup(x => x.Get(id)).Returns((MaintenanceTask)null);

                // Act
                var result = _controller.DeleteTask(id);

                // Assert
                _serviceMock.Verify(x => x.DeleteTask(id), Times.Never);
            }

            /// <summary>
            /// Test to look that when task is deleted a Ok message is returned, using the Delete method
            /// </summary>
            [Test]
            public void DeleteTask_ReturnsOkMessage()
            {
                // Arrange
                int id = 1;
                var task = new MaintenanceTask { Id = id };
                _serviceMock.Setup(x => x.Get(id)).Returns(task);

                // Act
                var result = (OkObjectResult)_controller.DeleteTask(id);

                // Assert
                Assert.AreEqual("Maitenance task has been deleted", result.Value);
            }
        }
    }
}
*/