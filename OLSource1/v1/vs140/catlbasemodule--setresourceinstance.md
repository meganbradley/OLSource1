---
title: "CAtlBaseModule::SetResourceInstance"
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
  - "SetResourceInstance"
  - "CAtlBaseModule.SetResourceInstance"
  - "CAtlBaseModule::SetResourceInstance"
  - "ATL.CAtlBaseModule.SetResourceInstance"
  - "ATL::CAtlBaseModule::SetResourceInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetResourceInstance method"
ms.assetid: 116a2440-2e74-4f54-897a-d570ad88429e
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlBaseModule::SetResourceInstance
Sets the resource instance of a `CAtlBaseModule` object.  
  
## Syntax  
  
```  
  
      HINSTANCE SetResourceInstance(  
   HINSTANCE hInst   
) throw( );  
```  
  
#### Parameters  
 `hInst`  
 The new resource instance.  
  
## Return Value  
 Returns the updated resource instance.  
  
## Requirements  
 **Header:** atlcore.h  
  
## See Also  
 [CAtlBaseModule Class](../vs140/catlbasemodule-class.md)   
 [CAtlBaseModule::GetResourceInstance](../vs140/catlbasemodule--getresourceinstance.md)