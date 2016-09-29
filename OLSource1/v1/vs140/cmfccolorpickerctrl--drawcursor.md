---
title: "CMFCColorPickerCtrl::DrawCursor"
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
  - "DrawCursor"
  - "CMFCColorPickerCtrl::DrawCursor"
  - "CMFCColorPickerCtrl.DrawCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DrawCursor method"
ms.assetid: 1eaaa982-dfb2-49ac-ae0c-b0a74ff5d0bb
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorPickerCtrl::DrawCursor
Called by the framework before a cursor that points to the selected color is displayed.  
  
## Syntax  
  
```  
virtual void DrawCursor(  
   CDC* pDC,  
   const CRect& rect   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `rect`  
 Specifies a rectangular area around the selected color.  
  
## Remarks  
 Override this method when you need to change the shape of the cursor that points to the selected color.  
  
## Requirements  
 **Header:** afxcolorpickerctrl.h  
  
## See Also  
 [CMFCColorPickerCtrl Class](../vs140/cmfccolorpickerctrl-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC Class](../vs140/cdc-class.md)