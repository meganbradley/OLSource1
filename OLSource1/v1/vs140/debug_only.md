---
title: "DEBUG_ONLY"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "AFX/DEBUG_ONLY"
  - "DEBUG_ONLY"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DEBUG_ONLY macro"
ms.assetid: 82f78864-43f5-425c-934d-5bef187afa77
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DEBUG_ONLY
In debug mode (when the **_DEBUG** symbol is defined), `DEBUG_ONLY` evaluates its argument.  
  
## Syntax  
  
```  
  
DEBUG_ONLY(  
expression  
 )  
  
```  
  
## Remarks  
 In a release build, **DEBUG_ONLY** does not evaluate its argument. This is useful when you have code that should be executed only in debug builds.  
  
 The `DEBUG_ONLY` macro is equivalent to surrounding *expression* with **#ifdef _DEBUG** and `#endif`.  
  
## Example  
 [!code[NVC_MFC_Utilities#32](../vs140/codesnippet/CPP/debug_only_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [ASSERT](../vs140/assert--mfc-.md)   
 [VERIFY](../vs140/verify.md)