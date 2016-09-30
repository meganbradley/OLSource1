---
title: "How to: Query an ArrayList with LINQ (Visual Basic)"
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
ms.assetid: 176358a9-d765-4b57-9557-7feb4428138d
caps.latest.revision: 7
---
# How to: Query an ArrayList with LINQ (Visual Basic)
When using LINQ to query non-generic \<xref:System.Collections.IEnumerable*> collections such as \<xref:System.Collections.ArrayList*>, you must explicitly declare the type of the range variable to reflect the specific type of the objects in the collection. For example, if you have an \<xref:System.Collections.ArrayList*> of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> objects, your [From Clause (Visual Basic)](../vs140/from-clause--visual-basic-.md) should look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 By specifying the type of the range variable, you are casting each item in the \<xref:System.Collections.ArrayList*> to a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The use of an explicitly typed range variable in a query expression is equivalent to calling the \<xref:System.Linq.Enumerable.Cast*> method. \<xref:System.Linq.Enumerable.Cast*> throws an exception if the specified cast cannot be performed. \<xref:System.Linq.Enumerable.Cast*> and \<xref:System.Linq.Enumerable.OfType*> are the two Standard Query Operator methods that operate on non-generic \<xref:System.Collections.IEnumerable*> types. In Visual Basic, you must explicitly call the \<xref:System.Linq.Enumerable.Cast*> method on the data source to ensure a specific range variable type. For more information, see[Type Relationships in Query Operations (Visual Basic)](../vs140/type-relationships-in-query-operations--visual-basic-.md).  
  
## Example  
 The following example shows a simple query over an \<xref:System.Collections.ArrayList*>. Note that this example uses object initializers when the code calls the \<xref:System.Collections.ArrayList.Add*> method, but this is not a requirement.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [LINQ to Objects (Visual Basic)](../vs140/linq-to-objects--visual-basic-.md)