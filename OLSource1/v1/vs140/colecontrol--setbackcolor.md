---
title: "COleControl::SetBackColor"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - COleControl.SetBackColor
  - COleControl::SetBackColor
  - SetBackColor
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetBackColor method
ms.assetid: 0a3cb201-1af1-46e1-878e-91b3654a558f
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# COleControl::SetBackColor
Sets the stock BackColor property value of your control.  
  
## Syntax  
  
```  
  
      void SetBackColor(  
   OLE_COLOR dwBackColor   
);  
```  
  
#### Parameters  
 *dwBackColor*  
 An **OLE_COLOR** value to be used for background drawing of your control.  
  
## Remarks  
 For more information on using this property and other related properties, see the article [ActiveX Controls: Properties](../vs140/mfc-activex-controls--properties.md).  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::SetForeColor](../vs140/colecontrol--setforecolor.md)   
 [COleControl::GetBackColor](../vs140/colecontrol--getbackcolor.md)   
 [COleControl::OnBackColorChanged](../vs140/colecontrol--onbackcolorchanged.md)