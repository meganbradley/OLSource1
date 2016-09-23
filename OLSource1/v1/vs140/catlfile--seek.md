---
title: "CAtlFile::Seek"
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
  - CAtlFile::Seek
  - FILE_BEGIN
  - FILE_END
  - FILE_CURRENT
  - ATL.CAtlFile.Seek
  - CAtlFile.Seek
  - ATL::CAtlFile::Seek
dev_langs: 
  - C++
helpviewer_keywords: 
  - FILE_BEGIN
  - FILE_END
  - Seek method
  - FILE_CURRENT
ms.assetid: 801bef22-1226-4511-819d-345d7de1dfdc
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFile::Seek
Call this method to move the file pointer of the file.  
  
## Syntax  
  
```  
  
      HRESULT Seek(  
   LONGLONG nOffset,  
   DWORD dwFrom = FILE_CURRENT  
) throw( );  
```  
  
#### Parameters  
 `nOffset`  
 The offset from the starting point given by `dwFrom`.  
  
 `dwFrom`  
 The starting point (FILE_BEGIN, FILE_CURRENT, or FILE_END).  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) to move the file pointer.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)