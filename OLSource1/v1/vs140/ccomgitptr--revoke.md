---
title: "CComGITPtr::Revoke"
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
  - ATL.CComGITPtr<T>.Revoke
  - Revoke
  - ATL.CComGITPtr.Revoke
  - CComGITPtr::Revoke
  - CComGITPtr.Revoke
  - CComGITPtr<T>.Revoke
  - ATL::CComGITPtr::Revoke
  - ATL::CComGITPtr<T>::Revoke
  - CComGITPtr<T>::Revoke
dev_langs: 
  - C++
helpviewer_keywords: 
  - Revoke method
ms.assetid: 7edac469-8a9b-4e27-a9b4-8c5d78d3259d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComGITPtr::Revoke
Call this method to remove the current interface from the global interface table (GIT).  
  
## Syntax  
  
```  
  
HRESULT Revoke( ) throw( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 Removes the interface from the GIT.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)