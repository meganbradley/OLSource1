---
title: "CBasePane::IsTabbed"
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
  - "IsTabbed"
  - "CBasePane::IsTabbed"
  - "CBasePane.IsTabbed"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsTabbed method"
ms.assetid: 9387323d-dbff-48a5-bc7f-2056deb4f003
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::IsTabbed
Determines whether the pane has been inserted in the tab control of a tabbed window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the control bar is inserted in a tab of a tabbed window; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 This method retrieves a pointer to the immediate parent and determines if the parent's runtime class is [CMFCBaseTabCtrl Class](../vs140/cmfcbasetabctrl-class.md).  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)