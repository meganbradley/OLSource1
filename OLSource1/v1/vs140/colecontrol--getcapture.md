---
title: "COleControl::GetCapture"
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
  - "COleControl::GetCapture"
  - "COleControl.GetCapture"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCapture method"
ms.assetid: 0f8e63dc-db22-4be3-ada6-ea12e73186ac
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetCapture
Determines whether the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object has the mouse capture.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the control is activated and windowless, returns **this** if the control currently has the mouse capture (as determined by the control's container), or **NULL** if it does not have the capture.  
  
 Otherwise, returns the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object that has the mouse capture (same as <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>).  
  
## Remarks  
 An activated windowless control receives the mouse capture when [SetCapture](../vs140/colecontrol--setcapture.md) is called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetCapture](../vs140/colecontrol--setcapture.md)   
 [COleControl::ReleaseCapture](../vs140/colecontrol--releasecapture.md)