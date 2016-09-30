---
title: "CComGITPtr::Detach"
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
  - "ATL::CComGITPtr<T>::Detach"
  - "CComGITPtr::Detach"
  - "CComGITPtr<T>::Detach"
  - "CComGITPtr<T>.Detach"
  - "ATL.CComGITPtr.Detach"
  - "ATL.CComGITPtr<T>.Detach"
  - "ATL::CComGITPtr::Detach"
  - "CComGITPtr.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: 37358422-88f1-4405-8cab-3ace8f10280b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::Detach
Call this method to disassociate the interface from the `CComGITPtr` object.  
  
## Syntax  
  
```  
  
DWORD Detach( ) throw( );  
  
```  
  
## Return Value  
 Returns the cookie from the `CComGITPtr` object.  
  
## Remarks  
 It is up to the caller to remove the interface from the GIT, using [CComGITPtr::Revoke](../vs140/ccomgitptr--revoke.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)   
 [CComGITPtr::Attach](../vs140/ccomgitptr--attach.md)