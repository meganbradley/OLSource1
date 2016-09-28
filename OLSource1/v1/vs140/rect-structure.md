---
title: "RECT Structure"
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
  - "LPRECT"
  - "RECT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RECT structure"
  - "LPRECT structure"
ms.assetid: 1b3160de-64e9-40d1-89eb-af3e0fd6acf0
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# RECT Structure
The `RECT` structure defines the coordinates of the upper-left and lower-right corners of a rectangle.  
  
## Syntax  
  
```  
  
      typedef struct tagRECT {   
   LONG left;  
   LONG top;  
   LONG right;  
   LONG bottom;  
} RECT;  
```  
  
## Members  
 `left`  
 Specifies the x-coordinate of the upper-left corner of a rectangle.  
  
 `top`  
 Specifies the y-coordinate of the upper-left corner of a rectangle.  
  
 `right`  
 Specifies the x-coordinate of the lower-right corner of a rectangle.  
  
 `bottom`  
 Specifies the y-coordinate of the lower-right corner of a rectangle.  
  
## Example  
 [!code[NVC_MFC_Utilities#38](../vs140/codesnippet/CPP/rect-structure_1.cpp)]  
  
## Requirements  
 **Header:** windef.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CRect Class](../vs140/crect-class.md)