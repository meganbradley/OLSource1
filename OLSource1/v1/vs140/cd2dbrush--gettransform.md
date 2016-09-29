---
title: "CD2DBrush::GetTransform"
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
  - "afxrendertarget/CD2DBrush::GetTransform"
  - "GetTransform"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTransform method"
ms.assetid: 4b8cf14f-b3a7-4900-9c8f-952fdcf42371
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CD2DBrush::GetTransform
Gets the current transform of the render target  
  
## Syntax  
  
```  
void GetTransform(  
   D2D1_MATRIX_3X2_F *transform  
) const;  
```  
  
#### Parameters  
 `transform`  
 When this returns, contains the current transform of the render target. This parameter is passed uninitialized  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CD2DBrush Class](../vs140/cd2dbrush-class.md)