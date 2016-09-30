---
title: "CMFCDynamicLayout::AddItem"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "C++"
ms.assetid: d094e709-68fa-4f52-b183-736cc4e35d8e
caps.latest.revision: 9
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMFCDynamicLayout::AddItem
Adds a child window, typically a control, to the list of windows that are controlled by the dynamic layout manager.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The handle to the window to add.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The ID of the child control to add.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A structure that describes how the control should be moved as the window size changes.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A structure that describes how the control should be resized as the window size changes.  
  
## Return Value  
 TRUE if the item was added successfully; otherwise FALSE.  
  
## Remarks  
 The position and size of a child control is changed dynamically when a hosting window is being resized.  
  
## Requirements  
 **Header:** afxlayout.h  
  
## See Also  
 [CMFCDynamicLayout Class](../vs140/cmfcdynamiclayout-class.md)   
 [CMFCDynamicLayout::MoveSettings Structure](../vs140/cmfcdynamiclayout--movesettings-structure.md)   
 [CMFCDynamicLayout::SizeSettings Structure](../vs140/cmfcdynamiclayout--sizesettings-structure.md)