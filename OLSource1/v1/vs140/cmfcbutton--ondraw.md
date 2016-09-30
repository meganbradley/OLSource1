---
title: "CMFCButton::OnDraw"
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
  - "OnDraw"
  - "CMFCButton::OnDraw"
  - "CMFCButton.OnDraw"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OnDraw method"
ms.assetid: 41e5b88c-7008-40c2-8f0a-a68c4fc35f6f
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCButton::OnDraw
Called by the framework to draw a button.  
  
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
 Override this method to use your own code to draw a button.  
  
## Requirements  
 **Header:** afxbutton.h  
  
## See Also  
 [CMFCButton Class](../vs140/cmfcbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)