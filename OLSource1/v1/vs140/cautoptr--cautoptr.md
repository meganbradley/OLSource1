---
title: "CAutoPtr::CAutoPtr"
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
  - ATL.CAutoPtr<T>.CAutoPtr
  - CAutoPtr<T>::CAutoPtr
  - CAutoPtr<T>.CAutoPtr
  - CAutoPtr.CAutoPtr
  - ATL::CAutoPtr::CAutoPtr
  - CAutoPtr::CAutoPtr
  - ATL::CAutoPtr<T>::CAutoPtr
  - ATL.CAutoPtr.CAutoPtr
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAutoPtr class, constructor
  - CAutoPtr constructor
ms.assetid: 8e2131e1-c73f-419e-a200-eaaadb5e006f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAutoPtr::CAutoPtr
The constructor.  
  
## Syntax  
  
```  
  
      CAutoPtr( ) throw( );   
explicit CAutoPtr(  
   T* p   
) throw( );  
template< typename TSrc > CAutoPtr(  
   CAutoPtr< TSrc >& p   
) throw( );  
template< > CAutoPtr(  
   CAutoPtr< T >& p   
) throw( );  
```  
  
#### Parameters  
 `p`  
 An existing pointer.  
  
 `TSrc`  
 The type being managed by another `CAutoPtr`, used to initialize the current object.  
  
## Remarks  
 The `CAutoPtr` object can be created using an existing pointer, in which case it transfers ownership of the pointer.  
  
## Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)   
 [CAutoPtr::~CAutoPtr](../vs140/cautoptr--~cautoptr.md)