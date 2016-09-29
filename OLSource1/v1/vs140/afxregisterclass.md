---
title: "AfxRegisterClass"
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
  - "AFXWIN/AfxRegisterClass"
  - "AfxRegisterClass"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxRegisterClass function"
ms.assetid: 24254107-df3c-4d1a-a13b-25663b3e56ab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxRegisterClass
Use this function to register window classes in a DLL that uses MFC.  
  
## Syntax  
  
```  
  
      BOOL AFXAPI AfxRegisterClass(  
   WNDCLASS* lpWndClass   
);  
```  
  
#### Parameters  
 *lpWndClass*  
 Pointer to a [WNDCLASS](http://msdn.microsoft.com/library/windows/desktop/ms633576) structure containing information about the window class to be registered. For more information on this structure, see the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 **TRUE** if the class is successfully registered; otherwise **FALSE**.  
  
## Remarks  
 If you use this function, the class is automatically unregistered when the DLL is unloaded.  
  
 In non-DLL builds, the `AfxRegisterClass` identifier is defined as a macro that maps to the Windows function **RegisterClass**, since classes registered in an application are automatically unregistered. If you use `AfxRegisterClass` instead of **RegisterClass**, your code can be used without change both in an application and in a DLL.  
  
## Example  
 [!code[NVC_MFC_DLL#3](../vs140/codesnippet/CPP/afxregisterclass_1.cpp)]  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)