---
title: "CMFCRibbonGallery::OnDrawPaletteIcon"
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
  - "CMFCRibbonGallery::OnDrawPaletteIcon"
  - "OnDrawPaletteIcon"
  - "CMFCRibbonGallery.OnDrawPaletteIcon"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawPaletteIcon method"
ms.assetid: e71ed9e9-45dc-4118-91a6-74f120202213
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::OnDrawPaletteIcon
Called by the framework when a gallery icon is drawn.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the device context that is used for drawing.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the bounding rectangle of the icon to draw.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the zero-based index in the image list of gallery icons of the icon to draw.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A pointer to the icon being drawn.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the color for the text of the item to draw.  
  
## Remarks  
 You can override this method in a derived class to customize the appearance of a ribbon gallery.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)