---
title: "CEdit::LineLength"
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
  - CEdit.LineLength
  - CEdit::LineLength
dev_langs: 
  - C++
helpviewer_keywords: 
  - CEdit class, general operations
  - LineLength method
ms.assetid: 426a7d9e-5571-409f-bc0e-5ba35b9a26c9
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CEdit::LineLength
Retrieves the length of a line in an edit control.  
  
## Syntax  
  
```  
int LineLength(  
   int nLine = -1   
) const;  
```  
  
#### Parameters  
 `nLine`  
 The zero-based index of a character in the line whose length is to be retrieved. The default value is -1.  
  
## Return Value  
 For single-line edit controls, the return value is the length, in `TCHAR`s, of the text in the edit control.  
  
 For multiline edit controls, the return value is the length, in `TCHAR`s, of the line specified by the `nLine` parameter. For [!INCLUDE[vcpransi](../vs140/includes/vcpransi_md.md)] text, the length is the number of bytes in the line; for Unicode text, the length is the number of characters in the line. The length does not include the carriage-return character at the end of the line.  
  
 If the `nLine` parameter is more than the number of characters in the control, the return value is zero.  
  
 If the `nLine` parameter is –1, the return value is the number of unselected characters in the lines that contain selected characters. For example, if the selection extends from the fourth character of one line through the eighth character from the end of the next line, the return value is 10. That is, three characters on the first line and seven on the next.  
  
 For more information about the `TCHAR` type, see the `TCHAR` row in the table in [Windows Data Types](http://msdn.microsoft.com/library/windows/desktop/aa383751).  
  
## Remarks  
 This method is supported by the [EM_LINELENGTH](http://msdn.microsoft.com/library/windows/desktop/bb761613) message, which is described in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CEdit::LineIndex](../vs140/cedit--lineindex.md).  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CEdit Class](../vs140/cedit-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CEdit::LineIndex](../vs140/cedit--lineindex.md)   
 [EM_LINELENGTH](http://msdn.microsoft.com/library/windows/desktop/bb761613)