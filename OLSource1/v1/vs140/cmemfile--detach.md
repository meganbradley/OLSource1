---
title: "CMemFile::Detach"
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
  - "CMemFile::Detach"
  - "CMemFile.Detach"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CMemFile class, operations"
  - "Detach method"
ms.assetid: 983a6786-356c-4318-9e04-48d4a432c90b
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CMemFile::Detach
Call this function to get a pointer to the memory block being used by `CMemFile`.  
  
## Syntax  
  
```  
  
BYTE * Detach( );  
  
```  
  
## Return Value  
 A pointer to the memory block that contains the contents of the memory file.  
  
## Remarks  
 Calling this function also closes the `CMemFile`. You can reattach the memory block to `CMemFile` by calling [Attach](../vs140/cmemfile--attach.md). If you want to reattach the file and use the data in it, you should call [CFile::GetLength](../vs140/cfile--getlength.md) to get the length of the file before calling **Detach**. Note that if you attach a memory block to `CMemFile` so that you can use its data (`nGrowBytes` == 0), then you won't be able to grow the memory file.  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::Attach](../vs140/cmemfile--attach.md)   
 [CFile::GetLength](../vs140/cfile--getlength.md)