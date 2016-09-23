---
title: "CRenderTarget::SetTextRenderingParams"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - SetTextRenderingParams
  - afxrendertarget/CRenderTarget::SetTextRenderingParams
dev_langs: 
  - C++
helpviewer_keywords: 
  - SetTextRenderingParams method
ms.assetid: 96adaad0-6ce6-40f6-8af5-b6055a570b2e
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CRenderTarget::SetTextRenderingParams
Specifies text rendering options to be applied to all subsequent text and glyph drawing operations.  
  
## Syntax  
  
```  
void SetTextRenderingParams(  
   IDWriteRenderingParams* textRenderingParams = NULL  
);  
```  
  
#### Parameters  
 `textRenderingParams`  
 The text rendering options to be applied to all subsequent text and glyph drawing operations; NULL to clear current text rendering options.  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CRenderTarget Class](../vs140/crendertarget-class.md)