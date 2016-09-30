---
title: "How to: Modify Expression Trees (C#)"
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
ms.assetid: 9b0cd8c2-457e-4833-9e36-31e79545f442
caps.latest.revision: 7
---
# How to: Modify Expression Trees (C#)
This topic shows you how to modify an expression tree. Expression trees are immutable, which means that they cannot be modified directly. To change an expression tree, you must create a copy of an existing expression tree and when you create the copy, make the required changes. You can use the \<xref:System.Linq.Expressions.ExpressionVisitor*> class to traverse an existing expression tree and to copy each node that it visits.  
  
### To modify an expression tree  
  
1.  Create a new **Console Application** project.  
  
2.  Add a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive to the file for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> namespace.  
  
3.  Add the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> class to your project.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     This class inherits the \<xref:System.Linq.Expressions.ExpressionVisitor*> class and is specialized to modify expressions that represent conditional <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> operations. It changes these operations from a conditional <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to a conditional <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. To do this, the class overrides the \<xref:System.Linq.Expressions.ExpressionVisitor.VisitBinary*> method of the base type, because conditional <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> expressions are represented as binary expressions. In the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method, if the expression that is passed to it represents a conditional <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> operation, the code constructs a new expression that contains the conditional <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator instead of the conditional <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> operator. If the expression that is passed to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> does not represent a conditional <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> operation, the method defers to the base class implementation. The base class methods construct nodes that are like the expression trees that are passed in, but the nodes have their sub trees replaced with the expression trees that are produced recursively by the visitor.  
  
4.  Add a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive to the file for the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> namespace.  
  
5.  Add code to the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> method in the Program.cs file to create an expression tree and pass it to the method that will modify it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     The code creates an expression that contains a conditional <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> operation. It then creates an instance of the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class and passes the expression to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> method of this class. Both the original and the modified expression trees are outputted to show the change.  
  
6.  Compile and run the application.  
  
## See Also  
 [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md)   
 [Expression Trees (C#)](../vs140/expression-trees--csharp-.md)