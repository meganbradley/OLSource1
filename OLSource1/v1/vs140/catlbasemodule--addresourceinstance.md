---
title: "CAtlBaseModule::AddResourceInstance"
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
  - CAtlBaseModule.AddResourceInstance
  - ATL::CAtlBaseModule::AddResourceInstance
  - ATL.CAtlBaseModule.AddResourceInstance
  - AddResourceInstance
  - CAtlBaseModule::AddResourceInstance
dev_langs: 
  - C++
helpviewer_keywords: 
  - AddResourceInstance method
ms.assetid: 94a35dfb-c908-4f20-b3bf-ceffab8c1e46
caps.latest.revision: 15
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CAtlBaseModule::AddResourceInstance
Adds a resource instance to the list of stored handles.  
  
## Syntax  
  
```  
  
      bool AddResourceInstance(  
   HINSTANCE hInst   
) throw( );  
```  
  
#### Parameters  
 `hInst`  
 The resource instance to add.  
  
## Return Value  
 Returns true if the resource was successfully added, false otherwise.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CAtlBaseModule Class](../vs140/catlbasemodule-class.md)   
 [CAtlBaseModule::GetHInstanceAt](../vs140/catlbasemodule--gethinstanceat.md)   
 [CAtlBaseModule::RemoveResourceInstance](../vs140/catlbasemodule--removeresourceinstance.md)