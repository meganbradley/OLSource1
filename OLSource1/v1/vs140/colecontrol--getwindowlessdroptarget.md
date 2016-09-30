---
title: "COleControl::GetWindowlessDropTarget"
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
  - "GetWindowlessDropTarget"
  - "COleControl.GetWindowlessDropTarget"
  - "COleControl::GetWindowlessDropTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetWindowlessDropTarget method"
ms.assetid: 9c96a7b1-cfba-4220-97ed-91a09531d736
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetWindowlessDropTarget
Override <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> when you want a windowless control to be the target of an OLE drag and drop operation.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Pointer to the object's <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> interface. Since it does not have a window, a windowless object cannot register an <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> interface. However, to participate in drag and drop, a windowless object can still implement the interface and return it in <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Normally, this would require that the control's window be registered as a drop target. But since the control has no window of its own, the container will use its own window as a drop target. The control simply needs to provide an implementation of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> interface to which the container can delegate calls at the appropriate time. For example:  
  
 [!code[NVC_MFCAxCtl#2](../vs140/codesnippet/CPP/colecontrol--getwindowlessdroptarget_1.cpp)]  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)