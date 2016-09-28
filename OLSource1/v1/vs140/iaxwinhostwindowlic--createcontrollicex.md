---
title: "IAxWinHostWindowLic::CreateControlLicEx"
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
  - "IAxWinHostWindowLic::CreateControlLicEx"
  - "IAxWinHostWindowLic.CreateControlLicEx"
  - "CreateControlLicEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CreateControlLicEx method"
ms.assetid: e26f139e-3121-4c9c-b714-80bcc4ad8331
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IAxWinHostWindowLic::CreateControlLicEx
Creates a licensed ActiveX control, initializes it, and hosts it in the specified window, similar to [IAxWinHostWindow::CreateControl](../vs140/iaxwinhostwindow--createcontrol.md).  
  
## Syntax  
  
```  
  
      STDMETHOD( CreateControlLicEx )(  
   LPCOLESTR lpszTricsData,  
   HWND hWnd,  
   IStream* pStream,  
   IUnknown** ppUnk,  
   REFIID riidAdvise,  
   IUnknown* punkAdvise,   
   BSTR bstrLic  
);  
```  
  
#### Parameters  
 `bstrLic`  
 [in] The BSTR that contains the license key for the control.  
  
## Remarks  
 See [IAxWinHostWindow::CreateControlEx](../vs140/iaxwinhostwindow--createcontrolex.md) for a description of the remaining parameters and return value.  
  
## Example  
 See [Hosting ActiveX Controls Using ATL AXHost](../vs140/hosting-activex-controls-using-atl-axhost.md) for a sample that uses `IAxWinHostWindowLic::CreateControlLicEx`.  
  
## Requirements  
 **Header:** atliface.h  
  
## See Also  
 [IAxWinHostWindowLic Interface](../vs140/iaxwinhostwindowlic-interface.md)