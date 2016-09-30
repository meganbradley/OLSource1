---
title: "CFile::SetStatus"
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
  - "CFile.SetStatus"
  - "CFile::SetStatus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetStatus method"
  - "CFile class, static"
ms.assetid: 1e761e25-d4c0-44d7-8720-3664a54154cf
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::SetStatus
Sets the status of the file associated with this file location.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A string that is the path to the desired file. The path can be relative or absolute, and can contain a network name.  
  
 *status*  
 The buffer containing the new status information. Call the **GetStatus** member function to prefill the **CFileStatus** structure with current values, then make changes as required. If a value is 0, then the corresponding status item is not updated. See the [GetStatus](../vs140/cfile--getstatus.md) member function for a description of the **CFileStatus** structure.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 To set the time, modify the **m_mtime** field of *status*.  
  
 Please note that when you make a call to <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in an attempt to change only the attributes of the file, and the **m_mtime** member of the file status structure is nonzero, the attributes may also be affected (changing the time stamp may have side effects on the attributes). If you want to only change the attributes of the file, first set the **m_mtime** member of the file status structure to zero and then make a call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
 [!code[NVC_MFCFiles#21](../vs140/codesnippet/CPP/cfile--setstatus_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::GetStatus](../vs140/cfile--getstatus.md)