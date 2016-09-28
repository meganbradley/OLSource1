---
title: "AtlAxCreateControlEx"
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
  - "ATL.AtlAxCreateControlEx"
  - "AtlAxCreateControlEx"
  - "ATL::AtlAxCreateControlEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxCreateControlEx function"
ms.assetid: 8b21d43b-7c3e-4ff1-9419-e0bd695d34df
caps.latest.revision: 16
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxCreateControlEx
Creates an ActiveX control, initializes it, and hosts it in the specified window. An interface pointer and event sink for the new control can also be created.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlAxCreateControlEx(  
LPCOLESTR lpszName,  
HWND hWnd,  
IStream* pStream,  
IUnknown** ppUnkContainer,  
IUnknown** ppUnkControl,  
REFIID iidSink = IID_NULL,  
IUnknown* punkSink = NULL  
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string to be passed to the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:<HTML\><BODY\>This is a line of text</BODY\></HTML\>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream.  
  
 `hWnd`  
 [in] Handle to the window that the control will be attached to.  
  
 `pStream`  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be **NULL**.  
  
 `ppUnkContainer`  
 [out] The address of a pointer that will receive the **IUnknown** of the container. Can be **NULL**.  
  
 `ppUnkControl`  
 [out] The address of a pointer that will receive the **IUnknown** of the created control. Can be **NULL**.  
  
 `iidSink`  
 The interface identifier of an outgoing interface on the contained object.  
  
 *punkSink*  
 A pointer to the **IUnknown** interface of the sink object to be connected to the connection point specified by `iidSink` on the contained object after the contained object has been successfully created.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 `AtlAxCreateControlEx` is similar to [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md) but also allows you to receive an interface pointer to the newly created control and set up an event sink to receive events fired by the control.  
  
 To create a licensed ActiveX control, see [AtlAxCreateControlLicEx](../vs140/atlaxcreatecontrollicex.md).  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [CAxWindow::CreateControlEx](../vs140/caxwindow--createcontrolex.md)