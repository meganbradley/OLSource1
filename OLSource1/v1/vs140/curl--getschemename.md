---
title: "CUrl::GetSchemeName"
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
  - ATL::CUrl::GetSchemeName
  - CUrl.GetSchemeName
  - GetSchemeName
  - CUrl::GetSchemeName
  - ATL.CUrl.GetSchemeName
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetSchemeName method
ms.assetid: 3ad765ed-5393-4416-9b63-5b2c96cca003
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUrl::GetSchemeName
Call this method to get the URL scheme name.  
  
## Syntax  
  
```  
  
inline LPCTSTR GetSchemeName( ) const throw( );  
  
```  
  
## Return Value  
 Returns the URL scheme name (such as "http" or "ftp").  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::GetSchemeNameLength](../vs140/curl--getschemenamelength.md)   
 [CUrl::GetScheme](../vs140/curl--getscheme.md)   
 [CUrl::SetSchemeName](../vs140/curl--setschemename.md)