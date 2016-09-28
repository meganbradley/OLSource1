---
title: "CComModule::GetModuleInstance"
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
  - "ATL.CComModule.GetModuleInstance"
  - "ATL::CComModule::GetModuleInstance"
  - "CComModule::GetModuleInstance"
  - "GetModuleInstance"
  - "CComModule.GetModuleInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetModuleInstance method"
ms.assetid: 5c845573-4eab-44aa-81f2-4183e9e19431
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::GetModuleInstance
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
HINSTANCE GetModuleInstance( ) throw( );  
  
```  
  
## Return Value  
 The `HINSTANCE` identifying this module.  
  
## Remarks  
 Returns the [m_hInst](../vs140/ccommodule--m_hinst.md) data member.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::GetResourceInstance](../vs140/ccommodule--getresourceinstance.md)   
 [CComModule::GetTypeLibInstance](../vs140/ccommodule--gettypelibinstance.md)