﻿using HotReloading.Core.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace StatementConverter.StatementInterpreter
{
    public class ExpressionStatementIntrepreter : IStatementInterpreter
    {
        private readonly ExpressionStatementSyntax expressionStatementSyntax;
        private readonly StatementInterpreterHandler interpreterHandler;

        public ExpressionStatementIntrepreter(StatementInterpreterHandler interpreterHandler,
            ExpressionStatementSyntax expressionStatementSyntax)
        {
            this.interpreterHandler = interpreterHandler;
            this.expressionStatementSyntax = expressionStatementSyntax;
        }

        public Statement GetStatement()
        {
            var interpreter = interpreterHandler.GetStatement(expressionStatementSyntax.Expression);

            return interpreter;
        }
    }
}