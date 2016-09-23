---
title: "CControlBar::DrawBorders"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - DrawBorders
  - CControlBar::DrawBorders
  - CControlBar.DrawBorders
dev_langs: 
  - C++
helpviewer_keywords: 
  - DrawBorders method
  - DrawBorders method, gripper bar painting
ms.assetid: 9bc74946-2d92-4a6b-88fb-a9d0739fa840
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CControlBar::DrawBorders
Called by the framework to render the borders of the control bar.  
  
## Syntax  
  
```  
  
      virtual void DrawBorders(  
   CDC* pDC,  
   CRect& rect   
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the device context to be used for rendering the borders of the control bar.  
  
 `rect`  
 A `CRect` object containing the dimensions of the control bar.  
  
## Remarks  
 Override this function to customize the appearance of the control bar borders.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::DoPaint](../vs140/ccontrolbar--dopaint.md)   
 [CControlBar::DrawGripper](../vs140/ccontrolbar--drawgripper.md)