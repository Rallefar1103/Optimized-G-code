﻿using System;
using OG.ASTBuilding.Terminals;
using OG.ASTBuilding.TreeNodes.BodyNodesAndVisitors;
using OG.ASTBuilding.TreeNodes.BoolNodes;
using OG.ASTBuilding.TreeNodes.DeclarationNodes;


namespace OG.ASTBuilding.Shapes
{
    public class ParameterNodeExtractor : OGBaseVisitor<ParameterNode>
    {
        private BoolNodeExtractor _boolNodeExtractor;
        private MathNodeExtractor _mathNodeExtractor;
        private FunctionCallExtractor _functionCallNodeExtractor;

        public ParameterNodeExtractor()
        {
            _mathNodeExtractor = null;
        }

        public override ParameterNode VisitSingleParameter(OGParser.SingleParameterContext context)
        {
            ParameterNode result =  ExtractParameterNode(context.parameter);
            return result;
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedDirectValueContext context)
        {
            
            OGParser.ExpressionContext exprContext = context.expr;
            
            
            OGParser.BoolExpressionContext boolExpressionContext = context.expr.boolExpression();
            OGParser.MathExpressionContext mathExpressionContext = context.expr.mathExpression();
            OGParser.FunctionCallContext functionExpressionContext = context.expr.functionCall();
            
            
            if (
                (exprContext != null && !exprContext.IsEmpty 
                                     && exprContext.id != null 
                                     && string.IsNullOrEmpty(exprContext.id.Text))
            )
            {


                return new ParameterNode(new IdNode(exprContext.id.Text));
            } 
            if (boolExpressionContext != null && !boolExpressionContext.IsEmpty)
            {
                _boolNodeExtractor = new BoolNodeExtractor();
                BoolNode boolRes = _boolNodeExtractor.ExtractBoolNode(boolExpressionContext);

                return new ParameterNode(boolRes, ParameterNode.ParameterType.BoolExpression);
            }

            if (mathExpressionContext != null && !mathExpressionContext.IsEmpty)
            {

                _mathNodeExtractor = new MathNodeExtractor();
                MathNode mathRes = _mathNodeExtractor.ExtractMathNode(mathExpressionContext);
                return new ParameterNode(mathRes, ParameterNode.ParameterType.MathExpressionNode);
            }

            if (functionExpressionContext != null && !functionExpressionContext.IsEmpty)
            {
                _functionCallNodeExtractor = new FunctionCallExtractor();
                FunctionCall functionCall = _functionCallNodeExtractor.VisitFunctionCall(functionExpressionContext);
                
                return new FunctionCallParameterNode(functionCall);
            }

            return null;
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedParamContext context)
        {
            
            try
            {
                
                OGParser.PassedIDContext idValue = (OGParser.PassedIDContext) context;
                return VisitPassedID(idValue);
            }
            catch (InvalidCastException )
            { }
            try
            {
                OGParser.PassedDirectValueContext expressionValue = (OGParser.PassedDirectValueContext) context;
               
                return ExtractParameterNode(expressionValue);
            }
            catch (InvalidCastException )
            { }

            try
            {
                OGParser.PassedEndPointReferenceContext endPointContext =
                    (OGParser.PassedEndPointReferenceContext) context;

                return VisitPassedEndPointReference(endPointContext);
            }
            catch (InvalidCastException )
            { }
            
            try
            {
                OGParser.PassedStartPointReferenceContext startPointContext =
                    (OGParser.PassedStartPointReferenceContext) context;
                return VisitPassedStartPointReference(startPointContext);
            }
            catch (InvalidCastException )
            {
            }

            OGParser.PassedFunctionCallContext funcCallContext = (OGParser.PassedFunctionCallContext) context;
            return ExtractParameterNode(funcCallContext);
        }

        public override ParameterNode VisitPassedID(OGParser.PassedIDContext context)
        {
            return new ParameterNode(new IdNode(context.id.Text));
        }

        public ParameterNode ExtractParameterNode(OGParser.PassedFunctionCallContext funcCallContext)
        {
            
            OGParser.FunctionCallContext functionCallContext = funcCallContext.funcCall;
            _functionCallNodeExtractor = new FunctionCallExtractor();
            FunctionCall funcCall = _functionCallNodeExtractor.VisitFunctionCall(functionCallContext);
            return new FunctionCallParameterNode(funcCall);
        }


        public override ParameterNode VisitPassedStartPointReference(OGParser.PassedStartPointReferenceContext context)
        {
            OGParser.StartPointReferenceContext startPRefContext = context.startpointRef;
            PointReferenceNode pointRef = new PointReferenceNodeExtractor().ExtractPointReferenceNode(startPRefContext);
            return new ParameterNode(new IdNode(context.startpointRef.id.Text), pointRef);
        }

        public override ParameterNode VisitPassedEndPointReference(OGParser.PassedEndPointReferenceContext context)
        {
            OGParser.EndPointReferenceContext endpointContext = context.endpointRef;
            PointReferenceNode pointRef = new PointReferenceNodeExtractor().ExtractPointReferenceNode(endpointContext);
            return new ParameterNode(new IdNode(context.endpointRef.id.Text), pointRef);
        }
    }
}