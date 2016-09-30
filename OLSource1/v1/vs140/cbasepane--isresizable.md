---
title: "CBasePane::IsResizable"
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
  - "CBasePane.IsResizable"
  - "CBasePane::IsResizable"
  - "IsResizable"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsResizable method"
ms.assetid: 2ae45130-1bac-496a-9d16-3c0c18f3a5a0
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsResizable
Determines whether the pane can be resized.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can be resized by the user; otherwise, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Panes of [CDockablePane Class](../vs140/cdockablepane-class.md) can be resized.  
  
 The status bar ([CMFCStatusBar Class](../vs140/cmfcstatusbar-class.md)) and the dock bar ([CDockSite Class](../vs140/cdocksite-class.md)) cannot be resized.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)