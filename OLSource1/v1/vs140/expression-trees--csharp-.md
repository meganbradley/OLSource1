---
title: "Expression Trees (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 7d0ac21a-6d90-4e2e-8903-528cb78615b7
caps.latest.revision: 7
---
# Expression Trees (C#)
Expression trees represent code in a tree-like data structure, where each node is an expression, for example, a method call or a binary operation such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 You can compile and run code represented by expression trees. This enables dynamic modification of executable code, the execution of LINQ queries in various databases, and the creation of dynamic queries. For more information about expression trees in LINQ, see [How to: Use Expression Trees to Build Dynamic Queries (C#)](../vs140/how-to--use-expression-trees-to-build-dynamic-queries--csharp-.md).  
  
 Expression trees are also used in the dynamic language runtime (DLR) to provide interoperability between dynamic languages and the .NET Framework and to enable compiler writers to emit expression trees instead of Microsoft intermediate language (MSIL). For more information about the DLR, see [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d).  
  
 You can have the C# or Visual Basic compiler create an expression tree for you based on an anonymous lambda expression, or you can create expression trees manually by using the \<xref:System.Linq.Expressions*> namespace.  
  
## Creating Expression Trees from Lambda Expressions  
 When a lambda expression is assigned to a variable of type <xref:System.Linq.Expressions.Expression<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>num => num < 5<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>num => num < 5<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>try-catch<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>num => num < 5<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1*> type provides the \<xref:System.Linq.Expressions.Expression`1.Compile*> method that compiles the code represented by an expression tree into an executable delegate.  
  
 The following code example demonstrates how to compile an expression tree and run the resulting code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For more information, see [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md).  
  
## See Also  
 \<xref:System.Linq.Expressions*>   
 [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md)   
 [How to: Modify Expression Trees (C#)](../vs140/how-to--modify-expression-trees--csharp-.md)   
 [Lambda Expressions (C# Programming Guide)](../vs140/lambda-expressions--csharp-programming-guide-.md)   
 [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d)   
 [Programming Concepts (C#)](../vs140/programming-concepts--csharp-.md)