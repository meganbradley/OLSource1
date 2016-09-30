---
title: "CAtlServiceModuleT::Handler"
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
  - "SERVICE_CONTROL_CONTINUE"
  - "CAtlServiceModuleT::Handler"
  - "SERVICE_CONTROL_SHUTDOWN"
  - "ATL::CAtlServiceModuleT::Handler"
  - "SERVICE_CONTROL_STOP"
  - "CAtlServiceModuleT.Handler"
  - "SERVICE_CONTROL_PAUSE"
  - "ATL.CAtlServiceModuleT.Handler"
  - "Handler"
  - "SERVICE_CONTROL_INTERROGATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SERVICE_CONTROL_SHUTDOWN"
  - "SERVICE_CONTROL_INTERROGATE"
  - "Handler method"
  - "SERVICE_CONTROL_PAUSE"
  - "SERVICE_CONTROL_CONTINUE"
  - "SERVICE_CONTROL_STOP"
ms.assetid: 956499e0-e1a2-4e32-a274-eb5c64f98738
caps.latest.revision: 14
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAtlServiceModuleT::Handler
The handler routine for the service.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 *dwOpcode*  
 A switch that defines the handler operation. For details, see the Remarks.  
  
## Remarks  
 This is the code that the Service Control Manager (SCM) calls to retrieve the status of the service and issue instructions such as stop or pause. The SCM passes an operation code, shown below, to <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to indicate what the service should do.  
  
|Operation code|Meaning|  
|--------------------|-------------|  
|SERVICE_CONTROL_STOP|Stops the service. Override the method [CAtlServiceModuleT::OnStop](../vs140/catlservicemodulet--onstop.md) in atlbase.h to change the behavior.|  
|SERVICE_CONTROL_PAUSE|User implemented. Override the empty method [CAtlServiceModuleT::OnPause](../vs140/catlservicemodulet--onpause.md) in atlbase.h to pause the service.|  
|SERVICE_CONTROL_CONTINUE|User implemented. Override the empty method [CAtlServiceModuleT::OnContinue](../vs140/catlservicemodulet--oncontinue.md) in atlbase.h to continue the service.|  
|SERVICE_CONTROL_INTERROGATE|User implemented. Override the empty method [CAtlServiceModuleT::OnInterrogate](../vs140/catlservicemodulet--oninterrogate.md) in atlbase.h to interrogate the service.|  
|SERVICE_CONTROL_SHUTDOWN|User implemented. Override the empty method [CAtlServiceModuleT::OnShutdown](../vs140/catlservicemodulet--onshutdown.md) in atlbase.h to shutdown the service.|  
  
 If the operation code isn't recognized, the method [CAtlServiceModuleT::OnUnknownRequest](../vs140/catlservicemodulet--onunknownrequest.md) is called.  
  
 A default ATL-generated service only handles the stop instruction. If the SCM passes the stop instruction, the service tells the SCM that the program is about to stop. The service then calls <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to post a quit message to itself. This terminates the message loop and the service will ultimately close.  
  
## Requirements  
 **Header:** atlbase.h  
  
## See Also  
 [CAtlServiceModuleT Class](../vs140/catlservicemodulet-class.md)