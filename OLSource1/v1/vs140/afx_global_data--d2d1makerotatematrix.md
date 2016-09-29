---
title: "AFX_GLOBAL_DATA::D2D1MakeRotateMatrix"
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
  - "D2D1MakeRotateMatrix"
  - "afxglobals/AFX_GLOBAL_DATA::D2D1MakeRotateMatrix"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "D2D1MakeRotateMatrix method"
ms.assetid: 6e6a6337-bd06-41f9-8d64-d81c85dd1450
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::D2D1MakeRotateMatrix
Creates a rotation transformation that rotates by a specified angle around a specified point.  
  
## Syntax  
  
```  
HRESULT D2D1MakeRotateMatrix(  
   FLOAT angle,  
   D2D1_POINT_2F center,  
   D2D1_MATRIX_3X2_F *matrix  
);  
```  
  
#### Parameters  
 `angle`  
 The clockwise rotation angle, in degrees.  
  
 `center`  
 The point about which to rotate.  
  
 `matrix`  
 When this method returns, contains the new rotation transformation. You must allocate storage for this parameter.  
  
## Return Value  
 Returns S_OK if successful, or an error value otherwise.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)