---
title: "CPane::StretchPaneDeferWndPos"
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
  - "CPane.StretchPaneDeferWndPos"
  - "StretchPaneDeferWndPos"
  - "CPane::StretchPaneDeferWndPos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "StretchPaneDeferWndPos method"
ms.assetid: 8efaeb94-d30b-4174-8703-22bc5f44fa8b
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPane::StretchPaneDeferWndPos
Stretches the pane vertically or horizontally based on docking style.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The amount, in pixels, to stretch the pane. Use a negative value to shrink the pane.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Not used.  
  
## Return Value  
 The actual amount, in pixels, that the pane was stretched.  
  
## Remarks  
 If necessary, this method modifies <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to ensure that the pane does not exceed size limits. These limits are obtained by calling [CPane::GetAvailableStretchSize](../vs140/cpane--getavailablestretchsize.md) and [CPane::GetAvailableExpandSize](../vs140/cpane--getavailableexpandsize.md).  
  
## Requirements  
 **Header:** afxpane.h  
  
## See Also  
 [CPane Class](../vs140/cpane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)