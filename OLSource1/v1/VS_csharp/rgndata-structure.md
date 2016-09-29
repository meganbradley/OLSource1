---
title: "RGNDATA Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "RGNDATA"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RGNDATA structure"
ms.assetid: 72257c00-f440-4dca-979e-9b6b5b2d5f2f
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RGNDATA Structure
The `RGNDATA` structure contains a header and an array of rectangles that compose a region. These rectangles, sorted top to bottom left to right, do not overlap.  
  
## Syntax  
  
```  
  
      typedef struct _RGNDATA { /* rgnd */  
   RGNDATAHEADER rdh;  
   char Buffer[1];  
} RGNDATA;  
```  
  
#### Parameters  
 *rdh*  
 Specifies a [RGNDATAHEADER](http://msdn.microsoft.com/library/windows/desktop/dd162941) structure. (For more information on this structure, see the [!INCLUDE[winSDK](../VS_csharp/includes/winsdk_md.md)].) The members of this structure specify the type of region (whether it is rectangular or trapezoidal), the number of rectangles that make up the region, the size of the buffer that contains the rectangle structures, and so on.  
  
 `Buffer`  
 Specifies an arbitrary-size buffer that contains the [RECT](../VS_csharp/rect-structure.md) structures that make up the region.  
  
## Requirements  
 **Header:** wingdi.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../VS_csharp/structures--styles--callbacks--and-message-maps.md)   
 [CRgn::CreateFromData](../Topic/CRgn::CreateFromData.md)   
 [CRgn::GetRegionData](../Topic/CRgn::GetRegionData.md)