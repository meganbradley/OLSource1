---
title: "CAtlFileMappingBase::MapFile"
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
  - "CAtlFileMappingBase.MapFile"
  - "CAtlFileMappingBase::MapFile"
  - "ATL.CAtlFileMappingBase.MapFile"
  - "MapFile"
  - "ATL::CAtlFileMappingBase::MapFile"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapFile method"
ms.assetid: e4c39eef-c4a0-4697-82b1-d87e6431e1c6
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMappingBase::MapFile
Call this method to open or create a file-mapping object for the specified file.  
  
## Syntax  
  
```  
  
      HRESULT MapFile(  
   HANDLE hFile,  
   SIZE_T nMappingSize = 0,  
   ULONGLONG nOffset = 0,  
   DWORD dwMappingProtection = PAGE_READONLY,  
   DWORD dwViewDesiredAccess = FILE_MAP_READ   
) throw( );  
```  
  
#### Parameters  
 `hFile`  
 Handle to the file from which to create a mapping object. `hFile` must be valid and cannot be set to INVALID_HANDLE_VALUE.  
  
 `nMappingSize`  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file identified by *hFile.*  
  
 `nOffset`  
 The file offset where mapping is to begin. The offset value must be a multiple of the system's memory allocation granularity.  
  
 `dwMappingProtection`  
 The protection desired for the file view when the file is mapped. See `flProtect` in [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 `dwViewDesiredAccess`  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See `dwDesiredAccess` in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 After a file-mapping object has been created, the size of the file must not exceed the size of the file-mapping object; if it does, not all of the file's contents will be available for sharing. For more details, see [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) and [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Example  
 See the example for [CAtlFileMappingBase::CAtlFileMappingBase](../vs140/catlfilemappingbase--catlfilemappingbase.md).  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)