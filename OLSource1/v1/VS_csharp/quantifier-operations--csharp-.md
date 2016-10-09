---
title: "Quantifier Operations (C#)"
ms.custom: na
ms.date: "10/03/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 84ac2ac2-7a63-4581-bc4c-14e34be1493b
caps.latest.revision: 3
ms.author: "shoag"
manager: "wpickett"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Quantifier Operations (C#)
Quantifier operations return a \<xref:System.Boolean> value that indicates whether some or all of the elements in a sequence satisfy a condition.  
  
 The following illustration depicts two different quantifier operations on two different source sequences. The first operation asks if one or more of the elements are the character 'A', and the result is `true`. The second operation asks if all the elements are the character 'A', and the result is `true`.  
  
 ![LINQ Quantifier Operations](../VS_csharp/media/linq_quantifier.png "LINQ_Quantifier")  
  
 The standard query operator methods that perform quantifier operations are listed in the following section.  
  
## Methods  
  
|Method Name|Description|C# Query Expression Syntax|More Information|  
|-----------------|-----------------|---------------------------------|----------------------|  
|All|Determines whether all the elements in a sequence satisfy a condition.|Not applicable.|\<xref:System.Linq.Enumerable.All*?displayProperty=fullName><br /><br /> \<xref:System.Linq.Queryable.All*?displayProperty=fullName>|  
|Any|Determines whether any elements in a sequence satisfy a condition.|Not applicable.|\<xref:System.Linq.Enumerable.Any*?displayProperty=fullName><br /><br /> \<xref:System.Linq.Queryable.Any*?displayProperty=fullName>|  
|Contains|Determines whether a sequence contains a specified element.|Not applicable.|\<xref:System.Linq.Enumerable.Contains*?displayProperty=fullName><br /><br /> \<xref:System.Linq.Queryable.Contains*?displayProperty=fullName>|  
  
## See Also  
 \<xref:System.Linq>   
 [Standard Query Operators Overview (C#)](../VS_csharp/standard-query-operators-overview--csharp-.md)   
 [How to: Dynamically Specify Predicate Filters at Runtime](../VS_csharp/how-to--dynamically-specify-predicate-filters-at-runtime--csharp-programming-guide-.md)   
 [How to: Query for Sentences that Contain a Specified Set of Words (LINQ) (C#)](../VS_csharp/how-to--query-for-sentences-that-contain-a-specified-set-of-words--linq---csharp-.md)