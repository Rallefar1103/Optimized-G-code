using System;
using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.ASTBuilding.TreeNodes.FunctionCalls;
using OG.ASTBuilding.TreeNodes.MathNodes_and_extractors;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class AntlrToIterationCommand:OGBaseVisitor<IterationNode>
    {
        BodyNodeExtractor _bodyExtractor = new BodyNodeExtractor();

        private BodyNode GetBody(OGParser.BodyContext context)
        {
            BodyNode body = _bodyExtractor.VisitBody(context);
            return body;
        }

        public override IterationNode VisitUntilFuncCall(OGParser.UntilFuncCallContext context)
        {
            FunctionCallNode func = new FunctionCallNodeExtractor().VisitFunctionCall(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new UntilFunctionCallNode(func, body);
        }

        public override IterationNode VisitUntilCondition(OGParser.UntilConditionContext context)
        {
            BoolNode boolnode = new BoolNodeExtractor().ExtractBoolNode(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new UntilNode(boolnode, body);
        }

        

        public override IterationNode VisitNumberIteration(OGParser.NumberIterationContext context)
        {
            
            MathNode mathNode = new MathNodeExtractor().ExtractMathNode(context.iterator);
            BodyNode body = GetBody(context.statements);
            return new NumberIterationNode(mathNode, body);
        }

        public IterationNode ExtractIterationNode(OGParser.UntilIterationContext context)
        {
            try
            {
                OGParser.UntilFuncCallContext funcCallContext = (OGParser.UntilFuncCallContext) context;
                return VisitUntilFuncCall(funcCallContext);

            }
            catch (InvalidCastException )
            {}

            OGParser.UntilConditionContext untilConditionContext = (OGParser.UntilConditionContext) context;
            return VisitUntilCondition(untilConditionContext);

        }
        
        
    }
}