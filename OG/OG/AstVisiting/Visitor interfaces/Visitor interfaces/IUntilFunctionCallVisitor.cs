﻿using OG.ASTBuilding.TreeNodes.BodyNode_and_Statements.Statements.CommandNode;

namespace OG.AstVisiting
{
    public interface IUntilFunctionCallVisitor
    {
        public void Visit(UntilFunctionCallNode node);
    }
}