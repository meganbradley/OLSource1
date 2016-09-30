---
title: "CAtlTemporaryFile::LockRange"
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
  - "CAtlTemporaryFile.LockRange"
  - "ATL::CAtlTemporaryFile::LockRange"
  - "CAtlTemporaryFile::LockRange"
  - "LockRange"
  - "ATL.CAtlTemporaryFile.LockRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LockRange method"
ms.assetid: e69a5442-f712-4150-9dcf-a0d29c9f02d1
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::LockRange
Call this method to lock a region in the temporary file to prevent other processes from accessing it.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position in the file where the lock should begin.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The length of the byte range to be locked.  
  
## Return Value  
 Returns <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 Locking bytes in a file prevents access to those bytes by other processes. You can lock more than one region of a file, but no overlapping regions are allowed. To successfully unlock a region, use [CAtlTemporaryFile::UnlockRange](../vs140/catltemporaryfile--unlockrange.md), ensuring the byte range corresponds exactly to the region that was previously locked. <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not merge adjacent regions; if two locked regions are adjacent, you must unlock each separately.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlFile::LockRange](../vs140/catlfile--lockrange.md)   
 [CAtlTemporaryFile::UnlockRange](../vs140/catltemporaryfile--unlockrange.md)