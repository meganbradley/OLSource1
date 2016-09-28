---
title: "CAtlModule::GetGITPtr"
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
  - "ATL::CAtlModule::GetGITPtr"
  - "GetGITPtr"
  - "CAtlModule::GetGITPtr"
  - "ATL.CAtlModule.GetGITPtr"
  - "CAtlModule.GetGITPtr"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetGITPtr method"
ms.assetid: a3e44ed6-abbd-4dc1-809f-84627228bf8e
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModule::GetGITPtr
Retrieves a pointer to the Global Interface Table.  
  
## Syntax  
  
```  
  
      virtual HRESULT GetGITPtr(  
   IGlobalInterfaceTable** ppGIT   
) throw( );  
```  
  
#### Parameters  
 `ppGIT`  
 Pointer to the variable which will receive the pointer to the Global Interface Table.  
  
## Return Value  
 Returns S_OK on success, or an error code on failure. E_POINTER is returned if `ppGIT` is equal to NULL.  
  
## Remarks  
 If the Global Interface Table object does not exist, it is created, and its address is stored in the member variable [CAtlModule::m_pGIT](../vs140/catlmodule--m_pgit.md).  
  
 In debug builds, an assertion error will occur if `ppGIT` is equal to NULL, or if the Global Interface Table pointer cannot be obtained.  
  
 See [IGlobalInterfaceTable](http://msdn.microsoft.com/library/windows/desktop/ms678517) for information on the Global Interface Table.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModule Class](../vs140/catlmodule-class.md)