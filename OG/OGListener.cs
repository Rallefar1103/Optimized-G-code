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
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="OGParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public interface IOGListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] OGParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] OGParser.ProgramContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.machineVariables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMachineVariables([NotNull] OGParser.MachineVariablesContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.machineVariables"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMachineVariables([NotNull] OGParser.MachineVariablesContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.machine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMachine([NotNull] OGParser.MachineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.machine"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMachine([NotNull] OGParser.MachineContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.draw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDraw([NotNull] OGParser.DrawContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.draw"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDraw([NotNull] OGParser.DrawContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.shapeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterShapeDefinition([NotNull] OGParser.ShapeDefinitionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.shapeDefinition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitShapeDefinition([NotNull] OGParser.ShapeDefinitionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBody([NotNull] OGParser.BodyContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.body"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBody([NotNull] OGParser.BodyContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclaration([NotNull] OGParser.DeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.declaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclaration([NotNull] OGParser.DeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.booleanDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBooleanDeclaration([NotNull] OGParser.BooleanDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.booleanDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBooleanDeclaration([NotNull] OGParser.BooleanDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberDeclaration([NotNull] OGParser.NumberDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberDeclaration([NotNull] OGParser.NumberDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointDeclaration([NotNull] OGParser.PointDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointDeclaration([NotNull] OGParser.PointDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointReference([NotNull] OGParser.PointReferenceContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointReference"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointReference([NotNull] OGParser.PointReferenceContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberTuple([NotNull] OGParser.NumberTupleContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberTuple"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberTuple([NotNull] OGParser.NumberTupleContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] OGParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] OGParser.AssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPropertyAssignment([NotNull] OGParser.PropertyAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.propertyAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPropertyAssignment([NotNull] OGParser.PropertyAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVariableAssignment([NotNull] OGParser.VariableAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.variableAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVariableAssignment([NotNull] OGParser.VariableAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.idAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdAssign([NotNull] OGParser.IdAssignContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.idAssign"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdAssign([NotNull] OGParser.IdAssignContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.boolAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolAssignment([NotNull] OGParser.BoolAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.boolAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolAssignment([NotNull] OGParser.BoolAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberAssignment([NotNull] OGParser.NumberAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberAssignment([NotNull] OGParser.NumberAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.pointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPointAssignment([NotNull] OGParser.PointAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.pointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPointAssignment([NotNull] OGParser.PointAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.startPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStartPointAssignment([NotNull] OGParser.StartPointAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.startPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStartPointAssignment([NotNull] OGParser.StartPointAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.endPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterEndPointAssignment([NotNull] OGParser.EndPointAssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.endPointAssignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitEndPointAssignment([NotNull] OGParser.EndPointAssignmentContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] OGParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] OGParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMathExpression([NotNull] OGParser.MathExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.mathExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMathExpression([NotNull] OGParser.MathExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] OGParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] OGParser.TermContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] OGParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] OGParser.FactorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAtom([NotNull] OGParser.AtomContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.atom"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAtom([NotNull] OGParser.AtomContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolExpression([NotNull] OGParser.BoolExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.boolExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolExpression([NotNull] OGParser.BoolExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCommand([NotNull] OGParser.CommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.command"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCommand([NotNull] OGParser.CommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.movementCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMovementCommand([NotNull] OGParser.MovementCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.movementCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMovementCommand([NotNull] OGParser.MovementCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.lineCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLineCommand([NotNull] OGParser.LineCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.lineCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLineCommand([NotNull] OGParser.LineCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.curveCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCurveCommand([NotNull] OGParser.CurveCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.curveCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCurveCommand([NotNull] OGParser.CurveCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterToCommand([NotNull] OGParser.ToCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.toCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitToCommand([NotNull] OGParser.ToCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.drawCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDrawCommand([NotNull] OGParser.DrawCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.drawCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDrawCommand([NotNull] OGParser.DrawCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.iterationCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIterationCommand([NotNull] OGParser.IterationCommandContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.iterationCommand"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIterationCommand([NotNull] OGParser.IterationCommandContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.numberIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumberIteration([NotNull] OGParser.NumberIterationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.numberIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumberIteration([NotNull] OGParser.NumberIterationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.untilIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterUntilIteration([NotNull] OGParser.UntilIterationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.untilIteration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitUntilIteration([NotNull] OGParser.UntilIterationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionDeclaration([NotNull] OGParser.FunctionDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.functionDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionDeclaration([NotNull] OGParser.FunctionDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.returnFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnFunctionDCL([NotNull] OGParser.ReturnFunctionDCLContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.returnFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnFunctionDCL([NotNull] OGParser.ReturnFunctionDCLContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.typeWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTypeWord([NotNull] OGParser.TypeWordContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.typeWord"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTypeWord([NotNull] OGParser.TypeWordContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.voidFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVoidFunctionDCL([NotNull] OGParser.VoidFunctionDCLContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.voidFunctionDCL"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVoidFunctionDCL([NotNull] OGParser.VoidFunctionDCLContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameterDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterDeclarations([NotNull] OGParser.ParameterDeclarationsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameterDeclarations"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterDeclarations([NotNull] OGParser.ParameterDeclarationsContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameters([NotNull] OGParser.ParametersContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameters"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameters([NotNull] OGParser.ParametersContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] OGParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] OGParser.FunctionCallContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParameterList([NotNull] OGParser.ParameterListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParameterList([NotNull] OGParser.ParameterListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="OGParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterReturnStatement([NotNull] OGParser.ReturnStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="OGParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitReturnStatement([NotNull] OGParser.ReturnStatementContext context);
}
