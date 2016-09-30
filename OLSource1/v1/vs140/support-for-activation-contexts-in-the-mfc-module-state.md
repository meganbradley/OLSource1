---
title: "Support for Activation Contexts in the MFC Module State"
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
  - "activation contexts [C++]"
  - "activation contexts [C++], MFC support"
ms.assetid: 1e49eea9-3620-46dd-bc5f-d664749567c7
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Support for Activation Contexts in the MFC Module State
MFC creates an activation context using a manifest resource provided by the user module. For more information on how activation contexts are created, see the following topics:  
  
-   [Activation Contexts](http://msdn.microsoft.com/library/aa374153)  
  
-   [Application Manifests](http://msdn.microsoft.com/library/aa374191)  
  
-   [Assembly Manifests](http://msdn.microsoft.com/library/aa374219)  
  
## Remarks  
 When reading these [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] topics, note that the MFC activation context mechanism resembles the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] activation context except that MFC does not use the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)] Activation Context API.  
  
 Activation context works in MFC applications, user DLLs, and extension DLLs in the following ways:  
  
-   MFC applications use resource ID 1 for their manifest resource. In this case, the MFC does not create its own activation context, but uses the default application context.  
  
-   MFC user DLLs use resource ID 2 for their manifest resource. Here, MFC creates an activation context for each User DLL, so different user DLLs can use different versions of the same libraries (for example, the Common Controls library).  
  
-   MFC extension DLLs rely on their hosting applications or user DLLs to establish their activation context.  
  
 Although the activation context state can be modified using the processes described under [Using the Activation Context API](http://msdn.microsoft.com/library/aa376620), using the MFC activation context mechanism can be useful when developing DLL-based plug-in architectures where it is not easy (or not possible) to manually switch activation state before and after individual calls to external plug-ins.  
  
 The activation context is created in [AfxWinInit](../vs140/afxwininit.md). It is destroyed in the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> destructor. An activation context handle is kept in <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>. (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is described in [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md).)  
  
 The [AFX_MANAGE_STATE](../vs140/afx_manage_state.md) macro activates and deactivates the activation context. <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is enabled for static MFC libraries, as well as MFC DLLs, to allow MFC code to execute in the proper activation context selected by the User DLL.  
  
## See Also  
 [Activation Contexts](http://msdn.microsoft.com/library/aa374153)   
 [Application Manifests](http://msdn.microsoft.com/library/aa374191)   
 [Assembly Manifests](http://msdn.microsoft.com/library/aa374219)   
 [AfxWinInit](../vs140/afxwininit.md)   
 [AfxGetStaticModuleState](../vs140/afxgetstaticmodulestate.md)   
 [AFX_MANAGE_STATE](../vs140/afx_manage_state.md)