---
title: "_ATL_SECURE_NO_WARNINGS"
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
  - "ATL._ATL_SECURE_NO_WARNINGS"
  - "ATL::_ATL_SECURE_NO_DEPRECATE"
  - "ATL::_ATL_SECURE_NO_WARNINGS"
  - "_ATL_SECURE_NO_DEPRECATE"
  - "_ATL_SECURE_NO_WARNINGS"
  - "ATL._ATL_SECURE_NO_DEPRECATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_SECURE_NO_WARNINGS MACRO"
  - "ATL_SECURE_NO_DEPRECATE MACRO"
  - "_ATL_SECURE_NO_DEPRECATE MACRO"
  - "_ATL_SECURE_NO_WARNINGS MACRO"
ms.assetid: 587d29d8-a75a-44a3-bec8-f724087e5e73
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_SECURE_NO_WARNINGS
Suppresses compiler warnings for the use of deprecated ATL functions.  
  
## Syntax  
  
```  
#define _ATL_SECURE_NO_WARNINGS  
```  
  
## Example  
 This code sample would cause a compiler warning if _ATL_SECURE_NO_WARNINGS were not defined.  
  
 [!code[NVC_ATL_Utilities#125](../VS_csharp/codesnippet/CPP/_atl_secure_no_warnings_1.h)]  
  
 [!code[NVC_ATL_Utilities#126](../VS_csharp/codesnippet/CPP/_atl_secure_no_warnings_2.cpp)]  
  
## See Also  
 [Compiler Options Macros](../VS_csharp/compiler-options-macros.md)   
 [Macros](../VS_csharp/atl-macros.md)