---
title: "POINT Structure"
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
  - "POINT"
  - "LPPOINT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LPPOINT structure"
  - "POINT structure"
ms.assetid: 965736d8-4e53-41b6-9b8b-6961992dd21f
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# POINT Structure
The **POINT** structure defines the x*-* and y-coordinates of a point.  
  
## Syntax  
  
```  
  
      typedef struct tagPOINT {  
   LONG x;  
   LONG y;  
} POINT;  
```  
  
#### Parameters  
 *x*  
 Specifies the x-coordinate of a point.  
  
 *y*  
 Specifies the y-coordinate of a point.  
  
## Example  
 [!code[NVC_MFC_Utilities#37](../VS_csharp/codesnippet/CPP/point-structure_1.cpp)]  
  
## Requirements  
 **Header:** windef.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../VS_csharp/structures--styles--callbacks--and-message-maps.md)   
 [CPoint Class](../VS_csharp/cpoint-class.md)