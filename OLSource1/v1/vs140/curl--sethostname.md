---
title: "CUrl::SetHostName"
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
  - CUrl::SetHostName
  - CUrl.SetHostName
  - ATL.CUrl.SetHostName
  - SetHostName
  - ATL::CUrl::SetHostName
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetHostName method
ms.assetid: c60507e2-c3a5-49d6-a4d8-fa9ab7910e00
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CUrl::SetHostName
Call this method to set the host name.  
  
## Syntax  
  
```  
  
      inline BOOL SetHostName(  
   LPCTSTR lpszHost   
) throw( );  
```  
  
#### Parameters  
 `lpszHost`  
 The host name.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::GetHostName](../vs140/curl--gethostname.md)