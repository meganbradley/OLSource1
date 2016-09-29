---
title: "CStatusBar::GetPaneInfo"
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
  - "GetPaneInfo"
  - "CStatusBar::GetPaneInfo"
  - "CStatusBar.GetPaneInfo"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPaneInfo method"
  - "status bars, getting information"
  - "CStatusBar class, attributes"
ms.assetid: d55f856a-a755-4fc7-9e04-2ed1321eaa9f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::GetPaneInfo
Sets `nID`, `nStyle`, and `cxWidth` to the ID, style, and width of the indicator pane at the location specified by `nIndex`.  
  
## Syntax  
  
```  
  
      void GetPaneInfo(  
   int nIndex,  
   UINT& nID,  
   UINT& nStyle,  
   int& cxWidth   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Index of the pane whose information is to be retrieved.  
  
 `nID`  
 Reference to a **UINT** that is set to the ID of the pane.  
  
 `nStyle`  
 Reference to a **UINT** that is set to the style of the pane.  
  
 `cxWidth`  
 Reference to an integer that is set to the width of the pane.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBar::SetPaneInfo](../vs140/cstatusbar--setpaneinfo.md)   
 [CStatusBar::GetItemID](../vs140/cstatusbar--getitemid.md)   
 [CStatusBar::GetItemRect](../vs140/cstatusbar--getitemrect.md)