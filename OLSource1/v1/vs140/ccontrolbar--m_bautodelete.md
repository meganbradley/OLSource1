---
title: "CControlBar::m_bAutoDelete"
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
  - "CControlBar.m_bAutoDelete"
  - "CControlBar::m_bAutoDelete"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CControlBar class, data members"
  - "m_bAutoDelete"
ms.assetid: cd65807c-d555-4861-aae9-f69c59cee815
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::m_bAutoDelete
If nonzero, the `CControlBar` object is deleted when the Windows control bar is destroyed.  
  
## Syntax  
  
```  
  
BOOL m_bAutoDelete;  
  
```  
  
## Remarks  
 `m_bAutoDelete` is a public variable of type **BOOL**.  
  
 A control-bar object is usually embedded in a frame-window object. In this case, `m_bAutoDelete` is 0 because the embedded control-bar object is destroyed when the frame window is destroyed.  
  
 Set this variable to a nonzero value if you allocate a `CControlBar` object on the heap and you do not plan to call **delete**.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CWnd::DestroyWindow](../vs140/cwnd--destroywindow.md)