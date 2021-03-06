﻿using HotReloading.Core.Statements;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace StatementConverter.StatementInterpreter
{
    internal class ReturnStatementInterpreter : IStatementInterpreter
    {
        private StatementInterpreterHandler statementInterpreterHandler;
        private ReturnStatementSyntax returnStatementSyntax;

        public ReturnStatementInterpreter(StatementInterpreterHandler statementInterpreterHandler, ReturnStatementSyntax returnStatementSyntax)
        {
            this.statementInterpreterHandler = statementInterpreterHandler;
            this.returnStatementSyntax = returnStatementSyntax;
        }

        public Statement GetStatement()
        {
            return new ReturnStatement
            {
                Statement = statementInterpreterHandler.GetStatement(returnStatementSyntax.Expression)
            };
        }
    }
}