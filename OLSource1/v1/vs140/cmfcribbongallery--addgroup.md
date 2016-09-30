---
title: "CMFCRibbonGallery::AddGroup"
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
  - "AddGroup"
  - "CMFCRibbonGallery::AddGroup"
  - "CMFCRibbonGallery.AddGroup"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AddGroup method"
ms.assetid: 3f19b6bf-2b30-4576-bc87-ee0087b563b5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonGallery::AddGroup
Adds a new group to the gallery.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the name of the group.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the resource ID of the image list that contains the images for the group.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the width in pixels of an image.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A reference to image list that contains group images.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Specifies the number of icons in the group. This parameter should be specified only for custom (owner drawn) groups.  
  
## Remarks  
 You can divide the items on a ribbon gallery into multiple groups by calling this method. Each group can have a caption.  
  
## Requirements  
 **Header:** afxRibbonPaletteGallery.h  
  
## See Also  
 [CMFCRibbonGallery Class](../vs140/cmfcribbongallery-class.md)   
 [MFC Hierarchy Chart](../vs140/hierarchy-chart.md)