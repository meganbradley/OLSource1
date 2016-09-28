---
title: "CMFCPropertyGridCtrl::GetCustomColors"
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
  - "CMFCPropertyGridCtrl::GetCustomColors"
  - "GetCustomColors"
  - "CMFCPropertyGridCtrl.GetCustomColors"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetCustomColors method"
ms.assetid: 458d150f-01fb-49af-adec-5d225a4f74b6
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCPropertyGridCtrl::GetCustomColors
Retrieves the custom colors that are currently defined for property grid control elements.  
  
## Syntax  
  
```  
void GetCustomColors(  
   COLORREF& clrBackground,  
   COLORREF& clrText,  
   COLORREF& clrGroupBackground,  
   COLORREF& clrGroupText,  
   COLORREF& clrDescriptionBackground,  
   COLORREF& clrDescriptionText,  
   COLORREF& clrLine   
);  
```  
  
#### Parameters  
 [out] `clrBackground`  
 The background color of property values.  
  
 [out] `clrText`  
 The color of property names and property value text.  
  
 [out] `clrGroupBackground`  
 The background color of a property group.  
  
 [out] `clrGroupText`  
 The color of text in the property group.  
  
 [out] `clrDescriptionBackground`  
 The background color of the description area.  
  
 [out] `clrDescriptionText`  
 The color of text in the description area.  
  
 [out] `clrLine`  
 The color of lines that are drawn between properties.  
  
## Remarks  
 Use the [CMFCPropertyGridCtrl::SetCustomColors](../vs140/cmfcpropertygridctrl--setcustomcolors.md) method to set custom colors.  
  
## Requirements  
 **Header:** afxpropertygridctrl.h  
  
## See Also  
 [CMFCPropertyGridCtrl Class](../vs140/cmfcpropertygridctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMFCPropertyGridCtrl::SetCustomColors](../vs140/cmfcpropertygridctrl--setcustomcolors.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)