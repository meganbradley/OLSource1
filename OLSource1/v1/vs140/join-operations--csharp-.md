---
title: "Join Operations (C#)"
ms.custom: na
ms.date: 09/22/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - CSharp
ms.assetid: 5105e0da-1267-4c00-837a-f0e9602279b8
caps.latest.revision: 7
---
# Join Operations (C#)
A *join* of two data sources is the association of objects in one data source with objects that share a common attribute in another data source.  
  
 Joining is an important operation in queries that target data sources whose relationships to each other cannot be followed directly. In object-oriented programming, this could mean a correlation between objects that is not modeled, such as the backwards direction of a one-way relationship. An example of a one-way relationship is a Customer class that has a property of type City, but the City class does not have a property that is a collection of Customer objects. If you have a list of City objects and you want to find all the customers in each city, you could use a join operation to find them.  
  
 The join methods provided in the LINQ framework are <xref:System.Linq.Enumerable.Join``4?qualifyHint=False> and <xref:System.Linq.Enumerable.GroupJoin``4?qualifyHint=False>. These methods perform equijoins, or joins that match two data sources based on equality of their keys. (For comparison, Transact-SQL supports join operators other than 'equals', for example the 'less than' operator.) In relational database terms, <xref:System.Linq.Enumerable.Join``4?qualifyHint=False> implements an inner join, a type of join in which only those objects that have a match in the other data set are returned. The <xref:System.Linq.Enumerable.GroupJoin``4?qualifyHint=False> method has no direct equivalent in relational database terms, but it implements a superset of inner joins and left outer joins. A left outer join is a join that returns each element of the first (left) data source, even if it has no correlated elements in the other data source.  
  
 The following illustration shows a conceptual view of two sets and the elements within those sets that are included in either an inner join or a left outer join.  
  
 ![Two overlapping circles showing inner&#47;outer.](../vs140/media/joincircles.png "JoinCircles")  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|Join|Joins two sequences based on key selector functions and extracts pairs of values.|`join … in … on … equals …`|<xref:System.Linq.Enumerable.Join``4?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Join``4?qualifyHint=True>|  
|GroupJoin|Joins two sequences based on key selector functions and groups the resulting matches for each element.|`join … in … on … equals … into …`|<xref:System.Linq.Enumerable.GroupJoin``4?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.GroupJoin``4?qualifyHint=True>|  
  
## See Also  
 <xref:System.Linq?qualifyHint=False>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [Anonymous Types (C# Programming Guide)](../vs140/anonymous-types--csharp-programming-guide-.md)   
 [How to: Formulate Joins and Cross-Product Queries (LINQ to SQL)](assetId:///d8072ede-0521-4670-9bec-1778ceeb875b)   
 [join clause (C# Reference)](../vs140/join-clause--csharp-reference-.md)   
 [How to: Join By Using Composite Keys (C# Programming Guide)](../vs140/how-to--join-by-using-composite-keys--csharp-programming-guide-.md)   
 [How to: Join Content from Dissimilar Files (LINQ) (C#)](../vs140/how-to--join-content-from-dissimilar-files--linq---csharp-.md)   
 [How to: Order the Results of a Join Clause (C# Programming Guide)](../vs140/how-to--order-the-results-of-a-join-clause--csharp-programming-guide-.md)   
 [How to: Perform Custom Join Operations (C# Programming Guide)](../vs140/how-to--perform-custom-join-operations--csharp-programming-guide-.md)   
 [How to: Perform Grouped Joins (C# Programming Guide)](../vs140/how-to--perform-grouped-joins--csharp-programming-guide-.md)   
 [How to: Perform Inner Joins (C# Programming Guide)](../vs140/how-to--perform-inner-joins--csharp-programming-guide-.md)   
 [How to: Perform Left Outer Joins (C# Programming Guide)](../vs140/how-to--perform-left-outer-joins--csharp-programming-guide-.md)   
 [How to: Populate Object Collections from Multiple Sources (LINQ) (C#)](../vs140/how-to--populate-object-collections-from-multiple-sources--linq---csharp-.md)