---
title: "CDC::GetOutputTextMetrics"
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
  - CDC.GetOutputTextMetrics
  - CDC::GetOutputTextMetrics
  - GetOutputTextMetrics
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetOutputTextMetrics method
  - CDC class, text functions
ms.assetid: cc4bc814-993a-40bc-b37b-68097a6b6f31
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::GetOutputTextMetrics
Retrieves the metrics for the current font using `m_hDC`, the output device context.  
  
## Syntax  
  
```  
  
      BOOL GetOutputTextMetrics(  
   LPTEXTMETRIC lpMetrics   
) const;  
```  
  
#### Parameters  
 `lpMetrics`  
 Points to the [TEXTMETRIC](http://msdn.microsoft.com/library/windows/desktop/dd145132) structure that receives the metrics.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetTextAlign](../vs140/cdc--gettextalign.md)   
 [CDC::m_hAttribDC](../vs140/cdc--m_hattribdc.md)   
 [CDC::m_hDC](../vs140/cdc--m_hdc.md)   
 [CDC::GetTextMetrics](../vs140/cdc--gettextmetrics.md)   
 [CDC::GetTextExtent](../vs140/cdc--gettextextent.md)   
 [CDC::GetTextFace](../vs140/cdc--gettextface.md)   
 [CDC::SetTextJustification](../vs140/cdc--settextjustification.md)   
 [GetTextMetrics](http://msdn.microsoft.com/library/windows/desktop/dd144941)