---
title: "Where Can I Look Up Win32 Error Codes?"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.errors"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "C++"
helpviewer_keywords: 
  - "error codes, Win32"
  - "Win32, error codes"
ms.assetid: 8fb4ff42-b8eb-4152-b49e-b802d194b05e
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Where Can I Look Up Win32 Error Codes?
WINERROR.H in the INCLUDE directory of your default system installation contains the error code definitions for the Win32 API functions.  
  
 You can look up an error code by typing the code in the **Watch** window or the **QuickWatch** dialog box. For example:  
  
```  
0x80000004,hr  
```  
  
## See Also  
 [Debugging Native Code FAQs](../vs140/debugging-native-code-faqs.md)   
 [Debugging Native Code](../vs140/debugging-native-code.md)