---
title: "CMFCColorButton::OnDrawBorder"
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
  - "OnDrawBorder"
  - "CMFCColorButton.OnDrawBorder"
  - "CMFCColorButton::OnDrawBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawBorder method"
ms.assetid: 37036a42-8589-4076-8d3f-1a53d476fb10
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCColorButton::OnDrawBorder
Called by the framework to display the border of the button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Points to the device context used to draw the border.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A rectangle in the device context that is specified by the the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> parameter that defines the boundaries of the button to be drawn.  
  
 [in] <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the visual state of the button.  
  
## Remarks  
 Override this function to customize the color button's border appearance.  
  
## Requirements  
 **Header:** afxcolorbutton.h  
  
## See Also  
 [CMFCColorButton Class](../vs140/cmfccolorbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)