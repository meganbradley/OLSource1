---
title: "CMDIFrameWndEx::OnDrawMenuImage"
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
  - "CMDIFrameWndEx::OnDrawMenuImage"
  - "OnDrawMenuImage"
  - "CMDIFrameWndEx.OnDrawMenuImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuImage method"
ms.assetid: 5c58e761-af1a-42e1-be75-81dd2ec6bc9c
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMDIFrameWndEx::OnDrawMenuImage
Called by the framework when the image associated with a menu item is drawn.  
  
## Syntax  
  
```  
virtual BOOL OnDrawMenuImage(  
   CDC* pDC,  
   const CMFCToolBarMenuButton* pMenuButton,  
   const CRect& rectImage   
);  
```  
  
#### Parameters  
 [in] `pDC`  
 Pointer to a device context.  
  
 [in] `pMenuButton`  
 Pointer to the menu button.  
  
 [in] `rectImage`  
 Bounding rectangle of the image.  
  
## Return Value  
 `TRUE` if the method draws the image. The default implementation returns `FALSE`.  
  
## Remarks  
 Override this method  if you want to customize image rendering for the menu items that belong to the menu bar owned by the `CMDIFrameWndEx`-derived object. The default implementation does nothing.  
  
## Requirements  
 **Header:** afxMDIFrameWndEx.h  
  
## See Also  
 [CMDIFrameWndEx Class](../vs140/cmdiframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)