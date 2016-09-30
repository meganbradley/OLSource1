---
title: "CBasePane::GetParentMiniFrame"
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
  - "CBasePane.GetParentMiniFrame"
  - "CBasePane::GetParentMiniFrame"
  - "GetParentMiniFrame"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetParentMiniFrame method"
ms.assetid: 518ffa89-7c6b-4415-ae13-815a082ad7d3
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::GetParentMiniFrame
Returns a pointer to the parent mini-frame window.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, this method does not check for non-valid pointers. If you call this method when your application exits, set this parameter to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 A valid pointer to the parent mini-frame window if the pane is floating; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this function to retrieve a pointer to the parent mini-frame window. This method iterates through all parents and checks for an object derived from [CPaneFrameWnd Class](../vs140/cpaneframewnd-class.md).  
  
 Use <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> to determine whether the pane is floating.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)