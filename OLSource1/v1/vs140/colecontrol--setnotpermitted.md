---
title: "COleControl::SetNotPermitted"
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
  - "COleControl::SetNotPermitted"
  - "COleControl.SetNotPermitted"
  - "SetNotPermitted"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetNotPermitted method"
ms.assetid: eb440f17-cee6-4f72-ab3f-edfb9a685075
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetNotPermitted
Indicates that an edit request has failed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Call this function when <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> fails. This function throws an exception of type **COleDispScodeException** to indicate that the set operation was not permitted.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::BoundPropertyRequestEdit](../vs140/colecontrol--boundpropertyrequestedit.md)