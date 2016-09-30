---
title: "COleControl::AmbientUIDead"
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
  - "COleControl.AmbientUIDead"
  - "AmbientUIDead"
  - "COleControl::AmbientUIDead"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AmbientUIDead method"
ms.assetid: 8d797864-0150-431d-824b-9da87e906c49
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::AmbientUIDead
Determines if the container wants the control to respond to user-interface actions.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the control should respond to user-interface actions; otherwise 0. If this property is not supported, this function returns 0.  
  
## Remarks  
 For example, a container might set this to **TRUE** in design mode.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::AmbientUserMode](../vs140/colecontrol--ambientusermode.md)