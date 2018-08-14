using Contracts;
using EIAServer.Controllers;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace EIAServer_tests
{
    public class UtilityControllerTest
    {
        private IRepositoryWrapper _repository;
        private ILoggerManager _logger;
        private UtilityController _utilityController;
        private EIA_DEVContext _eIA_DEVContext;

        public UtilityControllerTest()
        {
            _repository = new RepositoryWrapper(_eIA_DEVContext);
            _utilityController = new UtilityController(_logger, _repository);

        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _utilityController.GetFinaltialYear();

            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _utilityController.GetFinaltialYear().Result as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<MCommonMasterMst>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }
    }
}
