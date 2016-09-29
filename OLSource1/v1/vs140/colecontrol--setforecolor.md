---
title: "COleControl::SetForeColor"
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
  - "SetForeColor"
  - "COleControl.SetForeColor"
  - "COleControl::SetForeColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetForeColor method"
ms.assetid: 9986049d-ef74-415c-ba36-4623ba8a6fd9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::SetForeColor
Sets the stock ForeColor property value of your control.  
  
## Syntax  
  
```  
  
      void SetForeColor(  
   OLE_COLOR dwForeColor   
);  
```  
  
#### Parameters  
 *dwForeColor*  
 An **OLE_COLOR** value to be used for foreground drawing of your control.  
  
## Remarks  
 For more information on using this property and other related properties, see the article [ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetBackColor](../vs140/colecontrol--setbackcolor.md)   
 [COleControl::GetForeColor](../vs140/colecontrol--getforecolor.md)   
 [COleControl::OnForeColorChanged](../vs140/colecontrol--onforecolorchanged.md)