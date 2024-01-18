# Trustchain Lite Smart Contract

This repo contains the smart contract for our project Trustchain Lite!

## Details

it has 1 impt class, 3 dicts/states and 5 functions

class/ called message in proto3
1. Transfer (basically contains all the transfer info like what token, from who to who, and the status of the transfer, pending or accepted)

dictionary/States:
1. transfers: Map of NFT Symbol to Transfer Class
2. pending for: Map of User Address to NFT Symbol
3. pending by: Map of User Address to NFT Symbol
4. ApprovedTransfers: Map of User Address to NFT Symbol

Functions
1. ProposeTransfer
input: NFTsymbol, from and to address
output:
basically creates a new transfer class and updates the dictionaries accordingly

2. AcceptTransfer
input: NFT symbol
output:
basically updates the transfer object to reflect accepted and update the dictionaries accordingly

3. GetPendingProposal
input: your address
output:
shows you all the NFT symbols that you proposed and are pending

4. GetPendingAcceptances
input: your address
output:
shows you all the NFT symbols that other ppl propose to you and are pending your acceptance

5. GetTransfer
input: NFT Symbol
output: transfer class

6. GetApprovedProposals
input: your address
output:
shows you all the NFT symbols that you proposed to transfer and has been accepted by the other party

7. RemoveApprovedProposal
input: your address + NFT symbol
output:
Removes the NFT symbol from your ApprovedProposals MappedState

## Built with
- c#