---
title: "CAtlModuleT::UnregisterAppId"
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
  - "ATL.CAtlModuleT<T>.UnregisterAppId"
  - "CAtlModuleT::UnregisterAppId"
  - "ATL::CAtlModuleT<T>::UnregisterAppId"
  - "CAtlModuleT<T>::UnregisterAppId"
  - "CAtlModuleT.UnregisterAppId"
  - "ATL::CAtlModuleT::UnregisterAppId"
  - "UnregisterAppId"
  - "ATL.CAtlModuleT.UnregisterAppId"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "UnregisterAppId method"
ms.assetid: 2d29fd1b-6991-481c-922e-f64c095cfd1b
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlModuleT::UnregisterAppId
Removes the EXE from the registry.  
  
## Syntax  
  
```  
  
HRESULT UnregisterAppId( ) throw( );  
  
```  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlModuleT Class](../vs140/catlmodulet-class.md)   
 [CAtlModuleT::RegisterAppId](../vs140/catlmodulet--registerappid.md)