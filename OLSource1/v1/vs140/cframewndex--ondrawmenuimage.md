---
title: "CFrameWndEx::OnDrawMenuImage"
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
  - "OnDrawMenuImage"
  - "CFrameWndEx::OnDrawMenuImage"
  - "CFrameWndEx.OnDrawMenuImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuImage method"
ms.assetid: 50f4f13a-b38c-46b1-91c1-76b77a903d3a
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFrameWndEx::OnDrawMenuImage
Called by the framework when the application draws the image associated with a menu item.  
  
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
 A pointer to a device context.  
  
 [in] `pMenuButton`  
 A pointer to a menu button whose image is being rendered.  
  
 [in] `rectImage`  
 A pointer to a `Rect` structure that specifies the screen position and size of the image.  
  
## Return Value  
 `TRUE` if the framework successfully renders the image; `FALSE` otherwise.  
  
## Remarks  
 Override this method if you want to customize the image rendering for the menu items that belong to the menu bar owned by the `CFrameWndEx` derived object.  
  
## Requirements  
 **Header:** afxframewndex.h  
  
## See Also  
 [CFrameWndEx Class](../vs140/cframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)