---
title: "CAutoVectorPtr::operator ="
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
  - CAutoVectorPtr<T>::operator=
  - ATL::CAutoVectorPtr<T>::operator=
  - CAutoVectorPtr.operator=
  - CAutoVectorPtr<T>.operator=
  - CAutoVectorPtr::operator=
  - ATL.CAutoVectorPtr<T>.operator=
  - ATL::CAutoVectorPtr::operator=
  - ATL.CAutoVectorPtr.operator=
dev_langs: 
  - C++
helpviewer_keywords: 
  - = operator, with specific ATL objects
  - operator =, pointers
  - operator=, pointers
ms.assetid: 903c2d91-3663-4813-a49e-47c55124945d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAutoVectorPtr::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      CAutoVectorPtr< T >& operator =(  
   CAutoVectorPtr< T >& p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 A pointer.  
  
## Return Value  
 Returns a reference to a **CAutoVectorPtr< T >**.  
  
## Remarks  
 The assignment operator detaches the `CAutoVectorPtr` object from any current pointer and attaches the new pointer, `p`, in its place.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoVectorPtr Class](../vs140/cautovectorptr-class.md)   
 [CAutoVectorPtr::Attach](../vs140/cautovectorptr--attach.md)   
 [CAutoVectorPtr::Detach](../vs140/cautovectorptr--detach.md)