---
title: "CDC::ReleaseAttribDC"
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
  - "CDC::ReleaseAttribDC"
  - "CDC.ReleaseAttribDC"
  - "ReleaseAttribDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseAttribDC method"
  - "CDC class, initialization"
ms.assetid: ae0ad0d0-505e-4e0f-a535-a3fa3ce5bbc7
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ReleaseAttribDC
Call this member function to set `m_hAttribDC` to **NULL**.  
  
## Syntax  
  
```  
  
virtual void ReleaseAttribDC( );  
```  
  
## Remarks  
 This does not cause a **Detach** to occur. Only the output device context is attached to the `CDC` object, and only it can be detached.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetOutputDC](../vs140/cdc--setoutputdc.md)   
 [CDC::SetAttribDC](../vs140/cdc--setattribdc.md)   
 [CDC::ReleaseOutputDC](../vs140/cdc--releaseoutputdc.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)