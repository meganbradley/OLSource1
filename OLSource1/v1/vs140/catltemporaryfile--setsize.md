---
title: "CAtlTemporaryFile::SetSize"
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
  - "ATL::CAtlTemporaryFile::SetSize"
  - "ATL.CAtlTemporaryFile.SetSize"
  - "CAtlTemporaryFile::SetSize"
  - "CAtlTemporaryFile.SetSize"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetSize method"
ms.assetid: 0b866546-7493-4ce5-aea1-7f475fa8ad05
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlTemporaryFile::SetSize
Call this method to set the size of the temporary file.  
  
## Syntax  
  
```  
  
      HRESULT SetSize(  
   ULONGLONG nNewLen   
) throw( );  
```  
  
#### Parameters  
 `nNewLen`  
 The new length of the file in bytes.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [CAtlFile::SetSize](../vs140/catlfile--setsize.md). On return, the file pointer is positioned at the end of the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlTemporaryFile Class](../vs140/catltemporaryfile-class.md)   
 [CAtlTemporaryFile::GetSize](../vs140/catltemporaryfile--getsize.md)