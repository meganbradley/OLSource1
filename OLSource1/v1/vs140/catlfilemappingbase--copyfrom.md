---
title: "CAtlFileMappingBase::CopyFrom"
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
  - CAtlFileMappingBase.CopyFrom
  - ATL.CAtlFileMappingBase.CopyFrom
  - CopyFrom
  - CAtlFileMappingBase::CopyFrom
  - ATL::CAtlFileMappingBase::CopyFrom
dev_langs: 
  - C++
helpviewer_keywords: 
  - CopyFrom method
ms.assetid: 8b13baf6-d194-430b-8173-67f9f63d78c5
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFileMappingBase::CopyFrom
Call this method to copy from a file-mapping object.  
  
## Syntax  
  
```  
  
      HRESULT CopyFrom(  
   CAtlFileMappingBase& orig   
) throw( );  
```  
  
#### Parameters  
 `orig`  
 The original file-mapping object to copy from.  
  
## Return Value  
 Returns `S_OK` on success, or an error `HRESULT` on failure.  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)