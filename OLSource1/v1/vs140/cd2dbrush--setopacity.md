---
title: "CD2DBrush::SetOpacity"
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
  - "afxrendertarget/CD2DBrush::SetOpacity"
  - "SetOpacity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetOpacity method"
ms.assetid: 34d596cb-a918-4288-b2ac-f31842e37d93
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBrush::SetOpacity
Sets the degree of opacity of this brush  
  
## Syntax  
  
```  
void SetOpacity(  
   FLOAT opacity  
);  
```  
  
#### Parameters  
 `opacity`  
 A value between zero and 1 that indicates the opacity of the brush. This value is a constant multiplier that linearly scales the alpha value of all pixels filled by the brush. The opacity values are clamped in the range 0 to 1 before they are multiplied together  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBrush Class](../vs140/cd2dbrush-class.md)