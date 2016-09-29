---
title: "AfxOleRegisterTypeLib"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "afxoleregistertypelib"
  - "AFXDISP/AfxOleRegisterTypeLib"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxOleRegisterTypeLib function"
ms.assetid: 0493dcaa-eb8d-4e27-ac8e-b9e04c13ff05
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxOleRegisterTypeLib
Registers the type library with the Windows registration database and allows the type library to be used by other containers that are OLE-control aware.  
  
## Syntax  
  
```  
  
      BOOL AfxOleRegisterTypeLib(  
   HINSTANCE hInstance,  
   REFGUID tlid,  
   LPCTSTR pszFileName = NULL,  
   LPCTSTR pszHelpDir = NULL   
);  
```  
  
#### Parameters  
 `hInstance`  
 The instance handle of the application associated with the type library.  
  
 *tlid*  
 The unique ID of the type library.  
  
 *pszFileName*  
 Points to the optional filename of a localized type library (.TLB) file for the control.  
  
 *pszHelpDir*  
 The name of the directory where the help file for the type library can be found. If **NULL**, the help file is assumed to be in the same directory as the type library itself.  
  
## Return Value  
 Nonzero if the type library was registered; otherwise 0.  
  
## Remarks  
 This function updates the registry with the type library name and its location on the system.  
  
## Example  
 [!code[NVC_MFCAutomation#7](../vs140/codesnippet/CPP/afxoleregistertypelib_1.cpp)]  
  
 [!code[NVC_MFCAutomation#8](../vs140/codesnippet/CPP/afxoleregistertypelib_2.cpp)]  
  
## Requirements  
 **Header:** afxdisp.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxOleUnregisterTypeLib](../vs140/afxoleunregistertypelib.md)   
 [AfxOleRegisterControlClass](../vs140/afxoleregistercontrolclass.md)   
 [AfxOleUnregisterClass](../vs140/afxoleunregisterclass.md)