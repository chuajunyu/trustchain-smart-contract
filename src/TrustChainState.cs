using System.Diagnostics.CodeAnalysis;
using AElf.Sdk.CSharp.State;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic; // for List

using AElf.Standards.ACS6;
using AElf.Types;

namespace AElf.Contracts.TrustChain
{
    // The state class is used to communicate with the blockchain.
    public class TrustChainState : ContractState
    {
        // Map for tx_id to Transfer
        public MappedState<string, Transfer> Transfers { get; set; }

        // This is from the perspective of the user:
        // Map for pending proposals (proposals sent out)
        public MappedState<string, RepeatedString> Proposals { get; set; }
        public MappedState<string, RepeatedString> ApprovedProposals { get; set; }

        // Map for pending approvals (approvals waiting for you)
        public MappedState<string, RepeatedString> Approvals { get; set; }


        //encapsulate AEDPoS consensus contract reference state
        internal RandomNumberProvideacsrContractContainer.RandomNumberProvideacsrContractReferenceState
            RandomNumberContract { get; set; }
    }
}
