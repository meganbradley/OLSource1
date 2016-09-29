---
title: "CComGITPtr::GetCookie"
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
  - "CComGITPtr.GetCookie"
  - "CComGITPtr::GetCookie"
  - "GetCookie"
  - "ATL::CComGITPtr<T>::GetCookie"
  - "CComGITPtr<T>.GetCookie"
  - "ATL::CComGITPtr::GetCookie"
  - "ATL.CComGITPtr.GetCookie"
  - "CComGITPtr<T>::GetCookie"
  - "ATL.CComGITPtr<T>.GetCookie"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCookie method"
ms.assetid: e99e52f0-1c03-4356-b1b1-b034c8836322
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::GetCookie
Call this method to return the cookie from the `CComGITPtr` object.  
  
## Syntax  
  
```  
  
DWORD GetCookie( ) const;  
  
```  
  
## Return Value  
 Returns the cookie.  
  
## Remarks  
 The cookie is a variable used to identify an interface and its location.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)