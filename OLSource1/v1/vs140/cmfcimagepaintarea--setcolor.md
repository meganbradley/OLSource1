---
title: "CMFCImagePaintArea::SetColor"
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
  - "SetColor"
  - "CMFCImagePaintArea::SetColor"
  - "CMFCImagePaintArea.SetColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColor method"
ms.assetid: 33d62a6a-fa26-4444-9d16-28834f104fa0
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCImagePaintArea::SetColor
Sets the current drawing color.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|[in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|The new drawing color.|  
  
## Remarks  
 When you select a color from the image editor palette bar or color picker, the framework calls this method to update the current drawing color. The initial drawing color is black (a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> value of 0).  
  
 The drawing color is used by the image editor dialog box for all drawing modes except for <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. For more information about drawing modes, see [CMFCImagePaintArea::IMAGE_EDIT_MODE Enumeration](../vs140/cmfcimagepaintarea--image_edit_mode-enumeration.md).  
  
## Requirements  
 **Header:** afximagepaintarea.h  
  
## See Also  
 [CMFCImagePaintArea Class](../vs140/cmfcimagepaintarea-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMFCImagePaintArea::IMAGE_EDIT_MODE Enumeration](../vs140/cmfcimagepaintarea--image_edit_mode-enumeration.md)   
 [CMFCImageEditorPaletteBar Class](../vs140/cmfcimageeditorpalettebar-class.md)   
 [CMFCImageEditorDialog Class](../vs140/cmfcimageeditordialog-class.md)