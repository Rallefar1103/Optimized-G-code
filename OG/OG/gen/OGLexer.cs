//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/saxjax/developer/P4-project/OG/OG/OG.g4 by ANTLR 4.9.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.1")]
[System.CLSCompliant(false)]
public partial class OGLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		Number=1, BooleanValue=2, WS=3, COMMENT=4, ShapeDCLWord=5, PointDCLWord=6, 
		BoolDCLWord=7, NumberDCLWord=8, DrawDCLWord=9, WithAngle=10, Curve=11, 
		Line=12, To=13, From=14, RepeatStart=15, RepeatEnd=16, Until=17, DOT=18, 
		FunctionStartWord=19, FunctionReturnWord=20, Void=21, LParen=22, RParen=23, 
		Plus_Minus=24, Plus=25, Minus=26, Mul_Div=27, Times=28, Div=29, Pow=30, 
		LogicOperator=31, BoolOperator=32, NOT=33, Assign=34, OpenScope=35, CloseScope=36, 
		Terminator=37, Seperator=38, XMIN=39, XMAX=40, YMAX=41, YMIN=42, Machine=43, 
		WorkArea=44, Size=45, StartPointReference=46, EndPointReference=47, If=48, 
		Then=49, CoordinateXYValue=50, ID=51;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"Number", "BooleanValue", "Integer", "Float", "WS", "COMMENT", "ShapeDCLWord", 
		"PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", "WithAngle", 
		"Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", "Until", "DOT", 
		"FunctionStartWord", "FunctionReturnWord", "Void", "LParen", "RParen", 
		"Plus_Minus", "Plus", "Minus", "Mul_Div", "Times", "Div", "Pow", "LogicOperator", 
		"BoolOperator", "GT", "LT", "EQ", "AND", "NOT", "OR", "Assign", "OpenScope", 
		"CloseScope", "Terminator", "Seperator", "XMIN", "XMAX", "YMAX", "YMIN", 
		"Machine", "WorkArea", "Size", "StartPointReference", "EndPointReference", 
		"If", "Then", "CoordinateXYValue", "ID"
	};


	public OGLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public OGLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, "'shape'", "'point'", "'bool'", "'number'", 
		"'draw'", "'withAngle'", "'curve'", "'line'", "'to'", "'from'", "'repeat'", 
		"'repeat.end'", "'until'", "'.'", "'function'", "'return'", "'void'", 
		"'('", "')'", null, "'+'", "'-'", null, "'*'", "'/'", "'^'", null, null, 
		"'!'", "'='", "'{'", "'}'", "';'", "','", "'xmin'", "'xmax'", "'ymin'", 
		"'ymax'", "'Machine'", "'WorkArea'", "'size'", null, null, "'if'", "'then'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "Number", "BooleanValue", "WS", "COMMENT", "ShapeDCLWord", "PointDCLWord", 
		"BoolDCLWord", "NumberDCLWord", "DrawDCLWord", "WithAngle", "Curve", "Line", 
		"To", "From", "RepeatStart", "RepeatEnd", "Until", "DOT", "FunctionStartWord", 
		"FunctionReturnWord", "Void", "LParen", "RParen", "Plus_Minus", "Plus", 
		"Minus", "Mul_Div", "Times", "Div", "Pow", "LogicOperator", "BoolOperator", 
		"NOT", "Assign", "OpenScope", "CloseScope", "Terminator", "Seperator", 
		"XMIN", "XMAX", "YMAX", "YMIN", "Machine", "WorkArea", "Size", "StartPointReference", 
		"EndPointReference", "If", "Then", "CoordinateXYValue", "ID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "OG.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static OGLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x35', '\x1D1', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x4', '\x15', '\t', '\x15', '\x4', 
		'\x16', '\t', '\x16', '\x4', '\x17', '\t', '\x17', '\x4', '\x18', '\t', 
		'\x18', '\x4', '\x19', '\t', '\x19', '\x4', '\x1A', '\t', '\x1A', '\x4', 
		'\x1B', '\t', '\x1B', '\x4', '\x1C', '\t', '\x1C', '\x4', '\x1D', '\t', 
		'\x1D', '\x4', '\x1E', '\t', '\x1E', '\x4', '\x1F', '\t', '\x1F', '\x4', 
		' ', '\t', ' ', '\x4', '!', '\t', '!', '\x4', '\"', '\t', '\"', '\x4', 
		'#', '\t', '#', '\x4', '$', '\t', '$', '\x4', '%', '\t', '%', '\x4', '&', 
		'\t', '&', '\x4', '\'', '\t', '\'', '\x4', '(', '\t', '(', '\x4', ')', 
		'\t', ')', '\x4', '*', '\t', '*', '\x4', '+', '\t', '+', '\x4', ',', '\t', 
		',', '\x4', '-', '\t', '-', '\x4', '.', '\t', '.', '\x4', '/', '\t', '/', 
		'\x4', '\x30', '\t', '\x30', '\x4', '\x31', '\t', '\x31', '\x4', '\x32', 
		'\t', '\x32', '\x4', '\x33', '\t', '\x33', '\x4', '\x34', '\t', '\x34', 
		'\x4', '\x35', '\t', '\x35', '\x4', '\x36', '\t', '\x36', '\x4', '\x37', 
		'\t', '\x37', '\x4', '\x38', '\t', '\x38', '\x4', '\x39', '\t', '\x39', 
		'\x4', ':', '\t', ':', '\x4', ';', '\t', ';', '\x3', '\x2', '\x3', '\x2', 
		'\x5', '\x2', 'z', '\n', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x5', '\x3', '\x85', '\n', '\x3', '\x3', '\x4', '\x6', 
		'\x4', '\x88', '\n', '\x4', '\r', '\x4', '\xE', '\x4', '\x89', '\x3', 
		'\x4', '\x3', '\x4', '\x6', '\x4', '\x8E', '\n', '\x4', '\r', '\x4', '\xE', 
		'\x4', '\x8F', '\x5', '\x4', '\x92', '\n', '\x4', '\x3', '\x5', '\x6', 
		'\x5', '\x95', '\n', '\x5', '\r', '\x5', '\xE', '\x5', '\x96', '\x3', 
		'\x5', '\x3', '\x5', '\x6', '\x5', '\x9B', '\n', '\x5', '\r', '\x5', '\xE', 
		'\x5', '\x9C', '\x3', '\x5', '\x3', '\x5', '\x6', '\x5', '\xA1', '\n', 
		'\x5', '\r', '\x5', '\xE', '\x5', '\xA2', '\x3', '\x5', '\x3', '\x5', 
		'\x6', '\x5', '\xA7', '\n', '\x5', '\r', '\x5', '\xE', '\x5', '\xA8', 
		'\x3', '\x5', '\x3', '\x5', '\x6', '\x5', '\xAD', '\n', '\x5', '\r', '\x5', 
		'\xE', '\x5', '\xAE', '\x5', '\x5', '\xB1', '\n', '\x5', '\x3', '\x6', 
		'\x6', '\x6', '\xB4', '\n', '\x6', '\r', '\x6', '\xE', '\x6', '\xB5', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\a', '\a', '\xBE', '\n', '\a', '\f', '\a', '\xE', '\a', '\xC1', 
		'\v', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x15', '\x3', 
		'\x15', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', 
		'\x1A', '\x3', '\x1B', '\x3', '\x1B', '\x5', '\x1B', '\x137', '\n', '\x1B', 
		'\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1E', 
		'\x3', '\x1E', '\x5', '\x1E', '\x13F', '\n', '\x1E', '\x3', '\x1F', '\x3', 
		'\x1F', '\x3', ' ', '\x3', ' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', 
		'\"', '\x5', '\"', '\x149', '\n', '\"', '\x3', '#', '\x3', '#', '\x3', 
		'#', '\x5', '#', '\x14E', '\n', '#', '\x3', '$', '\x3', '$', '\x3', '%', 
		'\x3', '%', '\x3', '&', '\x3', '&', '\x3', '&', '\x3', '\'', '\x3', '\'', 
		'\x3', '\'', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', ')', '\x3', ')', 
		'\x3', '*', '\x3', '*', '\x3', '+', '\x3', '+', '\x3', ',', '\x3', ',', 
		'\x3', '-', '\x3', '-', '\x3', '.', '\x3', '.', '\x3', '/', '\x3', '/', 
		'\x3', '/', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', '\x30', '\x3', 
		'\x30', '\x3', '\x30', '\x3', '\x30', '\x3', '\x31', '\x3', '\x31', '\x3', 
		'\x31', '\x3', '\x31', '\x3', '\x31', '\x3', '\x32', '\x3', '\x32', '\x3', 
		'\x32', '\x3', '\x32', '\x3', '\x32', '\x3', '\x33', '\x3', '\x33', '\x3', 
		'\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', '\x33', '\x3', 
		'\x33', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', 
		'\x34', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', '\x34', '\x3', 
		'\x35', '\x3', '\x35', '\x3', '\x35', '\x3', '\x35', '\x3', '\x35', '\x3', 
		'\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', 
		'\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x36', '\x3', 
		'\x36', '\x3', '\x36', '\x3', '\x36', '\x3', '\x37', '\x3', '\x37', '\x3', 
		'\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', 
		'\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x37', '\x3', '\x38', '\x3', 
		'\x38', '\x3', '\x38', '\x3', '\x39', '\x3', '\x39', '\x3', '\x39', '\x3', 
		'\x39', '\x3', '\x39', '\x3', ':', '\x3', ':', '\x3', ':', '\x3', ':', 
		'\x3', ':', '\x3', ':', '\x3', ':', '\x3', ':', '\x3', ':', '\x3', ':', 
		'\x5', ':', '\x1BD', '\n', ':', '\x3', ':', '\x3', ':', '\x3', ':', '\x3', 
		':', '\x5', ':', '\x1C3', '\n', ':', '\x5', ':', '\x1C5', '\n', ':', '\x3', 
		';', '\x6', ';', '\x1C8', '\n', ';', '\r', ';', '\xE', ';', '\x1C9', '\x3', 
		';', '\a', ';', '\x1CD', '\n', ';', '\f', ';', '\xE', ';', '\x1D0', '\v', 
		';', '\x3', '\xBF', '\x2', '<', '\x3', '\x3', '\x5', '\x4', '\a', '\x2', 
		'\t', '\x2', '\v', '\x5', '\r', '\x6', '\xF', '\a', '\x11', '\b', '\x13', 
		'\t', '\x15', '\n', '\x17', '\v', '\x19', '\f', '\x1B', '\r', '\x1D', 
		'\xE', '\x1F', '\xF', '!', '\x10', '#', '\x11', '%', '\x12', '\'', '\x13', 
		')', '\x14', '+', '\x15', '-', '\x16', '/', '\x17', '\x31', '\x18', '\x33', 
		'\x19', '\x35', '\x1A', '\x37', '\x1B', '\x39', '\x1C', ';', '\x1D', '=', 
		'\x1E', '?', '\x1F', '\x41', ' ', '\x43', '!', '\x45', '\"', 'G', '\x2', 
		'I', '\x2', 'K', '\x2', 'M', '\x2', 'O', '#', 'Q', '\x2', 'S', '$', 'U', 
		'%', 'W', '&', 'Y', '\'', '[', '(', ']', ')', '_', '*', '\x61', '+', '\x63', 
		',', '\x65', '-', 'g', '.', 'i', '/', 'k', '\x30', 'm', '\x31', 'o', '\x32', 
		'q', '\x33', 's', '\x34', 'u', '\x35', '\x3', '\x2', '\x6', '\x3', '\x2', 
		'\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x4', 
		'\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\x32', ';', '\x43', '\\', 
		'\x63', '|', '\x2', '\x1E2', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', '\x2', 
		'\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', '/', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'O', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'Y', '\x3', '\x2', '\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', 
		'\x2', ']', '\x3', '\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x61', '\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x65', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'g', '\x3', '\x2', '\x2', '\x2', '\x2', 'i', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'k', '\x3', '\x2', '\x2', '\x2', '\x2', 'm', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'o', '\x3', '\x2', '\x2', '\x2', '\x2', 'q', '\x3', '\x2', 
		'\x2', '\x2', '\x2', 's', '\x3', '\x2', '\x2', '\x2', '\x2', 'u', '\x3', 
		'\x2', '\x2', '\x2', '\x3', 'y', '\x3', '\x2', '\x2', '\x2', '\x5', '\x84', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x91', '\x3', '\x2', '\x2', '\x2', 
		'\t', '\xB0', '\x3', '\x2', '\x2', '\x2', '\v', '\xB3', '\x3', '\x2', 
		'\x2', '\x2', '\r', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xF', '\xC7', 
		'\x3', '\x2', '\x2', '\x2', '\x11', '\xCD', '\x3', '\x2', '\x2', '\x2', 
		'\x13', '\xD3', '\x3', '\x2', '\x2', '\x2', '\x15', '\xD8', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\xDF', '\x3', '\x2', '\x2', '\x2', '\x19', '\xE4', 
		'\x3', '\x2', '\x2', '\x2', '\x1B', '\xEE', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '\xF4', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xF9', '\x3', '\x2', 
		'\x2', '\x2', '!', '\xFC', '\x3', '\x2', '\x2', '\x2', '#', '\x101', '\x3', 
		'\x2', '\x2', '\x2', '%', '\x108', '\x3', '\x2', '\x2', '\x2', '\'', '\x113', 
		'\x3', '\x2', '\x2', '\x2', ')', '\x119', '\x3', '\x2', '\x2', '\x2', 
		'+', '\x11B', '\x3', '\x2', '\x2', '\x2', '-', '\x124', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x12B', '\x3', '\x2', '\x2', '\x2', '\x31', '\x130', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x132', '\x3', '\x2', '\x2', '\x2', 
		'\x35', '\x136', '\x3', '\x2', '\x2', '\x2', '\x37', '\x138', '\x3', '\x2', 
		'\x2', '\x2', '\x39', '\x13A', '\x3', '\x2', '\x2', '\x2', ';', '\x13E', 
		'\x3', '\x2', '\x2', '\x2', '=', '\x140', '\x3', '\x2', '\x2', '\x2', 
		'?', '\x142', '\x3', '\x2', '\x2', '\x2', '\x41', '\x144', '\x3', '\x2', 
		'\x2', '\x2', '\x43', '\x148', '\x3', '\x2', '\x2', '\x2', '\x45', '\x14D', 
		'\x3', '\x2', '\x2', '\x2', 'G', '\x14F', '\x3', '\x2', '\x2', '\x2', 
		'I', '\x151', '\x3', '\x2', '\x2', '\x2', 'K', '\x153', '\x3', '\x2', 
		'\x2', '\x2', 'M', '\x156', '\x3', '\x2', '\x2', '\x2', 'O', '\x159', 
		'\x3', '\x2', '\x2', '\x2', 'Q', '\x15B', '\x3', '\x2', '\x2', '\x2', 
		'S', '\x15E', '\x3', '\x2', '\x2', '\x2', 'U', '\x160', '\x3', '\x2', 
		'\x2', '\x2', 'W', '\x162', '\x3', '\x2', '\x2', '\x2', 'Y', '\x164', 
		'\x3', '\x2', '\x2', '\x2', '[', '\x166', '\x3', '\x2', '\x2', '\x2', 
		']', '\x168', '\x3', '\x2', '\x2', '\x2', '_', '\x16D', '\x3', '\x2', 
		'\x2', '\x2', '\x61', '\x172', '\x3', '\x2', '\x2', '\x2', '\x63', '\x177', 
		'\x3', '\x2', '\x2', '\x2', '\x65', '\x17C', '\x3', '\x2', '\x2', '\x2', 
		'g', '\x184', '\x3', '\x2', '\x2', '\x2', 'i', '\x18D', '\x3', '\x2', 
		'\x2', '\x2', 'k', '\x192', '\x3', '\x2', '\x2', '\x2', 'm', '\x19F', 
		'\x3', '\x2', '\x2', '\x2', 'o', '\x1AA', '\x3', '\x2', '\x2', '\x2', 
		'q', '\x1AD', '\x3', '\x2', '\x2', '\x2', 's', '\x1C4', '\x3', '\x2', 
		'\x2', '\x2', 'u', '\x1C7', '\x3', '\x2', '\x2', '\x2', 'w', 'z', '\x5', 
		'\a', '\x4', '\x2', 'x', 'z', '\x5', '\t', '\x5', '\x2', 'y', 'w', '\x3', 
		'\x2', '\x2', '\x2', 'y', 'x', '\x3', '\x2', '\x2', '\x2', 'z', '\x4', 
		'\x3', '\x2', '\x2', '\x2', '{', '|', '\a', 'v', '\x2', '\x2', '|', '}', 
		'\a', 't', '\x2', '\x2', '}', '~', '\a', 'w', '\x2', '\x2', '~', '\x85', 
		'\a', 'g', '\x2', '\x2', '\x7F', '\x80', '\a', 'h', '\x2', '\x2', '\x80', 
		'\x81', '\a', '\x63', '\x2', '\x2', '\x81', '\x82', '\a', 'n', '\x2', 
		'\x2', '\x82', '\x83', '\a', 'u', '\x2', '\x2', '\x83', '\x85', '\a', 
		'g', '\x2', '\x2', '\x84', '{', '\x3', '\x2', '\x2', '\x2', '\x84', '\x7F', 
		'\x3', '\x2', '\x2', '\x2', '\x85', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'\x86', '\x88', '\t', '\x2', '\x2', '\x2', '\x87', '\x86', '\x3', '\x2', 
		'\x2', '\x2', '\x88', '\x89', '\x3', '\x2', '\x2', '\x2', '\x89', '\x87', 
		'\x3', '\x2', '\x2', '\x2', '\x89', '\x8A', '\x3', '\x2', '\x2', '\x2', 
		'\x8A', '\x92', '\x3', '\x2', '\x2', '\x2', '\x8B', '\x8D', '\a', '/', 
		'\x2', '\x2', '\x8C', '\x8E', '\t', '\x2', '\x2', '\x2', '\x8D', '\x8C', 
		'\x3', '\x2', '\x2', '\x2', '\x8E', '\x8F', '\x3', '\x2', '\x2', '\x2', 
		'\x8F', '\x8D', '\x3', '\x2', '\x2', '\x2', '\x8F', '\x90', '\x3', '\x2', 
		'\x2', '\x2', '\x90', '\x92', '\x3', '\x2', '\x2', '\x2', '\x91', '\x87', 
		'\x3', '\x2', '\x2', '\x2', '\x91', '\x8B', '\x3', '\x2', '\x2', '\x2', 
		'\x92', '\b', '\x3', '\x2', '\x2', '\x2', '\x93', '\x95', '\t', '\x2', 
		'\x2', '\x2', '\x94', '\x93', '\x3', '\x2', '\x2', '\x2', '\x95', '\x96', 
		'\x3', '\x2', '\x2', '\x2', '\x96', '\x94', '\x3', '\x2', '\x2', '\x2', 
		'\x96', '\x97', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', '\x3', '\x2', 
		'\x2', '\x2', '\x98', '\x9A', '\a', '\x30', '\x2', '\x2', '\x99', '\x9B', 
		'\t', '\x2', '\x2', '\x2', '\x9A', '\x99', '\x3', '\x2', '\x2', '\x2', 
		'\x9B', '\x9C', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9A', '\x3', '\x2', 
		'\x2', '\x2', '\x9C', '\x9D', '\x3', '\x2', '\x2', '\x2', '\x9D', '\xB1', 
		'\x3', '\x2', '\x2', '\x2', '\x9E', '\xA0', '\a', '/', '\x2', '\x2', '\x9F', 
		'\xA1', '\t', '\x2', '\x2', '\x2', '\xA0', '\x9F', '\x3', '\x2', '\x2', 
		'\x2', '\xA1', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xA2', '\xA0', '\x3', 
		'\x2', '\x2', '\x2', '\xA2', '\xA3', '\x3', '\x2', '\x2', '\x2', '\xA3', 
		'\xB1', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA6', '\a', '/', '\x2', 
		'\x2', '\xA5', '\xA7', '\t', '\x2', '\x2', '\x2', '\xA6', '\xA5', '\x3', 
		'\x2', '\x2', '\x2', '\xA7', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA8', 
		'\xA6', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xA9', '\x3', '\x2', '\x2', 
		'\x2', '\xA9', '\xAA', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAC', '\a', 
		'\x30', '\x2', '\x2', '\xAB', '\xAD', '\t', '\x2', '\x2', '\x2', '\xAC', 
		'\xAB', '\x3', '\x2', '\x2', '\x2', '\xAD', '\xAE', '\x3', '\x2', '\x2', 
		'\x2', '\xAE', '\xAC', '\x3', '\x2', '\x2', '\x2', '\xAE', '\xAF', '\x3', 
		'\x2', '\x2', '\x2', '\xAF', '\xB1', '\x3', '\x2', '\x2', '\x2', '\xB0', 
		'\x94', '\x3', '\x2', '\x2', '\x2', '\xB0', '\x9E', '\x3', '\x2', '\x2', 
		'\x2', '\xB0', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xB1', '\n', '\x3', 
		'\x2', '\x2', '\x2', '\xB2', '\xB4', '\t', '\x3', '\x2', '\x2', '\xB3', 
		'\xB2', '\x3', '\x2', '\x2', '\x2', '\xB4', '\xB5', '\x3', '\x2', '\x2', 
		'\x2', '\xB5', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\x3', 
		'\x2', '\x2', '\x2', '\xB6', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB7', 
		'\xB8', '\b', '\x6', '\x2', '\x2', '\xB8', '\f', '\x3', '\x2', '\x2', 
		'\x2', '\xB9', '\xBA', '\a', '\x31', '\x2', '\x2', '\xBA', '\xBB', '\a', 
		',', '\x2', '\x2', '\xBB', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xBC', 
		'\xBE', '\v', '\x2', '\x2', '\x2', '\xBD', '\xBC', '\x3', '\x2', '\x2', 
		'\x2', '\xBE', '\xC1', '\x3', '\x2', '\x2', '\x2', '\xBF', '\xC0', '\x3', 
		'\x2', '\x2', '\x2', '\xBF', '\xBD', '\x3', '\x2', '\x2', '\x2', '\xC0', 
		'\xC2', '\x3', '\x2', '\x2', '\x2', '\xC1', '\xBF', '\x3', '\x2', '\x2', 
		'\x2', '\xC2', '\xC3', '\a', ',', '\x2', '\x2', '\xC3', '\xC4', '\a', 
		'\x31', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', '\x2', '\x2', '\xC5', 
		'\xC6', '\b', '\a', '\x2', '\x2', '\xC6', '\xE', '\x3', '\x2', '\x2', 
		'\x2', '\xC7', '\xC8', '\a', 'u', '\x2', '\x2', '\xC8', '\xC9', '\a', 
		'j', '\x2', '\x2', '\xC9', '\xCA', '\a', '\x63', '\x2', '\x2', '\xCA', 
		'\xCB', '\a', 'r', '\x2', '\x2', '\xCB', '\xCC', '\a', 'g', '\x2', '\x2', 
		'\xCC', '\x10', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCE', '\a', 'r', 
		'\x2', '\x2', '\xCE', '\xCF', '\a', 'q', '\x2', '\x2', '\xCF', '\xD0', 
		'\a', 'k', '\x2', '\x2', '\xD0', '\xD1', '\a', 'p', '\x2', '\x2', '\xD1', 
		'\xD2', '\a', 'v', '\x2', '\x2', '\xD2', '\x12', '\x3', '\x2', '\x2', 
		'\x2', '\xD3', '\xD4', '\a', '\x64', '\x2', '\x2', '\xD4', '\xD5', '\a', 
		'q', '\x2', '\x2', '\xD5', '\xD6', '\a', 'q', '\x2', '\x2', '\xD6', '\xD7', 
		'\a', 'n', '\x2', '\x2', '\xD7', '\x14', '\x3', '\x2', '\x2', '\x2', '\xD8', 
		'\xD9', '\a', 'p', '\x2', '\x2', '\xD9', '\xDA', '\a', 'w', '\x2', '\x2', 
		'\xDA', '\xDB', '\a', 'o', '\x2', '\x2', '\xDB', '\xDC', '\a', '\x64', 
		'\x2', '\x2', '\xDC', '\xDD', '\a', 'g', '\x2', '\x2', '\xDD', '\xDE', 
		'\a', 't', '\x2', '\x2', '\xDE', '\x16', '\x3', '\x2', '\x2', '\x2', '\xDF', 
		'\xE0', '\a', '\x66', '\x2', '\x2', '\xE0', '\xE1', '\a', 't', '\x2', 
		'\x2', '\xE1', '\xE2', '\a', '\x63', '\x2', '\x2', '\xE2', '\xE3', '\a', 
		'y', '\x2', '\x2', '\xE3', '\x18', '\x3', '\x2', '\x2', '\x2', '\xE4', 
		'\xE5', '\a', 'y', '\x2', '\x2', '\xE5', '\xE6', '\a', 'k', '\x2', '\x2', 
		'\xE6', '\xE7', '\a', 'v', '\x2', '\x2', '\xE7', '\xE8', '\a', 'j', '\x2', 
		'\x2', '\xE8', '\xE9', '\a', '\x43', '\x2', '\x2', '\xE9', '\xEA', '\a', 
		'p', '\x2', '\x2', '\xEA', '\xEB', '\a', 'i', '\x2', '\x2', '\xEB', '\xEC', 
		'\a', 'n', '\x2', '\x2', '\xEC', '\xED', '\a', 'g', '\x2', '\x2', '\xED', 
		'\x1A', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEF', '\a', '\x65', '\x2', 
		'\x2', '\xEF', '\xF0', '\a', 'w', '\x2', '\x2', '\xF0', '\xF1', '\a', 
		't', '\x2', '\x2', '\xF1', '\xF2', '\a', 'x', '\x2', '\x2', '\xF2', '\xF3', 
		'\a', 'g', '\x2', '\x2', '\xF3', '\x1C', '\x3', '\x2', '\x2', '\x2', '\xF4', 
		'\xF5', '\a', 'n', '\x2', '\x2', '\xF5', '\xF6', '\a', 'k', '\x2', '\x2', 
		'\xF6', '\xF7', '\a', 'p', '\x2', '\x2', '\xF7', '\xF8', '\a', 'g', '\x2', 
		'\x2', '\xF8', '\x1E', '\x3', '\x2', '\x2', '\x2', '\xF9', '\xFA', '\a', 
		'v', '\x2', '\x2', '\xFA', '\xFB', '\a', 'q', '\x2', '\x2', '\xFB', ' ', 
		'\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\a', 'h', '\x2', '\x2', '\xFD', 
		'\xFE', '\a', 't', '\x2', '\x2', '\xFE', '\xFF', '\a', 'q', '\x2', '\x2', 
		'\xFF', '\x100', '\a', 'o', '\x2', '\x2', '\x100', '\"', '\x3', '\x2', 
		'\x2', '\x2', '\x101', '\x102', '\a', 't', '\x2', '\x2', '\x102', '\x103', 
		'\a', 'g', '\x2', '\x2', '\x103', '\x104', '\a', 'r', '\x2', '\x2', '\x104', 
		'\x105', '\a', 'g', '\x2', '\x2', '\x105', '\x106', '\a', '\x63', '\x2', 
		'\x2', '\x106', '\x107', '\a', 'v', '\x2', '\x2', '\x107', '$', '\x3', 
		'\x2', '\x2', '\x2', '\x108', '\x109', '\a', 't', '\x2', '\x2', '\x109', 
		'\x10A', '\a', 'g', '\x2', '\x2', '\x10A', '\x10B', '\a', 'r', '\x2', 
		'\x2', '\x10B', '\x10C', '\a', 'g', '\x2', '\x2', '\x10C', '\x10D', '\a', 
		'\x63', '\x2', '\x2', '\x10D', '\x10E', '\a', 'v', '\x2', '\x2', '\x10E', 
		'\x10F', '\a', '\x30', '\x2', '\x2', '\x10F', '\x110', '\a', 'g', '\x2', 
		'\x2', '\x110', '\x111', '\a', 'p', '\x2', '\x2', '\x111', '\x112', '\a', 
		'\x66', '\x2', '\x2', '\x112', '&', '\x3', '\x2', '\x2', '\x2', '\x113', 
		'\x114', '\a', 'w', '\x2', '\x2', '\x114', '\x115', '\a', 'p', '\x2', 
		'\x2', '\x115', '\x116', '\a', 'v', '\x2', '\x2', '\x116', '\x117', '\a', 
		'k', '\x2', '\x2', '\x117', '\x118', '\a', 'n', '\x2', '\x2', '\x118', 
		'(', '\x3', '\x2', '\x2', '\x2', '\x119', '\x11A', '\a', '\x30', '\x2', 
		'\x2', '\x11A', '*', '\x3', '\x2', '\x2', '\x2', '\x11B', '\x11C', '\a', 
		'h', '\x2', '\x2', '\x11C', '\x11D', '\a', 'w', '\x2', '\x2', '\x11D', 
		'\x11E', '\a', 'p', '\x2', '\x2', '\x11E', '\x11F', '\a', '\x65', '\x2', 
		'\x2', '\x11F', '\x120', '\a', 'v', '\x2', '\x2', '\x120', '\x121', '\a', 
		'k', '\x2', '\x2', '\x121', '\x122', '\a', 'q', '\x2', '\x2', '\x122', 
		'\x123', '\a', 'p', '\x2', '\x2', '\x123', ',', '\x3', '\x2', '\x2', '\x2', 
		'\x124', '\x125', '\a', 't', '\x2', '\x2', '\x125', '\x126', '\a', 'g', 
		'\x2', '\x2', '\x126', '\x127', '\a', 'v', '\x2', '\x2', '\x127', '\x128', 
		'\a', 'w', '\x2', '\x2', '\x128', '\x129', '\a', 't', '\x2', '\x2', '\x129', 
		'\x12A', '\a', 'p', '\x2', '\x2', '\x12A', '.', '\x3', '\x2', '\x2', '\x2', 
		'\x12B', '\x12C', '\a', 'x', '\x2', '\x2', '\x12C', '\x12D', '\a', 'q', 
		'\x2', '\x2', '\x12D', '\x12E', '\a', 'k', '\x2', '\x2', '\x12E', '\x12F', 
		'\a', '\x66', '\x2', '\x2', '\x12F', '\x30', '\x3', '\x2', '\x2', '\x2', 
		'\x130', '\x131', '\a', '*', '\x2', '\x2', '\x131', '\x32', '\x3', '\x2', 
		'\x2', '\x2', '\x132', '\x133', '\a', '+', '\x2', '\x2', '\x133', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x134', '\x137', '\x5', '\x37', '\x1C', '\x2', 
		'\x135', '\x137', '\x5', '\x39', '\x1D', '\x2', '\x136', '\x134', '\x3', 
		'\x2', '\x2', '\x2', '\x136', '\x135', '\x3', '\x2', '\x2', '\x2', '\x137', 
		'\x36', '\x3', '\x2', '\x2', '\x2', '\x138', '\x139', '\a', '-', '\x2', 
		'\x2', '\x139', '\x38', '\x3', '\x2', '\x2', '\x2', '\x13A', '\x13B', 
		'\a', '/', '\x2', '\x2', '\x13B', ':', '\x3', '\x2', '\x2', '\x2', '\x13C', 
		'\x13F', '\x5', '=', '\x1F', '\x2', '\x13D', '\x13F', '\x5', '?', ' ', 
		'\x2', '\x13E', '\x13C', '\x3', '\x2', '\x2', '\x2', '\x13E', '\x13D', 
		'\x3', '\x2', '\x2', '\x2', '\x13F', '<', '\x3', '\x2', '\x2', '\x2', 
		'\x140', '\x141', '\a', ',', '\x2', '\x2', '\x141', '>', '\x3', '\x2', 
		'\x2', '\x2', '\x142', '\x143', '\a', '\x31', '\x2', '\x2', '\x143', '@', 
		'\x3', '\x2', '\x2', '\x2', '\x144', '\x145', '\a', '`', '\x2', '\x2', 
		'\x145', '\x42', '\x3', '\x2', '\x2', '\x2', '\x146', '\x149', '\x5', 
		'M', '\'', '\x2', '\x147', '\x149', '\x5', 'Q', ')', '\x2', '\x148', '\x146', 
		'\x3', '\x2', '\x2', '\x2', '\x148', '\x147', '\x3', '\x2', '\x2', '\x2', 
		'\x149', '\x44', '\x3', '\x2', '\x2', '\x2', '\x14A', '\x14E', '\x5', 
		'I', '%', '\x2', '\x14B', '\x14E', '\x5', 'G', '$', '\x2', '\x14C', '\x14E', 
		'\x5', 'K', '&', '\x2', '\x14D', '\x14A', '\x3', '\x2', '\x2', '\x2', 
		'\x14D', '\x14B', '\x3', '\x2', '\x2', '\x2', '\x14D', '\x14C', '\x3', 
		'\x2', '\x2', '\x2', '\x14E', '\x46', '\x3', '\x2', '\x2', '\x2', '\x14F', 
		'\x150', '\a', '@', '\x2', '\x2', '\x150', 'H', '\x3', '\x2', '\x2', '\x2', 
		'\x151', '\x152', '\a', '>', '\x2', '\x2', '\x152', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\x153', '\x154', '\a', '?', '\x2', '\x2', '\x154', '\x155', 
		'\a', '?', '\x2', '\x2', '\x155', 'L', '\x3', '\x2', '\x2', '\x2', '\x156', 
		'\x157', '\a', '(', '\x2', '\x2', '\x157', '\x158', '\a', '(', '\x2', 
		'\x2', '\x158', 'N', '\x3', '\x2', '\x2', '\x2', '\x159', '\x15A', '\a', 
		'#', '\x2', '\x2', '\x15A', 'P', '\x3', '\x2', '\x2', '\x2', '\x15B', 
		'\x15C', '\a', '~', '\x2', '\x2', '\x15C', '\x15D', '\a', '~', '\x2', 
		'\x2', '\x15D', 'R', '\x3', '\x2', '\x2', '\x2', '\x15E', '\x15F', '\a', 
		'?', '\x2', '\x2', '\x15F', 'T', '\x3', '\x2', '\x2', '\x2', '\x160', 
		'\x161', '\a', '}', '\x2', '\x2', '\x161', 'V', '\x3', '\x2', '\x2', '\x2', 
		'\x162', '\x163', '\a', '\x7F', '\x2', '\x2', '\x163', 'X', '\x3', '\x2', 
		'\x2', '\x2', '\x164', '\x165', '\a', '=', '\x2', '\x2', '\x165', 'Z', 
		'\x3', '\x2', '\x2', '\x2', '\x166', '\x167', '\a', '.', '\x2', '\x2', 
		'\x167', '\\', '\x3', '\x2', '\x2', '\x2', '\x168', '\x169', '\a', 'z', 
		'\x2', '\x2', '\x169', '\x16A', '\a', 'o', '\x2', '\x2', '\x16A', '\x16B', 
		'\a', 'k', '\x2', '\x2', '\x16B', '\x16C', '\a', 'p', '\x2', '\x2', '\x16C', 
		'^', '\x3', '\x2', '\x2', '\x2', '\x16D', '\x16E', '\a', 'z', '\x2', '\x2', 
		'\x16E', '\x16F', '\a', 'o', '\x2', '\x2', '\x16F', '\x170', '\a', '\x63', 
		'\x2', '\x2', '\x170', '\x171', '\a', 'z', '\x2', '\x2', '\x171', '`', 
		'\x3', '\x2', '\x2', '\x2', '\x172', '\x173', '\a', '{', '\x2', '\x2', 
		'\x173', '\x174', '\a', 'o', '\x2', '\x2', '\x174', '\x175', '\a', 'k', 
		'\x2', '\x2', '\x175', '\x176', '\a', 'p', '\x2', '\x2', '\x176', '\x62', 
		'\x3', '\x2', '\x2', '\x2', '\x177', '\x178', '\a', '{', '\x2', '\x2', 
		'\x178', '\x179', '\a', 'o', '\x2', '\x2', '\x179', '\x17A', '\a', '\x63', 
		'\x2', '\x2', '\x17A', '\x17B', '\a', 'z', '\x2', '\x2', '\x17B', '\x64', 
		'\x3', '\x2', '\x2', '\x2', '\x17C', '\x17D', '\a', 'O', '\x2', '\x2', 
		'\x17D', '\x17E', '\a', '\x63', '\x2', '\x2', '\x17E', '\x17F', '\a', 
		'\x65', '\x2', '\x2', '\x17F', '\x180', '\a', 'j', '\x2', '\x2', '\x180', 
		'\x181', '\a', 'k', '\x2', '\x2', '\x181', '\x182', '\a', 'p', '\x2', 
		'\x2', '\x182', '\x183', '\a', 'g', '\x2', '\x2', '\x183', '\x66', '\x3', 
		'\x2', '\x2', '\x2', '\x184', '\x185', '\a', 'Y', '\x2', '\x2', '\x185', 
		'\x186', '\a', 'q', '\x2', '\x2', '\x186', '\x187', '\a', 't', '\x2', 
		'\x2', '\x187', '\x188', '\a', 'm', '\x2', '\x2', '\x188', '\x189', '\a', 
		'\x43', '\x2', '\x2', '\x189', '\x18A', '\a', 't', '\x2', '\x2', '\x18A', 
		'\x18B', '\a', 'g', '\x2', '\x2', '\x18B', '\x18C', '\a', '\x63', '\x2', 
		'\x2', '\x18C', 'h', '\x3', '\x2', '\x2', '\x2', '\x18D', '\x18E', '\a', 
		'u', '\x2', '\x2', '\x18E', '\x18F', '\a', 'k', '\x2', '\x2', '\x18F', 
		'\x190', '\a', '|', '\x2', '\x2', '\x190', '\x191', '\a', 'g', '\x2', 
		'\x2', '\x191', 'j', '\x3', '\x2', '\x2', '\x2', '\x192', '\x193', '\x5', 
		'u', ';', '\x2', '\x193', '\x194', '\a', '\x30', '\x2', '\x2', '\x194', 
		'\x195', '\a', 'u', '\x2', '\x2', '\x195', '\x196', '\a', 'v', '\x2', 
		'\x2', '\x196', '\x197', '\a', '\x63', '\x2', '\x2', '\x197', '\x198', 
		'\a', 't', '\x2', '\x2', '\x198', '\x199', '\a', 'v', '\x2', '\x2', '\x199', 
		'\x19A', '\a', 'R', '\x2', '\x2', '\x19A', '\x19B', '\a', 'q', '\x2', 
		'\x2', '\x19B', '\x19C', '\a', 'k', '\x2', '\x2', '\x19C', '\x19D', '\a', 
		'p', '\x2', '\x2', '\x19D', '\x19E', '\a', 'v', '\x2', '\x2', '\x19E', 
		'l', '\x3', '\x2', '\x2', '\x2', '\x19F', '\x1A0', '\x5', 'u', ';', '\x2', 
		'\x1A0', '\x1A1', '\a', '\x30', '\x2', '\x2', '\x1A1', '\x1A2', '\a', 
		'g', '\x2', '\x2', '\x1A2', '\x1A3', '\a', 'p', '\x2', '\x2', '\x1A3', 
		'\x1A4', '\a', '\x66', '\x2', '\x2', '\x1A4', '\x1A5', '\a', 'R', '\x2', 
		'\x2', '\x1A5', '\x1A6', '\a', 'q', '\x2', '\x2', '\x1A6', '\x1A7', '\a', 
		'k', '\x2', '\x2', '\x1A7', '\x1A8', '\a', 'p', '\x2', '\x2', '\x1A8', 
		'\x1A9', '\a', 'v', '\x2', '\x2', '\x1A9', 'n', '\x3', '\x2', '\x2', '\x2', 
		'\x1AA', '\x1AB', '\a', 'k', '\x2', '\x2', '\x1AB', '\x1AC', '\a', 'h', 
		'\x2', '\x2', '\x1AC', 'p', '\x3', '\x2', '\x2', '\x2', '\x1AD', '\x1AE', 
		'\a', 'v', '\x2', '\x2', '\x1AE', '\x1AF', '\a', 'j', '\x2', '\x2', '\x1AF', 
		'\x1B0', '\a', 'g', '\x2', '\x2', '\x1B0', '\x1B1', '\a', 'p', '\x2', 
		'\x2', '\x1B1', 'r', '\x3', '\x2', '\x2', '\x2', '\x1B2', '\x1B3', '\x5', 
		'u', ';', '\x2', '\x1B3', '\x1B4', '\a', '\x30', '\x2', '\x2', '\x1B4', 
		'\x1B5', '\a', 'z', '\x2', '\x2', '\x1B5', '\x1C5', '\x3', '\x2', '\x2', 
		'\x2', '\x1B6', '\x1B7', '\x5', 'u', ';', '\x2', '\x1B7', '\x1B8', '\a', 
		'\x30', '\x2', '\x2', '\x1B8', '\x1B9', '\a', '{', '\x2', '\x2', '\x1B9', 
		'\x1C5', '\x3', '\x2', '\x2', '\x2', '\x1BA', '\x1BD', '\x5', 'k', '\x36', 
		'\x2', '\x1BB', '\x1BD', '\x5', 'm', '\x37', '\x2', '\x1BC', '\x1BA', 
		'\x3', '\x2', '\x2', '\x2', '\x1BC', '\x1BB', '\x3', '\x2', '\x2', '\x2', 
		'\x1BD', '\x1C2', '\x3', '\x2', '\x2', '\x2', '\x1BE', '\x1BF', '\a', 
		'\x30', '\x2', '\x2', '\x1BF', '\x1C3', '\a', 'z', '\x2', '\x2', '\x1C0', 
		'\x1C1', '\a', '\x30', '\x2', '\x2', '\x1C1', '\x1C3', '\a', '{', '\x2', 
		'\x2', '\x1C2', '\x1BE', '\x3', '\x2', '\x2', '\x2', '\x1C2', '\x1C0', 
		'\x3', '\x2', '\x2', '\x2', '\x1C3', '\x1C5', '\x3', '\x2', '\x2', '\x2', 
		'\x1C4', '\x1B2', '\x3', '\x2', '\x2', '\x2', '\x1C4', '\x1B6', '\x3', 
		'\x2', '\x2', '\x2', '\x1C4', '\x1BC', '\x3', '\x2', '\x2', '\x2', '\x1C5', 
		't', '\x3', '\x2', '\x2', '\x2', '\x1C6', '\x1C8', '\t', '\x4', '\x2', 
		'\x2', '\x1C7', '\x1C6', '\x3', '\x2', '\x2', '\x2', '\x1C8', '\x1C9', 
		'\x3', '\x2', '\x2', '\x2', '\x1C9', '\x1C7', '\x3', '\x2', '\x2', '\x2', 
		'\x1C9', '\x1CA', '\x3', '\x2', '\x2', '\x2', '\x1CA', '\x1CE', '\x3', 
		'\x2', '\x2', '\x2', '\x1CB', '\x1CD', '\t', '\x5', '\x2', '\x2', '\x1CC', 
		'\x1CB', '\x3', '\x2', '\x2', '\x2', '\x1CD', '\x1D0', '\x3', '\x2', '\x2', 
		'\x2', '\x1CE', '\x1CC', '\x3', '\x2', '\x2', '\x2', '\x1CE', '\x1CF', 
		'\x3', '\x2', '\x2', '\x2', '\x1CF', 'v', '\x3', '\x2', '\x2', '\x2', 
		'\x1D0', '\x1CE', '\x3', '\x2', '\x2', '\x2', '\x19', '\x2', 'y', '\x84', 
		'\x89', '\x8F', '\x91', '\x96', '\x9C', '\xA2', '\xA8', '\xAE', '\xB0', 
		'\xB5', '\xBF', '\x136', '\x13E', '\x148', '\x14D', '\x1BC', '\x1C2', 
		'\x1C4', '\x1C9', '\x1CE', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
