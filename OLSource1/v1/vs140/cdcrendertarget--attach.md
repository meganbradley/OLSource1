---
title: "CDCRenderTarget::Attach"
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
  - "Attach"
  - "afxrendertarget/CDCRenderTarget::Attach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Attach method"
ms.assetid: e09f2586-b6ec-446a-b01a-641f4285afc0
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDCRenderTarget::Attach
Attaches existing render target interface to the object  
  
## Syntax  
  
```  
void Attach(  
   ID2D1DCRenderTarget* pTarget  
);  
```  
  
#### Parameters  
 `pTarget`  
 Existing render target interface. Cannot be NULL  
  
## Requirements  
 **Header:** afxrendertarget.h  
  
## See Also  
 [CDCRenderTarget Class](../vs140/cdcrendertarget-class.md)