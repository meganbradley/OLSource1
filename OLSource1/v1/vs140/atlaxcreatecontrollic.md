---
title: "AtlAxCreateControlLic"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: reference
f1_keywords: 
  - ATL.AtlAxCreateControlLic
  - AtlAxCreateControlLic
  - ATL::AtlAxCreateControlLic
dev_langs: 
  - C++
helpviewer_keywords: 
  - AtlAxCreateControlLic function
ms.assetid: b409bd0e-28c9-4d9a-80a4-8df77a3aff88
caps.latest.revision: 16
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AtlAxCreateControlLic
Creates a licensed ActiveX control, initializes it, and hosts it in the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlAxCreateControlLic(  
LPCOLESTR lpszName,   
HWND hWnd,   
IStream* pStream,   
IUnknown** ppUnkContainer,   
BSTR bstrLic= NULL  
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
 Handle to the window that the control will be attached to.  
  
 `pStream`  
 A pointer to a stream that is used to initialize the properties of the control. Can be **NULL**.  
  
 `ppUnkContainer`  
 The address of a pointer that will receive the **IUnknown** of the container. Can be **NULL**.  
  
 `bstrLic`  
 The BSTR containing the license for the control.  
  
## Return Value  
 One of the standard HRESULT values.  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample of how to use `AtlAxCreateControlLic`.  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)   
 [CAxWindow2T::CreateControlLic](../vs140/caxwindow2t--createcontrollic.md)