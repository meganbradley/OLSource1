---
title: "CComModule::GetTypeLibInstance"
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
  - ATL.CComModule.GetTypeLibInstance
  - CComModule.GetTypeLibInstance
  - CComModule::GetTypeLibInstance
  - ATL::CComModule::GetTypeLibInstance
  - GetTypeLibInstance
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetTypeLibInstance method
ms.assetid: 09f0bbc4-908b-4536-aa77-7b9a1c7183fb
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - de-de
  - ja-jp
---
# CComModule::GetTypeLibInstance
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
HINSTANCE GetTypeLibInstance( ) const throw( );  
  
```  
  
## Return Value  
 An `HINSTANCE`.  
  
## Remarks  
 Returns the [m_hInstTypeLib](../vs140/ccommodule--m_hinsttypelib.md) data member.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::GetModuleInstance](../vs140/ccommodule--getmoduleinstance.md)   
 [CComModule::GetResourceInstance](../vs140/ccommodule--getresourceinstance.md)