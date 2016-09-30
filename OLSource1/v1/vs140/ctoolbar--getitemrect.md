---
title: "CToolBar::GetItemRect"
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
  - "CToolBar::GetItemRect"
  - "CToolBar.GetItemRect"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetItemRect method [MFC]"
  - "CToolBar class, attributes"
  - "toolbars [C++], attributes"
ms.assetid: 865bed6a-3520-47b9-8902-da9daa7f5df9
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CToolBar::GetItemRect
This member function fills the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure whose address is contained in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> with the coordinates of the button or separator specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Index of the item (button or separator) whose rectangle coordinates are to be retrieved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Address of the [RECT](../vs140/rect-structure.md) structure that will contain the item's coordinates.  
  
## Remarks  
 Coordinates are in pixels relative to the upper-left corner of the toolbar.  
  
 Use <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to get the coordinates of a separator you want to replace with a combo box or other control.  
  
## Example  
 See the example for [CToolBar::SetSizes](../vs140/ctoolbar--setsizes.md).  
  
## Requirements  
 **Header:** afxext.h  
  
## See Also  
 [CToolBar Class](../vs140/ctoolbar-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CToolBar::CommandToIndex](../vs140/ctoolbar--commandtoindex.md)