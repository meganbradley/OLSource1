---
title: "How to: Perform Grouped Joins (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
  - "group joins [LINQ in C#]"
  - "joins [C#], group"
  - "query expressions [LINQ in C#], joins"
  - "queries [LINQ in C#], joins"
ms.assetid: 31b654c0-77ac-43fa-be11-aa38e14cae2d
caps.latest.revision: 23
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Perform Grouped Joins (C# Programming Guide)
The group join is useful for producing hierarchical data structures. It pairs each element from the first collection with a set of correlated elements from the second collection.  
  
 For example, a class or a relational database table named Student might contain two fields: Id and Name. A second class or relational database table named Course might contain two fields: StudentId and CourseTitle. A group join of these two data sources, based on matching Student.Id and Course.StudentId, would group each Student with a collection of Course objects (which might be empty).  
  
> [!NOTE]
>  Each element of the first collection appears in the result set of a group join regardless of whether correlated elements are found in the second collection. In the case where no correlated elements are found, the sequence of correlated elements for that element is empty. The result selector therefore has access to every element of the first collection. This differs from the result selector in a non-group join, which cannot access elements from the first collection that have no match in the second collection.  
  
 The first example in this topic shows you how to perform a group join. The second example shows you how to use a group join to create XML elements.  
  
## Example  
  
### Group Join Example  
 The following example performs a group join of objects of type `Person` and `Pet` based on the `Person` matching the `Pet.Owner` property. Unlike a non-group join, which would produce a pair of elements for each match, the group join produces only one resulting object for each element of the first collection, which in this example is a `Person` object. The corresponding elements from the second collection, which in this example are `Pet` objects, are grouped into a collection. Finally, the result selector function creates an anonymous type for each match that consists of `Person.FirstName` and a collection of `Pet` objects.  
  
 [!code[CsLINQProgJoining#5](../VS_csharp/codesnippet/CSharp/how-to--perform-grouped-joins--csharp-programming-guide-_1.cs)]  
  
## Example  
  
### Group Join to Create XML Example  
 Group joins are ideal for creating XML by using [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)]. The following example is similar to the previous example except that instead of creating anonymous types, the result selector function creates XML elements that represent the joined objects. For more information about [!INCLUDE[sqltecxlinq](../VS_csharp/includes/sqltecxlinq_md.md)], see [LINQ to XML](../Topic/LINQ%20to%20XML.md).  
  
 [!code[CsLINQProgJoining#6](../VS_csharp/codesnippet/CSharp/how-to--perform-grouped-joins--csharp-programming-guide-_2.cs)]  
  
## Compiling the Code  
  
-   Create a new **Console Application** project in [!INCLUDE[vs_current_short](../VS_csharp/includes/vs_current_short_md.md)].  
  
-   Add a reference to System.Core.dll and to System.Xml.Linq.dll if they are not already referenced.  
  
-   Include the \<xref:System.Linq> and \<xref:System.Xml.Linq> namespaces.  
  
-   Copy and paste the code from the example into the program.cs file, below the `Main` method. Add a line of code to the `Main` method to call the method you pasted in.  
  
-   Run the program.  
  
## See Also  
 \<xref:System.Linq.Enumerable.Join*>   
 \<xref:System.Linq.Enumerable.GroupJoin*>   
 [Join Operations](../Topic/Join%20Operations.md)   
 [How to: Perform Inner Joins](../VS_csharp/how-to--perform-inner-joins--csharp-programming-guide-.md)   
 [How to: Perform Left Outer Joins](../VS_csharp/how-to--perform-left-outer-joins--csharp-programming-guide-.md)   
 [LINQ to XML](../Topic/LINQ%20to%20XML.md)   
 [Anonymous Types](../VS_csharp/anonymous-types--csharp-programming-guide-.md)   
 [Anonymous Types](../Topic/Anonymous%20Types%20\(Visual%20Basic\).md)