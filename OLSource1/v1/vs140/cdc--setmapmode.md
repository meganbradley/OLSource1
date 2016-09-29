---
title: "CDC::SetMapMode"
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
  - "MM_TEXT"
  - "CDC::SetMapMode"
  - "CDC.SetMapMode"
  - "MM_LOMETRIC"
  - "MM_ISOTROPIC"
  - "MM_TWIPS"
  - "MM_ANISOTROPIC"
  - "MM_LOENGLISH"
  - "MM_HIENGLISH"
  - "MM_HIMETRIC"
  - "SetMapMode"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MM_TEXT"
  - "CDC class, mapping functions"
  - "MM_TWIPS"
  - "MM_HIENGLISH"
  - "MM_ISOTROPIC"
  - "MM_LOENGLISH"
  - "MM_LOMETRIC"
  - "SetMapMode method"
  - "MM_ANISOTROPIC"
  - "MM_HIMETRIC"
ms.assetid: 3fbe6ca9-bc3f-4df3-b2cc-66c37e815ed5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetMapMode
Sets the mapping mode.  
  
## Syntax  
  
```  
  
      virtual int SetMapMode(  
   int nMapMode   
);  
```  
  
#### Parameters  
 `nMapMode`  
 Specifies the new mapping mode. It can be any one of the following values:  
  
-   `MM_ANISOTROPIC` Logical units are converted to arbitrary units with arbitrarily scaled axes. Setting the mapping mode to `MM_ANISOTROPIC` does not change the current window or viewport settings. To change the units, orientation, and scaling, call the [SetWindowExt](../vs140/cdc--setwindowext.md) and [SetViewportExt](../vs140/cdc--setviewportext.md) member functions.  
  
-   `MM_HIENGLISH` Each logical unit is converted to 0.001 inch. Positive x is to the right; positive y is up.  
  
-   `MM_HIMETRIC` Each logical unit is converted to 0.01 millimeter. Positive x is to the right; positive y is up.  
  
-   `MM_ISOTROPIC` Logical units are converted to arbitrary units with equally scaled axes; that is, 1 unit along the x-axis is equal to 1 unit along the y-axis. Use the `SetWindowExt` and `SetViewportExt` member functions to specify the desired units and the orientation of the axes. GDI makes adjustments as necessary to ensure that the x and y units remain the same size.  
  
-   `MM_LOENGLISH` Each logical unit is converted to 0.01 inch. Positive x is to the right; positive y is up.  
  
-   `MM_LOMETRIC` Each logical unit is converted to 0.1 millimeter. Positive x is to the right; positive y is up.  
  
-   `MM_TEXT` Each logical unit is converted to 1 device pixel. Positive x is to the right; positive y is down.  
  
-   `MM_TWIPS` Each logical unit is converted to 1/20 of a point. (Because a point is 1/72 inch, a twip is 1/1440 inch.) Positive x is to the right; positive y is up.  
  
## Return Value  
 The previous mapping mode.  
  
## Remarks  
 The mapping mode defines the unit of measure used to convert logical units to device units; it also defines the orientation of the device's x- and y-axes. GDI uses the mapping mode to convert logical coordinates into the appropriate device coordinates. The `MM_TEXT` mode allows applications to work in device pixels, where 1 unit is equal to 1 pixel. The physical size of a pixel varies from device to device.  
  
 The `MM_HIENGLISH`, `MM_HIMETRIC`, `MM_LOENGLISH`, `MM_LOMETRIC`, and `MM_TWIPS` modes are useful for applications that must draw in physically meaningful units (such as inches or millimeters). The `MM_ISOTROPIC` mode ensures a 1:1 aspect ratio, which is useful when it is important to preserve the exact shape of an image. The `MM_ANISOTROPIC` mode allows the x- and y-coordinates to be adjusted independently.  
  
> [!NOTE]
>  If you call [SetLayout](../vs140/cdc--setlayout.md) to change the DC (device context) to right-to-left layout, **SetLayout** automatically changes the mapping mode to `MM_ISOTROPIC`.  
  
## Example  
 See the example for [CView::OnPrepareDC](../vs140/cview--onpreparedc.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::SetViewportExt](../vs140/cdc--setviewportext.md)   
 [CDC::SetWindowExt](../vs140/cdc--setwindowext.md)   
 [SetMapMode](http://msdn.microsoft.com/library/windows/desktop/dd162980)