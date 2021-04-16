﻿using OG.ASTBuilding.TreeNodes.BoolNodes_and_extractors;
using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode
{
    public class UntilNode : IterationNode, IUntilNodeVisitable
    {
        public BoolNode Predicate;

        public UntilNode(BoolNode condition, BodyNode body):base(body)
        {
            Predicate = condition;
        }

        public void Accept(IUntilNodeVisitorBundleBundle visitorBundleBundle)
        {
            visitorBundleBundle.Visit(this);
        }
    }
}