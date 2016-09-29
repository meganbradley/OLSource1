---
title: "COleControl::GetBackColor"
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
  - "GetBackColor"
  - "COleControl.GetBackColor"
  - "COleControl::GetBackColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetBackColor method"
ms.assetid: 2dfdbb7d-047c-4e53-8ddc-0a8c388cdb71
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::GetBackColor
Implements the Get function of your control's stock BackColor property.  
  
## Syntax  
  
```  
  
OLE_COLOR GetBackColor( );  
```  
  
## Return Value  
 The return value specifies the current background color as a **OLE_COLOR** value, if successful. This value can be translated to a **COLORREF** value with a call to `TranslateColor`.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::AmbientBackColor](../vs140/colecontrol--ambientbackcolor.md)   
 [COleControl::TranslateColor](../vs140/colecontrol--translatecolor.md)   
 [COleControl::SetBackColor](../vs140/colecontrol--setbackcolor.md)   
 [COleControl::GetForeColor](../vs140/colecontrol--getforecolor.md)