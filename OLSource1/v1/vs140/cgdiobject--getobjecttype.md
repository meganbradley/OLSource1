---
title: "CGdiObject::GetObjectType"
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
  - "CGdiObject.GetObjectType"
  - "CGdiObject::GetObjectType"
  - "GetObjectType"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetObjectType method"
  - "CGdiObject class, operations"
ms.assetid: 61a090bc-2ad6-4e59-a1f0-54f846b4047a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CGdiObject::GetObjectType
Retrieves the type of the GDI object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 The type of the object, if successful; otherwise 0. The value can be one of the following:  
  
-   **OBJ_BITMAP** Bitmap  
  
-   **OBJ_BRUSH** Brush  
  
-   **OBJ_FONT** Font  
  
-   **OBJ_PAL** Palette  
  
-   **OBJ_PEN** Pen  
  
-   **OBJ_EXTPEN** Extended pen  
  
-   **OBJ_REGION** Region  
  
-   **OBJ_DC** Device context  
  
-   **OBJ_MEMDC** Memory device context  
  
-   **OBJ_METAFILE** Metafile  
  
-   **OBJ_METADC** Metafile device context  
  
-   **OBJ_ENHMETAFILE** Enhanced metafile  
  
-   **OBJ_ENHMETADC** Enhanced-metafile device context  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CGdiObject Class](../vs140/cgdiobject-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CGdiObject::GetObject](../vs140/cgdiobject--getobject.md)   
 [CDC::SelectObject](../vs140/cdc--selectobject.md)