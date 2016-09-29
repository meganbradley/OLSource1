---
title: "COleControl::TranslateColor"
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
  - "COleControl::TranslateColor"
  - "TranslateColor"
  - "COleControl.TranslateColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TranslateColor method"
ms.assetid: d798ac45-0a6f-454f-a5b0-d686cac3bb96
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleControl::TranslateColor
Converts a color value from the **OLE_COLOR** data type to the [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449) data type.  
  
## Syntax  
  
```  
  
      COLORREF TranslateColor(  
   OLE_COLOR clrColor,  
   HPALETTE hpal = NULL   
);  
```  
  
#### Parameters  
 `clrColor`  
 A **OLE_COLOR** data type. For more information, see the Windows [OleTranslateColor](http://msdn.microsoft.com/library/windows/desktop/ms694353) function.  
  
 `hpal`  
 A handle to an optional palette; can be **NULL**.  
  
## Return Value  
 An RGB (red, green, blue) 32-bit color value that defines the solid color closest to the `clrColor` value that the device can represent.  
  
## Remarks  
 This function is useful to translate the stock ForeColor and BackColor properties to **COLORREF** types used by [CDC](../vs140/cdc-class.md) member functions.  
  
## Requirements  
 **Header:** afxctl.h  
  
## See Also  
 [COleControl Class](../vs140/colecontrol-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COleControl::GetForeColor](../vs140/colecontrol--getforecolor.md)   
 [COleControl::GetBackColor](../vs140/colecontrol--getbackcolor.md)