---
title: "CMFCToolBarImages::MirrorBitmap"
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
  - "CMFCToolBarImages.MirrorBitmap"
  - "MirrorBitmap"
  - "CMFCToolBarImages::MirrorBitmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MirrorBitmap method"
ms.assetid: 09214b90-4ec7-4df9-a3ce-e78e63547b14
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::MirrorBitmap
Replaces a bitmap with its horizontal mirror image.  
  
## Syntax  
  
```  
static BOOL MirrorBitmap(  
   HBITMAP& hbmp,  
   int cxImage   
);  
```  
  
#### Parameters  
 [in, out] `hbmp`  
 A handle to bitmap to mirror.  
  
 [in] `cxImage`  
 Width of the image in pixels.  
  
## Return Value  
 `TRUE` if the image was successfully mirrored; otherwise `FALSE`.  
  
## Remarks  
 This function is used to support right-to-left writing systems.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)