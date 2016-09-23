---
title: "CDC::SetROP2"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CDC::SetROP2
  - SetROP2
  - CDC.SetROP2
dev_langs: 
  - C++
helpviewer_keywords: 
  - CDC class, drawing-attribute functions
  - SetROP2 method
ms.assetid: dfd7a6c2-6c08-4fda-9466-fc783fcaaa00
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::SetROP2
Sets the current drawing mode.  
  
## Syntax  
  
```  
  
      int SetROP2(  
   int nDrawMode   
);  
```  
  
#### Parameters  
 `nDrawMode`  
 Specifies the new drawing mode. It can be any of the following values:  
  
-   **R2_BLACK** Pixel is always black.  
  
-   **R2_WHITE** Pixel is always white.  
  
-   **R2_NOP** Pixel remains unchanged.  
  
-   **R2_NOT** Pixel is the inverse of the screen color.  
  
-   **R2_COPYPEN** Pixel is the pen color.  
  
-   **R2_NOTCOPYPEN** Pixel is the inverse of the pen color.  
  
-   **R2_MERGEPENNOT** Pixel is a combination of the pen color and the inverse of the screen color (final pixel = (NOT screen pixel) OR pen).  
  
-   **R2_MASKPENNOT** Pixel is a combination of the colors common to both the pen and the inverse of the screen (final pixel = (NOT screen pixel) AND pen).  
  
-   **R2_MERGENOTPEN** Pixel is a combination of the screen color and the inverse of the pen color (final pixel = (NOT pen) OR screen pixel).  
  
-   **R2_MASKNOTPEN** Pixel is a combination of the colors common to both the screen and the inverse of the pen (final pixel = (NOT pen) AND screen pixel).  
  
-   **R2_MERGEPEN** Pixel is a combination of the pen color and the screen color (final pixel = pen OR screen pixel).  
  
-   **R2_NOTMERGEPEN** Pixel is the inverse of the **R2_MERGEPEN** color (final pixel = NOT(pen OR screen pixel)).  
  
-   **R2_MASKPEN** Pixel is a combination of the colors common to both the pen and the screen (final pixel = pen AND screen pixel).  
  
-   **R2_NOTMASKPEN** Pixel is the inverse of the **R2_MASKPEN** color (final pixel = NOT(pen AND screen pixel)).  
  
-   **R2_XORPEN** Pixel is a combination of the colors that are in the pen or in the screen, but not in both (final pixel = pen XOR screen pixel).  
  
-   **R2_NOTXORPEN** Pixel is the inverse of the **R2_XORPEN** color (final pixel = NOT(pen XOR screen pixel)).  
  
## Return Value  
 The previous drawing mode.  
  
 It can be any of the values given in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Remarks  
 The drawing mode specifies how the colors of the pen and the interior of filled objects are combined with the color already on the display surface.  
  
 The drawing mode is for raster devices only; it does not apply to vector devices. Drawing modes are binary raster-operation codes representing all possible Boolean combinations of two variables, using the binary operators AND, OR, and XOR (exclusive OR), and the unary operation NOT.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CDC::GetROP2](../vs140/cdc--getrop2.md)   
 [SetROP2](http://msdn.microsoft.com/library/windows/desktop/dd145088)