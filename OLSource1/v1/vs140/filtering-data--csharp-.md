---
title: "Filtering Data (C#)"
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
ms.assetid: fbaece0d-0f23-47f7-89c5-f3ea8db692b6
caps.latest.revision: 8
---
# Filtering Data (C#)
Filtering refers to the operation of restricting the result set to contain only those elements that satisfy a specified condition. It is also known as selection.  
  
 The following illustration shows the results of filtering a sequence of characters. The predicate for the filtering operation specifies that the character must be 'A'.  
  
 ![LINQ Filtering Operation](../vs140/media/linq_filter.png "LINQ_Filter")  
  
 The standard query operator methods that perform selection are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|OfType|Selects values, depending on their ability to be cast to a specified type.|Not applicable.|\<xref:System.Linq.Enumerable.OfType*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.OfType*?displayProperty=fullName>|  
|Where|Selects values that are based on a predicate function.|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|\<xref:System.Linq.Enumerable.Where*?displayProperty=fullName>\<br />\<br /> \<xref:System.Linq.Queryable.Where*?displayProperty=fullName>|  
  
## Query Expression Syntax Example  
 The following example uses the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> clause to filter from an array those strings that have a specific length.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## See Also  
 \<xref:System.Linq*>   
 [Standard Query Operators Overview (C#)](../vs140/standard-query-operators-overview--csharp-.md)   
 [where clause (C# Reference)](../vs140/where-clause--csharp-reference-.md)   
 [How to: Dynamically Specify Predicate Filters at Runtime (C# Programming Guide)](../vs140/how-to--dynamically-specify-predicate-filters-at-runtime--csharp-programming-guide-.md)   
 [How to: Query An Assembly's Metadata with Reflection (LINQ) (C#)](../vs140/how-to--query-an-assembly-s-metadata-with-reflection--linq---csharp-.md)   
 [How to: Query for Files with a Specified Attribute or Name (C#)](../vs140/how-to--query-for-files-with-a-specified-attribute-or-name--csharp-.md)   
 [How to: Sort or Filter Text Data by Any Word or Field (LINQ) (C#)](../vs140/how-to--sort-or-filter-text-data-by-any-word-or-field--linq---csharp-.md)