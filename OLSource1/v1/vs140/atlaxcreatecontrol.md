---
title: "AtlAxCreateControl"
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
  - "ATL::AtlAxCreateControl"
  - "ATL.AtlAxCreateControl"
  - "AtlAxCreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AtlAxCreateControl function"
ms.assetid: 582a883e-2050-4af0-bf27-e89a0948f41d
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AtlAxCreateControl
Creates an ActiveX control, initializes it, and hosts it in the specified window.  
  
> [!IMPORTANT]
>  This function cannot be used in applications that execute in the [!INCLUDE[wrt](../vs140/includes/wrt_md.md)].  
  
## Syntax  
  
```  
  
      ATLAPI AtlAxCreateControl(  
LPCOLESTR lpszName,  
HWND hWnd,  
IStream* pStream,  
IUnknown** ppUnkContainer   
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
  
## Return Value  
 One of the standard HRESULT values.  
  
## Remarks  
 This global function gives you the same result as calling [AtlAxCreateControlEx](../vs140/atlaxcreatecontrolex.md)( `lpszName`**,** `hWnd`**,** `pStream`**, NULL, NULL, NULL, NULL** );.  
  
 To create a licensed ActiveX control, see [AtlAxCreateControlLic](../vs140/atlaxcreatecontrollic.md).  
  
## Requirements  
 **Header:** atlhost.h  
  
## See Also  
 [Composite Control Global Functions](../vs140/composite-control-global-functions.md)   
 [Composite Control Fundamentals](../vs140/atl-composite-control-fundamentals.md)   
 [CAxWindow::CreateControl](../vs140/caxwindow--createcontrol.md)