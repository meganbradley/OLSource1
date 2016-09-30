---
title: "COleControl::AmbientUserMode"
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
  - "AmbientUserMode"
  - "COleControl.AmbientUserMode"
  - "COleControl::AmbientUserMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AmbientUserMode method"
ms.assetid: bfbeac1c-91d9-4e0f-a56a-97cef31421d5
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::AmbientUserMode
Determines if the container is in design mode or user mode.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 Nonzero if the container is in user mode; otherwise 0 (in design mode). If this property is not supported, this function returns TRUE.  
  
## Remarks  
 For example, a container might set this to **FALSE** in design mode.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::AmbientUIDead](../vs140/colecontrol--ambientuidead.md)