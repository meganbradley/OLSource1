---
title: "CAtlServiceModuleT::WinMain"
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
  - "CAtlServiceModuleT::WinMain"
  - "ATL::CAtlServiceModuleT::WinMain"
  - "CAtlServiceModuleT.WinMain"
  - "ATL.CAtlServiceModuleT.WinMain"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "WinMain method, running services"
  - "WinMain method"
ms.assetid: 2c4d6d05-1ed4-4b5f-887d-1d13fabc6415
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::WinMain
This method implements the code required to start the service.  
  
## Syntax  
  
```  
  
      int WinMain(  
   int nShowCmd   
) throw( );  
```  
  
#### Parameters  
 `nShowCmd`  
 Specifies how the window is to be shown. This parameter can be one of the values discussed in the [WinMain](http://msdn.microsoft.com/library/windows/desktop/ms633559) section.  
  
## Return Value  
 Returns the service's return value.  
  
## Remarks  
 This method processes the command line (with [CAtlServiceModuleT::ParseCommandLine](../vs140/catlservicemodulet--parsecommandline.md)) and then starts the service (using [CAtlServiceModuleT::Start](../vs140/catlservicemodulet--start.md)).  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)