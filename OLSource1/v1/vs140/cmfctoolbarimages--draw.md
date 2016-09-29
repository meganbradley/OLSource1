---
title: "CMFCToolBarImages::Draw"
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
  - "CMFCToolBarImages::Draw"
  - "CMFCToolBarImages.Draw"
  - "Draw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Draw method"
ms.assetid: 657f78ea-8608-4ff8-9a03-4296c7e4e776
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCToolBarImages::Draw
Draws a single toolbar image.  
  
## Syntax  
  
```  
BOOL Draw(  
   CDC* pDC,  
   int x,  
   int y,  
   int iImageIndex,  
   BOOL bHilite=FALSE,  
   BOOL bDisabled=FALSE,  
   BOOL bIndeterminate=FALSE,  
   BOOL bShadow=FALSE,  
   BOOL bInactive=FALSE,  
   BYTE alphaSrc=255   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 A pointer to a device context.  
  
 [in] `x`  
 The X coordinate of the left side of the rectangle where the image is to be drawn.  
  
 [in] `y`  
 The Y coordinate of the top of the rectangle where the image is to be drawn.  
  
 [in] `iImageIndex`  
 The zero-based index of the image to be displayed.  
  
 [in] `bHilite`  
 `TRUE` if the image is to be highlighted; otherwise `FALSE`.  
  
 [in] `bDisabled`  
 `TRUE` if the image is to be drawn in the disabled style; otherwise `FALSE`.  
  
 [in] `bIndeterminate`  
 `TRUE` if the image is to be drawn in the indeterminate state style; otherwise `FALSE`.  
  
 [in] `bShadow`  
 `TRUE` if the image is to be drawn with a drop shadow; otherwise `FALSE`.  
  
 [in] `bInactive`  
 `TRUE` if the image is to be drawn in the inactive state style; otherwise `FALSE`.  
  
 [in] `alphaSrc`  
 The alpha channel (opacity) value. A value of 255 means the image is drawn opaque. A value of 0 means the image is drawn transparent. This value is used only for 32 bit color images and for images that displayed a Windows Vista glass style.  
  
## Return Value  
 `TRUE` if the specified image was displayed successfully; `FALSE` if the image index was invalid or some other error occurred.  
  
## Requirements  
 **Header:** afxtoolbarimages.h  
  
## See Also  
 [CMFCToolBarImages Class](../vs140/cmfctoolbarimages-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)