---
title: "COleIPFrameWndEx::OnDrawMenuImage"
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
  - "COleIPFrameWndEx.OnDrawMenuImage"
  - "COleIPFrameWndEx::OnDrawMenuImage"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawMenuImage method"
ms.assetid: aaec10a5-5e66-4b1b-a4a4-3e0c55c14fcc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::OnDrawMenuImage
Called by the framework when the image that is associated with a menu item is drawn.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the menu button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The image associated with the menu item.  
  
## Return Value  
 The default implementation does nothing and returns 0.  
  
## Remarks  
 Override this method if you want to customize image drawing for the menu items that belong to the menu bar owned by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>-derived object.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)