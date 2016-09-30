---
title: "COleControlContainer::HandleSetFocus"
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
  - "COleControlContainer::HandleSetFocus"
  - "COleControlContainer.HandleSetFocus"
  - "HandleSetFocus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "HandleSetFocus method"
  - "COleControlContainer class, overridables"
ms.assetid: 82b0a505-cb37-47cc-9a42-13c92a402e21
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControlContainer::HandleSetFocus
Determines if the container handles `WM_SETFOCUS` messages.  
  
## Syntax  
  
```  
  
virtual BOOL HandleSetFocus( );  
  
```  
  
## Return Value  
 Nonzero if the container handles `WM_SETFOCUS` messages; otherwise zero.  
  
## Requirements  
 **Header:** afxocc.h  
  
## See Also  
 [COleControlContainer Class](../vs140/colecontrolcontainer-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)