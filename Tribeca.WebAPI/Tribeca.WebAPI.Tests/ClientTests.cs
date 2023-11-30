using System.ComponentModel.DataAnnotations;
using Tribeca.WebAPI.Entities;
using Xunit;

namespace Tribeca.WebAPI.Tests
{
    public class ClientTests
    {
        [Fact]
        public void Client_Should_Have_Required_Properties()
        {
            // Arrange
            var client = new Client();

            // Act

            // Assert
            Assert.NotNull(client);
            Assert.IsType<int>(client.ClientId);
            Assert.IsType<string>(client.Name);
            Assert.IsType<int>(client.OfficeID);
            Assert.IsType<string>(client.Address);
            Assert.IsType<bool>(client.IsHeadOffice);
            Assert.IsType<int?>(client.EmployeeID);
            Assert.IsType<string>(client.EmployeeName);
        }

        [Fact]
        public void Client_Should_Have_KeyAttribute_On_ClientId()
        {
            // Arrange
            var clientProperty = typeof(Client).GetProperty(nameof(Client.ClientId));

            // Act
            var keyAttribute = clientProperty.GetCustomAttributes(typeof(KeyAttribute), true);

            // Assert
            Assert.NotNull(keyAttribute);
            Assert.NotEmpty(keyAttribute);
        }
    }
}
