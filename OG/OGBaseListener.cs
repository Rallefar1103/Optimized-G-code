//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:/Users/esben/Documents/GitHub/P4-project/OG/OG\OG.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IOGListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.Diagnostics.DebuggerNonUserCode]
[System.CLSCompliant(false)]
public partial class OGBaseListener : IOGListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProgram([NotNull] OGParser.ProgramContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.program"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProgram([NotNull] OGParser.ProgramContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.machineVariables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMachineVariables([NotNull] OGParser.MachineVariablesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.machineVariables"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMachineVariables([NotNull] OGParser.MachineVariablesContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.machine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMachine([NotNull] OGParser.MachineContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.machine"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMachine([NotNull] OGParser.MachineContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.draw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDraw([NotNull] OGParser.DrawContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.draw"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDraw([NotNull] OGParser.DrawContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.shapeDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterShapeDefinition([NotNull] OGParser.ShapeDefinitionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.shapeDefinition"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitShapeDefinition([NotNull] OGParser.ShapeDefinitionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBody([NotNull] OGParser.BodyContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.body"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBody([NotNull] OGParser.BodyContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDeclaration([NotNull] OGParser.DeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.declaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDeclaration([NotNull] OGParser.DeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.booleanDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBooleanDeclaration([NotNull] OGParser.BooleanDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.booleanDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBooleanDeclaration([NotNull] OGParser.BooleanDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberDeclaration([NotNull] OGParser.NumberDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberDeclaration([NotNull] OGParser.NumberDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointDeclaration([NotNull] OGParser.PointDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointDeclaration([NotNull] OGParser.PointDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointReference([NotNull] OGParser.PointReferenceContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointReference"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointReference([NotNull] OGParser.PointReferenceContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberTuple([NotNull] OGParser.NumberTupleContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberTuple"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberTuple([NotNull] OGParser.NumberTupleContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAssignment([NotNull] OGParser.AssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.assignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAssignment([NotNull] OGParser.AssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.propertyAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPropertyAssignment([NotNull] OGParser.PropertyAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.propertyAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPropertyAssignment([NotNull] OGParser.PropertyAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVariableAssignment([NotNull] OGParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.variableAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVariableAssignment([NotNull] OGParser.VariableAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.idAssign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIdAssign([NotNull] OGParser.IdAssignContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.idAssign"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIdAssign([NotNull] OGParser.IdAssignContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.boolAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolAssignment([NotNull] OGParser.BoolAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.boolAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolAssignment([NotNull] OGParser.BoolAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberAssignment([NotNull] OGParser.NumberAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberAssignment([NotNull] OGParser.NumberAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterPointAssignment([NotNull] OGParser.PointAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitPointAssignment([NotNull] OGParser.PointAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.startPointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterStartPointAssignment([NotNull] OGParser.StartPointAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.startPointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitStartPointAssignment([NotNull] OGParser.StartPointAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.endPointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEndPointAssignment([NotNull] OGParser.EndPointAssignmentContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.endPointAssignment"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEndPointAssignment([NotNull] OGParser.EndPointAssignmentContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterExpression([NotNull] OGParser.ExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.expression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitExpression([NotNull] OGParser.ExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.mathExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMathExpression([NotNull] OGParser.MathExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.mathExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMathExpression([NotNull] OGParser.MathExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] OGParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] OGParser.TermContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFactor([NotNull] OGParser.FactorContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.factor"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFactor([NotNull] OGParser.FactorContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] OGParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] OGParser.AtomContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.boolExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBoolExpression([NotNull] OGParser.BoolExpressionContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.boolExpression"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBoolExpression([NotNull] OGParser.BoolExpressionContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCommand([NotNull] OGParser.CommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.command"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCommand([NotNull] OGParser.CommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.movementCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterMovementCommand([NotNull] OGParser.MovementCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.movementCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitMovementCommand([NotNull] OGParser.MovementCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.lineCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLineCommand([NotNull] OGParser.LineCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.lineCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLineCommand([NotNull] OGParser.LineCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.curveCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCurveCommand([NotNull] OGParser.CurveCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.curveCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCurveCommand([NotNull] OGParser.CurveCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.toCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterToCommand([NotNull] OGParser.ToCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.toCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitToCommand([NotNull] OGParser.ToCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.drawCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDrawCommand([NotNull] OGParser.DrawCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.drawCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDrawCommand([NotNull] OGParser.DrawCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.iterationCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterIterationCommand([NotNull] OGParser.IterationCommandContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.iterationCommand"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitIterationCommand([NotNull] OGParser.IterationCommandContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberIteration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterNumberIteration([NotNull] OGParser.NumberIterationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberIteration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitNumberIteration([NotNull] OGParser.NumberIterationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.untilIteration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterUntilIteration([NotNull] OGParser.UntilIterationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.untilIteration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitUntilIteration([NotNull] OGParser.UntilIterationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionDeclaration([NotNull] OGParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.functionDeclaration"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionDeclaration([NotNull] OGParser.FunctionDeclarationContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.returnFunctionDCL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnFunctionDCL([NotNull] OGParser.ReturnFunctionDCLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.returnFunctionDCL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnFunctionDCL([NotNull] OGParser.ReturnFunctionDCLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.typeWord"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTypeWord([NotNull] OGParser.TypeWordContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.typeWord"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTypeWord([NotNull] OGParser.TypeWordContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.voidFunctionDCL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterVoidFunctionDCL([NotNull] OGParser.VoidFunctionDCLContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.voidFunctionDCL"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitVoidFunctionDCL([NotNull] OGParser.VoidFunctionDCLContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameterDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterDeclarations([NotNull] OGParser.ParameterDeclarationsContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameterDeclarations"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterDeclarations([NotNull] OGParser.ParameterDeclarationsContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameters([NotNull] OGParser.ParametersContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameters"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameters([NotNull] OGParser.ParametersContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterFunctionCall([NotNull] OGParser.FunctionCallContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.functionCall"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitFunctionCall([NotNull] OGParser.FunctionCallContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterParameterList([NotNull] OGParser.ParameterListContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameterList"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitParameterList([NotNull] OGParser.ParameterListContext context) { }
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterReturnStatement([NotNull] OGParser.ReturnStatementContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.returnStatement"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitReturnStatement([NotNull] OGParser.ReturnStatementContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}