---
title: "CControlBar::CalcFixedLayout"
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
  - "CControlBar.CalcFixedLayout"
  - "CalcFixedLayout"
  - "CControlBar::CalcFixedLayout"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CalcFixedLayout method"
  - "CControlBar class, attributes"
ms.assetid: a13e9c7f-4a17-40d1-abc9-fff7cbda5a97
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::CalcFixedLayout
Call this member function to calculate the horizontal size of a control bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Indicates whether the bar should be stretched to the size of the frame. The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> parameter is nonzero when the bar is not a docking bar (not available for docking) and is 0 when it is docked or floating (available for docking).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Indicates that the bar is horizontally or vertically oriented. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter is nonzero if the bar is horizontally oriented and is 0 if it is vertically oriented.  
  
## Return Value  
 The control bar size, in pixels, of a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
## Remarks  
 Control bars such as toolbars can stretch horizontally or vertically to accommodate the buttons contained in the control bar.  
  
 If <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is **TRUE**, stretch the dimension along the orientation provided by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. In other words, if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is **FALSE**, the control bar is stretched vertically. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is **FALSE**, no stretch occurs. The following table shows the possible permutations, and resulting control-bar styles, of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
|bStretch|bHorz|Stretching|Orientation|Docking/Not docking|  
|--------------|-----------|----------------|-----------------|--------------------------|  
|**TRUE**|**TRUE**|Horizontal stretching|Horizontally oriented|Not docking|  
|**TRUE**|**FALSE**|Vertical stretching|Vertically oriented|Not docking|  
|**FALSE**|**TRUE**|No stretching available|Horizontally oriented|Docking|  
|**FALSE**|**FALSE**|No stretching available|Vertically oriented|Docking|  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::CalcDynamicLayout](../vs140/ccontrolbar--calcdynamiclayout.md)