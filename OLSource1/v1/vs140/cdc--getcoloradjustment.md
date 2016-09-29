---
title: "CDC::GetColorAdjustment"
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
  - "CDC.GetColorAdjustment"
  - "CDC::GetColorAdjustment"
  - "GetColorAdjustment"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing-attribute functions"
  - "GetColorAdjustment method"
ms.assetid: a4b47c38-bf33-4fcd-a948-13dde5277b3a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::GetColorAdjustment
Retrieves the color adjustment values for the device context.  
  
## Syntax  
  
```  
  
      BOOL GetColorAdjustment(  
   LPCOLORADJUSTMENT lpColorAdjust   
) const;  
```  
  
#### Parameters  
 `lpColorAdjust`  
 Points to a [COLORADJUSTMENT](../vs140/coloradjustment-structure.md) data structure to receive the color adjustment values.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetColorAdjustment](../vs140/cdc--setcoloradjustment.md)