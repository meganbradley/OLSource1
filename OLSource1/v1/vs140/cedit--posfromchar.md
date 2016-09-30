---
title: "CEdit::PosFromChar"
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
  - "PosFromChar"
  - "CEdit.PosFromChar"
  - "CEdit::PosFromChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PosFromChar method"
ms.assetid: 38763d66-3e04-4085-806f-0d78ef32ffa2
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::PosFromChar
Call this function to get the position (top-left corner) of a given character within this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The zero-based index of the specified character.  
  
## Return Value  
 The coordinates of the top-left corner of the character specified by <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Remarks  
 The character is specified by giving its zero-based index value. If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is greater than the index of the last character in this <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, the return value specifies the coordinates of the character position just past the last character in this <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
> [!NOTE]
>  This member function is available beginning with Windows 95 and Windows NT 4.0.  
  
 For more information, see [EM_POSFROMCHAR](http://msdn.microsoft.com/library/windows/desktop/bb761631) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::LineFromChar](../vs140/cedit--linefromchar.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::CharFromPos](../vs140/cedit--charfrompos.md)