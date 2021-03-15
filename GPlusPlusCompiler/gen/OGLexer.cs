//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/saxjax/developer/P4-project/GPlusPlusCompiler/GPlusPlusCompiler/OG.g4 by ANTLR 4.9.1

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
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, BooleanValue=6, Number=7, WS=8, 
		COMMENT=9, ShapeDCLWord=10, PointDCLWord=11, BoolDCLWord=12, NumberDCLWord=13, 
		DrawDCLWord=14, WithAngle=15, Curve=16, Line=17, To=18, From=19, RepeatStart=20, 
		RepeatEnd=21, Until=22, DOT=23, FunctionStartWord=24, FunctionReturnWord=25, 
		Void=26, LPAREN=27, RPAREN=28, PLUS=29, MINUS=30, TIMES=31, DIV=32, POW=33, 
		LogicOperator=34, BoolOperator=35, GT=36, LT=37, EQ=38, AND=39, OR=40, 
		Assign=41, OpenScope=42, CloseScope=43, Terminator=44, Seperator=45, CoordinatePropRef=46, 
		ID=47;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "BooleanValue", "Number", "Integer", 
		"Float", "WS", "COMMENT", "ShapeDCLWord", "PointDCLWord", "BoolDCLWord", 
		"NumberDCLWord", "DrawDCLWord", "WithAngle", "Curve", "Line", "To", "From", 
		"RepeatStart", "RepeatEnd", "Until", "DOT", "FunctionStartWord", "FunctionReturnWord", 
		"Void", "LPAREN", "RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "POW", "LogicOperator", 
		"BoolOperator", "GT", "LT", "EQ", "AND", "OR", "Assign", "OpenScope", 
		"CloseScope", "Terminator", "Seperator", "CoordinatePropRef", "ID"
	};


	public OGLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public OGLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'Xmin:'", "'Machine'", "'WorkArea'", "'size'", "'.to'", null, null, 
		null, null, "'shape'", "'point'", "'bool'", "'number'", "'draw'", "'withAngle'", 
		"'curve'", "'line'", "'to'", "'from'", "'repeat'", "'repeat.end'", "'until'", 
		"'.'", "'function'", "'return'", "'void'", "'('", "')'", "'+'", "'-'", 
		"'*'", "'/'", "'^'", null, null, "'>'", "'<'", "'=='", "'&&'", "'||'", 
		"'='", "'{'", "'}'", "';'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "BooleanValue", "Number", "WS", "COMMENT", 
		"ShapeDCLWord", "PointDCLWord", "BoolDCLWord", "NumberDCLWord", "DrawDCLWord", 
		"WithAngle", "Curve", "Line", "To", "From", "RepeatStart", "RepeatEnd", 
		"Until", "DOT", "FunctionStartWord", "FunctionReturnWord", "Void", "LPAREN", 
		"RPAREN", "PLUS", "MINUS", "TIMES", "DIV", "POW", "LogicOperator", "BoolOperator", 
		"GT", "LT", "EQ", "AND", "OR", "Assign", "OpenScope", "CloseScope", "Terminator", 
		"Seperator", "CoordinatePropRef", "ID"
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
		'\x5964', '\x2', '\x31', '\x181', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
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
		'\t', '\x32', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', 
		'\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', 
		'\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x5', '\a', '\x8F', '\n', '\a', '\x3', '\b', '\x3', '\b', 
		'\x5', '\b', '\x93', '\n', '\b', '\x3', '\t', '\x6', '\t', '\x96', '\n', 
		'\t', '\r', '\t', '\xE', '\t', '\x97', '\x3', '\t', '\x3', '\t', '\x6', 
		'\t', '\x9C', '\n', '\t', '\r', '\t', '\xE', '\t', '\x9D', '\x5', '\t', 
		'\xA0', '\n', '\t', '\x3', '\n', '\x6', '\n', '\xA3', '\n', '\n', '\r', 
		'\n', '\xE', '\n', '\xA4', '\x3', '\n', '\x3', '\n', '\x6', '\n', '\xA9', 
		'\n', '\n', '\r', '\n', '\xE', '\n', '\xAA', '\x3', '\n', '\x3', '\n', 
		'\x6', '\n', '\xAF', '\n', '\n', '\r', '\n', '\xE', '\n', '\xB0', '\x3', 
		'\n', '\x3', '\n', '\x6', '\n', '\xB5', '\n', '\n', '\r', '\n', '\xE', 
		'\n', '\xB6', '\x3', '\n', '\x3', '\n', '\x6', '\n', '\xBB', '\n', '\n', 
		'\r', '\n', '\xE', '\n', '\xBC', '\x5', '\n', '\xBF', '\n', '\n', '\x3', 
		'\v', '\x6', '\v', '\xC2', '\n', '\v', '\r', '\v', '\xE', '\v', '\xC3', 
		'\x3', '\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\a', '\f', '\xCC', '\n', '\f', '\f', '\f', '\xE', '\f', '\xCF', 
		'\v', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', 
		'\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', 
		'\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', '\xE', '\x3', 
		'\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x3', 
		'\xF', '\x3', '\xF', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x11', '\x3', 
		'\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x12', '\x3', '\x13', '\x3', 
		'\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', '\x13', '\x3', 
		'\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', '\x14', '\x3', 
		'\x15', '\x3', '\x15', '\x3', '\x15', '\x3', '\x16', '\x3', '\x16', '\x3', 
		'\x16', '\x3', '\x16', '\x3', '\x16', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', '\x17', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', '\x18', '\x3', 
		'\x18', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', '\x19', '\x3', 
		'\x19', '\x3', '\x19', '\x3', '\x1A', '\x3', '\x1A', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', 
		'\x1B', '\x3', '\x1B', '\x3', '\x1B', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', '\x1C', '\x3', 
		'\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', '\x1D', '\x3', 
		'\x1E', '\x3', '\x1E', '\x3', '\x1F', '\x3', '\x1F', '\x3', ' ', '\x3', 
		' ', '\x3', '!', '\x3', '!', '\x3', '\"', '\x3', '\"', '\x3', '#', '\x3', 
		'#', '\x3', '$', '\x3', '$', '\x3', '%', '\x3', '%', '\x5', '%', '\x14F', 
		'\n', '%', '\x3', '&', '\x3', '&', '\x3', '&', '\x5', '&', '\x154', '\n', 
		'&', '\x3', '\'', '\x3', '\'', '\x3', '(', '\x3', '(', '\x3', ')', '\x3', 
		')', '\x3', ')', '\x3', '*', '\x3', '*', '\x3', '*', '\x3', '+', '\x3', 
		'+', '\x3', '+', '\x3', ',', '\x3', ',', '\x3', '-', '\x3', '-', '\x3', 
		'.', '\x3', '.', '\x3', '/', '\x3', '/', '\x3', '\x30', '\x3', '\x30', 
		'\x3', '\x31', '\x3', '\x31', '\x3', '\x31', '\x3', '\x31', '\x3', '\x31', 
		'\x3', '\x31', '\x3', '\x31', '\x3', '\x31', '\x5', '\x31', '\x175', '\n', 
		'\x31', '\x3', '\x32', '\x6', '\x32', '\x178', '\n', '\x32', '\r', '\x32', 
		'\xE', '\x32', '\x179', '\x3', '\x32', '\a', '\x32', '\x17D', '\n', '\x32', 
		'\f', '\x32', '\xE', '\x32', '\x180', '\v', '\x32', '\x3', '\xCD', '\x2', 
		'\x33', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\x2', '\x13', '\x2', '\x15', '\n', '\x17', 
		'\v', '\x19', '\f', '\x1B', '\r', '\x1D', '\xE', '\x1F', '\xF', '!', '\x10', 
		'#', '\x11', '%', '\x12', '\'', '\x13', ')', '\x14', '+', '\x15', '-', 
		'\x16', '/', '\x17', '\x31', '\x18', '\x33', '\x19', '\x35', '\x1A', '\x37', 
		'\x1B', '\x39', '\x1C', ';', '\x1D', '=', '\x1E', '?', '\x1F', '\x41', 
		' ', '\x43', '!', '\x45', '\"', 'G', '#', 'I', '$', 'K', '%', 'M', '&', 
		'O', '\'', 'Q', '(', 'S', ')', 'U', '*', 'W', '+', 'Y', ',', '[', '-', 
		']', '.', '_', '/', '\x61', '\x30', '\x63', '\x31', '\x3', '\x2', '\x6', 
		'\x3', '\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', 
		'\"', '\x4', '\x2', '\x43', '\\', '\x63', '|', '\x5', '\x2', '\x32', ';', 
		'\x43', '\\', '\x63', '|', '\x2', '\x192', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', '\'', '\x3', 
		'\x2', '\x2', '\x2', '\x2', ')', '\x3', '\x2', '\x2', '\x2', '\x2', '+', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '-', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'/', '\x3', '\x2', '\x2', '\x2', '\x2', '\x31', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x33', '\x3', '\x2', '\x2', '\x2', '\x2', '\x35', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x37', '\x3', '\x2', '\x2', '\x2', '\x2', '\x39', 
		'\x3', '\x2', '\x2', '\x2', '\x2', ';', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'=', '\x3', '\x2', '\x2', '\x2', '\x2', '?', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\x41', '\x3', '\x2', '\x2', '\x2', '\x2', '\x43', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x45', '\x3', '\x2', '\x2', '\x2', '\x2', 'G', '\x3', 
		'\x2', '\x2', '\x2', '\x2', 'I', '\x3', '\x2', '\x2', '\x2', '\x2', 'K', 
		'\x3', '\x2', '\x2', '\x2', '\x2', 'M', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'O', '\x3', '\x2', '\x2', '\x2', '\x2', 'Q', '\x3', '\x2', '\x2', '\x2', 
		'\x2', 'S', '\x3', '\x2', '\x2', '\x2', '\x2', 'U', '\x3', '\x2', '\x2', 
		'\x2', '\x2', 'W', '\x3', '\x2', '\x2', '\x2', '\x2', 'Y', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '[', '\x3', '\x2', '\x2', '\x2', '\x2', ']', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '_', '\x3', '\x2', '\x2', '\x2', '\x2', '\x61', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\x63', '\x3', '\x2', '\x2', '\x2', 
		'\x3', '\x65', '\x3', '\x2', '\x2', '\x2', '\x5', 'k', '\x3', '\x2', '\x2', 
		'\x2', '\a', 's', '\x3', '\x2', '\x2', '\x2', '\t', '|', '\x3', '\x2', 
		'\x2', '\x2', '\v', '\x81', '\x3', '\x2', '\x2', '\x2', '\r', '\x8E', 
		'\x3', '\x2', '\x2', '\x2', '\xF', '\x92', '\x3', '\x2', '\x2', '\x2', 
		'\x11', '\x9F', '\x3', '\x2', '\x2', '\x2', '\x13', '\xBE', '\x3', '\x2', 
		'\x2', '\x2', '\x15', '\xC1', '\x3', '\x2', '\x2', '\x2', '\x17', '\xC7', 
		'\x3', '\x2', '\x2', '\x2', '\x19', '\xD5', '\x3', '\x2', '\x2', '\x2', 
		'\x1B', '\xDB', '\x3', '\x2', '\x2', '\x2', '\x1D', '\xE1', '\x3', '\x2', 
		'\x2', '\x2', '\x1F', '\xE6', '\x3', '\x2', '\x2', '\x2', '!', '\xED', 
		'\x3', '\x2', '\x2', '\x2', '#', '\xF2', '\x3', '\x2', '\x2', '\x2', '%', 
		'\xFC', '\x3', '\x2', '\x2', '\x2', '\'', '\x102', '\x3', '\x2', '\x2', 
		'\x2', ')', '\x107', '\x3', '\x2', '\x2', '\x2', '+', '\x10A', '\x3', 
		'\x2', '\x2', '\x2', '-', '\x10F', '\x3', '\x2', '\x2', '\x2', '/', '\x116', 
		'\x3', '\x2', '\x2', '\x2', '\x31', '\x121', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\x127', '\x3', '\x2', '\x2', '\x2', '\x35', '\x129', '\x3', '\x2', 
		'\x2', '\x2', '\x37', '\x132', '\x3', '\x2', '\x2', '\x2', '\x39', '\x139', 
		'\x3', '\x2', '\x2', '\x2', ';', '\x13E', '\x3', '\x2', '\x2', '\x2', 
		'=', '\x140', '\x3', '\x2', '\x2', '\x2', '?', '\x142', '\x3', '\x2', 
		'\x2', '\x2', '\x41', '\x144', '\x3', '\x2', '\x2', '\x2', '\x43', '\x146', 
		'\x3', '\x2', '\x2', '\x2', '\x45', '\x148', '\x3', '\x2', '\x2', '\x2', 
		'G', '\x14A', '\x3', '\x2', '\x2', '\x2', 'I', '\x14E', '\x3', '\x2', 
		'\x2', '\x2', 'K', '\x153', '\x3', '\x2', '\x2', '\x2', 'M', '\x155', 
		'\x3', '\x2', '\x2', '\x2', 'O', '\x157', '\x3', '\x2', '\x2', '\x2', 
		'Q', '\x159', '\x3', '\x2', '\x2', '\x2', 'S', '\x15C', '\x3', '\x2', 
		'\x2', '\x2', 'U', '\x15F', '\x3', '\x2', '\x2', '\x2', 'W', '\x162', 
		'\x3', '\x2', '\x2', '\x2', 'Y', '\x164', '\x3', '\x2', '\x2', '\x2', 
		'[', '\x166', '\x3', '\x2', '\x2', '\x2', ']', '\x168', '\x3', '\x2', 
		'\x2', '\x2', '_', '\x16A', '\x3', '\x2', '\x2', '\x2', '\x61', '\x174', 
		'\x3', '\x2', '\x2', '\x2', '\x63', '\x177', '\x3', '\x2', '\x2', '\x2', 
		'\x65', '\x66', '\a', 'Z', '\x2', '\x2', '\x66', 'g', '\a', 'o', '\x2', 
		'\x2', 'g', 'h', '\a', 'k', '\x2', '\x2', 'h', 'i', '\a', 'p', '\x2', 
		'\x2', 'i', 'j', '\a', '<', '\x2', '\x2', 'j', '\x4', '\x3', '\x2', '\x2', 
		'\x2', 'k', 'l', '\a', 'O', '\x2', '\x2', 'l', 'm', '\a', '\x63', '\x2', 
		'\x2', 'm', 'n', '\a', '\x65', '\x2', '\x2', 'n', 'o', '\a', 'j', '\x2', 
		'\x2', 'o', 'p', '\a', 'k', '\x2', '\x2', 'p', 'q', '\a', 'p', '\x2', 
		'\x2', 'q', 'r', '\a', 'g', '\x2', '\x2', 'r', '\x6', '\x3', '\x2', '\x2', 
		'\x2', 's', 't', '\a', 'Y', '\x2', '\x2', 't', 'u', '\a', 'q', '\x2', 
		'\x2', 'u', 'v', '\a', 't', '\x2', '\x2', 'v', 'w', '\a', 'm', '\x2', 
		'\x2', 'w', 'x', '\a', '\x43', '\x2', '\x2', 'x', 'y', '\a', 't', '\x2', 
		'\x2', 'y', 'z', '\a', 'g', '\x2', '\x2', 'z', '{', '\a', '\x63', '\x2', 
		'\x2', '{', '\b', '\x3', '\x2', '\x2', '\x2', '|', '}', '\a', 'u', '\x2', 
		'\x2', '}', '~', '\a', 'k', '\x2', '\x2', '~', '\x7F', '\a', '|', '\x2', 
		'\x2', '\x7F', '\x80', '\a', 'g', '\x2', '\x2', '\x80', '\n', '\x3', '\x2', 
		'\x2', '\x2', '\x81', '\x82', '\a', '\x30', '\x2', '\x2', '\x82', '\x83', 
		'\a', 'v', '\x2', '\x2', '\x83', '\x84', '\a', 'q', '\x2', '\x2', '\x84', 
		'\f', '\x3', '\x2', '\x2', '\x2', '\x85', '\x86', '\a', 'v', '\x2', '\x2', 
		'\x86', '\x87', '\a', 't', '\x2', '\x2', '\x87', '\x88', '\a', 'w', '\x2', 
		'\x2', '\x88', '\x8F', '\a', 'g', '\x2', '\x2', '\x89', '\x8A', '\a', 
		'h', '\x2', '\x2', '\x8A', '\x8B', '\a', '\x63', '\x2', '\x2', '\x8B', 
		'\x8C', '\a', 'n', '\x2', '\x2', '\x8C', '\x8D', '\a', 'u', '\x2', '\x2', 
		'\x8D', '\x8F', '\a', 'g', '\x2', '\x2', '\x8E', '\x85', '\x3', '\x2', 
		'\x2', '\x2', '\x8E', '\x89', '\x3', '\x2', '\x2', '\x2', '\x8F', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x90', '\x93', '\x5', '\x11', '\t', '\x2', 
		'\x91', '\x93', '\x5', '\x13', '\n', '\x2', '\x92', '\x90', '\x3', '\x2', 
		'\x2', '\x2', '\x92', '\x91', '\x3', '\x2', '\x2', '\x2', '\x93', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x94', '\x96', '\t', '\x2', '\x2', '\x2', 
		'\x95', '\x94', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\x3', '\x2', 
		'\x2', '\x2', '\x97', '\x95', '\x3', '\x2', '\x2', '\x2', '\x97', '\x98', 
		'\x3', '\x2', '\x2', '\x2', '\x98', '\xA0', '\x3', '\x2', '\x2', '\x2', 
		'\x99', '\x9B', '\a', '/', '\x2', '\x2', '\x9A', '\x9C', '\t', '\x2', 
		'\x2', '\x2', '\x9B', '\x9A', '\x3', '\x2', '\x2', '\x2', '\x9C', '\x9D', 
		'\x3', '\x2', '\x2', '\x2', '\x9D', '\x9B', '\x3', '\x2', '\x2', '\x2', 
		'\x9D', '\x9E', '\x3', '\x2', '\x2', '\x2', '\x9E', '\xA0', '\x3', '\x2', 
		'\x2', '\x2', '\x9F', '\x95', '\x3', '\x2', '\x2', '\x2', '\x9F', '\x99', 
		'\x3', '\x2', '\x2', '\x2', '\xA0', '\x12', '\x3', '\x2', '\x2', '\x2', 
		'\xA1', '\xA3', '\t', '\x2', '\x2', '\x2', '\xA2', '\xA1', '\x3', '\x2', 
		'\x2', '\x2', '\xA3', '\xA4', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA2', 
		'\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', '\x2', 
		'\xA5', '\xA6', '\x3', '\x2', '\x2', '\x2', '\xA6', '\xA8', '\a', '\x30', 
		'\x2', '\x2', '\xA7', '\xA9', '\t', '\x2', '\x2', '\x2', '\xA8', '\xA7', 
		'\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\x3', '\x2', '\x2', '\x2', 
		'\xAA', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', '\x2', 
		'\x2', '\x2', '\xAB', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xAC', '\xAE', 
		'\a', '/', '\x2', '\x2', '\xAD', '\xAF', '\t', '\x2', '\x2', '\x2', '\xAE', 
		'\xAD', '\x3', '\x2', '\x2', '\x2', '\xAF', '\xB0', '\x3', '\x2', '\x2', 
		'\x2', '\xB0', '\xAE', '\x3', '\x2', '\x2', '\x2', '\xB0', '\xB1', '\x3', 
		'\x2', '\x2', '\x2', '\xB1', '\xBF', '\x3', '\x2', '\x2', '\x2', '\xB2', 
		'\xB4', '\a', '/', '\x2', '\x2', '\xB3', '\xB5', '\t', '\x2', '\x2', '\x2', 
		'\xB4', '\xB3', '\x3', '\x2', '\x2', '\x2', '\xB5', '\xB6', '\x3', '\x2', 
		'\x2', '\x2', '\xB6', '\xB4', '\x3', '\x2', '\x2', '\x2', '\xB6', '\xB7', 
		'\x3', '\x2', '\x2', '\x2', '\xB7', '\xB8', '\x3', '\x2', '\x2', '\x2', 
		'\xB8', '\xBA', '\a', '\x30', '\x2', '\x2', '\xB9', '\xBB', '\t', '\x2', 
		'\x2', '\x2', '\xBA', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', 
		'\x3', '\x2', '\x2', '\x2', '\xBC', '\xBA', '\x3', '\x2', '\x2', '\x2', 
		'\xBC', '\xBD', '\x3', '\x2', '\x2', '\x2', '\xBD', '\xBF', '\x3', '\x2', 
		'\x2', '\x2', '\xBE', '\xA2', '\x3', '\x2', '\x2', '\x2', '\xBE', '\xAC', 
		'\x3', '\x2', '\x2', '\x2', '\xBE', '\xB2', '\x3', '\x2', '\x2', '\x2', 
		'\xBF', '\x14', '\x3', '\x2', '\x2', '\x2', '\xC0', '\xC2', '\t', '\x3', 
		'\x2', '\x2', '\xC1', '\xC0', '\x3', '\x2', '\x2', '\x2', '\xC2', '\xC3', 
		'\x3', '\x2', '\x2', '\x2', '\xC3', '\xC1', '\x3', '\x2', '\x2', '\x2', 
		'\xC3', '\xC4', '\x3', '\x2', '\x2', '\x2', '\xC4', '\xC5', '\x3', '\x2', 
		'\x2', '\x2', '\xC5', '\xC6', '\b', '\v', '\x2', '\x2', '\xC6', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\a', '\x31', '\x2', '\x2', 
		'\xC8', '\xC9', '\a', ',', '\x2', '\x2', '\xC9', '\xCD', '\x3', '\x2', 
		'\x2', '\x2', '\xCA', '\xCC', '\v', '\x2', '\x2', '\x2', '\xCB', '\xCA', 
		'\x3', '\x2', '\x2', '\x2', '\xCC', '\xCF', '\x3', '\x2', '\x2', '\x2', 
		'\xCD', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xCD', '\xCB', '\x3', '\x2', 
		'\x2', '\x2', '\xCE', '\xD0', '\x3', '\x2', '\x2', '\x2', '\xCF', '\xCD', 
		'\x3', '\x2', '\x2', '\x2', '\xD0', '\xD1', '\a', ',', '\x2', '\x2', '\xD1', 
		'\xD2', '\a', '\x31', '\x2', '\x2', '\xD2', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD3', '\xD4', '\b', '\f', '\x2', '\x2', '\xD4', '\x18', '\x3', 
		'\x2', '\x2', '\x2', '\xD5', '\xD6', '\a', 'u', '\x2', '\x2', '\xD6', 
		'\xD7', '\a', 'j', '\x2', '\x2', '\xD7', '\xD8', '\a', '\x63', '\x2', 
		'\x2', '\xD8', '\xD9', '\a', 'r', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'g', '\x2', '\x2', '\xDA', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xDB', 
		'\xDC', '\a', 'r', '\x2', '\x2', '\xDC', '\xDD', '\a', 'q', '\x2', '\x2', 
		'\xDD', '\xDE', '\a', 'k', '\x2', '\x2', '\xDE', '\xDF', '\a', 'p', '\x2', 
		'\x2', '\xDF', '\xE0', '\a', 'v', '\x2', '\x2', '\xE0', '\x1C', '\x3', 
		'\x2', '\x2', '\x2', '\xE1', '\xE2', '\a', '\x64', '\x2', '\x2', '\xE2', 
		'\xE3', '\a', 'q', '\x2', '\x2', '\xE3', '\xE4', '\a', 'q', '\x2', '\x2', 
		'\xE4', '\xE5', '\a', 'n', '\x2', '\x2', '\xE5', '\x1E', '\x3', '\x2', 
		'\x2', '\x2', '\xE6', '\xE7', '\a', 'p', '\x2', '\x2', '\xE7', '\xE8', 
		'\a', 'w', '\x2', '\x2', '\xE8', '\xE9', '\a', 'o', '\x2', '\x2', '\xE9', 
		'\xEA', '\a', '\x64', '\x2', '\x2', '\xEA', '\xEB', '\a', 'g', '\x2', 
		'\x2', '\xEB', '\xEC', '\a', 't', '\x2', '\x2', '\xEC', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\xED', '\xEE', '\a', '\x66', '\x2', '\x2', '\xEE', '\xEF', 
		'\a', 't', '\x2', '\x2', '\xEF', '\xF0', '\a', '\x63', '\x2', '\x2', '\xF0', 
		'\xF1', '\a', 'y', '\x2', '\x2', '\xF1', '\"', '\x3', '\x2', '\x2', '\x2', 
		'\xF2', '\xF3', '\a', 'y', '\x2', '\x2', '\xF3', '\xF4', '\a', 'k', '\x2', 
		'\x2', '\xF4', '\xF5', '\a', 'v', '\x2', '\x2', '\xF5', '\xF6', '\a', 
		'j', '\x2', '\x2', '\xF6', '\xF7', '\a', '\x43', '\x2', '\x2', '\xF7', 
		'\xF8', '\a', 'p', '\x2', '\x2', '\xF8', '\xF9', '\a', 'i', '\x2', '\x2', 
		'\xF9', '\xFA', '\a', 'n', '\x2', '\x2', '\xFA', '\xFB', '\a', 'g', '\x2', 
		'\x2', '\xFB', '$', '\x3', '\x2', '\x2', '\x2', '\xFC', '\xFD', '\a', 
		'\x65', '\x2', '\x2', '\xFD', '\xFE', '\a', 'w', '\x2', '\x2', '\xFE', 
		'\xFF', '\a', 't', '\x2', '\x2', '\xFF', '\x100', '\a', 'x', '\x2', '\x2', 
		'\x100', '\x101', '\a', 'g', '\x2', '\x2', '\x101', '&', '\x3', '\x2', 
		'\x2', '\x2', '\x102', '\x103', '\a', 'n', '\x2', '\x2', '\x103', '\x104', 
		'\a', 'k', '\x2', '\x2', '\x104', '\x105', '\a', 'p', '\x2', '\x2', '\x105', 
		'\x106', '\a', 'g', '\x2', '\x2', '\x106', '(', '\x3', '\x2', '\x2', '\x2', 
		'\x107', '\x108', '\a', 'v', '\x2', '\x2', '\x108', '\x109', '\a', 'q', 
		'\x2', '\x2', '\x109', '*', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x10B', 
		'\a', 'h', '\x2', '\x2', '\x10B', '\x10C', '\a', 't', '\x2', '\x2', '\x10C', 
		'\x10D', '\a', 'q', '\x2', '\x2', '\x10D', '\x10E', '\a', 'o', '\x2', 
		'\x2', '\x10E', ',', '\x3', '\x2', '\x2', '\x2', '\x10F', '\x110', '\a', 
		't', '\x2', '\x2', '\x110', '\x111', '\a', 'g', '\x2', '\x2', '\x111', 
		'\x112', '\a', 'r', '\x2', '\x2', '\x112', '\x113', '\a', 'g', '\x2', 
		'\x2', '\x113', '\x114', '\a', '\x63', '\x2', '\x2', '\x114', '\x115', 
		'\a', 'v', '\x2', '\x2', '\x115', '.', '\x3', '\x2', '\x2', '\x2', '\x116', 
		'\x117', '\a', 't', '\x2', '\x2', '\x117', '\x118', '\a', 'g', '\x2', 
		'\x2', '\x118', '\x119', '\a', 'r', '\x2', '\x2', '\x119', '\x11A', '\a', 
		'g', '\x2', '\x2', '\x11A', '\x11B', '\a', '\x63', '\x2', '\x2', '\x11B', 
		'\x11C', '\a', 'v', '\x2', '\x2', '\x11C', '\x11D', '\a', '\x30', '\x2', 
		'\x2', '\x11D', '\x11E', '\a', 'g', '\x2', '\x2', '\x11E', '\x11F', '\a', 
		'p', '\x2', '\x2', '\x11F', '\x120', '\a', '\x66', '\x2', '\x2', '\x120', 
		'\x30', '\x3', '\x2', '\x2', '\x2', '\x121', '\x122', '\a', 'w', '\x2', 
		'\x2', '\x122', '\x123', '\a', 'p', '\x2', '\x2', '\x123', '\x124', '\a', 
		'v', '\x2', '\x2', '\x124', '\x125', '\a', 'k', '\x2', '\x2', '\x125', 
		'\x126', '\a', 'n', '\x2', '\x2', '\x126', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '\x127', '\x128', '\a', '\x30', '\x2', '\x2', '\x128', '\x34', 
		'\x3', '\x2', '\x2', '\x2', '\x129', '\x12A', '\a', 'h', '\x2', '\x2', 
		'\x12A', '\x12B', '\a', 'w', '\x2', '\x2', '\x12B', '\x12C', '\a', 'p', 
		'\x2', '\x2', '\x12C', '\x12D', '\a', '\x65', '\x2', '\x2', '\x12D', '\x12E', 
		'\a', 'v', '\x2', '\x2', '\x12E', '\x12F', '\a', 'k', '\x2', '\x2', '\x12F', 
		'\x130', '\a', 'q', '\x2', '\x2', '\x130', '\x131', '\a', 'p', '\x2', 
		'\x2', '\x131', '\x36', '\x3', '\x2', '\x2', '\x2', '\x132', '\x133', 
		'\a', 't', '\x2', '\x2', '\x133', '\x134', '\a', 'g', '\x2', '\x2', '\x134', 
		'\x135', '\a', 'v', '\x2', '\x2', '\x135', '\x136', '\a', 'w', '\x2', 
		'\x2', '\x136', '\x137', '\a', 't', '\x2', '\x2', '\x137', '\x138', '\a', 
		'p', '\x2', '\x2', '\x138', '\x38', '\x3', '\x2', '\x2', '\x2', '\x139', 
		'\x13A', '\a', 'x', '\x2', '\x2', '\x13A', '\x13B', '\a', 'q', '\x2', 
		'\x2', '\x13B', '\x13C', '\a', 'k', '\x2', '\x2', '\x13C', '\x13D', '\a', 
		'\x66', '\x2', '\x2', '\x13D', ':', '\x3', '\x2', '\x2', '\x2', '\x13E', 
		'\x13F', '\a', '*', '\x2', '\x2', '\x13F', '<', '\x3', '\x2', '\x2', '\x2', 
		'\x140', '\x141', '\a', '+', '\x2', '\x2', '\x141', '>', '\x3', '\x2', 
		'\x2', '\x2', '\x142', '\x143', '\a', '-', '\x2', '\x2', '\x143', '@', 
		'\x3', '\x2', '\x2', '\x2', '\x144', '\x145', '\a', '/', '\x2', '\x2', 
		'\x145', '\x42', '\x3', '\x2', '\x2', '\x2', '\x146', '\x147', '\a', ',', 
		'\x2', '\x2', '\x147', '\x44', '\x3', '\x2', '\x2', '\x2', '\x148', '\x149', 
		'\a', '\x31', '\x2', '\x2', '\x149', '\x46', '\x3', '\x2', '\x2', '\x2', 
		'\x14A', '\x14B', '\a', '`', '\x2', '\x2', '\x14B', 'H', '\x3', '\x2', 
		'\x2', '\x2', '\x14C', '\x14F', '\x5', 'S', '*', '\x2', '\x14D', '\x14F', 
		'\x5', 'U', '+', '\x2', '\x14E', '\x14C', '\x3', '\x2', '\x2', '\x2', 
		'\x14E', '\x14D', '\x3', '\x2', '\x2', '\x2', '\x14F', 'J', '\x3', '\x2', 
		'\x2', '\x2', '\x150', '\x154', '\x5', 'O', '(', '\x2', '\x151', '\x154', 
		'\x5', 'M', '\'', '\x2', '\x152', '\x154', '\x5', 'Q', ')', '\x2', '\x153', 
		'\x150', '\x3', '\x2', '\x2', '\x2', '\x153', '\x151', '\x3', '\x2', '\x2', 
		'\x2', '\x153', '\x152', '\x3', '\x2', '\x2', '\x2', '\x154', 'L', '\x3', 
		'\x2', '\x2', '\x2', '\x155', '\x156', '\a', '@', '\x2', '\x2', '\x156', 
		'N', '\x3', '\x2', '\x2', '\x2', '\x157', '\x158', '\a', '>', '\x2', '\x2', 
		'\x158', 'P', '\x3', '\x2', '\x2', '\x2', '\x159', '\x15A', '\a', '?', 
		'\x2', '\x2', '\x15A', '\x15B', '\a', '?', '\x2', '\x2', '\x15B', 'R', 
		'\x3', '\x2', '\x2', '\x2', '\x15C', '\x15D', '\a', '(', '\x2', '\x2', 
		'\x15D', '\x15E', '\a', '(', '\x2', '\x2', '\x15E', 'T', '\x3', '\x2', 
		'\x2', '\x2', '\x15F', '\x160', '\a', '~', '\x2', '\x2', '\x160', '\x161', 
		'\a', '~', '\x2', '\x2', '\x161', 'V', '\x3', '\x2', '\x2', '\x2', '\x162', 
		'\x163', '\a', '?', '\x2', '\x2', '\x163', 'X', '\x3', '\x2', '\x2', '\x2', 
		'\x164', '\x165', '\a', '}', '\x2', '\x2', '\x165', 'Z', '\x3', '\x2', 
		'\x2', '\x2', '\x166', '\x167', '\a', '\x7F', '\x2', '\x2', '\x167', '\\', 
		'\x3', '\x2', '\x2', '\x2', '\x168', '\x169', '\a', '=', '\x2', '\x2', 
		'\x169', '^', '\x3', '\x2', '\x2', '\x2', '\x16A', '\x16B', '\a', '.', 
		'\x2', '\x2', '\x16B', '`', '\x3', '\x2', '\x2', '\x2', '\x16C', '\x16D', 
		'\x5', '\x63', '\x32', '\x2', '\x16D', '\x16E', '\a', '\x30', '\x2', '\x2', 
		'\x16E', '\x16F', '\a', 'z', '\x2', '\x2', '\x16F', '\x175', '\x3', '\x2', 
		'\x2', '\x2', '\x170', '\x171', '\x5', '\x63', '\x32', '\x2', '\x171', 
		'\x172', '\a', '\x30', '\x2', '\x2', '\x172', '\x173', '\a', '{', '\x2', 
		'\x2', '\x173', '\x175', '\x3', '\x2', '\x2', '\x2', '\x174', '\x16C', 
		'\x3', '\x2', '\x2', '\x2', '\x174', '\x170', '\x3', '\x2', '\x2', '\x2', 
		'\x175', '\x62', '\x3', '\x2', '\x2', '\x2', '\x176', '\x178', '\t', '\x4', 
		'\x2', '\x2', '\x177', '\x176', '\x3', '\x2', '\x2', '\x2', '\x178', '\x179', 
		'\x3', '\x2', '\x2', '\x2', '\x179', '\x177', '\x3', '\x2', '\x2', '\x2', 
		'\x179', '\x17A', '\x3', '\x2', '\x2', '\x2', '\x17A', '\x17E', '\x3', 
		'\x2', '\x2', '\x2', '\x17B', '\x17D', '\t', '\x5', '\x2', '\x2', '\x17C', 
		'\x17B', '\x3', '\x2', '\x2', '\x2', '\x17D', '\x180', '\x3', '\x2', '\x2', 
		'\x2', '\x17E', '\x17C', '\x3', '\x2', '\x2', '\x2', '\x17E', '\x17F', 
		'\x3', '\x2', '\x2', '\x2', '\x17F', '\x64', '\x3', '\x2', '\x2', '\x2', 
		'\x180', '\x17E', '\x3', '\x2', '\x2', '\x2', '\x15', '\x2', '\x8E', '\x92', 
		'\x97', '\x9D', '\x9F', '\xA4', '\xAA', '\xB0', '\xB6', '\xBC', '\xBE', 
		'\xC3', '\xCD', '\x14E', '\x153', '\x174', '\x179', '\x17E', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
