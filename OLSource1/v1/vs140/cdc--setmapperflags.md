---
title: "CDC::SetMapperFlags"
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
  - "CDC::SetMapperFlags"
  - "CDC.SetMapperFlags"
  - "SetMapperFlags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMapperFlags method"
  - "CDC class, font functions"
ms.assetid: 56f71b79-06ce-4aca-b399-28b9c6f1252b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::SetMapperFlags
Changes the method used by the font mapper when it converts a logical font to a physical font.  
  
## Syntax  
  
```  
  
      DWORD SetMapperFlags(  
   DWORD dwFlag   
);  
```  
  
#### Parameters  
 `dwFlag`  
 Specifies whether the font mapper attempts to match a font's aspect height and width to the device. When this value is **ASPECT_FILTERING**, the mapper selects only fonts whose x-aspect and y-aspect exactly match those of the specified device.  
  
## Return Value  
 The previous value of the font-mapper flag.  
  
## Remarks  
 An application can use `SetMapperFlags` to cause the font mapper to attempt to choose only a physical font that exactly matches the aspect ratio of the specified device.  
  
 An application that uses only raster fonts can use the `SetMapperFlags` function to ensure that the font selected by the font mapper is attractive and readable on the specified device. Applications that use scalable (TrueType) fonts typically do not use `SetMapperFlags`.  
  
 If no physical font has an aspect ratio that matches the specification in the logical font, GDI chooses a new aspect ratio and selects a font that matches this new aspect ratio.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [SetMapperFlags](http://msdn.microsoft.com/library/windows/desktop/dd162981)