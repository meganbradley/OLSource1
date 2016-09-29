---
title: "CRenderTarget::SaveDrawingState"
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
  - "SaveDrawingState"
  - "afxrendertarget/CRenderTarget::SaveDrawingState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveDrawingState method"
ms.assetid: 526e94f7-4e1e-480f-a152-fdd9fe06d948
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRenderTarget::SaveDrawingState
Saves the current drawing state to the specified ID2D1DrawingStateBlock.  
  
## Syntax  
  
```  
void SaveDrawingState(  
   ID2D1DrawingStateBlock& drawingStateBlock  
) const;  
```  
  
#### Parameters  
 `drawingStateBlock`  
 When this method returns, contains the current drawing state of the render target. This parameter must be initialized before passing it to the method.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)