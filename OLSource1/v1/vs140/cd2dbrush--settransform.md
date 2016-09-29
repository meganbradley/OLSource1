---
title: "CD2DBrush::SetTransform"
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
  - "afxrendertarget/CD2DBrush::SetTransform"
  - "SetTransform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetTransform method"
ms.assetid: 10955722-0ca8-497a-9b79-0e058e12474b
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBrush::SetTransform
Applies the specified transform to the render target, replacing the existing transformation. All subsequent drawing operations occur in the transformed space  
  
## Syntax  
  
```  
void SetTransform(  
   const D2D1_MATRIX_3X2_F *transform  
);  
```  
  
#### Parameters  
 `transform`  
 The transform to apply to the render target  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBrush Class](../vs140/cd2dbrush-class.md)