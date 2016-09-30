---
title: "Path-File access error"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Path/File access error"
f1_keywords: 
  - "vbrID75"
dev_langs: 
  - "VB"
ms.assetid: 6ce3a161-7316-46bd-a785-0d50e5414020
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Path-File access error
During a file-access or disk-access operation, the operating system could not make a connection between the path and the file name.  
  
### To correct this error  
  
1.  Make sure the file specification is correctly formatted. A file name can contain a fully qualified (absolute) or relative path. A fully qualified path starts with the drive name (if the path is on another drive) and lists the explicit path from the root to the file. Any path that is not fully qualified is relative to the current drive and directory.  
  
2.  Make sure that you did not attempt to save a file that would replace an existing read-only file. If this is the case, change the read-only attribute of the target file, or save the file with a different file name.  
  
3.  Make sure you did not attempt to open a read-only file in sequential<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> mode. If this is the case, open the file in <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> mode or change the read-only attribute of the file.  
  
4.  Make sure you did not attempt to change a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project within a database or document.  
  
## See Also  
 [Types of Errors](../vs140/error-types--visual-basic-.md)