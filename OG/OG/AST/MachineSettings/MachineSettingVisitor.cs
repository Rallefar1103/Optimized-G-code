﻿using System;
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using OG;
using OG.AST;
using OG.AST.MathExpression;
using OG.AST.Terminals;


namespace OG.AST.MachineSettings
{
    public class MachineSettingVisitor : OGBaseVisitor<Dictionary<string,MachineSettingNode>>
    {
        private Dictionary<string,MachineSettingNode> MachineSettings { get; set; }
        private MathExpressionVisitor MathExpressionVisitor { get; }
        
        public MachineSettingVisitor()
        {
            MathExpressionVisitor = new MathExpressionVisitor();
        }
        
        public override Dictionary<string,MachineSettingNode> VisitMachineSettings([NotNull] OGParser.MachineSettingsContext context)
        {
            MachineSettings = new Dictionary<string,MachineSettingNode>();

            VisitChildren(context);
            
            return MachineSettings;
        }

        // public override Dictionary<string,MachineSettingNode> VisitNoMachineSettings([NotNull] OGParser.NoMachineSettingsContext context)
        // {
        //     return VisitChildren(context);
        // }

        public override Dictionary<string,MachineSettingNode> VisitMachineModifiers([NotNull] OGParser.MachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitEndOfMachineModifiers([NotNull] OGParser.EndOfMachineModifiersContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitWorkAreaModifier([NotNull] OGParser.WorkAreaModifierContext context)
        {
            // if MachineSettings.Contain(WorkAreaNode) -> Semantic Error!
            MachineSettings["WorkArea"] = new WorkAreaModificationNode();
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitWorkAreaModifierProperties(
            [NotNull] OGParser.WorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string,MachineSettingNode> VisitEndOfWorkAreaModifierProperties(
            [NotNull] OGParser.EndOfWorkAreaModifierPropertiesContext context)
        {
            return VisitChildren(context);
        }

        public override Dictionary<string, MachineSettingNode> VisitSizeProperty(
            [NotNull] OGParser.SizePropertyContext context)
        {
            NumberNode<int> xMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables.xmin);
            NumberNode<int> xMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables.xmax);
            NumberNode<int> yMin = MathExpressionVisitor.VisitChildren(context.workAreaVariables.ymin);
            NumberNode<int> yMax = MathExpressionVisitor.VisitChildren(context.workAreaVariables.ymax);

            SizePropertyNode sizeProperty = new SizePropertyNode(xMin, xMax, yMin, yMax);
            WorkAreaModificationNode workNode = (WorkAreaModificationNode) MachineSettings["WorkArea"];
            workNode.SizeProperty = sizeProperty;
            return VisitChildren(context);
        }

    }   
}