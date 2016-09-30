---
title: "Expression Trees (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 8bbbb02d-7ffc-476b-8c25-118d82bf5d46
caps.latest.revision: 3
---
# Expression Trees (Visual Basic)
Expression trees represent code in a tree-like data structure, where each node is an expression, for example, a method call or a binary operation such as <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
 You can compile and run code represented by expression trees. This enables dynamic modification of executable code, the execution of LINQ queries in various databases, and the creation of dynamic queries. For more information about expression trees in LINQ, see [How to: Use Expression Trees to Build Dynamic Queries (Visual Basic)](../vs140/how-to--use-expression-trees-to-build-dynamic-queries--visual-basic-.md).  
  
 Expression trees are also used in the dynamic language runtime (DLR) to provide interoperability between dynamic languages and the .NET Framework and to enable compiler writers to emit expression trees instead of Microsoft intermediate language (MSIL). For more information about the DLR, see [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d).  
  
 You can have the C# or Visual Basic compiler create an expression tree for you based on an anonymous lambda expression, or you can create expression trees manually by using the \<xref:System.Linq.Expressions*> namespace.  
  
## Creating Expression Trees from Lambda Expressions  
 When a lambda expression is assigned to a variable of type <xref:System.Linq.Expressions.Expression<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Function(num) num < 5<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Function(num) num < 5<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>try-catch<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>Function(num) num < 5<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>1*> type provides the \<xref:System.Linq.Expressions.Expression`1.Compile*> method that compiles the code represented by an expression tree into an executable delegate.  
  
 The following code example demonstrates how to compile an expression tree and run the resulting code.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 For more information, see [How to: Execute Expression Trees (Visual Basic)](../vs140/how-to--execute-expression-trees--visual-basic-.md).  
  
## See Also  
 \<xref:System.Linq.Expressions*>   
 [How to: Execute Expression Trees (Visual Basic)](../vs140/how-to--execute-expression-trees--visual-basic-.md)   
 [How to: Modify Expression Trees (Visual Basic)](../vs140/how-to--modify-expression-trees--visual-basic-.md)   
 [Lambda Expressions (Visual Basic)](../vs140/lambda-expressions--visual-basic-.md)   
 [Dynamic Language Runtime Overview](assetId:///f769a271-8aff-4bea-bfab-6160217ce23d)   
 [Programming Concepts (Visual Basic)](../vs140/programming-concepts--visual-basic-.md)