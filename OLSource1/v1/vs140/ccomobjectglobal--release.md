---
title: "CComObjectGlobal::Release"
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
  - "ATL::CComObjectGlobal<Base>::Release"
  - "ATL.CComObjectGlobal<Base>.Release"
  - "CComObjectGlobal<Base>::Release"
  - "CComObjectGlobal::Release"
  - "CComObjectGlobal.Release"
  - "ATL.CComObjectGlobal.Release"
  - "ATL::CComObjectGlobal::Release"
  - "CComObjectGlobal<Base>.Release"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Release method"
ms.assetid: eaf8c7e6-2fee-447f-adbf-d6cb3fc9c6e2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComObjectGlobal::Release
Decrements the reference count of the object by 1.  
  
## Syntax  
  
```  
  
STDMETHOD_(ULONG, Release)( );  
```  
  
## Return Value  
 In debug builds, **Release** returns a value that may be useful for diagnostics and testing. In non-debug builds, **Release** always returns 0.  
  
## Remarks  
 By default, **Release** calls **_Module::Unlock**, where **_Module** is the global instance of [CComModule](../vs140/ccommodule-class.md) or a class derived from it.  
  
## Requirements  
 **Header:** atlcom.h  
  
## See Also  
 [CComObjectGlobal Class](../vs140/ccomobjectglobal-class.md)   
 [CComObjectGlobal::AddRef](../vs140/ccomobjectglobal--addref.md)