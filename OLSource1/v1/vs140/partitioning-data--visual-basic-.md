---
title: "Partitioning Data (Visual Basic)"
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
ms.assetid: 69c59379-b66e-422c-b324-5b5c07760ef7
caps.latest.revision: 7
---
# Partitioning Data (Visual Basic)
Partitioning in LINQ refers to the operation of dividing an input sequence into two sections, without rearranging the elements, and then returning one of the sections.  
  
 The following illustration shows the results of three different partitioning operations on a sequence of characters. The first operation returns the first three elements in the sequence. The second operation skips the first three elements and returns the remaining elements. The third operation skips the first two elements in the sequence and returns the next three elements.  
  
 ![LINQ Partitioning Operations](../vs140/media/linq_partition.png "LINQ_Partition")  
  
 The standard query operator methods that partition sequences are listed in the following section.  
  
## Operators  
  
|Operator Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-------------------|-----------------|------------------------------------------|----------------------|  
|Skip|Skips elements up to a specified position in a sequence.|<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.Skip*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Skip*?displayProperty=fullName>|  
|SkipWhile|Skips elements based on a predicate function until an element does not satisfy the condition.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.SkipWhile*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.SkipWhile*?displayProperty=fullName>|  
|Take|Takes elements up to a specified position in a sequence.|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.Take*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Take*?displayProperty=fullName>|  
|TakeWhile|Takes elements based on a predicate function until an element does not satisfy the condition.|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.TakeWhile*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.TakeWhile*?displayProperty=fullName>|  
  
## Query Expression Syntax Examples  
  
### Skip  
 The following code example uses the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to skip over the first four strings in an array of strings before returning the remaining strings in the array.  
  
 [!code[CsLINQPartitioning#1](../vs140/codesnippet/VisualBasic/partitioning-data--visual-basic-_1.vb)]  
  
### SkipWhile  
 The following code example uses the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to skip over the strings in an array while the first letter of the string is "a". The remaining strings in the array are returned.  
  
 [!code[CsLINQPartitioning#2](../vs140/codesnippet/VisualBasic/partitioning-data--visual-basic-_2.vb)]  
  
### Take  
 The following code example uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to return the first two strings in an array of strings.  
  
 [!code[CsLINQPartitioning#3](../vs140/codesnippet/VisualBasic/partitioning-data--visual-basic-_3.vb)]  
  
### TakeWhile  
 The following code example uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause in [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to return strings from an array while the length of the string is five or less.  
  
 [!code[CsLINQPartitioning#4](../vs140/codesnippet/VisualBasic/partitioning-data--visual-basic-_4.vb)]  
  
## See Also  
 \<xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Skip Clause (Visual Basic)](../vs140/skip-clause--visual-basic-.md)   
 [Skip While Clause (Visual Basic)](../vs140/skip-while-clause--visual-basic-.md)   
 [Take Clause (Visual Basic)](../vs140/take-clause--visual-basic-.md)   
 [Take While Clause (Visual Basic)](../vs140/take-while-clause--visual-basic-.md)