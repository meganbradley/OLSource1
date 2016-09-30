---
title: "CListBox::GetTextLen"
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
  - "CListBox.GetTextLen"
  - "GetTextLen"
  - "CListBox::GetTextLen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetTextLen method"
  - "CListBox class, general operations"
ms.assetid: 6b4451bc-4acb-4523-9bee-c46e8979a304
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CListBox::GetTextLen
Gets the length of a string in a list-box item.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Specifies the zero-based index of the string.  
  
## Return Value  
 The length of the string in characters, excluding the terminating null character. If <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> does not specify a valid index, the return value is **LB_ERR**.  
  
## Example  
 See the example for [CListBox::GetText](../vs140/clistbox--gettext.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CListBox Class](../vs140/clistbox-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CListBox::GetText](../vs140/clistbox--gettext.md)   
 [LB_GETTEXTLEN](http://msdn.microsoft.com/library/windows/desktop/bb761315)