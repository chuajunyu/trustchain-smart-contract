using AElf.Cryptography.ECDSA;
using AElf.Testing.TestBase;

namespace AElf.Contracts.TrustChain
{
    // The Module class load the context required for unit testing
    public class Module : ContractTestModule<TrustChain>
    {
        
    }
    
    // The TestBase class inherit ContractTestBase class, it defines Stub classes and gets instances required for unit testing
    public class TestBase : ContractTestBase<Module>
    {
        // The Stub class for unit testing
        internal readonly TrustChainContainer.TrustChainStub TrustChainStub;
        // A key pair that can be used to interact with the contract instance
        private ECKeyPair DefaultKeyPair => Accounts[0].KeyPair;

        public TestBase()
        {
            TrustChainStub = GetTrustChainContractStub(DefaultKeyPair);
        }

        private TrustChainContainer.TrustChainStub GetTrustChainContractStub(ECKeyPair senderKeyPair)
        {
            return GetTester<TrustChainContainer.TrustChainStub>(ContractAddress, senderKeyPair);
        }
    }
    
}