---
title: "Option Strict Custom can only be used as an option to the command-line compiler (vbc.exe)"
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
  - "vbc31141"
  - "bc31141"
helpviewer_keywords: 
  - "BC31141"
ms.assetid: c32ae8ff-aacc-40b4-960a-6f2d5d246671
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Option Strict Custom can only be used as an option to the command-line compiler (vbc.exe)
The `Option Strict` statement takes only `On` and `Off` as arguments; `Option Strict Custom` is not allowed.  
  
 Use the `/optionstrict:custom` compiler option to warn when strict language semantics are not respected.  
  
 **Error ID:** BC31141  
  
### To correct this error  
  
1.  Remove `Option Strict Custom` from the source code.  
  
2.  Specify the `/optionstrict:custom` option. For more information, see [/optionstrict](../vs140/-optionstrict.md).  
  
## See Also  
 [Option (Visual Basic)](../vs140/option--keyword--statement.md)   
 [Option Strict Statement](../vs140/option-strict-statement.md)   
 [/optionstrict](../vs140/-optionstrict.md)