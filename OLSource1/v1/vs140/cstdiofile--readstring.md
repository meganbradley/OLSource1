---
title: "CStdioFile::ReadString"
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
  - "CStdioFile::ReadString"
  - "CStdioFile.ReadString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data [MFC], reading"
  - "reading data [C++]"
  - "text [C++], reading"
  - "ReadString method"
  - "data [MFC]"
  - "CStdioFile class, text read/write"
ms.assetid: 3380de82-8c28-4e8a-b24b-d5d9a94d4b2d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CStdioFile::ReadString
Reads text data into a buffer, up to a limit of `nMax`–1 characters, from the file associated with the `CStdioFile` object.  
  
## Syntax  
  
```  
  
      virtual LPTSTR ReadString(  
   LPTSTR lpsz,  
   UINT nMax   
);  
virtual BOOL ReadString(  
   CString& rString  
);  
```  
  
#### Parameters  
 `lpsz`  
 Specifies a pointer to a user-supplied buffer that will receive a null-terminated text string.  
  
 `nMax`  
 Specifies the maximum number of characters to read, not counting the terminating null character.  
  
 `rString`  
 A reference to a `CString` object that will contain the string when the function returns.  
  
## Return Value  
 A pointer to the buffer containing the text data. **NULL** if end-of-file was reached without reading any data; or if boolean, **FALSE** if end-of-file was reached without reading any data.  
  
## Remarks  
 Reading is stopped by the first newline character. If, in that case, fewer than `nMax`–1 characters have been read, a newline character is stored in the buffer. A null character ('\0') is appended in either case.  
  
 [CFile::Read](../vs140/cfile--read.md) is also available for text-mode input, but it does not terminate on a carriage return–linefeed pair.  
  
> [!NOTE]
>  The `CString` version of this function removes the `'\n'` if present; the `LPTSTR` version does not.  
  
## Example  
 [!code[NVC_MFCFiles#38](../vs140/codesnippet/CPP/cstdiofile--readstring_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CStdioFile Class](../vs140/cstdiofile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CStdioFile::WriteString](../vs140/cstdiofile--writestring.md)   
 [CFile::Read](../vs140/cfile--read.md)