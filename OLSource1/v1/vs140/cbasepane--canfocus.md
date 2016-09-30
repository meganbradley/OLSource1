---
title: "CBasePane::CanFocus"
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
  - "CBasePane::CanFocus"
  - "CanFocus"
  - "CBasePane.CanFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CanFocus method"
ms.assetid: 22f06164-93a7-4b18-8d82-e5f5f22c1c9e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBasePane::CanFocus
Specifies whether the pane can receive focus.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the pane can receive focus; otherwise <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this method in a derived class to control focus. For example, because toolbars cannot receive focus, this method returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> when it is called on toolbar objects.  
  
 The framework tries to set the input focus when a pane is docked or floated.  
  
## Requirements  
 **Header:** afxbasepane.h  
  
## See Also  
 [CBasePane Class](../vs140/cbasepane-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)