---
title: "CFile::GetStatus"
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
  - "CFile.GetStatus"
  - "CFile::GetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CFileStatus structure"
  - "GetStatus method"
  - "CFile class, static"
ms.assetid: 1b0d6bbf-8468-4801-8953-292f099fde68
caps.latest.revision: 20
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::GetStatus
This method retrieves status information related to a given <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object instance or a given file path.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A reference to a user-supplied **CFileStatus** structure that will receive the status information. The **CFileStatus** structure has the following fields:  
  
-   **CTime m_ctime** The date and time the file was created.  
  
-   **CTime m_mtime** The date and time the file was last modified.  
  
-   **CTime m_atime** The date and time the file was last accessed for reading.  
  
-   **ULONGLONG m_size** The logical size of the file in bytes, as reported by the DIR command.  
  
-   **BYTE m_attribute** The attribute byte of the file.  
  
-   **char m_szFullName[_MAX_PATH]** The absolute filename in the Windows character set.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A string in the Windows character set that is the path to the desired file. The path can be relative or absolute, or it can contain a network path name.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
## Return Value  
 **TRUE** if the status information for the specified file is successfully obtained; otherwise, **FALSE**.  
  
## Remarks  
 The non-static version of **GetStatus** retrieves status information of the open file associated with the given <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  The static version of **GetStatus** obtains the file status from a given file path without actually opening the file. This is useful for testing the existence and access rights of a file.  
  
 The **m_attribute** member of the **CFileStatus** structure refers to the file attribute set. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class provides the **Attribute** enumeration type so file attributes can be specified symbolically:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Example  
 [!code[NVC_MFCFiles#10](../vs140/codesnippet/CPP/cfile--getstatus_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::SetStatus](../vs140/cfile--setstatus.md)   
 [CTime Class](../vs140/ctime-class.md)