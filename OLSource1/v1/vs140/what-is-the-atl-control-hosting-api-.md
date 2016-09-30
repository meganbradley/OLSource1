---
title: "What Is the ATL Control-Hosting API?"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "APIs [C++], hosting"
  - "control-hosting API"
  - "controls [ATL], hosting APIs"
ms.assetid: 75b27e45-cfba-4950-aa35-96cc7d8da753
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Is the ATL Control-Hosting API?
ATL's control-hosting API is the set of functions that allows any window to act as an ActiveX control container. These functions can be statically or dynamically linked into your project since they are available as source code and exposed by ATL90.dll. The control-hosting functions are listed in the table below.  
  
|Function|Description|  
|--------------|-----------------|  
|[AtlAxAttachControl](../vs140/atlaxattachcontrol.md)|Creates a host object, connects it to the supplied window, then attaches an existing control.|  
|[AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)|Creates a host object, connects it to the supplied window, then loads a control.|  
|[AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window, similar to [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md).|  
|[AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)|Creates a host object, connects it to the supplied window, then loads a control (also allows event sinks to be set up).|  
|[AtlAxCreateControlLicEx](../vs140/atlaxcreatecontrollicex.md)|Creates a licensed ActiveX control, initializes it, and hosts it in the specified window, similar to [AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md).|  
|[AtlAxCreateDialog](../vs140/atlaxcreatedialog.md)|Creates a modeless dialog box from a dialog resource and returns the window handle.|  
|[AtlAxDialogBox](../vs140/atlaxdialogbox.md)|Creates a modal dialog box from a dialog resource.|  
|[AtlAxGetControl](../vs140/atlaxgetcontrol.md)|Returns the **IUnknown** interface pointer of the control hosted in a window.|  
|[AtlAxGetHost](../vs140/atlaxgethost.md)|Returns the **IUnknown** interface pointer of the host object connected to a window.|  
|[AtlAxWinInit](../vs140/atlaxwininit.md)|Initializes the control-hosting code.|  
|[AtlAxWinTerm](../vs140/atlaxwinterm.md)|Uninitializes the control-hosting code.|  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> parameters in the first three functions must be an existing window of (almost) any type. If you call any of these three functions explicitly (typically, you won't have to), do not pass a handle to a window that's already acting as a host (if you do, the existing host object won't be freed).  
  
 The first seven functions call [AtlAxWinInit](../vs140/atlaxwininit.md) implicitly.  
  
> [!NOTE]
>  The control-hosting API forms the foundation of ATL's support for ActiveX control containment. However, there is usually little need to call these functions directly if you take advantage of or make full use of ATL's wrapper classes. For more information, see [Which ATL Classes Facilitate ActiveX Control Containment?](../vs140/which-atl-classes-facilitate-activex-control-containment-.md).  
  
## See Also  
 [Control Containment FAQ](../vs140/atl-control-containment-faq.md)