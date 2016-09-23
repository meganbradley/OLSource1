---
title: "Set Operations (C#)"
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
ms.assetid: 7c589367-ef8f-4161-9050-642c47e6bf63
caps.latest.revision: 7
---
# Set Operations (C#)
Set operations in LINQ refer to query operations that produce a result set that is based on the presence or absence of equivalent elements within the same or separate collections (or sets).  
  
 The standard query operator methods that perform set operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|Distinct|Removes duplicate values from a collection.|Not applicable.|<xref:System.Linq.Enumerable.Distinct``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Distinct``1?qualifyHint=True>|  
|Except|Returns the set difference, which means the elements of one collection that do not appear in a second collection.|Not applicable.|<xref:System.Linq.Enumerable.Except``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Except``1?qualifyHint=True>|  
|Intersect|Returns the set intersection, which means elements that appear in each of two collections.|Not applicable.|<xref:System.Linq.Enumerable.Intersect``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Intersect``1?qualifyHint=True>|  
|Union|Returns the set union, which means unique elements that appear in either of two collections.|Not applicable.|<xref:System.Linq.Enumerable.Union``1?qualifyHint=True><br /><br /> <xref:System.Linq.Queryable.Union``1?qualifyHint=True>|  
  
## Comparison of Set Operations  
  
### Distinct  
 The following illustration depicts the behavior of the <xref:System.Linq.Enumerable.Distinct``1?qualifyHint=True> method on a sequence of characters. The returned sequence contains the unique elements from the input sequence.  
  
 ![Graphic showing the behavior of Distinct&#40;&#41;.](../vs140/media/distinct.png "Distinct")  
  
### Except  
 The following illustration depicts the behavior of <xref:System.Linq.Enumerable.Except``1?qualifyHint=True>. The returned sequence contains only the elements from the first input sequence that are not in the second input sequence.  
  
 ![Graphic showing the action of Except&#40;&#41;.](../vs140/media/except.png "Except")  
  
### Intersect  
 The following illustration depicts the behavior of <xref:System.Linq.Enumerable.Intersect``1?qualifyHint=True>. The returned sequence contains the elements that are common to both of the input sequences.  
  
 ![Graphic showing the intersection of two sequences.](../vs140/media/intersect.png "Intersect")  
  
### Union  
 The following illustration depicts a union operation on two sequences of characters. The returned sequence contains the unique elements from both input sequences.  
  
 ![Graphic showing the union of two sequences.](../vs140/media/union.png "Union")  
  
## See Also  
 <xref:System.Linq?qualifyHint=False>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [How to: Combine and Compare String Collections (LINQ) (C#)](../vs140/how-to--combine-and-compare-string-collections--linq---csharp-.md)   
 [How to: Find the Set Difference Between Two Lists (LINQ) (C#)](../vs140/how-to--find-the-set-difference-between-two-lists--linq---csharp-.md)