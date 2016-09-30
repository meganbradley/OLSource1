---
title: "CBasePane::CalcFixedLayout"
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
  - "CalcFixedLayout"
  - "CBasePane::CalcFixedLayout"
  - "CBasePane.CalcFixedLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcFixedLayout method"
ms.assetid: 41666d79-3a1c-48de-bf37-8fbdede599e4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CalcFixedLayout
Calculates the horizontal size of a control bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether the bar should be stretched to the size of the frame. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is nonzero when the bar is not a docking bar (not available for docking) and is 0 when it is docked or floating (available for docking).  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates that the bar is horizontally or vertically oriented. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
## Return Value  
 The control bar size, in pixels, of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Remarks  
 See the remarks section in [CControlBar::CalcFixedLayout](../vs140/ccontrolbar--calcfixedlayout.md)  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)