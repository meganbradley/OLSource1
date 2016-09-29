---
title: "CAxWindow::CreateControl"
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
  - "CAxWindow::CreateControl"
  - "CAxWindow.CreateControl"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControl method"
ms.assetid: 0e604a50-51a0-474f-a2c5-f3599434e6c7
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CAxWindow::CreateControl
Creates an ActiveX control, initializes it, and hosts it in the specified window.  
  
## Syntax  
  
```  
  
      HRESULT CreateControl(  
   LPCOLESTR lpszName,  
   IStream* pStream = NULL,  
   IUnknown** ppUnkContainer = NULL   
);  
HRESULT CreateControl(  
   DWORD dwResID,  
   IStream* pStream = NULL,  
   IUnknown** ppUnkContainer = NULL   
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string to create the control. Must be formatted in one of the following ways:  
  
-   A ProgID such as "MSCAL.Calendar.7"  
  
-   A CLSID such as "{8E27C92B-1264-101C-8A2F-040224009C02}"  
  
-   A URL such as "http://www.microsoft.com"  
  
-   A reference to an Active document such as "file://\\\Documents\MyDoc.doc"  
  
-   A fragment of HTML such as "MSHTML:\<HTML>\<BODY>This is a line of text</BODY\></HTML\>"  
  
    > [!NOTE]
    >  "MSHTML:" must precede the HTML fragment so that it is designated as being an MSHTML stream. Only the ProgID and CLSID are supported in Windows Mobile platforms. Windows CE embedded platforms, other than Windows Mobile with support for CE IE support all types including ProgID, CLSID, URL, reference to active document, and fragment of HTML.  
  
 `pStream`  
 [in] A pointer to a stream that is used to initialize the properties of the control. Can be **NULL**.  
  
 `ppUnkContainer`  
 [out] The address of a pointer that will receive the **IUnknown** of the container. Can be **NULL**.  
  
 `dwResID`  
 The resource ID of an HTML resource. The WebBrowser control will be created and loaded with the specified resource.  
  
## Return Value  
 A standard `HRESULT` value.  
  
## Remarks  
 If the second version of this method is used, an HTML control is created and bound to the resource identified by `dwResID`.  
  
 This method gives you the same result as calling:  
  
 [!code[NVC_ATL_Windowing#42](../vs140/codesnippet/CPP/caxwindow--createcontrol_1.cpp)]  
  
 See [CAxWindow2T::CreateControlLic](../vs140/caxwindow2t--createcontrollic.md) to create, initialize, and host a licensed ActiveX control.  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses `CreateControl`.  
  
## Requirements  
 **Header:** atlwin.h  
  
## See Also  
 [CAxWindow Class](../vs140/caxwindow-class.md)   
 [AtlAxCreateControl](../vs140/atlaxcreatecontrol.md)