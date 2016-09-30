---
title: "CEdit::Clear"
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
  - "CEdit.Clear"
  - "CEdit::Clear"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CEdit class, general operations"
  - "Clear method"
ms.assetid: ec508beb-b9c5-4fe1-b7e2-10e6c27a802b
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::Clear
Call this function to delete (clear) the current selection (if any) in the edit control.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The deletion performed by **Clear** can be undone by calling the [Undo](../vs140/cedit--undo.md) member function.  
  
 To delete the current selection and place the deleted contents into the Clipboard, call the [Cut](../vs140/cedit--cut.md) member function.  
  
 For more information, see [WM_CLEAR](http://msdn.microsoft.com/library/windows/desktop/ms649020) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 [!code[NVC_MFC_CEdit#4](../vs140/codesnippet/CPP/cedit--clear_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::Undo](../vs140/cedit--undo.md)   
 [CEdit::Copy](../vs140/cedit--copy.md)   
 [CEdit::Cut](../vs140/cedit--cut.md)   
 [CEdit::Paste](../vs140/cedit--paste.md)