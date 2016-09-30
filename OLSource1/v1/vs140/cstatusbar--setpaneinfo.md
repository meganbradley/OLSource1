---
title: "CStatusBar::SetPaneInfo"
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
  - "CStatusBar.SetPaneInfo"
  - "SetPaneInfo"
  - "CStatusBar::SetPaneInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "status bars, pane information"
  - "SetPaneInfo method"
  - "CStatusBar class, attributes"
ms.assetid: b6ccce43-9e20-4fc5-9442-7c3e6587915a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::SetPaneInfo
Sets the specified indicator pane to a new ID, style, and width.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Index of the indicator pane whose style is to be set.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 New ID for the indicator pane.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 New style for the indicator pane.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 New width for the indicator pane.  
  
## Remarks  
 The following indicator styles are supported:  
  
-   **SBPS_NOBORDERS** No 3-D border around the pane.  
  
-   **SBPS_POPOUT** Reverse border so that text "pops out."  
  
-   **SBPS_DISABLED** Do not draw text.  
  
-   **SBPS_STRETCH** Stretch pane to fill unused space. Only one pane per status bar can have this style.  
  
-   **SBPS_NORMAL** No stretch, borders, or pop-out.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBar::GetPaneInfo](../vs140/cstatusbar--getpaneinfo.md)