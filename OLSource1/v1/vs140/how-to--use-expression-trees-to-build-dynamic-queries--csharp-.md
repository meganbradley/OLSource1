---
title: "How to: Use Expression Trees to Build Dynamic Queries (C#)"
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
ms.assetid: 52cd44dd-a3ec-441e-b93a-4eca388119c7
caps.latest.revision: 7
---
# How to: Use Expression Trees to Build Dynamic Queries (C#)
In LINQ, expression trees are used to represent structured queries that target sources of data that implement <xref:System.Linq.IQueryable<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>1*> interface for querying relational data stores. The C# compiler compiles queries that target such data sources into code that builds an expression tree at runtime. The query provider can then traverse the expression tree data structure and translate it into a query language appropriate for the data source.  
  
 Expression trees are also used in LINQ to represent lambda expressions that are assigned to variables of type <xref:System.Linq.Expressions.Expression<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>companies.Where(company => (company.ToLower() == "coho winery" || company.Length > 16)).OrderBy(company => company)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>IQueryable<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>Queryable.Where<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>Main` method.  
  
## See Also  
 [Expression Trees (C#)](../vs140/expression-trees--csharp-.md)   
 [How to: Execute Expression Trees (C#)](../vs140/how-to--execute-expression-trees--csharp-.md)   
 [How To: Dynamically Specify Predicate Filters at Runtime](../vs140/how-to--dynamically-specify-predicate-filters-at-runtime--csharp-programming-guide-.md)