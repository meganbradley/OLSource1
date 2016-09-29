---
title: "CMFCToolBar::GetRouteCommandsViaFrame"
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
  - "GetRouteCommandsViaFrame"
  - "CMFCToolBar::GetRouteCommandsViaFrame"
  - "CMFCToolBar.GetRouteCommandsViaFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRouteCommandsViaFrame method"
ms.assetid: ba34151f-5370-42f2-8849-816190bc4957
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBar::GetRouteCommandsViaFrame
Determines which object, the parent frame or the owner, sends commands to the toolbar.  
  
## Syntax  
  
```  
BOOL GetRouteCommandsViaFrame();  
```  
  
## Return Value  
 Nonzero if the parent frame sends commands to the toolbar; 0 if the owner sends commands to the toolbar.  
  
## Remarks  
 By default, the parent frame sends commands to the toolbar. Call [CMFCToolBar::SetRouteCommandsViaFrame](../vs140/cmfctoolbar--setroutecommandsviaframe.md) to change this behavior.  
  
 If this method returns a nonzero value, you can retrieve a pointer to the parent frame object by using the `CMFCToolBar::GetCommandTarget` method. See the VisualStudioDemo sample for an example that uses this method.  
  
## Requirements  
 **Header:** afxtoolbar.h  
  
## See Also  
 [CMFCToolBar Class](../vs140/cmfctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCToolBar::SetRouteCommandsViaFrame](../vs140/cmfctoolbar--setroutecommandsviaframe.md)