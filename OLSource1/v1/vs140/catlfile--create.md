---
title: "CAtlFile::Create"
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
  - "ATL.CAtlFile.Create"
  - "ATL::CAtlFile::Create"
  - "CAtlFile::Create"
  - "CAtlFile.Create"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Create method [C++]"
ms.assetid: d2bc9cc1-206f-45ca-824a-18b12122d6e4
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFile::Create
Call this method to create or open a file.  
  
## Syntax  
  
```  
  
      HRESULT Create(  
   LPCTSTR szFilename,  
   DWORD dwDesiredAccess,  
   DWORD dwShareMode,  
   DWORD dwCreationDisposition,  
   DWORD dwFlagsAndAttributes = FILE_ATTRIBUTE_NORMAL,  
   LPSECURITY_ATTRIBUTES lpsa = NULL,  
   HANDLE hTemplateFile = NULL   
) throw( );  
```  
  
#### Parameters  
 *szFilename*  
 The file name.  
  
 `dwDesiredAccess`  
 The desired access. See `dwDesiredAccess` in [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwShareMode`  
 The share mode. See `dwShareMode` in **CreateFile**.  
  
 `dwCreationDisposition`  
 The creation disposition. See `dwCreationDisposition` in **CreateFile**.  
  
 `dwFlagsAndAttributes`  
 The flags and attributes. See `dwFlagsAndAttributes` in **CreateFile**.  
  
 `lpsa`  
 The security attributes. See *lpSecurityAttributes* in **CreateFile**.  
  
 `hTemplateFile`  
 The template file. See `hTemplateFile` in **CreateFile**.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 Calls [CreateFile](http://msdn.microsoft.com/library/windows/desktop/aa363858) to create or open the file.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFile Class](../vs140/catlfile-class.md)