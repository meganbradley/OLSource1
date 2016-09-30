---
title: "CAtlFileMappingBase::MapSharedMem"
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
  - "CAtlFileMappingBase.MapSharedMem"
  - "MapSharedMem"
  - "ATL.CAtlFileMappingBase.MapSharedMem"
  - "ATL::CAtlFileMappingBase::MapSharedMem"
  - "CAtlFileMappingBase::MapSharedMem"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "MapSharedMem method"
ms.assetid: e5bc5578-8b1f-4a02-9a49-20f0c0336200
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMappingBase::MapSharedMem
Call this method to create a file-mapping object that permits full access to all processes.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The mapping size. If 0, the maximum size of the file-mapping object is equal to the current size of the file-mapping object identified by <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the mapping object.  
  
 *pbAlreadyExisted*  
 Points to a BOOL value that is set to TRUE if the mapping object already existed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The pointer to a **SECURITY_ATTRIBUTES** structure that determines whether the returned handle can be inherited by child processes. See *lpAttributes* in [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The protection desired for the file view, when the file is mapped. See <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> in **CreateFileMapping** in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 Specifies the type of access to the file view and, therefore, the protection of the pages mapped by the file. See <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> in [MapViewOfFileEx](http://msdn.microsoft.com/library/windows/desktop/aa366763) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 Returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> on success, or an error <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> on failure.  
  
## Remarks  
 **MapShareMem** allows an existing file-mapping object, created by [CreateFileMapping](http://msdn.microsoft.com/library/windows/desktop/aa366537), to be shared between processes.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)