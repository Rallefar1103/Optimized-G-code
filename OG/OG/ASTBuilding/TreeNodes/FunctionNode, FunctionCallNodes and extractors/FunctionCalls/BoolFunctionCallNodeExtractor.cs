﻿using System.Collections.Generic;
using OG.ASTBuilding.TreeNodes.TerminalNodes;

namespace OG.ASTBuilding.TreeNodes.FunctionCalls
{
    public class BoolFunctionCallNodeExtractor : OGBaseVisitor<BoolFunctionCallNode>
    {
        /// <summary>
        /// Must not be created on initialisation. Danger of infinite recursion.
        /// </summary>
        private ParameterNodeListBuilder _parameterListBuilder = null;

        public override BoolFunctionCallNode VisitFunctionCall(OGParser.FunctionCallContext context)
        {
            _parameterListBuilder = new ParameterNodeListBuilder();
            IdNode id = new IdNode(context.id.Text);
            List<ParameterNode> parameters = _parameterListBuilder.VisitFunctionCall(context);
            return new BoolFunctionCallNode(context.GetText(), id, parameters);
        }
        
    }
}