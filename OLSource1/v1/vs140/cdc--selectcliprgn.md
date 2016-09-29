---
title: "CDC::SelectClipRgn"
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
  - "CDC.SelectClipRgn"
  - "SelectClipRgn"
  - "CDC::SelectClipRgn"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CDC class, clipping functions"
  - "SelectClipRgn method"
ms.assetid: a56735b9-b7b4-4191-aa58-fa3b168a90dd
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SelectClipRgn
Selects the given region as the current clipping region for the device context.  
  
## Syntax  
  
```  
  
      int SelectClipRgn(  
   CRgn* pRgn   
);  
int SelectClipRgn(  
   CRgn* pRgn,  
   int nMode   
);  
```  
  
#### Parameters  
 `pRgn`  
 Identifies the region to be selected.  
  
-   For the first version of this function, if this value is **NULL**, the entire client area is selected and output is still clipped to the window.  
  
-   For the second version of this function, this handle can be **NULL** only when the **RGN_COPY** mode is specified.  
  
 `nMode`  
 Specifies the operation to be performed. It must be one of the following values:  
  
-   **RGN_AND** The new clipping region combines the overlapping areas of the current clipping region and the region identified by `pRgn`.  
  
-   **RGN_COPY** The new clipping region is a copy of the region identified by `pRgn`. This is functionality is identical to the first version of `SelectClipRgn`. If the region identified by `pRgn` is **NULL**, the new clipping region becomes the default clipping region (a null region).  
  
-   **RGN_DIFF** The new clipping region combines the areas of the current clipping region with those areas excluded from the region identified by `pRgn`.  
  
-   **RGN_OR** The new clipping region combines the current clipping region and the region identified by `pRgn`.  
  
-   **RGN_XOR** The new clipping region combines the current clipping region and the region identified by `pRgn` but excludes any overlapping areas.  
  
## Return Value  
 The region's type. It can be any of the following values:  
  
-   **COMPLEXREGION** New clipping region has overlapping borders.  
  
-   **ERROR** Device context or region is not valid.  
  
-   **NULLREGION** New clipping region is empty.  
  
-   **SIMPLEREGION** New clipping region has no overlapping borders.  
  
## Remarks  
 Only a copy of the selected region is used. The region itself can be selected for any number of other device contexts, or it can be deleted.  
  
 The function assumes that the coordinates for the given region are specified in device units. Some printer devices support text output at a higher resolution than graphics output in order to retain the precision needed to express text metrics. These devices report device units at the higher resolution, that is, in text units. These devices then scale coordinates for graphics so that several reported device units map to only 1 graphic unit. You should always call the `SelectClipRgn` function using text units.  
  
 Applications that must take the scaling of graphics objects in the GDI can use the **GETSCALINGFACTOR** printer escape to determine the scaling factor. This scaling factor affects clipping. If a region is used to clip graphics, GDI divides the coordinates by the scaling factor. If the region is used to clip text, GDI makes no scaling adjustment. A scaling factor of 1 causes the coordinates to be divided by 2; a scaling factor of 2 causes the coordinates to be divided by 4; and so on.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetClipBox](../vs140/cdc--getclipbox.md)   
 [CDC::Escape](../vs140/cdc--escape.md)   
 [CRgn Class](../vs140/crgn-class.md)   
 [SelectClipRgn](http://msdn.microsoft.com/library/windows/desktop/dd162955)