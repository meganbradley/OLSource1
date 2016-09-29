---
title: "CDC::ReleaseOutputDC"
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
  - "CDC::ReleaseOutputDC"
  - "ReleaseOutputDC"
  - "CDC.ReleaseOutputDC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReleaseOutputDC method"
  - "CDC class, initialization"
ms.assetid: a646b79c-097a-4363-8e27-e6d0e88dfb7e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::ReleaseOutputDC
Call this member function to set the `m_hDC` member to **NULL**.  
  
## Syntax  
  
```  
  
virtual void ReleaseOutputDC( );  
```  
  
## Remarks  
 This member function cannot be called when the output device context is attached to the `CDC` object. Use the **Detach** member function to detach the output device context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetAttribDC](../vs140/cdc--setattribdc.md)   
 [CDC::SetOutputDC](../vs140/cdc--setoutputdc.md)   
 [CDC::ReleaseAttribDC](../vs140/cdc--releaseattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)