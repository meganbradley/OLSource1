---
title: "CAtlFileMappingBase::OpenMapping"
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
  - "CAtlFileMappingBase.OpenMapping"
  - "ATL::CAtlFileMappingBase::OpenMapping"
  - "OpenMapping"
  - "CAtlFileMappingBase::OpenMapping"
  - "ATL.CAtlFileMappingBase.OpenMapping"
  - "AtlFileMappingBase.OpenMapping"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OpenMapping method"
ms.assetid: 57588e73-4633-40a4-adfc-ef27d67bdbfc
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMappingBase::OpenMapping
Call this method to open a named file-mapping object for the specified file.  
  
## Syntax  
  
```  
  
      HRESULT OpenMapping(  
   LPCTSTR szName,  
   SIZE_T nMappingSize,  
   ULONGLONG nOffset = 0,  
   DWORD dwViewDesiredAccess = FILE_MAP_ALL_ACCESS   
) throw( );  
```  
  
#### Parameters  
 `szName`  
 The name of the mapping object. If there is an open handle to a file-mapping object by this name and the security descriptor on the mapping object does not conflict with the `dwViewDesiredAccess` parameter, the open operation succeeds.  
  
 `nMappingSize`  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file-mapping object identified by `szName.`  
  
 `nOffset`  
 The file offset where mapping is to begin. The offset value must be a multiple of the system's memory allocation granularity.  
  
 `dwViewDesiredAccess`  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See `dwDesiredAccess` in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 In debug builds, an assertion error will occur if the input parameters are invalid.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)   
 [CAtlFileMappingBase::MapFile](../vs140/catlfilemappingbase--mapfile.md)