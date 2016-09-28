---
title: "CAtlExeModuleT::RevokeClassObjects"
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
  - "ATL::CAtlExeModuleT::RevokeClassObjects"
  - "RevokeClassObjects"
  - "CAtlExeModuleT<T>::RevokeClassObjects"
  - "ATL::CAtlExeModuleT<T>::RevokeClassObjects"
  - "CAtlExeModuleT.RevokeClassObjects"
  - "ATL.CAtlExeModuleT.RevokeClassObjects"
  - "CAtlExeModuleT::RevokeClassObjects"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "RevokeClassObjects method"
ms.assetid: b8ce24e3-1579-4297-aaed-7fe37d96c0a4
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlExeModuleT::RevokeClassObjects
Removes the class object.  
  
## Syntax  
  
```  
  
HRESULT RevokeClassObjects( ) throw( );  
  
```  
  
## Return Value  
 Returns S_OK on success, S_FALSE if there were no classes to register, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlExeModuleT Class](../vs140/catlexemodulet-class.md)   
 [CAtlExeModuleT::RegisterClassObjects](../vs140/catlexemodulet--registerclassobjects.md)