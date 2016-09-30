---
title: "Indexers (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
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
caps.latest.revision: 33
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Indexers (C# Programming Guide)
Indexers allow instances of a class or struct to be indexed just like arrays. Indexers resemble [properties](../vs140/properties--csharp-programming-guide-.md) except that their accessors take parameters.  
  
 In the following example, a generic class is defined and provided with simple [get](../vs140/get--csharp-reference-.md) and [set](../vs140/set--csharp-reference-.md) accessor methods as a means of assigning and retrieving values. The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class creates an instance of this class for storing strings.  
  
 [!code[csProgGuideIndexers#9](../vs140/codesnippet/CSharp/indexers--csharp-programming-guide-_1.cs)]  
  
> [!NOTE]
>  For more examples, see [Related Sections](../vs140/indexers--csharp-programming-guide-.md#BKMK_RelatedSections).  
  
## Expression Body Definitions  
 It is common to have indexers that simply return immediately with the result of an expression.  There is a syntax shortcut for defining these indexers using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The indexer must be read only, and you do not use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> accessor keyword.  
  
## Indexers Overview  
  
-   Indexers enable objects to be indexed in a similar manner to arrays.  
  
-   A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> accessor returns a value. A <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> accessor assigns a value.  
  
-   The [this](../vs140/this--csharp-reference-.md) keyword is used to define the indexers.  
  
-   The [value](../vs140/value--csharp-reference-.md) keyword is used to define the value being assigned by the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> indexer.  
  
-   Indexers do not have to be indexed by an integer value; it is up to you how to define the specific look-up mechanism.  
  
-   Indexers can be overloaded.  
  
-   Indexers can have more than one formal parameter, for example, when accessing a two-dimensional array.  
  
##  \<a name="BKMK_RelatedSections">\</a> Related Sections  
  
-   [Using Indexers](../vs140/using-indexers--csharp-programming-guide-.md)  
  
-   [Interface Indexers](../vs140/indexers-in-interfaces--csharp-programming-guide-.md)  
  
-   [Comparison Between Properties and Indexers](../vs140/comparison-between-properties-and-indexers--csharp-programming-guide-.md)  
  
-   [Asymmetric Accessor Accessibility (C# Programmer's Reference)](../vs140/restricting-accessor-accessibility--csharp-programming-guide-.md)  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Properties](../vs140/properties--csharp-programming-guide-.md)