---
title: "CMFCColorPickerCtrl::SetType"
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
  - "CMFCColorPickerCtrl.SetType"
  - "CMFCColorPickerCtrl::SetType"
  - "SetType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetType method"
ms.assetid: d69130a5-0958-496c-8c4f-25daea29d92b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPickerCtrl::SetType
Sets the type of color picker control to display.  
  
## Syntax  
  
```  
void SetType(  
   COLORTYPE colorType   
);  
```  
  
#### Parameters  
 [in] `colorType`  
 A color picker control type.  
  
 The types are defined by the `CMFCColorPickerCtrl::COLORTYPE` enumeration. The possible types are `LUMINANCE`, `PICKER`, `HEX` and `HEX_GREYSCALE`. The default type is `PICKER`.  
  
## Remarks  
 To specify a color picker control type, call this method before the Windows control is created.  
  
## Requirements  
 **Header:** afxcolorpickerctrl.h  
  
## See Also  
 [CMFCColorPickerCtrl Class](../vs140/cmfccolorpickerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)