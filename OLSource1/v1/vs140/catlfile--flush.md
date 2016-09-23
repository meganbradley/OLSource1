---
title: "CAtlFile::Flush"
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
  - ATL::CAtlFile::Flush
  - CAtlFile::Flush
  - ATL.CAtlFile.Flush
  - CAtlFile.Flush
dev_langs: 
  - C++
helpviewer_keywords: 
  - Flush method
ms.assetid: 8dd6ec7a-0081-47cd-aa78-1a97cbb42784
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFile::Flush
Call this method to clear the buffers for the file and cause all buffered data to be written to the file.  
  
## Syntax  
  
```  
  
HRESULT Flush( ) throw( );  
  
```  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [FlushFileBuffers](http://msdn.microsoft.com/library/windows/desktop/aa364439) to flush buffered data to the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)