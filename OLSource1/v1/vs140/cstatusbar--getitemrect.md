---
title: "CStatusBar::GetItemRect"
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
  - "CStatusBar.GetItemRect"
  - "CStatusBar::GetItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemRect method [MFC]"
  - "status bars, getting information"
  - "CStatusBar class, attributes"
ms.assetid: b9697c04-c0cf-4c04-bbd0-07a828656f97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatusBar::GetItemRect
Copies the coordinates of the indicator specified by <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> into the structure pointed to by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Index of the indicator whose rectangle coordinates are to be retrieved.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure or a [CRect](../vs140/crect-class.md) object that will receive the coordinates of the indicator specified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Coordinates are in pixels relative to the upper-left corner of the status bar.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CStatusBar Class](../vs140/cstatusbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatusBar::CommandToIndex](../vs140/cstatusbar--commandtoindex.md)   
 [CStatusBar::GetPaneInfo](../vs140/cstatusbar--getpaneinfo.md)