---
title: "CMDIFrameWndEx::m_bDisableSetRedraw"
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
  - m_bDisableSetRedraw
  - CMDIFrameWndEx.m_bDisableSetRedraw
  - CMDIFrameWndEx::m_bDisableSetRedraw
dev_langs: 
  - C++
helpviewer_keywords: 
  - m_bDisableSetRedraw
  - CMDIFrameWndEx class, data members
ms.assetid: afa8fae3-28e3-40d7-933f-b21165201a2f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMDIFrameWndEx::m_bDisableSetRedraw
Enables or disables redraw optimization for MDI child windows.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static BOOL m_bDisableSetRedraw;  
```  
  
## Remarks  
 The default value is `TRUE`.  
  
 Set this flag to `FALSE` if you want to optimize redrawing of MDI children. In this case the framework will call `SetRedraw (FALSE)` for the main frame when the application is changing the active tab.  
  
 This flag can cause unwanted effects (such as background applications that become visible). Therefore we recommend that you change the default only if you experience noticeable flickering during MDI tab activation.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)