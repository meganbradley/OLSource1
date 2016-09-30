---
title: "CComObjectRootEx::m_dwRef"
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
  - "CComObjectRootEx.m_dwRef"
  - "CComObjectRootEx::m_dwRef"
  - "m_dwRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_dwRef"
ms.assetid: b26657e5-f806-475d-b8e4-f533bfcfadb2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectRootEx::m_dwRef
Part of a union that accesses four bytes of memory.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 With <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, part of a union:  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
  
 If the object is not aggregated, the reference count accessed by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and **Release** is stored in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. If the object is aggregated, the pointer to the outer unknown is stored in [m_pOuterUnknown](../vs140/ccomobjectrootex--m_pouterunknown.md).  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md)