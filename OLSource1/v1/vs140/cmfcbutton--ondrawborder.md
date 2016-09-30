---
title: "CMFCButton::OnDrawBorder"
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
  - "CMFCButton::OnDrawBorder"
  - "CMFCButton.OnDrawBorder"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDrawBorder method"
ms.assetid: f146e90c-85d6-42e5-87c1-0c5c2be7b71e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::OnDrawBorder
Called by the framework to draw the border of a button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 [in] <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A pointer to a device context.  
  
 [in] <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a rectangle that bounds the button.  
  
 [in] <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The current button state. For more information, see the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> member of the [DRAWITEMSTRUCT Structure](../vs140/drawitemstruct-structure.md) topic.  
  
## Remarks  
 Override this method to use your own code to draw the border.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)