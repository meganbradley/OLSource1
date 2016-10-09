---
title: "Indexers (C# Programming Guide)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "cs.indexers"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "indexers [C#]"
  - "C# language, indexers"
ms.assetid: 022cd27d-d5e0-4cfe-8b97-dc018cc3355d
caps.latest.revision: 29
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
# Indexers (C# Programming Guide)
Indexers allow instances of a class or struct to be indexed just like arrays. Indexers resemble [properties](../VS_csharp/properties--csharp-programming-guide-.md) except that their accessors take parameters.  
  
 In the following example, a generic class is defined and provided with simple [get](../VS_csharp/get--csharp-reference-.md) and [set](../VS_csharp/set--csharp-reference-.md) accessor methods as a means of assigning and retrieving values. The `Program` class creates an instance of this class for storing strings.  
  
 [!code[csProgGuideIndexers#9](../VS_csharp/codesnippet/CSharp/indexers--csharp-programming-guide-_1.cs)]  
  
> [!NOTE]
>  For more examples, see [Related Sections](../VS_csharp/indexers--csharp-programming-guide-.md#BKMK_RelatedSections).  
  
## Expression Body Definitions  
 It is common to have indexers that simply return immediately with the result of an expression.  There is a syntax shortcut for defining these indexers using `=>`:  
  
```c#  
public Customer this[long id] => store.LookupCustomer(id);  
```  
  
 The indexer must be read only, and you do not use the `get` accessor keyword.  
  
## Indexers Overview  
  
-   Indexers enable objects to be indexed in a similar manner to arrays.  
  
-   A `get` accessor returns a value. A `set` accessor assigns a value.  
  
-   The [this](../VS_csharp/this--csharp-reference-.md) keyword is used to define the indexers.  
  
-   The [value](../VS_csharp/value--csharp-reference-.md) keyword is used to define the value being assigned by the `set` indexer.  
  
-   Indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism.  
  
-   Indexers can be overloaded.  
  
-   Indexers can have more than one formal parameter, for example, when accessing a two-dimensional array.  
  
##  <a name="BKMK_RelatedSections"></a> Related Sections  
  
-   [Using Indexers](../VS_csharp/using-indexers--csharp-programming-guide-.md)  
  
-   [Indexers in Interfaces](../VS_csharp/indexers-in-interfaces--csharp-programming-guide-.md)  
  
-   [Comparison Between Properties and Indexers](../VS_csharp/comparison-between-properties-and-indexers--csharp-programming-guide-.md)  
  
-   [Restricting Accessor Accessibility](../VS_csharp/restricting-accessor-accessibility--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Properties](../VS_csharp/properties--csharp-programming-guide-.md)