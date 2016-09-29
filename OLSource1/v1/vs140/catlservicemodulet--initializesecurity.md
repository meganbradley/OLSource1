---
title: "CAtlServiceModuleT::InitializeSecurity"
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
  - "ATL::CAtlServiceModuleT::InitializeSecurity"
  - "CAtlServiceModuleT.InitializeSecurity"
  - "InitializeSecurity"
  - "ATL.CAtlServiceModuleT.InitializeSecurity"
  - "CAtlServiceModuleT::InitializeSecurity"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitializeSecurity method"
ms.assetid: ff0af848-f26f-4415-961f-4c5d77f38faa
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::InitializeSecurity
Provides the default security settings for the service.  
  
## Syntax  
  
```  
  
HRESULT InitializeSecurity( ) throw( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 In Visual Studio .NET 2003, this method is not implemented in the base class. The Visual Studio project wizard includes this method in the generated code, but a compilation error will occur if a project created in an earlier version of Visual C++ is compiled using ATL 7.1. Any class that derives from `CAtlServiceModuleT` must implement this method in the derived class.  
  
 Use PKT-level authentication, impersonation level of RPC_C_IMP_LEVEL_IDENTIFY and an appropriate non-null security descriptor in the call to **CoInitializeSecurity**.  
  
 For wizard-generated nonattributed service projects, this would be in  
  
 [!code[NVC_ATL_Service#1](../vs140/codesnippet/CPP/catlservicemodulet--initializesecurity_1.cpp)]  
  
 For attributed service projects, this would be in  
  
 [!code[NVC_ATL_ServiceAttrib#1](../vs140/codesnippet/CPP/catlservicemodulet--initializesecurity_2.cpp)]  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)