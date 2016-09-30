---
title: "AfxGetStaticModuleState"
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
  - "AfxGetStaticModuleState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AFX_MODULE_STATE structure"
  - "AfxGetStaticModuleState function"
  - "module states, restoring and saving"
ms.assetid: 8b6c7c95-9d57-4337-9378-9b65e60d5c3b
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxGetStaticModuleState
Call this function to set the module state before initialization and/or to restore the previous module state after cleanup.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 A pointer to an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure.  
  
## Remarks  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> structure contains global data for the module, that is, the portion of the module state that is pushed or popped.  
  
 By default, MFC uses the resource handle of the main application to load the resource template. If you have an exported function in a DLL, such as one that launches a dialog box in the DLL, this template is actually stored in the DLL module. You need to switch the module state for the correct handle to be used. You can do this by adding the following code to the beginning of the function:  
  
 [!code[NVC_MFCWindowing#131](../vs140/codesnippet/CPP/afxgetstaticmodulestate_1.cpp)]  
  
 This swaps the current module state with the state returned from <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> until the end of the current scope.  
  
 For more information on module states and MFC, see "Managing the State Data of MFC Modules" in [Creating New Documents, Windows, and Views](../vs140/creating-new-documents--windows--and-views.md) and [Technical Note 58](../vs140/tn058--mfc-module-state-implementation.md).  
  
## Requirements  
 **Header:** afxstat_.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AFX_MANAGE_STATE](../vs140/afx_manage_state.md)