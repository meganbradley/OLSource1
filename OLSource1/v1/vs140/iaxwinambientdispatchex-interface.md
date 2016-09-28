---
title: "IAxWinAmbientDispatchEx Interface"
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
  - "ATL.IAxWinAmbientDispatchEx"
  - "IAxWinAmbientDispatchEx"
  - "ATL::IAxWinAmbientDispatchEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IAxWinAmbientDispatchEx interface"
ms.assetid: 2c25e079-6128-4278-bc72-b2c6195ba7ef
caps.latest.revision: 21
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinAmbientDispatchEx Interface
This interface implements supplemental ambient properties for a hosted control.  
  
> [!IMPORTANT]
>  This class and its members cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      MIDL_INTERFACE( "B2D0778B - AC99 - 4c58 - A5C8 - E7724E5316B5" )  
IAxWinAmbientDispatchEx : public IAxWinAmbientDispatch  
```  
  
## Members  
  
### Methods  
  
|||  
|-|-|  
|[SetAmbientDispatch](../vs140/iaxwinambientdispatchex--setambientdispatch.md)|This method is called to supplement the default ambient property interface with a user-defined interface.|  
  
## Remarks  
 Include this interface in ATL applications that are statically linked to ATL and host ActiveX Controls, especially ActiveX Controls that have Ambient Properties. Not including this interface will generate this assertion: "Did you forget to pass the LIBID to CComModule::Init?"  
  
 This interface is exposed by ATL's ActiveX control hosting objects. Derived from [IAxWinAmbientDispatch](../vs140/iaxwinambientdispatch-interface.md), `IAxWinAmbientDispatchEx` adds a method that allows you to supplement the ambient property interface provided by ATL with one of your own.  
  
 [AXHost](https://msdn.microsoft.com/en-us/library/system.windows.forms.axhost.aspx) will try to load type information about `IAxWinAmbientDispatch` and `IAxWinAmbientDispatchEx` from the type library that contains the code.  
  
 If you are linking to ATL90.dll, **AXHost** will load the type information from the type library in the DLL.  
  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for more details.  
  
## Requirements  
 The definition of this interface is available in a number of forms, as shown in the following table.  
  
|Definition Type|File|  
|---------------------|----------|  
|IDL|atliface.idl|  
|Type Library|ATL.dll|  
|C++|atliface.h (also included in ATLBase.h)|  
  
## See Also  
 [IAxWinAmbientDispatch Interface](../vs140/iaxwinambientdispatch-interface.md)