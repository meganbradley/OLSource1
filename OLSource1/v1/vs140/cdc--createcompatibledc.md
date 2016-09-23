---
title: "CDC::CreateCompatibleDC"
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
  - CreateCompatibleDC
  - CDC::CreateCompatibleDC
  - CDC.CreateCompatibleDC
dev_langs: 
  - C++
helpviewer_keywords: 
  - CreateCompatibleDC method
  - CDC class, initialization
ms.assetid: 3bf38d8a-bf02-4984-b2ba-23ecb64cbf49
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CDC::CreateCompatibleDC
Creates a memory device context that is compatible with the device specified by `pDC`.  
  
## Syntax  
  
```  
  
      BOOL CreateCompatibleDC(  
   CDC* pDC   
);  
```  
  
#### Parameters  
 `pDC`  
 A pointer to a device context. If `pDC` is **NULL**, the function creates a memory device context that is compatible with the system display.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 A memory device context is a block of memory that represents a display surface. It can be used to prepare images in memory before copying them to the actual device surface of the compatible device.  
  
 When a memory device context is created, GDI automatically selects a 1-by-1 monochrome stock bitmap for it. GDI output functions can be used with a memory device context only if a bitmap has been created and selected into that context.  
  
 This function can only be used to create compatible device contexts for devices that support raster operations. See the [CDC::BitBlt](../vs140/cdc--bitblt.md) member function for information regarding bit-block transfers between device contexts. To determine whether a device context supports raster operations, see the **RC_BITBLT** raster capability in the member function `CDC::GetDeviceCaps`.  
  
## Example  
 [!code[NVC_MFCDocView#32](../vs140/codesnippet/CPP/cdc--createcompatibledc_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CDC::CDC](../vs140/cdc--cdc.md)   
 [CDC::GetDeviceCaps](../vs140/cdc--getdevicecaps.md)   
 [CreateCompatibleDC](http://msdn.microsoft.com/library/windows/desktop/dd183489)   
 [CDC::BitBlt](../vs140/cdc--bitblt.md)   
 [CDC::CreateDC](../vs140/cdc--createdc.md)   
 [CDC::CreateIC](../vs140/cdc--createic.md)   
 [CDC::DeleteDC](../vs140/cdc--deletedc.md)