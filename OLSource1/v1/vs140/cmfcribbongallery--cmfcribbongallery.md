---
title: "CMFCRibbonGallery::CMFCRibbonGallery"
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
  - "CMFCRibbonGallery"
  - "CMFCRibbonGallery.CMFCRibbonGallery"
  - "CMFCRibbonGallery::CMFCRibbonGallery"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonGallery class, constructor"
ms.assetid: a3e6cb44-5752-4e9d-8c30-bd3102eb6060
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::CMFCRibbonGallery
Constructs and initializes a [CMFCRibbonGallery](../vs140/cmfcribbongallery-class.md) object.  
  
## Syntax  
  
```  
CMFCRibbonGallery (  
    UINT nID,  
    LPCTSTR lpszText,  
    int nSmallImageIndex,  
    int nLargeImageIndex,  
    CMFCToolBarImages& imagesPalette   
);  
CMFCRibbonGallery (  
    UINT nID,  
    LPCTSTR lpszText,  
    int nSmallImageIndex,  
    int nLargeImageIndex,  
    UINT uiImagesPaletteResID=0,  
    int cxPaletteImage=0   
);  
CMFCRibbonGallery (  
    UINT nID,  
    LPCTSTR lpszText,  
    int nSmallImageIndex,  
    int nLargeImageIndex,  
    CSize sizeIcon,  
    int nIconsNum,  
    BOOL bDefaultButtonStyle=TRUE   
);  
```  
  
#### Parameters  
 `nID`  
 Specifies the command ID of the command to execute when a user clicks the button.  
  
 `lpszText`  
 Specifies the text to appear on the button.  
  
 `nSmallImageIndex`  
 The zero-based index of the small image to appear on the button.  
  
 `nLargeImageIndex`  
 The zero-based index of the large image to appear on the button.  
  
 `imagesPalette`  
 A reference to the [CMFCToolBarImages](../vs140/cmfctoolbarimages-class.md) object that contains the images to appear on the gallery.  
  
 `uiImagesPaletteResID`  
 The resource ID of the list of images to display on the gallery.  
  
 `cxPaletteImage`  
 Specifies the width, in pixels, of the image on the gallery.  
  
 `sizeIcon`  
 Specifies the size, in pixels, of the gallery image.  
  
 `nIconsNum`  
 Specifies the number of icons in the gallery.  
  
 `bDefaultButtonStyle`  
 Specifies whether to use the default or the owner-drawn button style.  
  
## Remarks  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)