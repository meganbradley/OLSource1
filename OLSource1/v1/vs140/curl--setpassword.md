---
title: "CUrl::SetPassword"
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
  - "ATL.CUrl.SetPassword"
  - "CUrl::SetPassword"
  - "ATL::CUrl::SetPassword"
  - "SetPassword"
  - "CUrl.SetPassword"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetPassword method"
ms.assetid: 4d06b311-2b00-4a83-8e9a-7ac8c43b5c6b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CUrl::SetPassword
Call this method to set the password.  
  
## Syntax  
  
```  
  
      inline BOOL SetPassword(  
   LPCTSTR lpszPass   
) throw( );  
```  
  
#### Parameters  
 *lpszPass*  
 The password.  
  
## Return Value  
 Returns TRUE on success, FALSE on failure.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [CUrl Class](../vs140/curl-class.md)   
 [CUrl::GetPassword](../vs140/curl--getpassword.md)