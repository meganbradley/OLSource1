---
title: "CAtlTemporaryFile::UnlockRange"
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
  - "UnlockRange"
  - "CAtlTemporaryFile::UnlockRange"
  - "CAtlTemporaryFile.UnlockRange"
  - "ATL.CAtlTemporaryFile.UnlockRange"
  - "ATL::CAtlTemporaryFile::UnlockRange"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnlockRange method"
ms.assetid: 052c9b4d-ef57-4e36-b60c-b6829aac82d1
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::UnlockRange
Call this method to unlock a region of the temporary file.  
  
## Syntax  
  
```  
  
      HRESULT UnlockRange(  
   ULONGLONG nPos,  
   ULONGLONG nCount   
) throw( );  
```  
  
#### Parameters  
 `nPos`  
 The position in the file where the unlock should begin.  
  
 `nCount`  
 The length of the byte range to be unlocked.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [CAtlFile::UnlockRange](../vs140/catlfile--unlockrange.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::LockRange](../vs140/catltemporaryfile--lockrange.md)