---
title: "CBasePane::GetDockingMode"
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
  - "GetDockingMode"
  - "CBasePane.GetDockingMode"
  - "CBasePane::GetDockingMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDockingMode method"
ms.assetid: 0f3ca7e2-2447-4c6c-a3cf-460ff508ac98
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetDockingMode
Returns the current docking mode for the pane.  
  
## Syntax  
  
```  
virtual AFX_DOCK_TYPE GetDockingMode() const;  
```  
  
## Return Value  
 DT_STANDARD if dragging the pane is indicated on the screen by a drag rectangle. DT_IMMEDIATE if the contents of the pane are dragged.  
  
## Remarks  
 The framework calls this method to determine the current docking mode of the pane.  
  
 If `CBasePane::m_dockMode` is undefined (DT_UNDEFINED), then the docking mode is taken from the global docking mode (`AFX_GLOBAL_DATA::m_dockModeGlobal`).  
  
 By setting `m_dockMode` or overriding `GetDockingMode` you can control the docking mode for each pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)