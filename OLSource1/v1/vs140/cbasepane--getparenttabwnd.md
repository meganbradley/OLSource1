---
title: "CBasePane::GetParentTabWnd"
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
  - "CBasePane::GetParentTabWnd"
  - "CBasePane.GetParentTabWnd"
  - "GetParentTabWnd"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentTabWnd method"
ms.assetid: 22e3fb79-dd0d-46b7-bd62-14f6e673566c
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetParentTabWnd
Returns a pointer to the parent window that is inside a tab.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [out] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If the return value is not <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, this parameter contains the handle to the parent tabbed window.  
  
## Return Value  
 A valid pointer to the parent tabbed window or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this function to retrieve a pointer to the parent tabbed window. Sometimes it is not enough to call <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, because a pane may be inside a docking wrapper ([CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)) or inside a pane adapter ([CDockablePaneAdapter Class](../vs140/cdockablepaneadapter-class.md)). By using <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> you will be able to retrieve a valid pointer in those cases (assuming that the parent is a tabbed window).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)