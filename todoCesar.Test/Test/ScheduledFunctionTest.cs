using System;
using System.Collections.Generic;
using System.Text;
using todoCesar.Functions.Functions;
using todoCesar.Test.Helpers;
using Xunit;

namespace todoCesar.Test.Test
{
    public class ScheduledFunctionTest
    {

        [Fact]
        public void ScheduledFunction_Shoud_Log_Message()
        {
            // Arrange
            MockCloudTableTodos mockTodos = new MockCloudTableTodos(new Uri("http://127.0.0.1:10002/devstoreacccount1/reports"));
            ListLogger logger = (ListLogger)TestFactory.CreateLogger(LoggerTypes.List);

            // Act
            ScheduledFunction.Run(null, mockTodos, logger);
            string message = logger.Logs[0];

            // Assert
            Assert.Contains("Deleting completed", message);
        }
    }
}
