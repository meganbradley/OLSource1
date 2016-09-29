---
title: "CEdit::LineFromChar"
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
  - "LineFromChar"
  - "CEdit::LineFromChar"
  - "CEdit.LineFromChar"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LineFromChar method"
  - "CEdit class, general operations"
ms.assetid: fb96702a-17a8-43b0-ab47-8f5e5b60ac78
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::LineFromChar
Call this function to retrieve the line number of the line that contains the specified character index.  
  
## Syntax  
  
```  
  
      int LineFromChar(  
   int nIndex = -1   
) const;  
```  
  
#### Parameters  
 `nIndex`  
 Contains the zero-based index value for the desired character in the text of the edit control, or contains –1. If `nIndex` is –1, it specifies the current line, that is, the line that contains the caret.  
  
## Return Value  
 The zero-based line number of the line containing the character index specified by `nIndex`. If `nIndex` is –1, the number of the line that contains the first character of the selection is returned. If there is no selection, the current line number is returned.  
  
## Remarks  
 A character index is the number of characters from the beginning of the edit control.  
  
 This member function is only used by multiple-line edit controls.  
  
 For more information, see [EM_LINEFROMCHAR](http://msdn.microsoft.com/library/windows/desktop/bb761609) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#18](../vs140/codesnippet/CPP/cedit--linefromchar_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::LineIndex](../vs140/cedit--lineindex.md)