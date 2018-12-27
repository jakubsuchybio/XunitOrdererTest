using Xunit;
using XUnitPriorityOrderer;

// set to be sequential execution
[assembly: CollectionBehavior(DisableTestParallelization = true)]
// addset the custom test's collection orderer
[assembly: TestCollectionOrderer(CollectionPriorityOrderer.TypeName, CollectionPriorityOrderer.AssembyName)]

namespace XunitOrdererTest
{
    // set the custom test's case orderer
    [TestCaseOrderer(CasePriorityOrderer.TypeName, CasePriorityOrderer.AssembyName)]
    public class PriorityBaseClass { }
}
