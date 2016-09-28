---
title: "CComPtrBase::CopyTo"
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
  - "CComPtrBase::CopyTo"
  - "CComPtrBase<T>.CopyTo"
  - "CComPtrBase.CopyTo"
  - "ATL.CComPtrBase<T>.CopyTo"
  - "CComPtrBase<T>::CopyTo"
  - "ATL::CComPtrBase<T>::CopyTo"
  - "ATL.CComPtrBase.CopyTo"
  - "ATL::CComPtrBase::CopyTo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CopyTo method"
ms.assetid: 642dec53-e5c0-436d-be7a-d9ba3f67cb25
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::CopyTo
Call this method to copy the `CComPtrBase` pointer to another pointer variable.  
  
## Syntax  
  
```  
  
      HRESULT CopyTo(  
   T** ppT   
) throw( );  
```  
  
#### Parameters  
 *ppT*  
 Address of the variable which will receive the `CComPtrBase` pointer.  
  
## Return Value  
 Returns S_OK on success, E_POINTER on failure.  
  
## Remarks  
 Copies the `CComPtrBase` pointer to *ppT*. The reference count on the [CComPtrBase::p](../vs140/ccomptrbase--p.md) member variable is incremented.  
  
 An error HRESULT will be returned if *ppT* is equal to NULL. In debug builds, an assertion error will occur if *ppT* is equal to NULL.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)