---
title: "Checked and Unchecked (C# Reference)"
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
  - "operators [C#], checked and unchecked"
  - "exceptions [C#], overflow checking"
  - "checked statement [C#]"
  - "overflow checking [C#]"
  - "unchecked statement [C#]"
  - "statements [C#], checked and unchecked"
ms.assetid: a84bc877-2c7f-4396-8735-1ce97c42f35e
caps.latest.revision: 17
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
# Checked and Unchecked (C# Reference)
C# statements can execute in either checked or unchecked context. In a checked context, arithmetic overflow raises an exception. In an unchecked context, arithmetic overflow is ignored and the result is truncated.  
  
-   [checked](../VS_csharp/checked--csharp-reference-.md) Specify checked context.  
  
-   [unchecked](../VS_csharp/unchecked--csharp-reference-.md) Specify unchecked context.  
  
 If neither `checked` nor `unchecked` is specified, the default context depends on external factors such as compiler options.  
  
 The following operations are affected by the overflow checking:  
  
-   Expressions using the following predefined operators on integral types:  
  
     `++` `--` - (unary)   `+` -   `*` `/`  
  
-   Explicit numeric conversions between integral types.  
  
 The [/checked](../VS_csharp/-checked--csharp-compiler-options-.md) compiler option lets you specify checked or unchecked context for all integer arithmetic statements that are not explicitly in the scope of a `checked` or `unchecked` keyword.  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [Statement Keywords](../VS_csharp/statement-keywords--csharp-reference-.md)