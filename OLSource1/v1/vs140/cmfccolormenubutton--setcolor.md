---
title: "CMFCColorMenuButton::SetColor"
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
  - "SetColor"
  - "CMFCColorMenuButton.SetColor"
  - "CMFCColorMenuButton::SetColor"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetColor method"
ms.assetid: 38d63196-6323-4c34-b1ba-9ae06673c88f
caps.latest.revision: 12
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorMenuButton::SetColor
Sets the color of the current color button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An RGB color value.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to apply the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> parameter color to any associated menu button or toolbar button; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 Call this method to change the color of the current color button. If the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter is nonzero, the color of the corresponding button on any associated popup menu or toolbar is changed to the color specified by the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> parameter.  
  
## Requirements  
 **Header:** afxcolormenubutton.h  
  
## See Also  
 [CMFCColorMenuButton Class](../vs140/cmfccolormenubutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [COLORREF](http://msdn.microsoft.com/library/windows/desktop/dd183449)