---
title: "Reference Types (C# Reference)"
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
  - "cs.referencetypes"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "reference types [C#]"
  - "C# language, reference types"
  - "types [C#], reference types"
ms.assetid: 801cf030-6e2d-4a0d-9daf-1431b0c31f47
caps.latest.revision: 15
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
# Reference Types (C# Reference)
There are two kinds of types in C#: reference types and value types. Variables of reference types store references to their data (objects), while variables of value types directly contain their data. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in the case of ref and out parameter variables, see [ref](../VS_csharp/ref--csharp-reference-.md) and [out parameter modifier](../VS_csharp/out-parameter-modifier--csharp-reference-.md)).  
  
 The following keywords are used to declare reference types:  
  
-   [class](../VS_csharp/class--csharp-reference-.md)  
  
-   [interface](../VS_csharp/interface--csharp-reference-.md)  
  
-   [delegate](../VS_csharp/delegate--csharp-reference-.md)  
  
 C# also provides the following built-in reference types:  
  
-   [dynamic](../VS_csharp/dynamic--csharp-reference-.md)  
  
-   [object](../VS_csharp/object--csharp-reference-.md)  
  
-   [string](../VS_csharp/string--csharp-reference-.md)  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Types](../VS_csharp/types--csharp-reference-.md)   
 [Value Types](../VS_csharp/value-types--csharp-reference-.md)