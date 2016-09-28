---
title: "_ATL_COM_MODULE70 Structure"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "ATL::_ATL_COM_MODULE70"
  - "ATL._ATL_COM_MODULE70"
  - "_ATL_COM_MODULE70"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "_ATL_COM_MODULE70 structure"
  - "ATL_COM_MODULE70 structure"
ms.assetid: 5b0b2fd0-bdeb-4c7e-8870-78fa69ace6e6
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_COM_MODULE70 Structure
Used by COM-related code in ATL.  
  
## Syntax  
  
```  
  
      struct _ATL_COM_MODULE70{  
   UINT cbSize;  
   HINSTANCE m_hInstTypeLib;  
   _ATL_OBJMAP_ENTRY** m_ppAutoObjMapFirst;  
   _ATL_OBJMAP_ENTRY** m_ppAutoObjMapLast;  
   CRITICAL_SECTION m_csObjMap;  
};  
```  
  
## Members  
 `cbSize`  
 The size of the structure, used for versioning.  
  
 `m_hInstTypeLib`  
 The handle instance to the type library for this module.  
  
 **m_ppAutoObjMapFirst**  
 Address of the array element indicating the beginning of the object map entries for this module.  
  
 **m_ppAutoObjMapLast**  
 Address of the array element indicating the end of the object map entries for this module.  
  
 `m_csObjMap`  
 Critical section to serialize access to the object map entries. Used internally by ATL.  
  
## Remarks  
 [_ATL_COM_MODULE](../vs140/_atl_com_module.md) is defined as a typedef of `_ATL_COM_MODULE70`.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [Structures](../vs140/atl-structures.md)