---
title: "Exported DLL Function Entry Points"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exporting DLLs, functions"
  - "MFC, managing state data"
  - "state management, exported DLLs"
ms.assetid: 3268666e-d24b-44f2-80e8-7c80f73b93ca
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Exported DLL Function Entry Points
For exported functions of a DLL, use the [AFX_MANAGE_STATE](../vs140/afx_manage_state.md) macro to maintain the proper global state when switching from the DLL module to the calling application's DLL.  
  
 When called, this macro sets <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, a pointer to an <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure containing global data for the module, as the effective module state for the remainder of the containing scope of the function. Upon leaving the scope containing the macro, the previous effective module state is automatically restored.  
  
 This switching is achieved by constructing an instance of an **AFX_MODULE_STATE** class on the stack. In its constructor, this class obtains a pointer to the current module state and stores it in a member variable, and then sets <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as the new effective module state. In its destructor, this class restores the pointer stored in its member variable as the effective module state.  
  
 If you have an exported function, such as one that launches a dialog box in your DLL, you need to add the following code to the beginning of the function:  
  
 [!code[NVC_MFCConnectionPoints#6](../vs140/codesnippet/CPP/exported-dll-function-entry-points_1.cpp)]  
  
 This swaps the current module state with the state returned from [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md) until the end of the current scope.  
  
 Problems with resources in DLLs will occur if the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> macro is not used. By default, MFC uses the resource handle of the main application to load the resource template. This template is actually stored in the DLL. The root cause is that MFC's module state information has not been switched by the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> macro. The resource handle is recovered from MFC's module state. Not switching the module state causes the wrong resource handle to be used.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> does not need to be put into every function in the DLL. For example, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> can be called by the MFC code in the application without <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> because MFC automatically shifts the module state before <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and then switches it back after <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> returns. The same is true for all message-map handlers. Regular DLLs actually have a special master window procedure that automatically switches the module state before routing any message.  
  
## See Also  
 [Managing the State Data of MFC Modules](../vs140/managing-the-state-data-of-mfc-modules.md)