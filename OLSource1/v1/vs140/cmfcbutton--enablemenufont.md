---
title: "CMFCButton::EnableMenuFont"
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
  - "CMFCButton::EnableMenuFont"
  - "EnableMenuFont"
  - "CMFCButton.EnableMenuFont"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableMenuFont method"
ms.assetid: 8bbd47be-2daa-47c2-9c35-a9440eaa7dcc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::EnableMenuFont
Specifies whether the button text font is the same as the application menu font.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to use the application menu font as the button text font; <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to use the system font. The default is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [in] <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to immediately redraw the screen; otherwise, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 If you do not use this method to specify the button text font, you can specify the font with the [CWnd::SetFont](../vs140/cwnd--setfont.md) method. If you do not specify a font at all, the framework sets a default font.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)