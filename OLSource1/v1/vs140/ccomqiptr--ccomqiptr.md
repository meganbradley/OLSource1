---
title: "CComQIPtr::CComQIPtr"
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
  - ATL.CComQIPtr.CComQIPtr
  - ATL::CComQIPtr::CComQIPtr
  - CComQIPtr.CComQIPtr
  - CComQIPtr::CComQIPtr
dev_langs: 
  - C++
helpviewer_keywords: 
  - CComQIPtr class, constructor
  - CComQIPtr constructor
ms.assetid: 3eb3f592-c246-479f-950a-9370f47a08f7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComQIPtr::CComQIPtr
The constructor.  
  
## Syntax  
  
```  
  
      CComQIPtr( ) throw( );   
CComQIPtr(  
   T* lp   
) throw( );  
CComQIPtr(  
   IUnknown* lp   
) throw( );  
CComQIPtr(  
   const CComQIPtr< T,  
   piid >& lp   
) throw( );  
```  
  
#### Parameters  
 `lp`  
 Used to initialize the interface pointer.  
  
 `T`  
 A COM interface.  
  
 `piid`  
 A pointer to the IID of `T`.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComQIPtr Class](../vs140/ccomqiptr-class.md)