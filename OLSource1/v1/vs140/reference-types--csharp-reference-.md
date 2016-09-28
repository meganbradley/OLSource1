---
title: "Reference Types (C# Reference)"
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
  - "cs.referencetypes"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "reference types [C#]"
  - "C# language, reference types"
  - "types [C#], reference types"
ms.assetid: 801cf030-6e2d-4a0d-9daf-1431b0c31f47
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference Types (C# Reference)
There are two kinds of types in C#: reference types and value types. Variables of reference types store references to their data (objects), while variables of value types directly contain their data. With reference types, two variables can reference the same object; therefore, operations on one variable can affect the object referenced by the other variable. With value types, each variable has its own copy of the data, and it is not possible for operations on one variable to affect the other (except in the case of ref and out parameter variables, see [](../vs140/ref--csharp-reference-.md "ref (C# Reference)") and [](../vs140/out-parameter-modifier--csharp-reference-.md "out parameter modifier (C# Reference)")).  
  
 The following keywords are used to declare reference types:  
  
-   [class](../vs140/class--csharp-reference-.md)  
  
-   [interface](../vs140/interface--csharp-reference-.md)  
  
-   [delegate](../vs140/delegate--csharp-reference-.md)  
  
 C# also provides the following built-in reference types:  
  
-   [dynamic](../vs140/dynamic--csharp-reference-.md)  
  
-   [object](../vs140/object--csharp-reference-.md)  
  
-   [string](../vs140/string--csharp-reference-.md)  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [Types](../vs140/types--csharp-reference-.md)   
 [Value Types](../vs140/value-types--csharp-reference-.md)