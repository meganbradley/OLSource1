---
title: "Set Operations (Visual Basic)"
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
ms.assetid: 2b06e822-e030-438f-9db7-ee402bd3a706
caps.latest.revision: 5
---
# Set Operations (Visual Basic)
Set operations in LINQ refer to query operations that produce a result set that is based on the presence or absence of equivalent elements within the same or separate collections (or sets).  
  
 The standard query operator methods that perform set operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|Distinct|Removes duplicate values from a collection.|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.Distinct*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Distinct*?displayProperty=fullName>|  
|Except|Returns the set difference, which means the elements of one collection that do not appear in a second collection.|Not applicable.|\<xref:System.Linq.Enumerable.Except*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Except*?displayProperty=fullName>|  
|Intersect|Returns the set intersection, which means elements that appear in each of two collections.|Not applicable.|\<xref:System.Linq.Enumerable.Intersect*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Intersect*?displayProperty=fullName>|  
|Union|Returns the set union, which means unique elements that appear in either of two collections.|Not applicable.|\<xref:System.Linq.Enumerable.Union*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Union*?displayProperty=fullName>|  
  
## Comparison of Set Operations  
  
### Distinct  
 The following illustration depicts the behavior of the \<xref:System.Linq.Enumerable.Distinct*?displayProperty=fullName> method on a sequence of characters. The returned sequence contains the unique elements from the input sequence.  
  
 ![Graphic showing the behavior of Distinct&#40;&#41;.](../vs140/media/distinct.png "Distinct")  
  
### Except  
 The following illustration depicts the behavior of \<xref:System.Linq.Enumerable.Except*?displayProperty=fullName>. The returned sequence contains only the elements from the first input sequence that are not in the second input sequence.  
  
 ![Graphic showing the action of Except&#40;&#41;.](../vs140/media/except.png "Except")  
  
### Intersect  
 The following illustration depicts the behavior of \<xref:System.Linq.Enumerable.Intersect*?displayProperty=fullName>. The returned sequence contains the elements that are common to both of the input sequences.  
  
 ![Graphic showing the intersection of two sequences.](../vs140/media/intersect.png "Intersect")  
  
### Union  
 The following illustration depicts a union operation on two sequences of characters. The returned sequence contains the unique elements from both input sequences.  
  
 ![Graphic showing the union of two sequences.](../vs140/media/union.png "Union")  
  
## Query Expression Syntax Example  
 The following example uses the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause in a LINQ query to return the unique numbers from a list of integers.  
  
 [!code[CsLINQSetOps#1](../vs140/codesnippet/VisualBasic/set-operations--visual-basic-_1.vb)]  
  
## See Also  
 \<xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Distinct Clause (Visual Basic)](../vs140/distinct-clause--visual-basic-.md)   
 [How to: Combine and Compare String Collections (LINQ) (Visual Basic)](../vs140/how-to--combine-and-compare-string-collections--linq---visual-basic-.md)   
 [How to: Find the Set Difference Between Two Lists (LINQ) (Visual Basic)](../vs140/how-to--find-the-set-difference-between-two-lists--linq---visual-basic-.md)