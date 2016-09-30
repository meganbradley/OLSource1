---
title: "COleControl::GetRectInContainer"
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
  - "COleControl.GetRectInContainer"
  - "GetRectInContainer"
  - "COleControl::GetRectInContainer"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetRectInContainer method"
ms.assetid: 2164b6a7-ac2a-4d47-8bf2-b7d6b17dfaba
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetRectInContainer
Obtains the coordinates of the control's rectangle relative to the container, expressed in device units.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the rectangle structure into which the control's coordinates will be copied.  
  
## Return Value  
 Nonzero if the control is in-place active; otherwise 0.  
  
## Remarks  
 The rectangle is only valid if the control is in-place active.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetRectInContainer](../vs140/colecontrol--setrectincontainer.md)   
 [COleControl::GetControlSize](../vs140/colecontrol--getcontrolsize.md)