---
title: "CArchive::ReadString"
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
  - "CArchive.ReadString"
  - "CArchive::ReadString"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReadString method"
ms.assetid: 5d06747a-1194-4a0c-bd1a-36bc0ed500f7
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::ReadString
Call this member function to read text data into a buffer from the file associated with the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a [CString](../vs140/cstringt-class.md) that will contain the resultant string after it is read from the file associated with the CArchive object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 Specifies a pointer to a user-supplied buffer that will receive a null-terminated text string.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the maximum number of characters to read. Should be one less than the size of the *lpsz* buffer.  
  
## Return Value  
 In the version that returns **BOOL**, **TRUE** if successful; **FALSE** otherwise.  
  
 In the version that returns an <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, a pointer to the buffer containing the text data; **NULL** if end-of-file was reached.  
  
## Remarks  
 In the version of the member function with the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter, the buffer will hold up to a limit of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> - 1 characters. Reading is stopped by a carriage return-linefeed pair. Trailing newline characters are always removed. A null character ('\0') is appended in either case.  
  
 [CArchive::Read](../vs140/carchive--read.md) is also available for text-mode input, but it does not terminate on a carriage return-linefeed pair.  
  
## Example  
 See the example for [CArchive::WriteString](../vs140/carchive--writestring.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Read](../vs140/carchive--read.md)   
 [CArchive::Write](../vs140/carchive--write.md)   
 [CArchive::WriteString](../vs140/carchive--writestring.md)   
 [CArchiveException Class](../vs140/carchiveexception-class.md)