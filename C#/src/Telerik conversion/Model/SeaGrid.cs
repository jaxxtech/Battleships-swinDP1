
CONVERSION ERROR: Code could not be converted. Details:

----- Exception 1 of 1 -----
System.NotImplementedException: Microsoft.CodeAnalysis.VisualBasic.Syntax.RaiseEventStatementSyntax not implemented!
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.MethodBodyVisitor.DefaultVisit(SyntaxNode node)
   at Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxVisitor`1.VisitRaiseEventStatement(RaiseEventStatementSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.RaiseEventStatementSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.<VisitFinallyBlock>b__32_0(StatementSyntax s)
   at System.Linq.Enumerable.<SelectManyIterator>d__14`2.MoveNext()
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.List[TNode](IEnumerable`1 nodes)
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.Block(IEnumerable`1 statements)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.VisitFinallyBlock(FinallyBlockSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.FinallyBlockSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.MethodBodyVisitor.VisitTryBlock(TryBlockSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.TryBlockSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.<VisitMethodBlock>b__23_2(StatementSyntax s)
   at System.Linq.Enumerable.<SelectManyIterator>d__14`2.MoveNext()
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.List[TNode](IEnumerable`1 nodes)
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.Block(IEnumerable`1 statements)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.VisitMethodBlock(MethodBlockSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.MethodBlockSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.<ConvertMembers>b__11_0(StatementSyntax m)
   at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.<ConvertMembers>d__11.MoveNext()
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.List[TNode](IEnumerable`1 nodes)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.VisitClassBlock(ClassBlockSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.ClassBlockSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.<VisitCompilationUnit>b__8_1(StatementSyntax m)
   at System.Linq.Enumerable.WhereSelectEnumerableIterator`2.MoveNext()
   at Microsoft.CodeAnalysis.CSharp.SyntaxFactory.List[TNode](IEnumerable`1 nodes)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.NodesVisitor.VisitCompilationUnit(CompilationUnitSyntax node)
   at Microsoft.CodeAnalysis.VisualBasic.Syntax.CompilationUnitSyntax.Accept[TResult](VisualBasicSyntaxVisitor`1 visitor)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.Convert(VisualBasicSyntaxNode input, SemanticModel semanticModel, Document targetDocument)
   at RefactoringEssentials.CSharp.Converter.VisualBasicConverter.ConvertText(String text, MetadataReference[] references)

Please check for any errors in the original code and try again.
