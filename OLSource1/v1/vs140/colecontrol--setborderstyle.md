---
title: "COleControl::SetBorderStyle"
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
  - "SetBorderStyle"
  - "COleControl::SetBorderStyle"
  - "COleControl.SetBorderStyle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetBorderStyle method"
ms.assetid: fd21609b-5a4f-4c31-be0e-8442f6bd0c0c
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetBorderStyle
Sets the stock BorderStyle property value of your control.  
  
## Syntax  
  
```  
  
      void SetBorderStyle(  
   short sBorderStyle   
);  
```  
  
#### Parameters  
 *sBorderStyle*  
 The new border style for the control; 0 indicates no border and 1 indicates a normal border.  
  
## Remarks  
 The control window will then be re-created and `OnBorderStyleChanged` called.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetBorderStyle](../vs140/colecontrol--getborderstyle.md)   
 [COleControl::OnBorderStyleChanged](../vs140/colecontrol--onborderstylechanged.md)