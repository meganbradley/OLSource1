---
title: "NCCALCSIZE_PARAMS Structure"
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
  - "NCCALCSIZE_PARAMS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "NCCALCSIZE_PARAMS structure"
ms.assetid: 3424cd9f-806a-4089-82fb-414187589edf
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# NCCALCSIZE_PARAMS Structure
The `NCCALCSIZE_PARAMS` structure contains information that an application can use while processing the `WM_NCCALCSIZE` message to calculate the size, position, and valid contents of the client area of a window.  
  
## Syntax  
  
```  
  
      typedef struct tagNCCALCSIZE_PARAMS {  
   RECT rgrc[3];  
   PWINDOWPOS lppos;  
} NCCALCSIZE_PARAMS;  
```  
  
#### Parameters  
 *rgrc*  
 Specifies an array of rectangles. The first contains the new coordinates of a window that has been moved or resized. The second contains the coordinates of the window before it was moved or resized. The third contains the coordinates of the client area of a window before it was moved or resized. If the window is a child window, the coordinates are relative to the client area of the parent window. If the window is a top-level window, the coordinates are relative to the screen.  
  
 *lppos*  
 Points to a [WINDOWPOS](../vs140/windowpos-structure.md) structure that contains the size and position values specified in the operation that caused the window to be moved or resized.  
  
## Requirements  
 **Header:** winuser.h  
  
## See Also  
 [Structures, Styles, Callbacks, and Message Maps](../vs140/structures--styles--callbacks--and-message-maps.md)   
 [CWnd::OnNcCalcSize](../vs140/cwnd--onnccalcsize.md)