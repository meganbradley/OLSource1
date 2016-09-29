---
title: "CComAutoThreadModule::m_nThreads"
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
  - "CComAutoThreadModule.m_nThreads"
  - "m_nThreads"
  - "CComAutoThreadModule::m_nThreads"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_nThreads"
ms.assetid: c7ba1a83-0efb-4443-8d98-b19ea26debcd
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComAutoThreadModule::m_nThreads
As of ATL 7.0, `CComAutoThreadModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
int m_nThreads;  
  
```  
  
## Remarks  
 Contains the number of threads in the EXE module. When [Init](../vs140/ccomautothreadmodule--init.md) is called, `m_nThreads` is set to the `nThreads` parameter value. Each thread's associated apartment is managed by a [CComApartment](../vs140/ccomapartment-class.md) object.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComAutoThreadModule Class](../vs140/ccomautothreadmodule-class.md)   
 [CComAutoThreadModule::m_pApartments](../vs140/ccomautothreadmodule--m_papartments.md)