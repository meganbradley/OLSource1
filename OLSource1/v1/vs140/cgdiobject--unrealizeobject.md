---
title: "CGdiObject::UnrealizeObject"
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
  - "CGdiObject::UnrealizeObject"
  - "CGdiObject.UnrealizeObject"
  - "UnrealizeObject"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unrealizeobject method"
  - "CGdiObject class, operations"
ms.assetid: 5f15d627-2e8a-4ecc-aba3-a1e830bff8d2
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::UnrealizeObject
Resets the origin of a brush or resets a logical palette.  
  
## Syntax  
  
```  
  
BOOL UnrealizeObject( );  
```  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 While `UnrealizeObject` is a member function of the `CGdiObject` class, it should be invoked only on `CBrush` or `CPalette` objects.  
  
 For `CBrush` objects, `UnrealizeObject` directs the system to reset the origin of the given brush the next time it is selected into a device context. If the object is a `CPalette` object, `UnrealizeObject` directs the system to realize the palette as though it had not previously been realized. The next time the application calls the [CDC::RealizePalette](../vs140/cdc--realizepalette.md) function for the specified palette, the system completely remaps the logical palette to the system palette.  
  
 The `UnrealizeObject` function should not be used with stock objects. The `UnrealizeObject` function must be called whenever a new brush origin is set (by means of the [CDC::SetBrushOrg](../vs140/cdc--setbrushorg.md) function). The `UnrealizeObject` function must not be called for the currently selected brush or currently selected palette of any display context.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::RealizePalette](../vs140/cdc--realizepalette.md)   
 [CDC::SetBrushOrg](../vs140/cdc--setbrushorg.md)