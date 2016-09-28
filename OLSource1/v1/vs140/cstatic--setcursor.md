---
title: "CStatic::SetCursor"
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
  - "CStatic.SetCursor"
  - "CStatic::SetCursor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CStatic class, operations"
  - "SetCursor method"
ms.assetid: 43c20087-4e2c-4d40-aa8d-492dc96ddfff
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStatic::SetCursor
Associates a new cursor image with the static control.  
  
## Syntax  
  
```  
  
      HCURSOR SetCursor(  
   HCURSOR hCursor   
);  
```  
  
#### Parameters  
 `hCursor`  
 Handle of the cursor to be drawn in the static control.  
  
## Return Value  
 The handle of the cursor previously associated with the static control, or **NULL** if no cursor was associated with the static control.  
  
## Remarks  
 The cursor will be automatically drawn in the static control. By default, it will be drawn in the upper-left corner and the static control will be resized to the size of the cursor.  
  
 You can use various window and static control styles, including the following:  
  
-   **SS_ICON** Use this style always for cursors and icons.  
  
-   **SS_CENTERIMAGE** Use to center in the static control. If the image is larger than the static control, it will be clipped. If it is smaller than the static control, the empty space around the image will be filled with the background color of the static control.  
  
## Example  
 [!code[NVC_MFC_CStatic#4](../vs140/codesnippet/CPP/cstatic--setcursor_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CStatic Class](../vs140/cstatic-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStatic::GetCursor](../vs140/cstatic--getcursor.md)   
 [STM_SETIMAGE](http://msdn.microsoft.com/library/windows/desktop/bb760782)   
 [Cursors](http://msdn.microsoft.com/library/windows/desktop/ms646970)