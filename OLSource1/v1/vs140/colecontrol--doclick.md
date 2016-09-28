---
title: "COleControl::DoClick"
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
  - "DoClick"
  - "COleControl::DoClick"
  - "COleControl.DoClick"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DoClick method"
ms.assetid: 83b43640-e0ba-4c92-85fb-df18d9f7fb9c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::DoClick
Simulates a mouse click action on the control.  
  
## Syntax  
  
```  
  
void DoClick( );  
```  
  
## Remarks  
 The overridable `COleControl::OnClick` member function will be called, and a stock Click event will be fired, if supported by the control.  
  
 This function is supported by the `COleControl` base class as a stock method, called DoClick. For more information, see the article [ActiveX Controls: Methods](../vs140/mfc-activex-controls--methods.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::OnClick](../vs140/colecontrol--onclick.md)