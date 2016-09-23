---
title: "CW2CWEX::CW2CWEX"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CW2CWEX
  - ATL.CW2CWEX.CW2CWEX
  - CW2CWEX<t_nBufferLength>::CW2CWEX
  - CW2CWEX<t_nBufferLength>.CW2CWEX
  - CW2CWEX.CW2CWEX
  - ATL::CW2CWEX::CW2CWEX
  - CW2CWEX::CW2CWEX
  - ATL.CW2CWEX<t_nBufferLength>.CW2CWEX
  - ATL::CW2CWEX<t_nBufferLength>::CW2CWEX
dev_langs: 
  - C++
helpviewer_keywords: 
  - CW2CWEX class, constructor
  - CW2CWEX constructor
ms.assetid: a1a633b2-7d28-4c52-a44d-93fab79b2127
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CW2CWEX::CW2CWEX
The constructor.  
  
## Syntax  
  
```  
  
      CW2CWEX(  
   LPCWSTR psz,  
   UINT nCodePage  
) throw(...);  
CW2CWEX(  
   LPCWSTR psz  
) throw(...);  
```  
  
#### Parameters  
 `psz`  
 The text string to be converted.  
  
 `nCodePage`  
 The code page. Not used in this class.  
  
## Remarks  
 Allocates the buffer used in the translation process.  
  
## Requirements  
 **Header:** atlconv.h  
  
## See Also  
 [CW2CWEX Class](../vs140/cw2cwex-class.md)