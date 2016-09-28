---
title: "CDockingManager::m_nTimeOutBeforeToolBarDock"
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
  - "g_nTimeOutBeforeToolBarDock"
  - "CDockingManager.g_nTimeOutBeforeToolBarDock"
  - "CDockingManager::g_nTimeOutBeforeToolBarDock"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "g_nTimeOutBeforeToolBarDock"
  - "CDockingManager class, data members"
ms.assetid: f904eec3-8bd4-4010-9e07-482f0eeb6322
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockingManager::m_nTimeOutBeforeToolBarDock
Specifies the time, in milliseconds, before a toolbar is docked to the main frame window.  
  
## Syntax  
  
```  
static UINT m_nTimeOutBeforeToolBarDock;  
```  
  
## Remarks  
 Before a toolbar is docked, the framework waits the specified length of time. This prevents the toolbar from being accidentally docked to a location while the user is still dragging it.  
  
## Requirements  
 **Header:** afxDockingManager.h  
  
## See Also  
 [CDockingManager Class](../vs140/cdockingmanager-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)