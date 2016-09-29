---
title: "CDC::SetColorAdjustment"
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
  - "SetColorAdjustment"
  - "CDC::SetColorAdjustment"
  - "CDC.SetColorAdjustment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "SetColorAdjustment method"
ms.assetid: 3258d2bc-193e-4bbc-a36e-72b6f27ef708
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetColorAdjustment
Sets the color adjustment values for the device context using the specified values.  
  
## Syntax  
  
```  
  
      BOOL SetColorAdjustment(  
   const COLORADJUSTMENT* lpColorAdjust   
);  
```  
  
#### Parameters  
 `lpColorAdjust`  
 Points to a [COLORADJUSTMENT](../vs140/coloradjustment-structure.md) data structure containing the color adjustment values.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The color adjustment values are used to adjust the input color of the source bitmap for calls to the `CDC::StretchBlt` member function when **HALFTONE** mode is set.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetStretchBltMode](../vs140/cdc--setstretchbltmode.md)   
 [CDC::StretchBlt](../vs140/cdc--stretchblt.md)   
 [StretchDIBits](http://msdn.microsoft.com/library/windows/desktop/dd145121)