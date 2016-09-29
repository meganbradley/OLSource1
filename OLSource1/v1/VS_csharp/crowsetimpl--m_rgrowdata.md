---
title: "CRowsetImpl::m_rgRowData"
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
  - "CRowsetImpl.m_rgRowData"
  - "CRowsetImpl::m_rgRowData"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "m_rgRowData"
ms.assetid: e4e75ca7-12e8-4a0b-94e8-e395c21385b2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CRowsetImpl::m_rgRowData
By default, a `CAtlArray` that templatizes on the user record template argument to `CRowsetImpl`.  
  
## Syntax  
  
```  
  
ArrayType CRowsetBaseImpl::m_rgRowData;  
  
```  
  
## Remarks  
 **ArrayType** is a template parameter to `CRowsetImpl`.  
  
## Requirements  
 **Header:** atldb.h  
  
## See Also  
 [CRowsetImpl Class](../VS_csharp/crowsetimpl-class.md)   
 [CRowsetImpl::m_strCommandText](../VS_csharp/crowsetimpl--m_strcommandtext.md)   
 [CRowsetImpl::m_strIndexText](../VS_csharp/crowsetimpl--m_strindextext.md)