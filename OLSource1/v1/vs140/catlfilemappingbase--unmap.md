---
title: "CAtlFileMappingBase::Unmap"
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
  - "CAtlFileMappingBase.Unmap"
  - "ATL.CAtlFileMappingBase.Unmap"
  - "Unmap"
  - "CAtlFileMappingBase::Unmap"
  - "ATL::CAtlFileMappingBase::Unmap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Unmap method"
ms.assetid: 8a22c535-f57b-4916-bbea-3a24c07bb08e
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlFileMappingBase::Unmap
Call this method to unmap a file-mapping object.  
  
## Syntax  
  
```  
  
HRESULT Unmap( ) throw( );  
  
```  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Remarks  
 See [UnmapViewOfFile](http://msdn.microsoft.com/library/windows/desktop/aa366882) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] for more details.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)