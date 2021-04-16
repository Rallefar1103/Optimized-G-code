﻿using OG.AstVisiting;

namespace OG.ASTBuilding.TreeNodes.PointReferences
{
    /// <summary>
    /// This one is iffy. Need to find a way to represent all point references. This gonna be hard.
    /// </summary>
    public abstract class PointReferenceNode : ExpressionNode, IPointReferenceNode
    {
        /// <summary>
        /// If both LHS and RHS is null, it must be startpointreference, endpointreference, or ID.
        /// </summary>
        ///
        
        public enum PointReferenceNodeType
        {
            PointIdNode,
            ShapeStartPointNode,
            ShapeEndPointNode,
            PointFunctionCallNode,
            NumberTupleNode
        }

        public PointReferenceNodeType PointReferenceType { get; set; }

        public PointReferenceNode(string pointText, PointReferenceNodeType pointRefNodeType)
            :base(pointText, ExpressionType.PointReference)
        {
            PointReferenceType = pointRefNodeType;
        }


        public void Accept(IPointReferenceNodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public interface IPointReferenceNode : IExpressionNode
    {
        public void Accept(IPointReferenceNodeVisitor visitor);

    }
}