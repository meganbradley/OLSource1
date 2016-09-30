---
title: "COleControl::IsSubclassedControl"
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
  - "IsSubclassedControl"
  - "COleControl::IsSubclassedControl"
  - "COleControl.IsSubclassedControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IsSubclassedControl method"
ms.assetid: d7bf7b1e-2aa2-46b0-a8fc-9504c17c9462
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::IsSubclassedControl
Called by the framework to determine if the control subclasses a Windows control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the control is subclassed; otherwise 0.  
  
## Remarks  
 You must override this function and return **TRUE** if your OLE control subclasses a Windows control.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)