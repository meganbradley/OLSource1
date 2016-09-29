---
title: "CAtlFile::GetPosition"
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
  - "ATL.CAtlFile.GetPosition"
  - "ATL::CAtlFile::GetPosition"
  - "CAtlFile::GetPosition"
  - "CAtlFile.GetPosition"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetPosition method"
ms.assetid: 12bfa66c-0086-4c18-b877-0f407739ab33
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::GetPosition
Call this method to get the current file pointer position.  
  
## Syntax  
  
```  
  
      HRESULT GetPosition(  
   ULONGLONG& nPos  
) const throw( );  
```  
  
#### Parameters  
 `nPos`  
 The position in bytes.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [SetFilePointer](http://msdn.microsoft.com/library/windows/desktop/aa365541) to get the current file pointer position.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)   
 [CAtlFile::GetSize](../vs140/catlfile--getsize.md)