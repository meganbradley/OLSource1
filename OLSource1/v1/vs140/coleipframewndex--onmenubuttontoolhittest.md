---
title: "COleIPFrameWndEx::OnMenuButtonToolHitTest"
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
  - "OnMenuButtonToolHitTest"
  - "COleIPFrameWndEx.OnMenuButtonToolHitTest"
  - "COleIPFrameWndEx::OnMenuButtonToolHitTest"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnMenuButtonToolHitTest method"
ms.assetid: 282bf76b-9e4d-4e9d-b596-a7dd59e8bbf4
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::OnMenuButtonToolHitTest
Called by the framework when a [CMFCToolBarButton](../vs140/cmfctoolbarbutton-class.md)object processes a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] pButton  
 Pointer to a menu button.  
  
 [out] pTI  
 Pointer to a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure.  
  
## Return Value  
 The default implementation does nothing and returns 0. Your implementation should return a non-zero value if it fills the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter.  
  
## Remarks  
 Override this method to provide ToolTip information about a specific menu item.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)