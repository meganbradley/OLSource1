---
title: "_ATL_ALL_WARNINGS"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "ATL._ATL_ALL_WARNINGS"
  - "_ATL_ALL_WARNINGS"
  - "ATL::_ATL_ALL_WARNINGS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATL_ALL_WARNINGS macro"
  - "ATL_ALL_WARNINGS macro"
ms.assetid: 6dd254c3-0c8a-405d-89f1-5e4f62dc5ed3
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_ALL_WARNINGS
A symbol which enables errors in projects converted from previous versions of ATL.  
  
## Syntax  
  
```  
  
#define _ATL_ALL_WARNINGS  
  
```  
  
## Remarks  
 Before Visual C++ .NET 2002, ATL disabled a lot of warnings and left them disabled so that they never showed up in user code. Specifically:  
  
-   C4127 conditional expression is constant  
  
-   C4786 'identifier' : identifier was truncated to 'number' characters in the debug information  
  
-   C4201 nonstandard extension used : nameless struct/union  
  
-   C4103 'filename' : used #pragma pack to change alignment  
  
-   C4291 'declaration' : no matching operator delete found; memory will not be freed if initialization throws an exception  
  
-   C4268 'identifier' : 'const' static/global data initialized with compiler generated default constructor fills the object with zeros  
  
-   C4702 unreachable code  
  
 In projects converted from previous versions, these warnings are still disabled by the libraries headers.  
  
 By adding the following line to the stdafx.h file before including libraries headers, this behavior can be changed.  
  
 [!code[NVC_ATL_Utilities#97](../vs140/codesnippet/CPP/_atl_all_warnings_1.h)]  
  
 If this `#define` is added, the ATL headers are careful to preserve the state of these warnings so that they are not disabled globally (or if the user explicitly disables individual warnings, not to enable them).  
  
 New projects generated with Visual C++ .NET 2002 will have this `#define` set in stdafx.h by default.  
  
## See Also  
 [Compiler Options Macros](../vs140/compiler-options-macros.md)