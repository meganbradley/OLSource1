---
title: "ABCFLOAT Structure"
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
  - "ABCFLOAT"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ABCFLOAT structure"
ms.assetid: 338e7e15-9d2c-42d0-aa80-273acfde5cc5
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ABCFLOAT Structure
The `ABCFLOAT` structure contains the A, B, and C widths of a font character.  
  
## Syntax  
  
```  
  
      typedef struct _ABCFLOAT { /* abcf */  
   FLOAT abcfA;  
   FLOAT abcfB;  
   FLOAT abcfC;  
} ABCFLOAT;  
```  
  
#### Parameters  
 *abcfA*  
 Specifies the A spacing of the character. The A spacing is the distance to add to the current position before drawing the character glyph.  
  
 *abcfB*  
 Specifies the B spacing of the character. The B spacing is the width of the drawn portion of the character glyph.  
  
 *abcfC*  
 Specifies the C spacing of the character. The C spacing is the distance to add to the current position to provide white space to the right of the character glyph.  
  
## Remarks  
 The A, B, and C widths are measured along the base line of the font. The character increment (total width) of a character is the sum of the A, B, and C spaces. Either the A or the C space can be negative to indicate underhangs or overhangs.  
  
## Requirements  
 **Header:** wingdi.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDC::GetCharABCWidths](../vs140/cdc--getcharabcwidths.md)