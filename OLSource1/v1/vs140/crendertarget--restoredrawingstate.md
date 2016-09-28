---
title: "CRenderTarget::RestoreDrawingState"
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
  - "RestoreDrawingState"
  - "afxrendertarget/CRenderTarget::RestoreDrawingState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RestoreDrawingState method"
ms.assetid: fbbcd094-bf7c-403e-ba4a-98d7b6ead2c1
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::RestoreDrawingState
Sets the render target's drawing state to that of the specified ID2D1DrawingStateBlock.  
  
## Syntax  
  
```  
void RestoreDrawingState(  
   ID2D1DrawingStateBlock& drawingStateBlock  
);  
```  
  
#### Parameters  
 `drawingStateBlock`  
 The new drawing state of the render target.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)