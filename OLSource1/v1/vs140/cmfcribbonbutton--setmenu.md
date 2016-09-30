---
title: "CMFCRibbonButton::SetMenu"
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
  - "CMFCRibbonButton.SetMenu"
  - "CMFCRibbonButton::SetMenu"
  - "SetMenu"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetMenu method"
ms.assetid: 253c08f1-5068-4e26-81df-f99dc9754270
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCRibbonButton::SetMenu
Assigns a pop-up menu to the ribbon button.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A handle to a Windows menu.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, the button can execute its default command; otherwise, the button displays a pop-up menu.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the menu is right-aligned. Otherwise, the menu is left-aligned.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 A menu resource ID.  
  
## Remarks  
 When the application assigns the menu to the button, the button displays an arrow on its right side. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the menu appears only when the user clicks the arrow. If the user clicks the button, its default command is executed. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the menu appears by clicking anywhere on the button.  
  
## Requirements  
 **Header:** afxribbonbutton.h  
  
## See Also  
 [CMFCRibbonButton Class](../vs140/cmfcribbonbutton-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)