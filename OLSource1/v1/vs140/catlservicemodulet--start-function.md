---
title: "CAtlServiceModuleT::Start Function"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "CServiceModule.Start"
  - "CServiceModule::Start"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Start method"
ms.assetid: b5193a23-41bc-42d2-8d55-3eb43dc62238
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Start Function
When the service is run, **_tWinMain** calls **CAtlServiceModuleT::WinMain**, which in turn calls `CAtlServiceModuleT::Start`.  
  
 `CAtlServiceModuleT::Start` sets up an array of **SERVICE_TABLE_ENTRY** structures that map each service to its startup function. This array is then passed to the Win32 API function, [StartServiceCtrlDispatcher](http://msdn.microsoft.com/library/windows/desktop/ms686324). In theory, one EXE could handle multiple services and the array could have multiple **SERVICE_TABLE_ENTRY** structures. Currently, however, an ATL-generated service supports only one service per EXE. Therefore, the array has a single entry that contains the service name and **_ServiceMain** as the startup function. **_ServiceMain** is a static member function of `CAtlServiceModuleT` that calls the non-static member function, `ServiceMain`.  
  
> [!NOTE]
>  Failure of **StartServiceCtrlDispatcher** to connect to the service control manager (SCM) probably means that the program is not running as a service. In this case, the program calls `CAtlServiceModuleT::Run` directly so that the program can run as a local server. For more information about running the program as a local server, see [Debugging Tips](../vs140/debugging-tips.md).  
  
## See Also  
 [Services](../vs140/atl-services.md)   
 [CAtlServiceModuleT::Start](../vs140/catlservicemodulet--start.md)