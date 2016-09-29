---
title: "AFX_MANAGE_STATE"
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
  - "AFX_MANAGE_STATE"
  - "AFX_MODULE_STATE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exporting functions, protecting exported functions"
  - "AFX_MANAGE_STATE macro"
  - "AFX_MODULE_STATE structure"
  - "functions [C++], exporting"
  - "module states, restoring and saving"
ms.assetid: 620cb840-4227-4a75-b36d-f7d507f44606
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_MANAGE_STATE
Call this macro to protect an exported function in a DLL.  
  
## Syntax  
  
```  
  
AFX_MANAGE_STATE(AFX_MODULE_STATE* pModuleState )  
```  
  
#### Parameters  
 `pModuleState`  
 A pointer to an `AFX_MODULE_STATE` structure.  
  
## Remarks  
 When this macro is invoked, `pModuleState` is the effective module state for the remainder of the immediate containing scope. Upon leaving the scope, the previous effective module state will be automatically restored.  
  
 The `AFX_MODULE_STATE` structure contains global data for the module, that is, the portion of the module state that is pushed or popped.  
  
 By default, MFC uses the resource handle of the main application to load the resource template. If you have an exported function in a DLL, such as one that launches a dialog box in the DLL, this template is actually stored in the DLL module. You need to switch the module state for the correct handle to be used. You can do this by adding the following code to the beginning of the function:  
  
 [!code[NVC_MFCWindowing#131](../vs140/codesnippet/CPP/afx_manage_state_1.cpp)]  
  
 This swaps the current module state with the state returned from [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md) until the end of the current scope.  
  
 For more information on module states and MFC, see "Managing the State Data of MFC Modules" in [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md) and [Technical Note 58](../vs140/tn058--mfc-module-state-implementation.md).  
  
> [!NOTE]
>  When MFC creates an activation context for an assembly, it uses [AfxWinInit](../vs140/afxwininit.md) to create the context and `AFX_MANAGE_STATE` to activate and deactivate it. Note also that `AFX_MANAGE_STATE` is enabled for static MFC libraries, as well as MFC DLLs, in order to allow MFC code to execute in the proper activation context selected by the User DLL. For more information, see [Support for Activation Contexts in the MFC Module State](../vs140/support-for-activation-contexts-in-the-mfc-module-state.md).  
  
## Requirements  
 **Header:** afxstat_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md)