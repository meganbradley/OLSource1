---
title: "CComPtr::operator ="
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
  - "CComPtr.operator="
  - "ATL::CComPtr::operator="
  - "CComPtr::operator="
  - "CComPtr<T>.operator="
  - "ATL::CComPtr<T>::operator="
  - "ATL.CComPtr<T>.operator="
  - "CComPtr<T>::operator="
  - "ATL.CComPtr.operator="
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "= operator, with specific ATL objects"
  - "operator =, pointers"
  - "operator=, pointers"
ms.assetid: b84136f8-4881-4434-98f1-10f5a2bb5f5d
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtr::operator =
Assignment operator.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Returns a pointer to the updated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object  
  
## Remarks  
 This operation AddRefs the new object and releases the existing object, if one exists.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtr Class](../vs140/ccomptr-class.md)   
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)