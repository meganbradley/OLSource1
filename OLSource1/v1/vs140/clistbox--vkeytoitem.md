---
title: "CListBox::VKeyToItem"
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
  - "CListBox.VKeyToItem"
  - "VKeyToItem"
  - "CListBox::VKeyToItem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "VKeyToItem method"
  - "CListBox class, overridables"
ms.assetid: 49fcd057-8ce0-4342-a99d-e3d2512b7981
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::VKeyToItem
Called by the framework when the list box's parent window receives a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> message from the list box.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The virtual key code of the key the user pressed. For a list of of standard virtual key codes, see Winuser.h  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The current position of the list-box caret.  
  
## Return Value  
 Returns – 2 for no further action, – 1 for default action, or a nonnegative number to specify an index of a list box item on which to perform the default action for the keystroke.  
  
## Remarks  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> message is sent by the list box when it receives a <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> message, but only if the list box meets both of the following:  
  
-   Has the [LBS_WANTKEYBOARDINPUT](../vs140/list-box-styles.md) style set.  
  
-   Has at least one item.  
  
 You should never call this function yourself. Override this function to provide your own custom handling of keyboard messages.  
  
 You must return a value to tell the framework what action your override performed. A return value of – 2 indicates that the application handled all aspects of selecting the item and requires no further action by the list box. Before returning – 2, you could set the selection or move the caret or both. To set the selection, use [SetCurSel](../vs140/clistbox--setcursel.md) or [SetSel](../vs140/clistbox--setsel.md). To move the caret, use [SetCaretIndex](../vs140/clistbox--setcaretindex.md).  
  
 A return value of – 1 indicates that the list box should perform the default action in response to the keystroke.The default implementation returns – 1.  
  
 A return value of 0 or greater specifies the index of an item in the list box and indicates that the list box should perform the default action for the keystroke on the given item.  
  
## Example  
 [!code[NVC_MFC_CListBox#41](../vs140/codesnippet/CPP/clistbox--vkeytoitem_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::CharToItem](../vs140/clistbox--chartoitem.md)   
 [CListBox::SetCurSel](../vs140/clistbox--setcursel.md)   
 [CListBox::SetSel](../vs140/clistbox--setsel.md)   
 [CListBox::SetCaretIndex](../vs140/clistbox--setcaretindex.md)