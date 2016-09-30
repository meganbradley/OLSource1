---
title: "CTabbedPane::m_pTabWndRTC"
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
  - "m_pTabWndRTC"
  - "CTabbedPane::m_pTabWndRTC"
  - "CTabbedPane.m_pTabWndRTC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CTabbedPane class, data members"
  - "m_pTabWndRTC"
ms.assetid: 64d510c5-47d7-46af-b672-33e5e9914462
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CTabbedPane::m_pTabWndRTC
Runtime class information for a custom `CMFCTabCtrl`-derived object.  
  
## Syntax  
  
```  
AFX_IMPORT_DATA static CRuntimeClass* m_pTabWndRTC;  
```  
  
## Remarks  
 Set this static member variable to a pointer to the runtime class information of a `CMFCTabCtrl`-derived object if you are using a custom tabbed window inside a tabbed pane.  
  
## Requirements  
 **Header:** afxTabbedPane.h  
  
## See Also  
 [CTabbedPane Class](../vs140/ctabbedpane-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)