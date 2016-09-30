---
title: "COleIPFrameWndEx::OnTearOffMenu"
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
  - "OnTearOffMenu"
  - "COleIPFrameWndEx::OnTearOffMenu"
  - "COleIPFrameWndEx.OnTearOffMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnTearOffMenu method"
ms.assetid: 99919c1c-89dc-4ab5-80a3-cb11a12f6183
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COleIPFrameWndEx::OnTearOffMenu
Called by the framework when the user selects a menu that has a tear-off bar.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to the pop-up menu that the user selected.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A pointer to the pane that hosts the menu.  
  
## Return Value  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> if you want the framework to activate the pop-up menu; otherwise <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The default value is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Override this function if you want to customize the setup of the tear-off bar.  
  
## Requirements  
 **Header:** afxoleipframewndex.h  
  
## See Also  
 [COleIPFrameWndEx Class](../vs140/coleipframewndex-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)