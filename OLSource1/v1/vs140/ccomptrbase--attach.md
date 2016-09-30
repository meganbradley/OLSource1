---
title: "CComPtrBase::Attach"
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
  - "ATL.CComPtrBase.Attach"
  - "CComPtrBase::Attach"
  - "CComPtrBase<T>.Attach"
  - "ATL::CComPtrBase<T>::Attach"
  - "ATL.CComPtrBase<T>.Attach"
  - "CComPtrBase.Attach"
  - "CComPtrBase<T>::Attach"
  - "ATL::CComPtrBase::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method [ATL]"
ms.assetid: 5f4b27d8-68de-493f-9da4-d15a12661d18
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComPtrBase::Attach
Call this method to take ownership of an existing pointer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object will take ownership of this pointer.  
  
## Remarks  
 **Attach** calls [CComPtrBase::Release](../vs140/ccomptrbase--release.md) on the existing [CComPtrBase::p](../vs140/ccomptrbase--p.md) member variable and then assigns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. When a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object takes ownership of a pointer, it will automatically call <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> on the pointer which will delete the pointer and any allocated data if the reference count on the object goes to 0.  
  
## Requirements  
 **Header:** atlcomcli.h  
  
## See Also  
 [CComPtrBase Class](../vs140/ccomptrbase-class.md)   
 [CComPtrBase::Detach](../vs140/ccomptrbase--detach.md)