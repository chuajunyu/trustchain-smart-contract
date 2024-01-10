using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Shouldly;
using Xunit;
using System;
using AElf.Sdk.CSharp;

namespace AElf.Contracts.TrustChain
{
    // This class is unit test class, and it inherit TestBase. Write your unit test code inside it
    public class TrustChainTests : TestBase
    {
        [Fact]
        public async Task ProposeTransferTest()
        {
            // Arrange
            // var inputValue = "Hello, World!";
            // var input = new StringValue { Value = inputValue };
            var input = new TransferProposal {
                Tokenid = "abc",
                To = "123",
                From = "456"
            };

            // // Act
            await TrustChainStub.ProposeTransfer.SendAsync(input);

            // // Assert
            // var updatedMessage = await TrustChainStub.Read.CallAsync(new Empty());
            // updatedMessage.Value.ShouldBe(inputValue);

            var result = await TrustChainStub.GetTransfer.CallAsync(new TransferID
            {
                Tokenid = "abc",
            });
            result.Tokenid.ShouldBe("abc");
            result.To.ShouldBe("123");
            result.From.ShouldBe("456");
            result.Status.ShouldBe("pending");
            
        }
    }
    
}