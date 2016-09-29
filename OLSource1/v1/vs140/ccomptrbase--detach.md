---
title: "CComPtrBase::Detach"
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
  - "ATL::CComPtrBase<T>::Detach"
  - "ATL.CComPtrBase<T>.Detach"
  - "ATL.CComPtrBase.Detach"
  - "CComPtrBase.Detach"
  - "CComPtrBase<T>.Detach"
  - "ATL::CComPtrBase::Detach"
  - "CComPtrBase<T>::Detach"
  - "CComPtrBase::Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Detach method"
ms.assetid: 67c313ff-7903-42d2-81b3-ffc06878e29c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::Detach
Call this method to release ownership of a pointer.  
  
## Syntax  
  
```  
  
T* Detach( ) throw( );  
  
```  
  
## Return Value  
 Returns a copy of the pointer.  
  
## Remarks  
 Releases ownership of a pointer, sets the [CComPtrBase::p](../vs140/ccomptrbase--p.md) data member variable to NULL, and returns a copy of the pointer.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)   
 [CComPtrBase::Attach](../vs140/ccomptrbase--attach.md)