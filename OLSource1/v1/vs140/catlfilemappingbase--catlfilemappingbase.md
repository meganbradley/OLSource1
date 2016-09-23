---
title: "CAtlFileMappingBase::CAtlFileMappingBase"
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
  - CAtlFileMappingBase.CAtlFileMappingBase
  - CAtlFileMappingBase::CAtlFileMappingBase
  - ATL::CAtlFileMappingBase::CAtlFileMappingBase
  - ATL.CAtlFileMappingBase.CAtlFileMappingBase
dev_langs: 
  - C++
helpviewer_keywords: 
  - CAtlFileMappingBase constructor
  - CAtlFileMappingBase class, constructor
ms.assetid: 7451bb15-e60c-45f5-80d1-549b04891886
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlFileMappingBase::CAtlFileMappingBase
The constructor.  
  
## Syntax  
  
```  
  
      CAtlFileMappingBase(  
   CAtlFileMappingBase& orig   
);  
CAtlFileMappingBase( ) throw( );  
```  
  
#### Parameters  
 `orig`  
 The original file-mapping object to copy to create the new object.  
  
## Remarks  
 Creates a new file-mapping object, optionally using an existing object. It is still necessary to call [CAtlFileMappingBase::MapFile](../vs140/catlfilemappingbase--mapfile.md) to open or create the file-mapping object for a particular file.  
  
## Example  
 [!code[NVC_ATL_Utilities#71](../vs140/codesnippet/CPP/catlfilemappingbase--catlfilemappingbase_1.cpp)]
  
  
## Requirements  
 **Header:** atlfile.h  
  
## See Also  
 [CAtlFileMappingBase Class](../vs140/catlfilemappingbase-class.md)