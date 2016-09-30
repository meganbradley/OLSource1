---
title: "COleControl::DoSuperclassPaint"
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
  - "COleControl.DoSuperclassPaint"
  - "COleControl::DoSuperclassPaint"
  - "DoSuperclassPaint"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoSuperclassPaint method"
ms.assetid: 2581232d-90d1-4d01-af9f-5fb75aa21e19
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::DoSuperclassPaint
Redraws an OLE control that has been subclassed from a Windows control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context of the control container.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The area in which the control is to be drawn.  
  
## Remarks  
 Call this function to properly handle the painting of a nonactive OLE control. This function should only be used if the OLE control subclasses a Windows control and should be called in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function of your control.  
  
 For more information on this function and subclassing a Windows control, see the article [ActiveX Controls: Subclassing a Windows Control](../vs140/mfc-activex-controls--subclassing-a-windows-control.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnDraw](../vs140/colecontrol--ondraw.md)