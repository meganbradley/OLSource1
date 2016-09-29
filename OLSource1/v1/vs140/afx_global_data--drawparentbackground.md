---
title: "AFX_GLOBAL_DATA::DrawParentBackground"
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
  - "AFX_GLOBAL_DATA.DrawParentBackground"
  - "AFX_GLOBAL_DATA::DrawParentBackground"
  - "DrawParentBackground"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_GLOBAL_DATA::DrawParentBackground"
  - "DrawParentBackground method"
ms.assetid: 29b3c1bf-a3fc-47cd-94db-5371b9b3a031
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::DrawParentBackground
Draws the background of a control's parent in the specified area.  
  
## Syntax  
  
```  
BOOL DrawParentBackground(  
   CWnd* pWnd,   
   CDC* pDC,   
   LPRECT lpRect = NULL  
);  
```  
  
#### Parameters  
 [in] `pWnd`  
 Pointer to a control's window.  
  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `lpRect`  
 Pointer to a rectangle that bounds the area to draw. The default value is `NULL`.  
  
## Return Value  
 `TRUE` if this method is successful; otherwise, `FALSE`.  
  
## Requirements  
 **Header:**  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)