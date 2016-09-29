---
title: "IAxWinAmbientDispatch Interface"
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
  - "IAxWinAmbientDispatch"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAxWinAmbientDispatch interface"
ms.assetid: 55ba6f7b-7a3c-4792-ae47-c8a84b683ca9
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatch Interface
This interface provides methods for specifying characteristics of the hosted control or container.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../VS_csharp/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
interface IAxWinAmbientDispatch : IDispatch  
  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[get_AllowContextMenu](../VS_csharp/iaxwinambientdispatch--get_allowcontextmenu.md)|The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.|  
|[get_AllowShowUI](../VS_csharp/iaxwinambientdispatch--get_allowshowui.md)|The **AllowShowUI** property specifies whether the hosted control is allowed to display its own user interface.|  
|[get_AllowWindowlessActivation](../VS_csharp/iaxwinambientdispatch--get_allowwindowlessactivation.md)|The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.|  
|[get_BackColor](../VS_csharp/iaxwinambientdispatch--get_backcolor.md)|The `BackColor` property specifies the ambient background color of the container.|  
|[get_DisplayAsDefault](../VS_csharp/iaxwinambientdispatch--get_displayasdefault.md)|**DisplayAsDefault** is an ambient property that allows a control to find out if it is the default control.|  
|[get_DocHostDoubleClickFlags](../VS_csharp/iaxwinambientdispatch--get_dochostdoubleclickflags.md)|The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.|  
|[get_DocHostFlags](../VS_csharp/iaxwinambientdispatch--get_dochostflags.md)|The **DocHostFlags** property specifies the user interface capabilities of the host object.|  
|[get_Font](../VS_csharp/iaxwinambientdispatch--get_font.md)|The **Font** property specifies the ambient font of the container.|  
|[get_ForeColor](../VS_csharp/iaxwinambientdispatch--get_forecolor.md)|The `ForeColor` property specifies the ambient foreground color of the container.|  
|[get_LocaleID](../VS_csharp/iaxwinambientdispatch--get_localeid.md)|The **LocaleID** property specifies the ambient locale ID of the container.|  
|[get_MessageReflect](../VS_csharp/iaxwinambientdispatch--get_messagereflect.md)|The **MessageReflect** ambient property specifies whether the container will reflect messages to the hosted control.|  
|[get_OptionKeyPath](../VS_csharp/iaxwinambientdispatch--get_optionkeypath.md)|The **OptionKeyPath** property specifies the registry key path to user settings.|  
|[get_ShowGrabHandles](../VS_csharp/iaxwinambientdispatch--get_showgrabhandles.md)|The **ShowGrabHandles** ambient property allows the control to find out if it should draw itself with grab handles.|  
|[get_ShowHatching](../VS_csharp/iaxwinambientdispatch--get_showhatching.md)|The **ShowHatching** ambient property allows the control to find out if it should draw itself hatched.|  
|[get_UserMode](../VS_csharp/iaxwinambientdispatch--get_usermode.md)|The **UserMode** property specifies the ambient user mode of the container.|  
|[put_AllowContextMenu](../VS_csharp/iaxwinambientdispatch--put_allowcontextmenu.md)|The **AllowContextMenu** property specifies whether the hosted control is allowed to display its own context menu.|  
|[put_AllowShowUI](../VS_csharp/iaxwinambientdispatch--put_allowshowui.md)|The **AllowShowUI** property specifies whether the hosted control is allowed to display its own user interface.|  
|[put_AllowWindowlessActivation](../VS_csharp/iaxwinambientdispatch--put_allowwindowlessactivation.md)|The **AllowWindowlessActivation** property specifies whether the container will allow windowless activation.|  
|[put_BackColor](../VS_csharp/iaxwinambientdispatch--put_backcolor.md)|The `BackColor` property specifies the ambient background color of the container.|  
|[put_DisplayAsDefault](../VS_csharp/iaxwinambientdispatch--put_displayasdefault.md)|**DisplayAsDefault** is an ambient property that allows a control to find out if it is the default control.|  
|[put_DocHostDoubleClickFlags](../VS_csharp/iaxwinambientdispatch--put_dochostdoubleclickflags.md)|The **DocHostDoubleClickFlags** property specifies the operation that should take place in response to a double-click.|  
|[put_DocHostFlags](../VS_csharp/iaxwinambientdispatch--put_dochostflags.md)|The **DocHostFlags** property specifies the user interface capabilities of the host object.|  
|[put_Font](../VS_csharp/iaxwinambientdispatch--put_font.md)|The **Font** property specifies the ambient font of the container.|  
|[put_ForeColor](../VS_csharp/iaxwinambientdispatch--put_forecolor.md)|The `ForeColor` property specifies the ambient foreground color of the container.|  
|[put_LocaleID](../VS_csharp/iaxwinambientdispatch--put_localeid.md)|The **LocaleID** property specifies the ambient locale ID of the container.|  
|[put_MessageReflect](../VS_csharp/iaxwinambientdispatch--put_messagereflect.md)|The **MessageReflect** ambient property specifies whether the container will reflect messages to the hosted control.|  
|[put_OptionKeyPath](../VS_csharp/iaxwinambientdispatch--put_optionkeypath.md)|The **OptionKeyPath** property specifies the registry key path to user settings.|  
|[put_UserMode](../VS_csharp/iaxwinambientdispatch--put_usermode.md)|The **UserMode** property specifies the ambient user mode of the container.|  
  
## Remarks  
 This interface is exposed by ATL's ActiveX control hosting objects. Call the methods on this interface to set the ambient properties available to the hosted control or to specify other aspects of the container's behavior. To supplement the properties provided by `IAxWinAmbientDispatch`, use [IAxWinAmbientDispatchEx](../VS_csharp/iaxwinambientdispatchex-interface.md).  
  
 [AXHost](https://msdn.microsoft.com/en-us/library/system.windows.forms.axhost.aspx) will try to load type information about `IAxWinAmbientDispatch` and `IAxWinAmbientDispatchEx` from the typelib that contains the code.  
  
 If you are linking to ATL90.dll, **AXHost** will load the type information from the typelib in the DLL.  
  
 See [Hosting ActiveX Controls Using ATL AXHost](../VS_csharp/hosting-activex-controls-using-atl-axhost.md) for more details.  
  
## Requirements  
 The definition of this interface is available in a number of forms, as shown in the table below.  
  
|Definition Type|File|  
|---------------------|----------|  
|IDL|atliface.idl|  
|Type Library|ATL.dll|  
|C++|atliface.h (also included in ATLBase.h)|  
  
## See Also  
 [IAxWinAmbientDispatchEx Interface](../VS_csharp/iaxwinambientdispatchex-interface.md)   
 [IAxWinHostWindow Interface](../VS_csharp/iaxwinhostwindow-interface.md)   
 [CAxWindow::QueryHost](../Topic/CAxWindow::QueryHost.md)   
 [AtlAxGetHost](../VS_csharp/atlaxgethost.md)