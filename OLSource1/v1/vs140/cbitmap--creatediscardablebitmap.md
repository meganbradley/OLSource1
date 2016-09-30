---
title: "CBitmap::CreateDiscardableBitmap"
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
  - "CreateDiscardableBitmap"
  - "CBitmap.CreateDiscardableBitmap"
  - "CBitmap::CreateDiscardableBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateDiscardableBitmap method"
ms.assetid: 66aefb6b-6a12-45ed-adc7-e93a55c086ed
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CBitmap::CreateDiscardableBitmap
Initializes a discardable bitmap that is compatible with the device context identified by `pDC`.  
  
## Syntax  
  
```  
  
      BOOL CreateDiscardableBitmap(  
   CDC* pDC,  
   int nWidth,  
   int nHeight   
);  
```  
  
#### Parameters  
 `pDC`  
 Specifies a device context.  
  
 `nWidth`  
 Specifies the width (in bits) of the bitmap.  
  
 `nHeight`  
 Specifies the height (in bits) of the bitmap.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 The bitmap has the same number of color planes or the same bits-per-pixel format as the specified device context. An application can select this bitmap as the current bitmap for a memory device that is compatible with the one specified by `pDC`.  
  
 Windows can discard a bitmap created by this function only if an application has not selected it into a display context. If Windows discards the bitmap when it is not selected and the application later attempts to select it, the [CDC::SelectObject](../vs140/cdc--selectobject.md) function will return **NULL**.  
  
 When you finish with the `CBitmap` object created with the `CreateDiscardableBitmap` function, first select the bitmap out of the device context, then delete the `CBitmap` object.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CBitmap Class](../vs140/cbitmap-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CreateDiscardableBitmap](http://msdn.microsoft.com/library/windows/desktop/dd183495)   
 [CGdiObject::DeleteObject](../vs140/cgdiobject--deleteobject.md)