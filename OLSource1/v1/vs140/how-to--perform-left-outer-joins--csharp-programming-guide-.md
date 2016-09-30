---
title: "How to: Perform Left Outer Joins (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "left outer joins [LINQ in C#]"
  - "joins [C#], left outer"
  - "query expressions [LINQ in C#], joins"
  - "queries [LINQ in C#], joins"
ms.assetid: 18e32be8-93db-4d30-8dea-ec6596e18f43
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Perform Left Outer Joins (C# Programming Guide)
A left outer join is a join in which each element of the first collection is returned, regardless of whether it has any correlated elements in the second collection. You can use [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] to perform a left outer join by calling the \<xref:System.Linq.Enumerable.DefaultIfEmpty*> method on the results of a group join.  
  
## Example  
 The following example demonstrates how to use the \<xref:System.Linq.Enumerable.DefaultIfEmpty*> method on the results of a group join to perform a left outer join.  
  
 The first step in producing a left outer join of two collections is to perform an inner join by using a group join. (See [How to: Perform an Inner Join](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md) for an explanation of this process.) In this example, the list of <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> objects is inner-joined to the list of <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> objects based on a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that matches <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The second step is to include each element of the first (left) collection in the result set even if that element has no matches in the right collection. This is accomplished by calling \<xref:System.Linq.Enumerable.DefaultIfEmpty*> on each sequence of matching elements from the group join. In this example, \<xref:System.Linq.Enumerable.DefaultIfEmpty*> is called on each sequence of matching <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> objects. The method returns a collection that contains a single, default value if the sequence of matching <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> objects is empty for any <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object, thereby ensuring that each <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object is represented in the result collection.  
  
> [!NOTE]
>  The default value for a reference type is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>; therefore, the example checks for a null reference before accessing each element of each <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> collection.  
  
 [!code[CsLINQProgJoining#7](../vs140/codesnippet/CSharp/how-to--perform-left-outer-joins--csharp-programming-guide-_1.cs)]  
  
## Compiling the Code  
  
-   Create a new Console Application project in [!INCLUDE[vs_current_short](../vs140/includes/vs_current_short_md.md)].  
  
-   Add a reference to System.Core.dll if it is not already referenced.  
  
-   Include the \<xref:System.Linq*> namespace.  
  
-   Copy and paste the code from the example into the program.cs file, below the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> class. Add a line of code to the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method to call the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method.  
  
-   Run the program.  
  
## See Also  
 \<xref:System.Linq.Enumerable.Join*>   
 \<xref:System.Linq.Enumerable.GroupJoin*>   
 [Joining](../vs140/join-operations.md)   
 [How to: Perform an Inner Join](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md)   
 [How to: Perform a Grouped Join](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [Anonymous Types](../vs140/anonymous-types--visual-basic-.md)