---
title: "CToolTipCtrl::AdjustRect"
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
  - "CToolTipCtrl::AdjustRect"
  - "CToolTipCtrl.AdjustRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AdjustRect method"
ms.assetid: daaf123e-2525-4a5f-94f4-32ea05eb547a
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolTipCtrl::AdjustRect
Converts between a tooltip control's text display rectangle and its window rectangle.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to a [RECT](http://msdn.microsoft.com/library/windows/desktop/dd162897) structure that holds either a tool tip window rectangle or a text display rectangle.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If **TRUE**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is used to specify a text-display rectangle, and it receives the corresponding window rectangle. If **FALSE**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is used to specify a window rectangle, and it receives the corresponding text display rectangle.  
  
## Return Value  
 Nonzero if the rectangle is successfully adjusted; otherwise 0.  
  
## Remarks  
 This member function calculates a tool tip control's text display rectangle from its window rectangle, or the tool tip window rectangle needed to display a specified text display rectangle.  
  
 This member function implements the behavior of the Win32 message [TTM_ADJUSTRECT](http://msdn.microsoft.com/library/windows/desktop/bb760352), as described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Requirements  
 **Header:** afxcmn.h  
  
## See Also  
 [CToolTipCtrl Class](../vs140/ctooltipctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolTipCtrl::GetBubbleSize](../vs140/ctooltipctrl--getbubblesize.md)