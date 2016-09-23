---
title: "CAtlFileMappingBase::MapSharedMem"
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
  - CAtlFileMappingBase.MapSharedMem
  - MapSharedMem
  - ATL.CAtlFileMappingBase.MapSharedMem
  - ATL::CAtlFileMappingBase::MapSharedMem
  - CAtlFileMappingBase::MapSharedMem
dev_langs: 
  - C++
helpviewer_keywords: 
  - MapSharedMem method
ms.assetid: e5bc5578-8b1f-4a02-9a49-20f0c0336200
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFileMappingBase::MapSharedMem
Call this method to create a file-mapping object that permits full access to all processes.  
  
## Syntax  
  
```  
  
      HRESULT MapSharedMem(  
   SIZE_T nMappingSize,  
   LPCTSTR szName,  
   BOOL* pbAlreadyExisted = NULL,  
   LPSECURITY_ATTRIBUTES lpsa = NULL,  
   DWORD dwMappingProtection = PAGE_READWRITE,  
   DWORD dwViewDesiredAccess = FILE_MAP_ALL_ACCESS   
) throw( );  
```  
  
#### Parameters  
 `nMappingSize`  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file-mapping object identified by `szName.`  
  
 `szName`  
 The name of the mapping object.  
  
 *pbAlreadyExisted*  
 Points to a BOOL value that is set to TRUE if the mapping object already existed.  
  
 `lpsa`  
 The pointer to a **SECURITY_ATTRIBUTES** structure that determines whether the returned handle can be inherited by child processes. See *lpAttributes* in [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwMappingProtection`  
 The protection desired for the file view, when the file is mapped. See `flProtect` in **CreateFileMapping** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwViewDesiredAccess`  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See `dwDesiredAccess` in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 **MapShareMem** allows an existing file-mapping object, created by [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537), to be shared between processes.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)