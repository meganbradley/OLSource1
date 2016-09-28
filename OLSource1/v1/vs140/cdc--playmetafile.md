---
title: "CDC::PlayMetaFile"
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
  - "CDC.PlayMetaFile"
  - "PlayMetaFile"
  - "CDC::PlayMetaFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PlayMetaFile method"
  - "CDC class, metafile functions"
ms.assetid: e5e3d13a-20e9-4186-b5eb-0257558d45a7
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDC::PlayMetaFile
Plays the contents of the specified metafile on the device context.  
  
## Syntax  
  
```  
  
      BOOL PlayMetaFile(  
   HMETAFILE hMF   
);  
BOOL PlayMetaFile(  
   HENHMETAFILE hEnhMetaFile,  
   LPCRECT lpBounds   
);  
```  
  
#### Parameters  
 *hMF*  
 Identifies the metafile to be played.  
  
 *hEnhMetaFile*  
 Identifies the enhanced metafile.  
  
 `lpBounds`  
 Points to a `RECT` structure or a `CRect` object that contains the coordinates of the bounding rectangle used to display the picture. The coordinates are specified in logical units.  
  
## Return Value  
 Nonzero if the function is successful; otherwise 0.  
  
## Remarks  
 The metafile can be played any number of times.  
  
 The second version of `PlayMetaFile` displays the picture stored in the given enhanced-format metafile. When an application calls the second version of `PlayMetaFile`, Windows uses the picture frame in the enhanced-metafile header to map the picture onto the rectangle pointed to by the `lpBounds` parameter. (This picture may be sheared or rotated by setting the world transform in the output device before calling `PlayMetaFile`.) Points along the edges of the rectangle are included in the picture. An enhanced-metafile picture can be clipped by defining the clipping region in the output device before playing the enhanced metafile.  
  
 If an enhanced metafile contains an optional palette, an application can achieve consistent colors by setting up a color palette on the output device before calling the second version of `PlayMetaFile`. To retrieve the optional palette, use the **GetEnhMetaFilePaletteEntries** Windows function. An enhanced metafile can be embedded in a newly created enhanced metafile by calling the second version of `PlayMetaFile` and playing the source enhanced metafile into the device context for the new enhanced metafile.  
  
 The states of the output device context are preserved by this function. Any object created but not deleted in the enhanced metafile is deleted by this function. To stop this function, an application can call the **CancelDC** Windows function from another thread to terminate the operation. In this case, the function returns zero.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDC Class](../vs140/cdc-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CancelDC](http://msdn.microsoft.com/library/windows/desktop/dd183399)   
 [GetEnhMetaFileHeader](http://msdn.microsoft.com/library/windows/desktop/dd144883)   
 [GetEnhMetaFilePaletteEntries](http://msdn.microsoft.com/library/windows/desktop/dd144884)   
 [SetWorldTransform](http://msdn.microsoft.com/library/windows/desktop/dd145104)   
 [PlayMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd162802)   
 [PlayEnhMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd162800)   
 [PlayMetaFile](http://msdn.microsoft.com/library/windows/desktop/dd162802)