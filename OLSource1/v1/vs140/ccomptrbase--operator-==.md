---
title: "CComPtrBase::operator =="
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
  - ATL.CComPtrBase<T>.operator==
  - ATL.CComPtrBase.operator==
  - CComPtrBase<T>.operator==
  - CComPtrBase.operator==
  - ATL::CComPtrBase::operator==
  - CComPtrBase<T>::operator==
  - ATL::CComPtrBase<T>::operator==
  - CComPtrBase::operator==
dev_langs: 
  - C++
helpviewer_keywords: 
  - operator==, pointers
  - operator ==, pointers
  - == operator
ms.assetid: ca2235b3-9812-47f5-bd20-ab1e19d39d8c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComPtrBase::operator ==
The equality operator.  
  
## Syntax  
  
```  
  
      bool operator ==(  
   T * pT   
) const throw( );  
```  
  
#### Parameters  
 *pT*  
 A pointer to an object.  
  
## Return Value  
 Returns true if `CComPtrBase` and *pT* point to the same object, false otherwise.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)