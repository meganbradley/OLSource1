---
title: "CEdit::GetLine"
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
  - "CEdit::GetLine"
  - "CEdit.GetLine"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetLine method"
  - "CEdit class, multiple-line operations"
ms.assetid: 56f1a1c3-7ee8-4378-ace5-e34992c58987
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CEdit::GetLine
Call this function to retrieve a line of text from an edit control and places it in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the line number to retrieve from a multiple-line edit control. Line numbers are zero-based; a value of 0 specifies the first line. This parameter is ignored by a single-line edit control.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Points to the buffer that receives a copy of the line. The first word of the buffer must specify the maximum number of characters that can be copied to the buffer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the maximum number of bytes that can be copied to the buffer. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> places this value in the first word of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> before making the call to Windows.  
  
## Return Value  
 The number of bytes actually copied. The return value is 0 if the line number specified by <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is greater than the number of lines in the edit control.  
  
## Remarks  
 The copied line does not contain a null-termination character.  
  
 For more information, see [EM_GETLINE](http://msdn.microsoft.com/library/windows/desktop/bb761584) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::GetLineCount](../vs140/cedit--getlinecount.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::LineLength](../vs140/cedit--linelength.md)   
 [CWnd::GetWindowText](../vs140/cwnd--getwindowtext.md)