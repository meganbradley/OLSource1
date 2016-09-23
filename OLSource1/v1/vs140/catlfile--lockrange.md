---
title: "CAtlFile::LockRange"
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
  - ATL.CAtlFile.LockRange
  - CAtlFile.LockRange
  - LockRange
  - ATL::CAtlFile::LockRange
  - CAtlFile::LockRange
dev_langs: 
  - C++
helpviewer_keywords: 
  - LockRange method
ms.assetid: 568cb76a-657f-45dd-be14-2b066b988fd4
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFile::LockRange
Call this method to lock a region in the file to prevent other processes from accessing it.  
  
## Syntax  
  
```  
  
      HRESULT LockRange(  
   ULONGLONG nPos,  
   ULONGLONG nCount   
) throw( );  
```  
  
#### Parameters  
 `nPos`  
 The position in the file where the lock should begin.  
  
 `nCount`  
 The length of the byte range to be locked.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [LockFile](http://msdn.microsoft.com/library/windows/desktop/aa365202) to lock a region in the file. Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed. When you unlock a region, using [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md), the byte range must correspond exactly to the region that was previously locked. `LockRange` does not merge adjacent regions; if two locked regions are adjacent, you must unlock each separately.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md)