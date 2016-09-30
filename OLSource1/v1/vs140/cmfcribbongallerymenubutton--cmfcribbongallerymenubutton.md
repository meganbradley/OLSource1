---
title: "CMFCRibbonGalleryMenuButton::CMFCRibbonGalleryMenuButton"
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
  - "CMFCRibbonGalleryMenuButton"
  - "CMFCRibbonGalleryMenuButton::CMFCRibbonGalleryMenuButton"
  - "CMFCRibbonGalleryMenuButton.CMFCRibbonGalleryMenuButton"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMFCRibbonGalleryMenuButton class, constructor"
ms.assetid: b722c08b-1ece-41a0-91d4-29f706f09b43
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGalleryMenuButton::CMFCRibbonGalleryMenuButton
Constructs and initializes a [CMFCRibbonGalleryMenuButton](../vs140/cmfcribbongallerymenubutton-class.md) object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The command ID of the button. This is the value sent in the **WM_COMMAND** message when the user clicks this button.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The index of the image to display with the gallery menu button. The images are stored in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The text to display on the menu button.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Contains the list of images to display on the gallery.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The resource ID of the image list for the images to display on the gallery.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the width in pixels of the image to display on the gallery.  
  
## Remarks  
 The gallery menu button is displayed as a pop-up menu that has an arrow. When the user clicks this button, a gallery of images is displayed.  
  
## Example  
 The following example demonstrates how to use the constructor of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> class. This code snippet is part of the [MS Office 2007 Demo sample](../vs140/visual-c---samples.md).  
  
 [!code[NVC_MFC_MSOffice2007Demo#8](../vs140/codesnippet/CPP/cmfcribbongallerymenubutton--cmfcribbongallerymenubutton_1.cpp)]  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGalleryMenuButton Class](../vs140/cmfcribbongallerymenubutton-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)