---
title: "CComGITPtr::CComGITPtr"
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
  - "CComGITPtr.CComGITPtr"
  - "ATL.CComGITPtr<T>.CComGITPtr"
  - "CComGITPtr<T>.CComGITPtr"
  - "ATL::CComGITPtr<T>::CComGITPtr"
  - "ATL.CComGITPtr.CComGITPtr"
  - "CComGITPtr::CComGITPtr"
  - "CComGITPtr<T>::CComGITPtr"
  - "ATL::CComGITPtr::CComGITPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComGITPtr class, constructor"
  - "CComGITPtr constructor"
ms.assetid: c0b6edb2-0850-4bbd-8cce-aa6fed370ca1
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::CComGITPtr
The constructor.  
  
## Syntax  
  
```  
CComGITPtr( ) throw( );   
  
CComGITPtr(  
   T* p   
);  
  
CComGITPtr(  
   const CComGITPtr& git   
);  
  
explicit CComGITPtr(  
   DWORD dwCookie   
) throw( );  
  
CComGITPtr(  
   CComGITPtr&& rv  
);  
```  
  
#### Parameters  
 [in] `p`  
 An interface pointer to be stored in the global interface table (GIT).  
  
 [in] `git`  
 A reference to an existing `CComGITPtr` object.  
  
 [in] `dwCookie`  
 A cookie used to identify the interface pointer.  
  
 [in] `rv`  
 The source `CComGITPtr` object to move data from.  
  
## Remarks  
 Creates a new `CComGITPtr` object, optionally using an existing `CComGITPtr` object.  
  
 The constructor utilizing `rv` is a move constructor. The data is moved from the source, `rv`, and then `rv` is cleared.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)