---
title: "CDC::SetBrushOrg"
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
  - "CDC.SetBrushOrg"
  - "CDC::SetBrushOrg"
  - "SetBrushOrg"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, drawing tool functions"
  - "SetBrushOrg method"
ms.assetid: 9568c03a-dcd9-492e-b2a8-3beef5a7dcbe
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetBrushOrg
Specifies the origin that GDI will assign to the next brush that the application selects into the device context.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *x*  
 Specifies the x-coordinate (in device units) of the new origin. This value must be in the range 0–7.  
  
 *y*  
 Specifies the y-coordinate (in device units) of the new origin. This value must be in the range 0–7.  
  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the x- and y-coordinates of the new origin. Each value must be in the range 0–7. You can pass either a **POINT** structure or a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object for this parameter.  
  
## Return Value  
 The previous origin of the brush in device units.  
  
## Remarks  
 The default coordinates for the brush origin are (0, 0). To alter the origin of a brush, call the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> function for the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object, call <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, and then call the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> member function to select the brush into the device context.  
  
 Do not use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> with stock <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> objects.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CBrush Class](../vs140/cbrush-class.md)   
 [CDC::GetBrushOrg](../vs140/cdc--getbrushorg.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)   
 [CGdiObject::UnrealizeObject](../vs140/cgdiobject--unrealizeobject.md)   
 [POINT Structure](../vs140/point-structure.md)   
 [CPoint Class](../vs140/cpoint-class.md)