---
title: "CComObjectStack::AddRef"
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
  - "CComObjectStack::AddRef"
  - "ATL::CComObjectStack::AddRef"
  - "CComObjectStack.AddRef"
  - "CComObjectStack<Base>::AddRef"
  - "ATL.CComObjectStack.AddRef"
  - "AddRef"
  - "CComObjectStack<Base>.AddRef"
  - "ATL.CComObjectStack<Base>.AddRef"
  - "ATL::CComObjectStack<Base>::AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Module method"
  - "AddRef method [ATL]"
  - "_Module method"
  - "AddRef method [C++], object syntax"
ms.assetid: 1bd6b3e6-1a4f-4072-bc18-4f361497314d
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectStack::AddRef
Returns zero.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, AddRef)( );  
  
```  
  
## Return Value  
 Returns zero.  
  
## Remarks  
 In debug mode, calls `_ASSERTE`.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectStack Class](../vs140/ccomobjectstack-class.md)