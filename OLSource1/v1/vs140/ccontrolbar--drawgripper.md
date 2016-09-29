---
title: "CControlBar::DrawGripper"
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
  - "CControlBar::DrawGripper"
  - "DrawGripper"
  - "CControlBar.DrawGripper"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawGripper method, gripper bar painting"
  - "DrawGripper method"
ms.assetid: fc662551-8dfb-412d-ba02-115801c03a98
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CControlBar::DrawGripper
Called by the framework to render the gripper of the control bar.  
  
## Syntax  
  
```  
  
      virtual void DrawGripper(  
   CDC* pDC,  
   const CRect& rect   
);  
```  
  
#### Parameters  
 `pDC`  
 Points to the device context to be used for rendering the control bar gripper.  
  
 `rect`  
 A `CRect` object containing the dimensions of the control bar gripper.  
  
## Remarks  
 Override this function to customize the appearance of the control bar gripper.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CControlBar Class](../vs140/ccontrolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CControlBar::DoPaint](../vs140/ccontrolbar--dopaint.md)   
 [CControlBar::DrawBorders](../vs140/ccontrolbar--drawborders.md)