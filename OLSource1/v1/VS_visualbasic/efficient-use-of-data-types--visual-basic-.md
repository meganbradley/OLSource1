---
title: "Efficient Use of Data Types (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "performance, data type efficiency"
  - "data types [Visual Basic], weak typing"
  - "AscW function, preferred to Asc"
  - "data types [Visual Basic], using efficiently"
  - "optimization, data types"
  - "data types [Visual Basic], strong typing"
  - "strong typing"
  - "typing, strong"
  - "data types [Visual Basic], optimizing"
  - "ChrW function, preferred to Chr"
ms.assetid: 28f5e4ba-ec24-4f37-b90a-e8ee822f778a
caps.latest.revision: 16
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
# Efficient Use of Data Types (Visual Basic)
Undeclared variables and variables declared without a data type are assigned the `Object` data type. This makes it easy to write programs quickly, but it can cause them to execute more slowly.  
  
## Strong Typing  
 Specifying data types for all your variables is known as *strong typing*. Using strong typing has several advantages:  
  
-   It enables IntelliSense support for your variables. This allows you to see their properties and other members as you type in the code.  
  
-   It takes advantage of compiler type checking. This catches statements that can fail at run time due to errors such as overflow. It also catches calls to methods on objects that do not support them.  
  
-   It results in faster execution of your code.  
  
## Most Efficient Data Types  
 For variables that never contain fractions, the integral data types are more efficient than the nonintegral types. In [!INCLUDE[vbprvb](../VS_visualbasic/includes/vbprvb_md.md)], `Integer` and `UInteger` are the most efficient numeric types.  
  
 For fractional numbers, `Double` is the most efficient data type, because the processors on current platforms perform floating-point operations in double precision. However, operations with `Double` are not as fast as with the integral types such as `Integer`.  
  
## Specifying Data Type  
 Use the [Dim Statement](../VS_visualbasic/dim-statement--visual-basic-.md) to declare a variable of a specific type. You can simultaneously specify its access level by using the [Public](../VS_visualbasic/public--visual-basic-.md), [Protected](../VS_visualbasic/protected--visual-basic-.md), [Friend](../VS_visualbasic/friend--visual-basic-.md), or [Private](../VS_visualbasic/private--visual-basic-.md) keyword, as in the following example.  
  
```  
Private x As Double  
Protected s As String  
```  
  
## Character Conversion  
 The `AscW` and `ChrW` functions operate in Unicode. You should use them in preference to `Asc` and `Chr`, which must translate into and out of Unicode.  
  
## See Also  
 \<xref:Microsoft.VisualBasic.Strings.Asc*>   
 \<xref:Microsoft.VisualBasic.Strings.AscW*>   
 \<xref:Microsoft.VisualBasic.Strings.Chr*>   
 \<xref:Microsoft.VisualBasic.Strings.ChrW*>   
 [Data Types](../VS_visualbasic/data-types-in-visual-basic.md)   
 [Numeric Data Types](../VS_visualbasic/numeric-data-types--visual-basic-.md)   
 [Variable Declaration](../VS_visualbasic/variable-declaration-in-visual-basic.md)   
 [Using IntelliSense](../Topic/Using%20IntelliSense.md)