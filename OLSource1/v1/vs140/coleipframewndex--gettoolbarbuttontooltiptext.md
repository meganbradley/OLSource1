---
title: "COleIPFrameWndEx::GetToolbarButtonToolTipText"
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
  - "GetToolbarButtonToolTipText"
  - "COleIPFrameWndEx.GetToolbarButtonToolTipText"
  - "COleIPFrameWndEx::GetToolbarButtonToolTipText"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetToolbarButtonToolTipText method"
ms.assetid: 18c6bd81-dd72-479c-99fd-4f32921b0c19
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::GetToolbarButtonToolTipText
Called by the framework before the tooltip for a button is displayed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Pointer to the button.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to the tooltip text.  
  
## Return Value  
 The default implementation returns 0.  
  
## Remarks  
 Override this function to customize the display of tooltips on toolbar buttons.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)