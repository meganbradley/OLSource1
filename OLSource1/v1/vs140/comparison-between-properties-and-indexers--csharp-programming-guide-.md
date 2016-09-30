---
title: "Comparison Between Properties and Indexers (C# Programming Guide)"
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
  - "properties [C#], vs. indexers"
  - "indexers [C#], vs. properties"
ms.assetid: 3358a89f-44a0-4a4d-bf8c-07237a90af39
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Comparison Between Properties and Indexers (C# Programming Guide)
Indexers are like properties. Except for the differences shown in the following table, all the rules that are defined for property accessors apply to indexer accessors also.  
  
|Property|Indexer|  
|--------------|-------------|  
|Allows methods to be called as if they were public data members.|Allows elements of an internal collection of an object to be accessed by using array notation on the object itself.|  
|Accessed through a simple name.|Accessed through an index.|  
|Can be a static or an instance member.|Must be an instance member.|  
|A [get](../vs140/get--csharp-reference-.md) accessor of a property has no parameters.|A <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> accessor of an indexer has the same formal parameter list as the indexer.|  
|A [set](../vs140/set--csharp-reference-.md) accessor of a property contains the implicit <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> parameter.|A <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> accessor of an indexer has the same formal parameter list as the indexer, and also to the [value](../vs140/value--csharp-reference-.md) parameter.|  
|Supports shortened syntax with [Auto-Implemented Properties (C# Programming Guide)](../vs140/auto-implemented-properties--csharp-programming-guide-.md).|Does not support shortened syntax.|  
  
## See Also  
 [C# Programming](../vs140/csharp-programming-guide.md)   
 [Indexers](../vs140/indexers--csharp-programming-guide-.md)   
 [Properties](../vs140/properties--csharp-programming-guide-.md)