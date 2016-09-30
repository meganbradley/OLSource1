---
title: "Grouping Data (Visual Basic)"
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
ms.assetid: 8f3a0871-6958-4aef-8f6f-493e189fd57d
caps.latest.revision: 5
---
# Grouping Data (Visual Basic)
Grouping refers to the operation of putting data into groups so that the elements in each group share a common attribute.  
  
 The following illustration shows the results of grouping a sequence of characters. The key for each group is the character.  
  
 ![LINQ Grouping Operations](../vs140/media/linq_group.png "LINQ_Group")  
  
 The standard query operator methods that group data elements are listed in the following section.  
  
## Methods  
  
|Method Name|Description|Visual Basic Query Expression Syntax|More Information|  
|-----------------|-----------------|------------------------------------------|----------------------|  
|GroupBy|Groups elements that share a common attribute. Each group is represented by an <xref:System.Linq.IGrouping<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>Group … By … Into …<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>2*> (a one-to-many dictionary) based on a key selector function.|Not applicable.|\<xref:System.Linq.Enumerable.ToLookup*?displayProperty=fullName>|  
  
## Query Expression Syntax Example  
 The following code example uses the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> clause to group integers in a list according to whether they are even or odd.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Linq*>   
 [Standard Query Operators Overview (Visual Basic)](../vs140/standard-query-operators-overview--visual-basic-.md)   
 [Group By Clause (Visual Basic)](../vs140/group-by-clause--visual-basic-.md)   
 [How to: Group Files by Extension (LINQ) (Visual Basic)](../vs140/how-to--group-files-by-extension--linq---visual-basic-.md)   
 [How to: Split a File Into Many Files by Using Groups (LINQ) (Visual Basic)](../vs140/how-to--split-a-file-into-many-files-by-using-groups--linq---visual-basic-.md)