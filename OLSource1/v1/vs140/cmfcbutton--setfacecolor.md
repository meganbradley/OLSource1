---
title: "CMFCButton::SetFaceColor"
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
  - "CMFCButton.SetFaceColor"
  - "CMFCButton::SetFaceColor"
  - "SetFaceColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetFaceColor method"
ms.assetid: 68c9a77f-8da9-4c6f-86a3-727b73483be3
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::SetFaceColor
Sets the background color for the button text.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to redraw the screen immediately; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 Use this method to define a new fill color for the button background (face). Note that the background is not filled when the [CMFCButton::m_bTransparent](../vs140/cmfcbutton--m_btransparent.md) member variable is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)