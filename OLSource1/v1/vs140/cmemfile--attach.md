---
title: "CMemFile::Attach"
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
  - CMemFile::Attach
  - CMemFile.Attach
dev_langs: 
  - C++
helpviewer_keywords: 
  - CMemFile class, operations
  - Attach method [MFC]
ms.assetid: f55436fb-6765-44dc-90e4-71b736503540
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CMemFile::Attach
Call this function to attach a block of memory to `CMemFile`.  
  
## Syntax  
  
```  
  
      void Attach(  
   BYTE* lpBuffer,  
   UINT nBufferSize,  
   UINT nGrowBytes = 0   
);  
```  
  
#### Parameters  
 `lpBuffer`  
 Pointer to the buffer to be attached to `CMemFile`.  
  
 `nBufferSize`  
 An integer that specifies the size of the buffer in bytes.  
  
 `nGrowBytes`  
 The memory allocation increment in bytes.  
  
## Remarks  
 This causes `CMemFile` to use the block of memory as the memory file.  
  
 If `nGrowBytes` is 0, `CMemFile` will set the file length to `nBufferSize`. This means that the data in the memory block before it was attached to `CMemFile` will be used as the file. Memory files created in this manner cannot be grown.  
  
 Since the file cannot be grown, be careful not to cause `CMemFile` to attempt to grow the file. For example, don't call the `CMemFile` overrides of [CFile:Write](../vs140/cfile--write.md) to write past the end or don't call [CFile:SetLength](../vs140/cfile--setlength.md) with a length longer than `nBufferSize`.  
  
 If `nGrowBytes` is greater than 0, `CMemFile` will ignore the contents of the memory block you've attached. You'll have to write the contents of the memory file from scratch using the `CMemFile` override of `CFile::Write`. If you attempt to write past the end of the file or grow the file by calling the `CMemFile` override of `CFile::SetLength`, `CMemFile` will grow the memory allocation in increments of `nGrowBytes`. Growing the memory allocation will fail if the memory block you pass to **Attach** wasn't allocated with a method compatible with [Alloc](../vs140/cmemfile--alloc.md). To be compatible with the default implementation of `Alloc`, you must allocate the memory with the run-time library function [malloc](../vs140/malloc.md) or [calloc](../vs140/calloc.md).  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CMemFile Class](../vs140/cmemfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CMemFile::CMemFile](../vs140/cmemfile--cmemfile.md)   
 [CMemFile::Detach](../vs140/cmemfile--detach.md)   
 [CMemFile::Alloc](../vs140/cmemfile--alloc.md)   
 [CFile::Write](../vs140/cfile--write.md)   
 [CFile::SetLength](../vs140/cfile--setlength.md)