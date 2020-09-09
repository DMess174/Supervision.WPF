using Microsoft.AspNetCore.Identity;
using Moq;
using NUnit.Framework;
using SupervisionApp.CommonModel.Exceptions;
using SupervisionApp.CommonModel.Models.Factories;
using SupervisionApp.CommonModel.Models.OrganizationStructure;
using SupervisionApp.CommonModel.Services;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SupervisionApp.CommonModel.Tests.Services
{
    [TestFixture]
    public class AuthenticationServiceTests
    {
        private Mock<IPasswordHasher<Account>> _mockPasswordHasher;
        private Mock<IAccountService> _mockAccountService;
        private AuthenticationService _authenticationService;

        [SetUp]
        public void SetUp()
        {
            _mockPasswordHasher = new Mock<IPasswordHasher<Account>>();
            _mockAccountService = new Mock<IAccountService>();
            _authenticationService = new AuthenticationService(_mockAccountService.Object, _mockPasswordHasher.Object);
        }

        [Test]
        public async Task Login_WithCorrectPasswordForExistingUsername_ReturnsAccountForCorrectUsername()
        {
            string expectedUsername = "testuser";
            string password = "testpassword";
            Factory factory = new Factory()
            {
                EmployeeFactories = new ObservableCollection<EmployeeFactories>()
                {
                    new EmployeeFactories()
                    {
                        Employee = new Employee(),
                        Factory = new Factory()
                    }
                }
            };

            _mockAccountService.Setup(s => s.GetByUsernameAsync(expectedUsername)).ReturnsAsync(new Account() { Username = expectedUsername });
            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(It.IsAny<Account>(), It.IsAny<string>(), password)).Returns(PasswordVerificationResult.Success);

            Account account = await _authenticationService.LoginAsync(expectedUsername, password);

            string actualUsername = account.Username;
            Assert.AreEqual(expectedUsername, actualUsername);
        }

        [Test]
        public void Login_WithIncorrectPasswordForExistingUsername_ThrowsInvalidPasswordExceptionForUsername()
        {
            string expectedUsername = "testuser";
            string password = "testpassword";
            _mockAccountService.Setup(s => s.GetByUsernameAsync(expectedUsername)).ReturnsAsync(new Account() { Username = expectedUsername });
            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(new Account() { Username = expectedUsername }, It.IsAny<string>(), password)).Returns(PasswordVerificationResult.Failed);

            InvalidPasswordException exception = Assert.ThrowsAsync<InvalidPasswordException>(() => _authenticationService.LoginAsync(expectedUsername, password));

            string actualUsername = exception.Username;
            Assert.AreEqual(expectedUsername, actualUsername);
        }

        [Test]
        public void Login_WithNonExistingUsername_ThrowsInvalidPasswordExceptionForUsername()
        {
            string expectedUsername = "testuser";
            string password = "testpassword";
            _mockPasswordHasher.Setup(s => s.VerifyHashedPassword(new Account() { Username = expectedUsername }, It.IsAny<string>(), password)).Returns(PasswordVerificationResult.Failed);

            UserNotFoundException exception = Assert.ThrowsAsync<UserNotFoundException>(() => _authenticationService.LoginAsync(expectedUsername, password));

            string actualUsername = exception.Username;
            Assert.AreEqual(expectedUsername, actualUsername);
        }

        [Test]
        public async Task Register_WithPasswordsNotMatching_ReturnsPasswordsDoNotMatch()
        {
            string password = "testpassword";
            string confirmPassword = "confirmtestpassword";
            RegistrationResult expected = RegistrationResult.PasswordsDoNotMatch;

            RegistrationResult actual = await _authenticationService.RegisterAsync(It.IsAny<string>(), It.IsAny<string>(), password, confirmPassword, new Employee());

            Assert.AreEqual(expected, actual);
        }

        //[Test]
        //public async Task Register_WithAlreadyExistingEmail_ReturnsEmailAlreadyExists()
        //{
        //    string email = "test@gmail.com";
        //    _mockAccountService.Setup(s => s.GetByEmail(email)).ReturnsAsync(new Account());
        //    RegistrationResult expected = RegistrationResult.EmailAlreadyExists;

        //    RegistrationResult actual = await _authenticationService.Register(email, It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>());

        //    Assert.AreEqual(expected, actual);
        //}

        [Test]
        public async Task Register_WithAlreadyExistingUsername_ReturnsUsernameAlreadyExists()
        {
            string username = "testuser";
            _mockAccountService.Setup(s => s.GetByUsernameAsync(username)).ReturnsAsync(new Account());
            RegistrationResult expected = RegistrationResult.UsernameAlreadyExists;

            RegistrationResult actual = await _authenticationService.RegisterAsync(It.IsAny<string>(), username, It.IsAny<string>(), It.IsAny<string>(), new Employee());

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public async Task Register_WithNonExistingUserAndMatchingPasswords_ReturnsSuccess()
        {
            RegistrationResult expected = RegistrationResult.Success;

            RegistrationResult actual = await _authenticationService.RegisterAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), new Employee());

            Assert.AreEqual(expected, actual);
        }
    }
}
