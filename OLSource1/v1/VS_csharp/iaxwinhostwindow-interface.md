---
title: "IAxWinHostWindow Interface"
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
  - "IAxWinHostWindow"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAxWinHostWindow interface"
ms.assetid: 9821c035-cd52-4c46-b58a-9278064f09b4
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindow Interface
This interface provides methods for manipulating a control and its host object.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
interface IAxWinHostWindow : IUnknown  
  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[AttachControl](../VS_csharp/iaxwinhostwindow--attachcontrol.md)|Attaches an existing control to the host object.|  
|[CreateControl](../VS_csharp/iaxwinhostwindow--createcontrol.md)|Creates a control and attaches it to the host object.|  
|[CreateControlEx](../VS_csharp/iaxwinhostwindow--createcontrolex.md)|Creates a control, attaches it to the host object, and optionally sets up an event handler.|  
|[QueryControl](../VS_csharp/iaxwinhostwindow--querycontrol.md)|Returns an interface pointer to the hosted control.|  
|[SetExternalDispatch](../VS_csharp/iaxwinhostwindow--setexternaldispatch.md)|Sets the external `IDispatch` interface.|  
|[SetExternalUIHandler](../VS_csharp/iaxwinhostwindow--setexternaluihandler.md)|Sets the external `IDocHostUIHandlerDispatch` interface.|  
  
## Remarks  
 This interface is exposed by ATL's ActiveX control hosting objects. Call the methods on this interface to create and/or attach a control to the host object, to get an interface from a hosted control, or to set the external dispinterface or UI handler for use when hosting the Web browser.  
  
## Requirements  
 The definition of this interface is available as IDL or C++, as shown below.  
  
|Definition type|File|  
|---------------------|----------|  
|IDL|ATLIFace.idl|  
|C++|ATLIFace.h (also included in ATLBase.h)|  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../VS_csharp/iaxwinambientdispatch-interface.md)   
 [CAxWindow::QueryHost](../Topic/CAxWindow::QueryHost.md)   
 [AtlAxGetHost](../VS_csharp/atlaxgethost.md)