using CanvasPainter.Exceptions;
using CanvasPainter.Messages;
using Xunit;

namespace CanvasPainter.Testing.Commands
{
    public class QuitCommandTest
    {
        private QuitMessage QuitMessage { get; set; }

        [Fact]
        public void ValidateAndSetProperties_WithValidParameters_SetsQuitProp()
        {
            // arrange
            var inputParameters = new[] {"Q"};

            // act
            QuitMessage = new QuitMessage(inputParameters);

            // assert
            Assert.True(QuitMessage.IsQuit);
        }

        [Fact]
        public void ValidateAndSetProperties_WithInvalidParameters_ThrowsValidationException()
        {
            // arrange
            var inputParameters = new[] {"X", "5"};

            // act & assert
            Assert.Throws<ValidationException>(() => QuitMessage = new QuitMessage(inputParameters));
        }
    }
}