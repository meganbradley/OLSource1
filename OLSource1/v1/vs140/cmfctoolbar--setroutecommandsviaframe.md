---
title: "CMFCToolBar::SetRouteCommandsViaFrame"
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
  - "CMFCToolBar::SetRouteCommandsViaFrame"
  - "SetRouteCommandsViaFrame"
  - "CMFCToolBar.SetRouteCommandsViaFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetRouteCommandsViaFrame method"
ms.assetid: 62a8a2d1-8046-4395-aacd-171e71df76eb
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::SetRouteCommandsViaFrame
Specifies whether the parent frame or the owner sends commands to the toolbar.  
  
## Syntax  
  
```  
void SetRouteCommandsViaFrame(  
   BOOL bValue   
);  
```  
  
#### Parameters  
 [in] `bValue`  
 If this parameter is `TRUE`, the parent frame sends commands to the toolbar. Otherwise, the owner sends commands to the toolbar.  
  
## Remarks  
 By default, the parent frame sends commands to the toolbar. Call the [CMFCToolBar::GetRouteCommandsViaFrame](../vs140/cmfctoolbar--getroutecommandsviaframe.md) method to determine whether the parent frame or the owner sends commands to the toolbar.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::GetRouteCommandsViaFrame](../vs140/cmfctoolbar--getroutecommandsviaframe.md)