---
title: "CAutoVectorPtr::Attach"
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
  - CAutoVectorPtr::Attach
  - CAutoVectorPtr.Attach
  - CAutoVectorPtr<T>::Attach
  - ATL.CAutoVectorPtr<T>.Attach
  - ATL::CAutoVectorPtr::Attach
  - ATL::CAutoVectorPtr<T>::Attach
  - ATL.CAutoVectorPtr.Attach
  - CAutoVectorPtr<T>.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - Attach method [ATL]
ms.assetid: 53320770-fa1e-47c1-b932-16f5761b211d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAutoVectorPtr::Attach
Call this method to take ownership of an existing pointer.  
  
## Syntax  
  
```  
  
      void Attach(  
   T* p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 The `CAutoVectorPtr` object will take ownership of this pointer.  
  
## Remarks  
 When a `CAutoVectorPtr` object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope. If [CAutoVectorPtr::Detach](../vs140/cautovectorptr--detach.md) is called, the programmer is again given responsibility for freeing any allocated resources.  
  
 In debug builds, an assertion failure will occur if the [CAutoVectorPtr::m_p](../vs140/cautovectorptr--m_p.md) member variable currently points to an existing value; that is, it is not equal to NULL.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoVectorPtr Class](../vs140/cautovectorptr-class.md)   
 [CAutoVectorPtr::Detach](../vs140/cautovectorptr--detach.md)   
 [CAutoVectorPtr::operator =](../vs140/cautovectorptr--operator-=.md)