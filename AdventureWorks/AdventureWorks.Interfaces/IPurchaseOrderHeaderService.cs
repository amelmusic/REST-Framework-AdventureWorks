using A.Core.Attributes;
using A.Core.Interface;
using AdventureWorks.Model;
using AdventureWorks.Model.Requests;
using AdventureWorks.Model.SearchObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Interfaces
{
    [DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "purchaseOrderHeaders")]
    [StateMachine("PurchaseOrderHeaderStateMachine", "AdventureWorks.Model.PurchaceOrderHeaderStatusEnum", "Status")]
    public partial interface IPurchaseOrderHeaderService : IReadService<PurchaseOrderHeader, PurchaseOrderHeaderSearchObject, PurchaseOrderHeaderAdditionalSearchRequestData>
    {
        [DefaultMethodBehaviour(BehaviourEnum.StateMachineInsert)]
        PurchaseOrderHeader Insert(PurchaseOrderHeaderInsertRequest request);
        [DefaultMethodBehaviour(BehaviourEnum.StateMachineUpdate)]
        PurchaseOrderHeader Approve(int id, PurchaseOrderHeaderApproveRequest request);
        [DefaultMethodBehaviour(BehaviourEnum.StateMachineUpdate)]
        PurchaseOrderHeader Pending(int id, PurchaseOrderHeaderPendingRequest request);
        [DefaultMethodBehaviour(BehaviourEnum.StateMachineUpdate)]
        PurchaseOrderHeader Reject(int id, PurchaseOrderHeaderRejectRequest request);
        [DefaultMethodBehaviour(BehaviourEnum.StateMachineUpdate)]
        PurchaseOrderHeader Complete(int id, PurchaseOrderHeaderCompleteRequest request);
    }
}
