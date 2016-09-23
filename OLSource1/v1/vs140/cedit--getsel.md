---
title: "CEdit::GetSel"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - CEdit::GetSel
  - CEdit.GetSel
dev_langs: 
  - C++
helpviewer_keywords: 
  - CEdit class, general operations
  - GetSel method
ms.assetid: 62059750-6ac6-47fb-8c17-46b082d14797
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEdit::GetSel
Call this function to get the starting and ending character positions of the current selection (if any) in an edit control, using either the return value or the parameters.  
  
## Syntax  
  
```  
  
      DWORD GetSel( ) const;  
void GetSel(  
   int& nStartChar,  
   int& nEndChar   
) const;  
```  
  
#### Parameters  
 `nStartChar`  
 Reference to an integer that will receive the position of the first character in the current selection.  
  
 `nEndChar`  
 Reference to an integer that will receive the position of the first nonselected character past the end of the current selection.  
  
## Return Value  
 The version that returns a `DWORD` returns a value that contains the starting position in the low-order word and the position of the first nonselected character after the end of the selection in the high-order word.  
  
## Remarks  
 For more information, see [EM_GETSEL](http://msdn.microsoft.com/library/windows/desktop/bb761598) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#15](../vs140/codesnippet/CPP/cedit--getsel_1.cpp)]
  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::SetSel](../vs140/cedit--setsel.md)