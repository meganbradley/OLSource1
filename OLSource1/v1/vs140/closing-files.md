---
title: "Closing Files"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MFC [C++], file operations"
  - "files [C++], closing"
ms.assetid: 8415a3a8-3c75-45b0-ac2a-d5385f49bdb3
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Closing Files
As usual in I/O operations, once you finish with a file, you must close it.  
  
#### To close a file  
  
1.  Use the **Close** member function. This function closes the file-system file and flushes buffers if necessary.  
  
 If you allocated the [CFile](../vs140/cfile-class.md) object on the frame (as in the example shown in [Opening Files](../vs140/opening-files.md)), the object will automatically be closed and then destroyed when it goes out of scope. Note that deleting the `CFile` object does not delete the physical file in the file system.  
  
## See Also  
 [Files](../vs140/files-in-mfc.md)