---
title: "CComObjectGlobal::AddRef"
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
  - "CComObjectGlobal::AddRef"
  - "ATL.CComObjectGlobal.AddRef"
  - "ATL::CComObjectGlobal<Base>::AddRef"
  - "CComObjectGlobal<Base>.AddRef"
  - "CComObjectGlobal<Base>::AddRef"
  - "ATL.CComObjectGlobal<Base>.AddRef"
  - "AddRef"
  - "CComObjectGlobal.AddRef"
  - "ATL::CComObjectGlobal::AddRef"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Module method"
  - "AddRef method [ATL]"
  - "_Module method"
  - "AddRef method [C++], object syntax"
ms.assetid: aced4063-d2db-4081-8575-467fc25e3e33
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectGlobal::AddRef
Increments the reference count of the object by 1.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A value that may be useful for diagnostics and testing.  
  
## Remarks  
 By default, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> calls **_Module::Lock**, where **_Module** is the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectGlobal Class](../vs140/ccomobjectglobal-class.md)   
 [CComObjectGlobal::Release](../vs140/ccomobjectglobal--release.md)