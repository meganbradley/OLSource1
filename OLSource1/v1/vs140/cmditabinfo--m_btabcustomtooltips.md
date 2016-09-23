---
title: "CMDITabInfo::m_bTabCustomTooltips"
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
  - CMDITabInfo::m_bTabCustomTooltips
  - m_bTabCustomTooltips
  - CMDITabInfo.m_bTabCustomTooltips
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bTabCustomTooltips
  - CMDITabInfo class, data members
ms.assetid: c4f375b2-b7ee-4eeb-95db-cb4c467fdc8a
caps.latest.revision: 22
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDITabInfo::m_bTabCustomTooltips
Specifies whether the tabs display tooltips.  
  
## Syntax  
  
```  
BOOL m_bTabCustomTooltips;  
```  
  
## Remarks  
 If `TRUE`, the application sends an `AFX_WM_ON_GET_TAB_TOOLTIP` message to the main frame. You can handle this message by using the `ON_REGISTERED_MESSAGE` macro.  
  
## Requirements  
 **Header:** afxmdiclientareawnd.h  
  
## See Also  
 [CMDITabInfo Class](../vs140/cmditabinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)