---
title: "CComQIPtr::operator ="
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
  - "ATL::CComQIPtr::operator="
  - "CComQIPtr.operator="
  - "CComQIPtr::operator="
  - "ATL.CComQIPtr.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, pointers"
  - "operator=, pointers"
ms.assetid: 11e1a23e-c013-4e76-805e-d9daaa345f07
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComQIPtr::operator =
The assignment operator.  
  
## Syntax  
  
```  
  
      T  
      * operator =(  
   T* lp   
) throw( );  
T* operator =(  
   const CComQIPtr< T,  
   piid >& lp   
) throw( );  
T* operator =(  
   IUnknown* lp   
) throw( );  
```  
  
#### Parameters  
 `lp`  
 Used to initialize the interface pointer.  
  
 `T`  
 A COM interface.  
  
 `piid`  
 A pointer to the IID of `T`.  
  
## Return Value  
 Returns a pointer to the updated `CComQIPtr` object.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComQIPtr Class](../vs140/ccomqiptr-class.md)   
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)