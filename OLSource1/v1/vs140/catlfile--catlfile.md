---
title: "CAtlFile::CAtlFile"
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
  - "ATL::CAtlFile::CAtlFile"
  - "CAtlFile::CAtlFile"
  - "CAtlFile.CAtlFile"
  - "ATL.CAtlFile.CAtlFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CAtlFile class, constructor"
  - "CAtlFile constructor"
ms.assetid: 02aa72e8-cbd1-42a2-974e-59af43e08a5f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::CAtlFile
The constructor.  
  
## Syntax  
  
```  
  
      CAtlFile( ) throw( );   
CAtlFile(  
   CAtlTransactionManager* pTM = NULL  
) throw( );  
CAtlFile(  
   CAtlFile& file   
) throw( );  
explicit CAtlFile(  
   HANDLE hFile   
) throw( );  
```  
  
#### Parameters  
 `file`  
 The file object.  
  
 `hFile`  
 The file handle.  
  
 `pTM`  
 Pointer to CAtlTransactionManager object  
  
## Remarks  
 The copy constructor transfers ownership of the file handle from the original `CAtlFile` object to the newly constructed object.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)