---
title: "CBaseTabbedPane::SetAutoHideMode"
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
  - "CBaseTabbedPane.SetAutoHideMode"
  - "CBaseTabbedPane::SetAutoHideMode"
  - "SetAutoHideMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetAutoHideMode method"
ms.assetid: 3c1e04c6-52ed-448d-9c59-cfd1a96f219c
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBaseTabbedPane::SetAutoHideMode
Sets the auto-hide mode for detachable panes in the tabbed pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to enable auto-hide mode; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to enable regular docking mode.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the alignment of the auto-hide pane that is to be created. For a list of possible values, see [CPane::MoveByAlignment](../vs140/cpane--movebyalignment.md).  
  
 [in] [out] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the current auto-hide toolbar. Can be <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies whether to use the auto-hide effect when the user switches the pane to auto-hide mode, or to hide the pane immediately.  
  
## Return Value  
 A pointer to the auto-hide toolbar that is created when switching to auto-hide mode, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> if no toolbar is created.  
  
## Remarks  
 The framework calls this method when a user chooses the pin button to switch the tabbed pane to auto-hide mode or to regular docking mode.  
  
 Auto-hide mode is set for each detachable pane in the tabbed pane. Panes that are non-detachable are ignored. For more information, see [CMFCBaseTabCtrl::EnableTabDetach](../vs140/cmfcbasetabctrl--enabletabdetach.md).  
  
 Call this method to switch a tabbed pane to auto-hide mode programmatically. The pane must be docked to the main frame window ([CDockablePane::GetDefaultPaneDivider](../vs140/cdockablepane--getdefaultpanedivider.md) must return a valid pointer to the [CPaneDivider](../vs140/cpanedivider-class.md)).  
  
## Requirements  
 **Header:** afxbasetabbedpane.h  
  
## See Also  
 [CBaseTabbedPane Class](../vs140/cbasetabbedpane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)