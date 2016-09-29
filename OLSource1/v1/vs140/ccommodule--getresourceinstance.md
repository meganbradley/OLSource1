---
title: "CComModule::GetResourceInstance"
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
  - "CComModule::GetResourceInstance"
  - "GetResourceInstance"
  - "CComModule.GetResourceInstance"
  - "ATL::CComModule::GetResourceInstance"
  - "ATL.CComModule.GetResourceInstance"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetResourceInstance method"
ms.assetid: 7df0ac23-94fd-47bc-b8b2-9961cd6d0be6
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CComModule::GetResourceInstance
As of ATL 7.0, `CComModule` is obsolete: see [ATL Module Classes](../vs140/atl-module-classes.md) for more details.  
  
## Syntax  
  
```  
  
HINSTANCE GetResourceInstance( ) throw( );  
  
```  
  
## Return Value  
 An `HINSTANCE`.  
  
## Remarks  
 Returns the [m_hInstResource](../vs140/ccommodule--m_hinstresource.md) data member.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CComModule Class](../vs140/ccommodule-class.md)   
 [CComModule::GetModuleInstance](../vs140/ccommodule--getmoduleinstance.md)   
 [CComModule::GetTypeLibInstance](../vs140/ccommodule--gettypelibinstance.md)