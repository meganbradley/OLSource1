---
title: "Comparison Between Properties and Indexers (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 14
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Comparison Between Properties and Indexers (C# Programming Guide)
Indexers are like properties. Except for the differences shown in the following table, all the rules that are defined for property accessors apply to indexer accessors also.  
  
|Property|Indexer|  
|--------------|-------------|  
|Allows methods to be called as if they were public data members.|Allows elements of an internal collection of an object to be accessed by using array notation on the object itself.|  
|Accessed through a simple name.|Accessed through an index.|  
|Can be a static or an instance member.|Must be an instance member.|  
|A [get](../VS_csharp/get--csharp-reference-.md) accessor of a property has no parameters.|A `get` accessor of an indexer has the same formal parameter list as the indexer.|  
|A [set](../VS_csharp/set--csharp-reference-.md) accessor of a property contains the implicit `value` parameter.|A `set` accessor of an indexer has the same formal parameter list as the indexer, and also to the [value](../VS_csharp/value--csharp-reference-.md) parameter.|  
|Supports shortened syntax with [Auto-Implemented Properties](../VS_csharp/auto-implemented-properties--csharp-programming-guide-.md).|Does not support shortened syntax.|  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Indexers](../VS_csharp/indexers--csharp-programming-guide-.md)   
 [Properties](../VS_csharp/properties--csharp-programming-guide-.md)