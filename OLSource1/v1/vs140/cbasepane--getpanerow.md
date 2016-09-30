---
title: "CBasePane::GetPaneRow"
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
  - "CBasePane::GetPaneRow"
  - "GetPaneRow"
  - "CBasePane.GetPaneRow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneRow method"
ms.assetid: c764dd6a-5312-4319-9be5-97fcfcd88826
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetPaneRow
Returns a pointer to the [CDockingPanesRow](../vs140/cdockingpanesrow-class.md)object where the pane is docked.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane is docked, or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if it is floating.  
  
## Remarks  
 Call this method to access the row where a pane is docked. For example, to arrange the panes in a particular row, call <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and then call [CDockingPanesRow::ArrangePanes](../vs140/cdockingpanesrow--arrangepanes.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)