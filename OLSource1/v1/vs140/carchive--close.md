---
title: "CArchive::Close"
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
  - "CArchive::Close"
  - "CArchive.Close"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Close method"
  - "CArchive class, destructor"
ms.assetid: ff893d39-ccf9-4478-a5bd-6bb9101adfd8
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CArchive::Close
Flushes any data remaining in the buffer, closes the archive, and disconnects the archive from the file.  
  
## Syntax  
  
```  
  
void Close( );  
```  
  
## Remarks  
 No further operations on the archive are permitted. After you close an archive, you can create another archive for the same file or you can close the file.  
  
 The member function **Close** ensures that all data is transferred from the archive to the file, and it makes the archive unavailable. To complete the transfer from the file to the storage medium, you must first use [CFile::Close](../vs140/cfile--close.md) and then destroy the `CFile` object.  
  
## Example  
 See the example for [CArchive::WriteString](../vs140/carchive--writestring.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CArchive Class](../vs140/carchive-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CArchive::Flush](../vs140/carchive--flush.md)   
 [CArchive::Abort](../vs140/carchive--abort.md)