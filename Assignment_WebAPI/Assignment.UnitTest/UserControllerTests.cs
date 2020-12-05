using Assignment.API.Controllers;
using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment.UnitTest
{
    [TestClass]
    public class UserControllerTests
    {
        private readonly UserController _userController;
        private readonly Mock<IUserService> _mockUserService = new Mock<IUserService>();
        public UserControllerTests()
        {
            _userController = new UserController(_mockUserService.Object);
        }

        [TestMethod]
        public async Task PostUserAsync_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            UserViewModel user = new UserViewModel()
            {
                FirstName = "Hemant",
                LastName = "Mohapatra",
                Email = "Hemant@gmail.com",
                Password = "Hemant@123",
                Username = "Hemant123",
                Role = "Admin"
            };
            _mockUserService.Setup(x => x.PostUserAsync(user)).ReturnsAsync(true);

            //Act
            OkObjectResult  result = await _userController.PostUserAsync(user) as OkObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task PostUserAsync_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            UserViewModel user = new UserViewModel()
            {
                FirstName = "Hemant",
                LastName = "Mohapatra",
                Email = "",
                Password = "",
                Username = "Hemant123",
                Role = "Admin"
            };
            _mockUserService.Setup(x => x.PostUserAsync(user)).ReturnsAsync(false);

            //Act
            BadRequestObjectResult result = await _userController.PostUserAsync(user) as BadRequestObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task LoginAsync_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            string username = "Hemant123";
            string password = "Hemant@123";
            _mockUserService.Setup(x => x.LoginAsync(username, password)).ReturnsAsync("Admin");

            //Act
            OkObjectResult result = await _userController.LoginAsync(username, password) as OkObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task LoginAsync_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            string username = "Hemant123";
            string password = "Hemant";
            _mockUserService.Setup(x => x.LoginAsync(username, password)).ReturnsAsync(null as string);

            //Act
            BadRequestObjectResult result = await _userController.LoginAsync(username, password) as BadRequestObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task CheckIfUsernameExists_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            string username = "Hemant123";
            _mockUserService.Setup(x => x.UsernameExistsAsync(username)).ReturnsAsync(true);

            //Act
            OkObjectResult result = await _userController.CheckIfUsernameExists(username) as OkObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task CheckIfUsernameExists_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            string username = "Hemant1";
            _mockUserService.Setup(x => x.UsernameExistsAsync(username)).ReturnsAsync(false);

            //Act
            BadRequestObjectResult result = await _userController.CheckIfUsernameExists(username) as BadRequestObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetAllRoles_ValidData_ReturnsOkObjectResult()
        {
            //Arrange
            List<string> roles = new List<string>() { "Buyer", "Dealer" };
            _mockUserService.Setup(x => x.GetRolesAsync()).ReturnsAsync(roles);

            //Act
            OkObjectResult result = await _userController.GetAllRoles() as OkObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task GetAllRoles_InvalidData_ReturnsBadRequestObjectResult()
        {
            //Arrange
            List<string> roles = null;
            _mockUserService.Setup(x => x.GetRolesAsync()).ReturnsAsync(roles);

            //Act
            BadRequestObjectResult result = await _userController.GetAllRoles() as BadRequestObjectResult;

            //Assert
            Assert.IsInstanceOfType(result, typeof(BadRequestObjectResult));
            Assert.IsNotNull(result);
        }


    }
}
