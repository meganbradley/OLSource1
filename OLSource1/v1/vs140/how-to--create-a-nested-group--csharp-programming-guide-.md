---
title: "How to: Create a Nested Group (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
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
  - "queries [LINQ in C#], nested groups"
  - "grouping groups in LINQ queries"
  - "grouping LINQ queries"
  - "groups [LINQ in C#], nested"
  - "nested queries [C#]"
  - "query expressions [LINQ in C#], nested groups"
ms.assetid: f48c64af-6d4e-473c-ab27-02f78b5ec2b9
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Create a Nested Group (C# Programming Guide)
The following example shows how to create nested groups in a [!INCLUDE[vbteclinq](../vs140/includes/vbteclinq_md.md)] query expression. Each group that is created according to student year or grade level is then further subdivided into groups based on the individuals' names.  
  
## Example  
 [!code[csProgGuideLINQ#24](../vs140/codesnippet/CSharp/how-to--create-a-nested-group--csharp-programming-guide-_1.cs)]  
  
 Note that three nested `foreach` loops are required to iterate over the inner elements of a nested group.  
  
## Compiling the Code  
 This example contains references to objects that are defined in the sample application in [How to: Query a Collections of Objects](../vs140/how-to--query-a-collection-of-objects--csharp-programming-guide-.md). To compile and run this method, paste it into the `StudentClass` class in that application and add a call to it from the `Main` method.  
  
 When you adapt this method to your own application, remember that LINQ requires version 3.5 of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], and the project must contain a reference to System.Core.dll and a using directive for System.Linq. LINQ to SQL, LINQ to XML and LINQ to DataSet types require additional usings and references. For more information, see [How To: Create a LINQ Project](../Topic/How%20to:%20Create%20a%20LINQ%20Project_deleted.md).  
  
## See Also  
 [LINQ Query Expressions (C# Programming Guide)](../vs140/linq-query-expressions--csharp-programming-guide-.md)