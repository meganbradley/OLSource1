---
title: "Callback Function for CDC::GrayString"
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
  - "Callback Function for CDC::GrayString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "callback functions, for CDC::GrayString"
ms.assetid: 5217e183-df48-426b-931b-6245022ca36f
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Callback Function for CDC::GrayString
*OutputFunc* is a placeholder for the application-supplied callback function name.  
  
## Syntax  
  
```  
  
      BOOL CALLBACK EXPORT OutputFunc(   
   HDC hDC,   
   LPARAM lpData,   
   int nCount    
);  
```  
  
#### Parameters  
 `hDC`  
 Identifies a memory device context with a bitmap of at least the width and height specified by `nWidth` and `nHeight` to `GrayString`.  
  
 `lpData`  
 Points to the character string to be drawn.  
  
 `nCount`  
 Specifies the number of characters to output.  
  
## Return Value  
 The callback function's return value must be **TRUE** to indicate success; otherwise it is **FALSE**.  
  
## Remarks  
 The callback function (*OutputFunc*) must draw an image relative to the coordinates (0,0) rather than (*x*, *y*).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CDC::GrayString](../vs140/cdc--graystring.md)