---
title: "CAutoPtr::Attach"
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
  - "CAutoPtr.Attach"
  - "ATL.CAutoPtr<T>.Attach"
  - "ATL.CAutoPtr.Attach"
  - "CAutoPtr<T>::Attach"
  - "ATL::CAutoPtr::Attach"
  - "CAutoPtr::Attach"
  - "ATL::CAutoPtr<T>::Attach"
  - "CAutoPtr<T>.Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 35f7e389-5841-43b7-83b8-56a7110d6211
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAutoPtr::Attach
Call this method to take ownership of an existing pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object will take ownership of this pointer.  
  
## Remarks  
 When a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> object takes ownership of a pointer, it will automatically delete the pointer and any allocated data when it goes out of scope. If [CAutoPtr::Detach](../vs140/cautoptr--detach.md) is called, the programmer is again given responsibility for freeing any allocated resources.  
  
 In debug builds, an assertion failure will occur if the [CAutoPtr::m_p](../vs140/cautoptr--m_p.md) data member currently points to an existing value; that is, it is not equal to NULL.  
  
## Example  
 See the example in the [CAutoPtr Overview](../vs140/cautoptr-class.md).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAutoPtr Class](../vs140/cautoptr-class.md)   
 [CAutoPtr::Detach](../vs140/cautoptr--detach.md)   
 [CAutoPtr::operator =](../vs140/cautoptr--operator-=.md)