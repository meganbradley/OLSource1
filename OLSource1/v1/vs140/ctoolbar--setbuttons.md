---
title: "CToolBar::SetButtons"
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
  - "CToolBar::SetButtons"
  - "SetButtons"
  - "CToolBar.SetButtons"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "toolbar controls [MFC], command ID"
  - "CToolBar class, construction/destruction"
  - "command IDs, toolbar buttons"
  - "SetButtons method"
ms.assetid: 59a15aba-7b98-4653-a7af-a77d2c325f36
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::SetButtons
This member function sets each toolbar button's command ID to the value specified by the corresponding element of the array <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to an array of command Ids. It can be **NULL** to allocate empty buttons.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Number of elements in the array pointed to by <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
 If an element of the array has the value **ID_SEPARATOR**, a separator is created in the corresponding position of the toolbar. This function also sets each button's style to **TBBS_BUTTON** and each separator's style to **TBBS_SEPARATOR**, and assigns an image index to each button. The image index specifies the position of the button's image within the bitmap.  
  
 You do not need to account for separators in the bitmap because this function does not assign image indexes for separators. If your toolbar has buttons at positions 0, 1, and 3 and a separator at position 2, the images at positions 0, 1, and 2 in your bitmap are assigned to the buttons at positions 0, 1, and 3, respectively.  
  
 If <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is **NULL**, this function allocates space for the number of items specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Use [SetButtonInfo](../vs140/ctoolbar--setbuttoninfo.md) to set each item's attributes.  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::Create](../vs140/ctoolbar--create.md)   
 [CToolBar::SetButtonInfo](../vs140/ctoolbar--setbuttoninfo.md)   
 [CToolBar::SetButtonStyle](../vs140/ctoolbar--setbuttonstyle.md)   
 [CToolBar::LoadToolBar](../vs140/ctoolbar--loadtoolbar.md)