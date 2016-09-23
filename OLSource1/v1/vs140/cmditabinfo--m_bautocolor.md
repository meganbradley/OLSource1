---
title: "CMDITabInfo::m_bAutoColor"
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
  - CMDITabInfo::m_bAutoColor
  - CMDITabInfo.m_bAutoColor
  - m_bAutoColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bAutoColor
  - CMDITabInfo class, data members
ms.assetid: 20077d6b-848c-4195-be50-202d8bb107db
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDITabInfo::m_bAutoColor
Specifies whether each MDI tab has its own color.  
  
## Syntax  
  
```  
BOOL m_bAutoColor;  
```  
  
## Remarks  
 If `TRUE`, each tab will have its own color. The set of colors is managed by the MFC library. Otherwise, the tabs are displayed in white. The default value is `FALSE`.  
  
## Requirements  
 **Header:** afxmdiclientareawnd.h  
  
## See Also  
 [CMDITabInfo Class](../vs140/cmditabinfo-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)