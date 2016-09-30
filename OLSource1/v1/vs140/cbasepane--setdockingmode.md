---
title: "CBasePane::SetDockingMode"
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
  - "SetDockingMode"
  - "CBasePane.SetDockingMode"
  - "CBasePane::SetDockingMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetDockingMode method"
ms.assetid: ef8e450c-9b4f-45f2-9d2f-f0f85dd285d4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::SetDockingMode
Sets the docking mode for the pane.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the new docking mode for the pane.  
  
## Remarks  
 The framework supports two docking modes: standard and immediate.  
  
 In the standard docking mode, panes and mini-frame windows are moved around using a drag rectangle. In the immediate docking mode, control bars and mini-frame windows are moved immediately with their context.  
  
 Initially, the docking mode is defined globally by [CDockingManager::m_dockModeGlobal](../vs140/cdockingmanager--m_dockmodeglobal.md). You can set the docking mode for each pane individually using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> method.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBasePane::GetDockingMode](../vs140/cbasepane--getdockingmode.md)