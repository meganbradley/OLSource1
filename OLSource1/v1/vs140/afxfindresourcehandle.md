---
title: "AfxFindResourceHandle"
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
  - "AfxFindResourceHandle"
  - "AFXWIN/AfxFindResourceHandle"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "AfxFindResourceHandle macro"
ms.assetid: 697a7f16-89da-4811-8a20-409f7ef31431
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AfxFindResourceHandle
Use `AfxFindResourceHandle` to walk the resource chain and locate a specific resource by resource ID and resource type.  
  
## Syntax  
  
```  
  
      HINSTANCE AFXAPI AfxFindResourceHandle(  
   LPCTSTR lpszName,  
   LPCTSTR lpszType   
);  
```  
  
#### Parameters  
 `lpszName`  
 A pointer to a string containing the resource ID.  
  
 *lpszType*  
 A pointer to the type of resource. For a list of resource types, see [FindResource](http://msdn.microsoft.com/library/windows/desktop/ms648042) in the [!INCLUDE[winSDK](../vs140/includes/winsdk_md.md)].  
  
## Return Value  
 A handle to the module that contains the resource.  
  
## Remarks  
 `AfxFindResourceHandle` finds the specific resource and returns a handle to the module that contains the resource. The resource might be in any extension DLL you have loaded. `AfxFindResourceHandle` tells you which one has the resource.  
  
 The modules are searched in this order:  
  
1.  The main module (if it is an extension DLL).  
  
2.  Non-system modules.  
  
3.  Language-specific modules.  
  
4.  The main module (if it is a system DLL).  
  
5.  System modules.  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)   
 [AfxGetResourceHandle](../vs140/afxgetresourcehandle.md)