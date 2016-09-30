---
title: "CPalette::AnimatePalette"
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
  - "AnimatePalette"
  - "CPalette::AnimatePalette"
  - "CPalette.AnimatePalette"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AnimatePalette method"
  - "CPalette class, operations"
ms.assetid: 47fd4660-9144-4ce8-ac9f-91cb45c4a822
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CPalette::AnimatePalette
Replaces entries in the logical palette attached to the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the first entry in the palette to be animated.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies the number of entries in the palette to be animated.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Points to the first member of an array of [PALETTEENTRY](http://msdn.microsoft.com/library/windows/desktop/dd162769) structures to replace the palette entries identified by <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 When an application calls <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, it does not have to update its client area, because Windows maps the new entries into the system palette immediately.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> function will only change entries with the **PC_RESERVED** flag set in the corresponding **palPaletteEntry** member of the [LOGPALETTE](http://msdn.microsoft.com/library/windows/desktop/dd145040) structure that is attached to the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object. See **LOGPALETTE** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more information about this structure.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CPalette Class](../vs140/cpalette-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CPalette::CreatePalette](../vs140/cpalette--createpalette.md)   
 [AnimatePalette](http://msdn.microsoft.com/library/windows/desktop/dd183355)