---
title: "CDC::m_hAttribDC"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDC.m_hAttribDC
  - CDC::m_hAttribDC
  - m_hAttribDC
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, data members
  - m_hAttribDC method
ms.assetid: 00bdf972-da70-4f01-aaa0-b94a8b1e477f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::m_hAttribDC
The attribute device context for this `CDC` object.  
  
## Syntax  
  
```  
  
HDC m_hAttribDC;  
  
```  
  
## Remarks  
 By default, this device context is equal to `m_hDC`. In general, `CDC` GDI calls that request information from the device context are directed to `m_hAttribDC`. See the [CDC](../vs140/cdc-class.md) class description for more on the use of these two device contexts.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::SetAttribDC](../vs140/cdc--setattribdc.md)   
 [CDC::ReleaseAttribDC](../vs140/cdc--releaseattribdc.md)