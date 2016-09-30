---
title: "CColorDialog::SetCurrentColor"
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
  - "SetCurrentColor"
  - "CColorDialog::SetCurrentColor"
  - "CColorDialog.SetCurrentColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetCurrentColor method"
  - "CColorDialog class, operations"
ms.assetid: eb1cf2ca-2725-4bbc-94ee-eba6bb40ccf2
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CColorDialog::SetCurrentColor
Call this function after calling <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to force the current color selection to the color value specified in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An RGB color value.  
  
## Remarks  
 This function is called from within a message handler or <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. The dialog box will automatically update the user's selection based on the value of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> parameter.  
  
## Example  
 See the example for [CColorDialog::OnColorOK](../vs140/ccolordialog--oncolorok.md).  
  
## Requirements  
 **Header:** afxdlgs.h  
  
## See Also  
 [CColorDialog Class](../vs140/ccolordialog-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CColorDialog::GetColor](../vs140/ccolordialog--getcolor.md)   
 [CColorDialog::OnColorOK](../vs140/ccolordialog--oncolorok.md)