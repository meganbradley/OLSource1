---
title: "CComPtrBase::operator -&gt;"
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
  - "ATL.CComPtrBase.operator->"
  - "ATL::CComPtrBase<T>::operator->"
  - "CComPtrBase<T>::operator->"
  - "ATL::CComPtrBase::operator->"
  - "CComPtrBase.operator->"
  - "CComPtrBase<T>.operator->"
  - "ATL.CComPtrBase<T>.operator->"
  - "CComPtrBase::operator->"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "-> operator"
  - "operator->"
ms.assetid: 9ce396e3-f682-432b-9e29-2fb6affb22c7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::operator -&gt;
The pointer-to-member operator.  
  
## Syntax  
  
```  
  
_NoAddRefReleaseOnCComPtr< T > * operator ->( ) const throw( );  
  
```  
  
## Return Value  
 Returns the value of the [CComPtrBase::p](../vs140/ccomptrbase--p.md) data member variable.  
  
## Remarks  
 Use this operator to call a method in a class pointed to by the `CComPtrBase` object. In debug builds, an assertion failure will occur if the `CComPtrBase` data member points to NULL.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)