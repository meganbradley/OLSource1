---
title: "Implicit conversion from &#39;&lt;typename1&gt;&#39; to &#39;&lt;typename2&gt;&#39;"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc42016
  - BC42016
helpviewer_keywords: 
  - BC42016
ms.assetid: 7dabaab0-8258-4c17-927f-28e61f50bd3a
caps.latest.revision: 15
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Implicit conversion from &#39;&lt;typename1&gt;&#39; to &#39;&lt;typename2&gt;&#39;
An expression or an assignment statement takes a value of one data type and converts it to another type. Because no conversion keyword is used, the conversion is *implicit*.  
  
 By default, this message is a warning. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../vs140/configuring-warnings-in-visual-basic.md).  
  
 **Error ID:** BC42016  
  
### To correct this error  
  
-   If possible, use values of the same data type, so [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] does not need to do any conversion.  
  
-   Use `CType` or one of the other conversion keywords so that the conversion is *explicit*.  
  
## See Also  
 [Implicit and Explicit Conversions](../vs140/implicit-and-explicit-conversions--visual-basic-.md)   
 [Type Conversion Functions](../vs140/type-conversion-functions--visual-basic-.md)