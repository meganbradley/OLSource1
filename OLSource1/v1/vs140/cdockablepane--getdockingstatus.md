---
title: "CDockablePane::GetDockingStatus"
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
  - "GetDockingStatus"
  - "CDockablePane::GetDockingStatus"
  - "CDockablePane.GetDockingStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDockingStatus method"
ms.assetid: 6604d18e-a9db-4b62-a99b-5b82fc8d7c1f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDockablePane::GetDockingStatus
Determines the ability of a pane to be docked based on the provided pointer location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The location of the pointer in screen coordinates.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The distance, in pixels, away from the edge of a rectangle the pointer must be to enable docking.  
  
## Return Value  
 One of the following status values:  
  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> value|Meaning|  
|---------------------------|-------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|The pointer is not over a dock site. The framework does not dock the pane.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|The pointer is located over the dock site in immediate mode (the pane uses the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> docking mode). The framework docks the pane immediately.|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|The pointer is over a dock site that is another docking pane or is an edge of the main frame. The framework docks the pane after a delay. See the Remarks section for more information about this delay.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|The pointer is located over a dock site that causes the pane to be docked in a tabbed window. This occurs when the pointer is located over the caption of another docking pane or over the tab area of a tabbed pane.|  
  
## Remarks  
 The framework calls this method to handle docking of a floating pane.  
  
 For floating toolbars or docking panes that use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> docking mode, the framework delays the dock command to enable the user to move the window out of the client area of the parent frame before docking occurs. The length of the delay is measured in milliseconds and is controlled by the [CDockingManager::m_nTimeOutBeforeToolBarDock](../vs140/cdockingmanager--m_ntimeoutbeforetoolbardock.md) data member.. The default value of [CDockingManager::m_nTimeOutBeforeToolBarDock](../vs140/cdockingmanager--m_ntimeoutbeforetoolbardock.md) is 200. This behavior emulates the docking behavior of [!INCLUDE[ofprword](../vs140/includes/ofprword_md.md)] 2007.  
  
 For delayed docking states (<CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>), the framework does not perform docking until the user releases the mouse button. If a pane uses the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> docking mode, the framework displays a rectangle at the projected docking location. If a pane uses the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> docking mode, the framework displays smart docking markers and semi-transparent rectangles at the projected docking location. To specify the docking mode for your pane, call the [CBasePane::SetDockingMode](../vs140/cbasepane--setdockingmode.md) method. For more information about smart docking, see [CDockingManager::GetSmartDockingParams](../vs140/cdockingmanager--getsmartdockingparams.md).  
  
## Requirements  
 **Header:** afxdockablepane.h  
  
## See Also  
 [CDockablePane Class](../vs140/cdockablepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CBasePane::SetDockingMode](../vs140/cbasepane--setdockingmode.md)   
 [CDockingManager::GetSmartDockingParams](../vs140/cdockingmanager--getsmartdockingparams.md)