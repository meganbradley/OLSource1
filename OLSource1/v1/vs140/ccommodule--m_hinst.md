---
title: "CComModule::m_hInst"
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
  - "CComModule::m_hInst"
  - "m_hInst"
  - "CComModule.m_hInst"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_hInst"
ms.assetid: 99172bb9-61ae-4605-a1a3-3d0c9162c94a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::m_hInst
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
HINSTANCE m_hInst;  
  
```  
  
## Remarks  
 Contains the handle to the module instance.  
  
 The [Init](../vs140/ccommodule--init.md) method sets `m_hInst` to the handle passed to **DLLMain** or `WinMain`.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)