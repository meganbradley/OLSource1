---
title: "CUrl::GetExtraInfo"
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
  - ATL::CUrl::GetExtraInfo
  - CUrl.GetExtraInfo
  - GetExtraInfo
  - ATL.CUrl.GetExtraInfo
  - CUrl::GetExtraInfo
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetExtraInfo method
ms.assetid: 4d3122b6-d45a-47d4-be64-54d5bfe13b75
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUrl::GetExtraInfo
Call this method to get extra information (such as ?*text* or #*text*) from the URL.  
  
## Syntax  
  
```  
  
inline LPCTSTR GetExtraInfo( ) const throw( );  
  
```  
  
## Return Value  
 Returns a string containing the extra information.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::GetExtraInfoLength](../vs140/curl--getextrainfolength.md)   
 [CUrl::SetExtraInfo](../vs140/curl--setextrainfo.md)