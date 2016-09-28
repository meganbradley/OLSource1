---
title: "CAtlServiceModuleT::Start"
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
  - "CAtlServiceModuleT.Start"
  - "Start"
  - "ATL.CAtlServiceModuleT.Start"
  - "CAtlServiceModuleT::Start"
  - "ATL::CAtlServiceModuleT::Start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Start method"
ms.assetid: 2dd367c9-abc9-41cb-a48c-9d7a67f0de45
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Start
Called by `CAtlServiceModuleT::WinMain` when the service starts.  
  
## Syntax  
  
```  
  
      HRESULT Start(  
   int nShowCmd   
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section.  
  
## Return Value  
 Returns S_OK on success, or an error HRESULT on failure.  
  
## Remarks  
 The [CAtlServiceModuleT::WinMain](../vs140/catlservicemodulet--winmain.md) method handles both registration and installation, as well as tasks involved in removing registry entries and uninstalling the module. When the service is run, `WinMain` calls **Start**.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)