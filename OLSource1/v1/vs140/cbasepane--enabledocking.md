---
title: "CBasePane::EnableDocking"
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
  - "CBasePane::EnableDocking"
  - "EnableDocking"
  - "CBasePane.EnableDocking"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableDocking method"
ms.assetid: 4f636957-839a-4bfe-bfd1-aad671600b1a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::EnableDocking
Enables docking of the pane to the main frame.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the docking alignment to enable.  
  
## Remarks  
 Call this method to enable docking alignment to the main frame. You can pass a combination of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> flags (for more information, see [CControlBar::EnableDocking](../vs140/ccontrolbar--enabledocking.md)).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> sets the internal flag <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and the framework checks this flag when a pane is docked.  
  
 Call [CBasePane::GetEnabledAlignment](../vs140/cbasepane--getenabledalignment.md) to determine the docking alignment for a pane.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)