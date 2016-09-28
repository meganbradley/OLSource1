---
title: "CComModule::m_hInstResource"
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
  - "CComModule.m_hInstResource"
  - "m_hInstResource"
  - "CComModule::m_hInstResource"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_hInstResource"
ms.assetid: 3128f561-c5e7-4cf0-a958-c76fa807149e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::m_hInstResource
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
HINSTANCE m_hInstResource;  
  
```  
  
## Remarks  
 By default, contains the handle to the module instance.  
  
 The [Init](../vs140/ccommodule--init.md) method sets `m_hInstResource` to the handle passed to **DLLMain** or `WinMain`. You can explicitly set `m_hInstResource` to the handle to a resource.  
  
 The [GetResourceInstance](../vs140/ccommodule--getresourceinstance.md) method returns the handle stored in `m_hInstResource`.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)