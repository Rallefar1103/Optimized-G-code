using OG.ASTBuilding.Shapes;
using OG.ASTBuilding.TreeNodes.BodyNodes.CommandNodes;


namespace OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors
{
    public class UntilFunctionCallNode : IterationNode
    {
        public FunctionCallNode Predicate;

        public UntilFunctionCallNode(FunctionCallNode predicate, BodyNode body) : base(body)
        {
            Predicate = predicate;
        }
    }
}