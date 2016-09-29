---
title: "CMFCColorPickerCtrl::GetHLS"
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
  - "CMFCColorPickerCtrl::GetHLS"
  - "CMFCColorPickerCtrl.GetHLS"
  - "GetHLS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetHLS method"
ms.assetid: bec3a273-cbb7-4ff8-9216-e660d3f95d44
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPickerCtrl::GetHLS
Retrieves the hue, luminance and saturation values of the color that the user selects.  
  
## Syntax  
  
```  
void GetHLS(  
   double* hue,  
   double* luminance,  
   double* saturation   
);  
```  
  
#### Parameters  
 [out] `hue`  
 Pointer to a variable of type double that receives hue information.  
  
 [out] `luminance`  
 Pointer to a variable of type double that receives luminance information.  
  
 [out] `saturation`  
 Pointer to a variable of type double that receives saturation information.  
  
## Remarks  
  
## Requirements  
 **Header:** afxcolorpickerctrl.h  
  
## See Also  
 [CMFCColorPickerCtrl Class](../vs140/cmfccolorpickerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)