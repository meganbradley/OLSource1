---
title: "CDC::m_hDC"
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
  - CDC.m_hDC
  - m_hDC
  - CDC::m_hDC
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, data members
  - m_hDC method
ms.assetid: 81c10ba5-75be-4bc1-9687-13bbc6fcd0d1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::m_hDC
The output device context for this `CDC` object.  
  
## Syntax  
  
```  
  
HDC m_hDC;  
  
```  
  
## Remarks  
 By default, `m_hDC` is equal to `m_hAttribDC`, the other device context wrapped by `CDC`. In general, `CDC` GDI calls that create output go to the `m_hDC` device context. You can initialize `m_hDC` and `m_hAttribDC` to point to different devices. See the [CDC](../vs140/cdc-class.md) class description for more on the use of these two device contexts.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::SetOutputDC](../vs140/cdc--setoutputdc.md)   
 [CDC::ReleaseOutputDC](../vs140/cdc--releaseoutputdc.md)