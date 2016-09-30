---
title: "CEdit::Cut"
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
  - "CEdit.Cut"
  - "CEdit::Cut"
  - "Cut"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "Cut method"
ms.assetid: 237e5632-9328-4dbf-bbdd-7ef4af0cdf21
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Cut
Call this function to delete (cut) the current selection (if any) in the edit control and copy the deleted text to the Clipboard in **CF_TEXT** format.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The deletion performed by **Cut** can be undone by calling the [Undo](../vs140/cedit--undo.md) member function.  
  
 To delete the current selection without placing the deleted text into the Clipboard, call the [Clear](../vs140/cedit--clear.md) member function.  
  
 For more information, see [WM_CUT](http://msdn.microsoft.com/library/windows/desktop/ms649023) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#6](../vs140/codesnippet/CPP/cedit--cut_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::Undo](../vs140/cedit--undo.md)   
 [CEdit::Clear](../vs140/cedit--clear.md)   
 [CEdit::Copy](../vs140/cedit--copy.md)   
 [CEdit::Paste](../vs140/cedit--paste.md)