---
title: "CFile::LockRange"
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
  - "CFile.LockRange"
  - "LockRange"
  - "CFile::LockRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockRange method"
  - "CFile class, locking"
ms.assetid: 2d7b0acf-7c0f-46d7-bdd5-9d915f68b19d
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CFile::LockRange
Locks a range of bytes in an open file, throwing an exception if the file is already locked.  
  
## Syntax  
  
```  
  
      virtual void LockRange(  
   ULONGLONG dwPos,  
   ULONGLONG dwCount   
);  
```  
  
#### Parameters  
 `dwPos`  
 The byte offset of the start of the byte range to lock.  
  
 `dwCount`  
 The number of bytes in the range to lock.  
  
## Remarks  
 Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed.  
  
 When you unlock the region, using the `UnlockRange` member function, the byte range must correspond exactly to the region that was previously locked. The `LockRange` function does not merge adjacent regions; if two locked regions are adjacent, you must unlock each region separately.  
  
> [!NOTE]
>  This function is not available for the `CMemFile`-derived class.  
  
## Example  
 [!code[NVC_MFCFiles#12](../vs140/codesnippet/CPP/cfile--lockrange_1.cpp)]  
  
## Requirements  
 **Header:** afx.h  
  
## See Also  
 [CFile Class](../vs140/cfile-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)   
 [CFile::UnlockRange](../vs140/cfile--unlockrange.md)