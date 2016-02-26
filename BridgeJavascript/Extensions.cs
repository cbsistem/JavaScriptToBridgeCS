﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeJavascript
{
    static class Extensions
    {
        public static string ToOperatorString (this Jint.Parser.Ast.BinaryOperator value)
        {
            switch (value)
            {
                case Jint.Parser.Ast.BinaryOperator.Plus:
                    return "+";
                case Jint.Parser.Ast.BinaryOperator.Minus:
                    return "-";
                case Jint.Parser.Ast.BinaryOperator.Times:
                    return "*";
                case Jint.Parser.Ast.BinaryOperator.Divide:
                    return "/";
                case Jint.Parser.Ast.BinaryOperator.Modulo:
                    return "%";
                case Jint.Parser.Ast.BinaryOperator.Equal:
                    throw new ArgumentException("Equal not possible.");
                case Jint.Parser.Ast.BinaryOperator.NotEqual:
                    throw new ArgumentException("Not-Equal not possible.");
                case Jint.Parser.Ast.BinaryOperator.Greater:
                    return ">";
                case Jint.Parser.Ast.BinaryOperator.GreaterOrEqual:
                    return ">=";
                case Jint.Parser.Ast.BinaryOperator.Less:
                    return "<";
                case Jint.Parser.Ast.BinaryOperator.LessOrEqual:
                    return "<=";
                case Jint.Parser.Ast.BinaryOperator.StrictlyEqual:
                    return "==";
                case Jint.Parser.Ast.BinaryOperator.StricltyNotEqual:
                    return "!=";
                case Jint.Parser.Ast.BinaryOperator.BitwiseAnd:
                    return "&";
                case Jint.Parser.Ast.BinaryOperator.BitwiseOr:
                    return "|";
                case Jint.Parser.Ast.BinaryOperator.BitwiseXOr:
                    return "^";
                case Jint.Parser.Ast.BinaryOperator.LeftShift:
                    return "<<";
                case Jint.Parser.Ast.BinaryOperator.RightShift:
                    return ">>";
                case Jint.Parser.Ast.BinaryOperator.UnsignedRightShift:
                    break;
                case Jint.Parser.Ast.BinaryOperator.InstanceOf:
                    break;
                case Jint.Parser.Ast.BinaryOperator.In:
                    break;
                default:
                    break;
            }
            throw new ArgumentException("Inpossible operator: " + value);
        }
    }
}