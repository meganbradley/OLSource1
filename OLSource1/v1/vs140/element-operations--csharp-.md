---
title: "Element Operations (C#)"
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
ms.assetid: 283206c9-3246-4c48-b01a-d9de409a7231
caps.latest.revision: 3
---
# Element Operations (C#)
Element operations return a single, specific element from a sequence.  
  
 The standard query operator methods that perform element operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|ElementAt|Returns the element at a specified index in a collection.|Not applicable.|<xref:System.Linq.Enumerable.ElementAt``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.ElementAt``1?qualifyHint=True>|  
|ElementAtOrDefault|Returns the element at a specified index in a collection or a default value if the index is out of range.|Not applicable.|<xref:System.Linq.Enumerable.ElementAtOrDefault``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.ElementAtOrDefault``1?qualifyHint=True>|  
|First|Returns the first element of a collection, or the first element that satisfies a condition.|Not applicable.|<xref:System.Linq.Enumerable.First``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.First``1?qualifyHint=True>|  
|FirstOrDefault|Returns the first element of a collection, or the first element that satisfies a condition. Returns a default value if no such element exists.|Not applicable.|<xref:System.Linq.Enumerable.FirstOrDefault``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.FirstOrDefault``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.FirstOrDefault``1(System.Linq.IQueryable{``0})?qualifyHint=True>|  
|Last|Returns the last element of a collection, or the last element that satisfies a condition.|Not applicable.|<xref:System.Linq.Enumerable.Last``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Last``1?qualifyHint=True>|  
|LastOrDefault|Returns the last element of a collection, or the last element that satisfies a condition. Returns a default value if no such element exists.|Not applicable.|<xref:System.Linq.Enumerable.LastOrDefault``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.LastOrDefault``1?qualifyHint=True>|  
|Single|Returns the only element of a collection, or the only element that satisfies a condition.|Not applicable.|<xref:System.Linq.Enumerable.Single``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Single``1?qualifyHint=True>|  
|SingleOrDefault|Returns the only element of a collection, or the only element that satisfies a condition. Returns a default value if no such element exists or the collection does not contain exactly one element.|Not applicable.|<xref:System.Linq.Enumerable.SingleOrDefault``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.SingleOrDefault``1?qualifyHint=True>|  
  
## See Also  
 <xref:System.Linq?qualifyHint=False>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [How to: Query for the Largest File or Files in a Directory Tree (LINQ) (C#)](../vs140/how-to--query-for-the-largest-file-or-files-in-a-directory-tree--linq---csharp-.md)