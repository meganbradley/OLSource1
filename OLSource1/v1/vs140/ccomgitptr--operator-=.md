---
title: "CComGITPtr::operator ="
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
  - "ATL.CComGITPtr<T>.operator="
  - "ATL::CComGITPtr<T>::operator="
  - "ATL.CComGITPtr.operator="
  - "CComGITPtr.operator="
  - "CComGITPtr::operator="
  - "CComGITPtr<T>.operator="
  - "ATL::CComGITPtr::operator="
  - "CComGITPtr<T>::operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, pointers"
  - "operator=, pointers"
ms.assetid: 0e06eab8-85f3-4a7f-aa65-271519e99883
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComGITPtr::operator =
The assignment operator.  
  
## Syntax  
  
```  
CComGITPtr& operator =(  
   T* p   
);  
  
CComGITPtr& operator =(  
   const CComGITPtr& git   
);  
  
CComGITPtr& operator =(  
   DWORD dwCookie   
);  
  
CComGITPtr& operator =(  
   CComGITPtr&& rv  
);  
```  
  
#### Parameters  
 [in] `p`  
 A pointer to an interface.  
  
 [in] `git`  
 A reference to a `CComGITPtr` object.  
  
 [in] `dwCookie`  
 A cookie used to identify the interface pointer.  
  
 [in] `rv`  
 The `CComGITPtr` to move data from.  
  
## Return Value  
 Returns the updated `CComGITPtr` object.  
  
## Remarks  
 Assigns a new value to a `CComGITPtr` object, either from an existing object or from a reference to a global interface table.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComGITPtr Class](../vs140/ccomgitptr-class.md)