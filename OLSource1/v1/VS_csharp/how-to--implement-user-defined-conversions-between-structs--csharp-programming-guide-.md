---
title: "How to: Implement User-Defined Conversions Between Structs (C# Programming Guide)"
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
  - "user-defined conversions [C#]"
ms.assetid: 97839aef-8fbc-40d5-9769-6b569bc2710b
caps.latest.revision: 11
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
# How to: Implement User-Defined Conversions Between Structs (C# Programming Guide)
This example defines two structs, `RomanNumeral` and `BinaryNumeral`, and demonstrates conversions between them.  
  
## Example  
 [!code[csProgGuideStatements#13](../VS_csharp/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_1.cs)]  
  
## Robust Programming  
  
-   In the previous example, the statement:  
  
     [!code[csProgGuideStatements#14](../VS_csharp/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_2.cs)]  
  
     performs a conversion from a `RomanNumeral` to a `BinaryNumeral`. Because there is no direct conversion from `RomanNumeral` to `BinaryNumeral`, a cast is used to convert from a `RomanNumeral` to an `int`, and another cast to convert from an `int` to a `BinaryNumeral`.  
  
-   Also the statement  
  
     [!code[csProgGuideStatements#15](../VS_csharp/codesnippet/CSharp/how-to--implement-user-defined-conversions-between-structs--csharp-programming-guide-_3.cs)]  
  
     performs a conversion from a `BinaryNumeral` to a `RomanNumeral`. Because `RomanNumeral` defines an implicit conversion from `BinaryNumeral`, no cast is required.  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [Conversion Operators](../VS_csharp/conversion-operators--csharp-programming-guide-.md)