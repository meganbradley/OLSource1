---
title: "CAtlTemporaryFile::Seek"
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
  - CAtlTemporaryFile.Seek
  - CAtlTemporaryFile::Seek
  - ATL.CAtlTemporaryFile.Seek
  - ATL::CAtlTemporaryFile::Seek
dev_langs: 
  - C++
helpviewer_keywords: 
  - Seek method
ms.assetid: d08c6183-25b1-4175-ad73-458fc323f935
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlTemporaryFile::Seek
Call this method to move the file pointer of the temporary file.  
  
## Syntax  
  
```  
  
      HRESULT Seek(  
   LONGLONG nOffset,  
   DWORD dwFrom = FILE_CURRENT   
) throw( );  
```  
  
#### Parameters  
 `nOffset`  
 The offset, in bytes, from the starting point given by *dwFrom.*  
  
 `dwFrom`  
 The starting point (FILE_BEGIN, FILE_CURRENT, or FILE_END).  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [CAtlFile::Seek](../vs140/catlfile--seek.md). To obtain the current file pointer position, call [CAtlTemporaryFile::GetPosition](../vs140/catltemporaryfile--getposition.md).  
  
## Example  
 See the example for [CAtlTemporaryFile::CAtlTemporaryFile](../vs140/catltemporaryfile--catltemporaryfile.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::Read](../vs140/catltemporaryfile--read.md)