---
title: "How to: Use Expression Trees to Build Dynamic Queries (Visual Basic)"
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
ms.assetid: 16278787-7532-4b65-98b2-7a412406c4ee
caps.latest.revision: 3
---
# How to: Use Expression Trees to Build Dynamic Queries (Visual Basic)
In LINQ, expression trees are used to represent structured queries that target sources of data that implement <xref:System.Linq.IQueryable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*> interface for querying relational data stores. The Visual Basic compiler compiles queries that target such data sources into code that builds an expression tree at runtime. The query provider can then traverse the expression tree data structure and translate it into a query language appropriate for the data source.  
  
 Expression trees are also used in LINQ to represent lambda expressions that are assigned to variables of type <xref:System.Linq.Expressions.Expression<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>companies.Where(Function(company) company.ToLower() = "coho winery" OrElse company.Length > 16).OrderBy(Function(company) company)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Queryable.Where<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Main<CodeContentPlaceHolder>8\</CodeContentPlaceHolder> procedure.  
  
## See Also  
 [Expression Trees (Visual Basic)](../vs140/expression-trees--visual-basic-.md)   
 [How to: Execute Expression Trees (Visual Basic)](../vs140/how-to--execute-expression-trees--visual-basic-.md)