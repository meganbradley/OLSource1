---
title: "CWinAppEx::EnableTearOffMenus"
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
  - "CWinAppEx.EnableTearOffMenus"
  - "CWinAppEx::EnableTearOffMenus"
  - "EnableTearOffMenus"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EnableTearOffMenus method"
ms.assetid: 8ea81c5b-93a8-4be4-92dd-4861ca28407d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::EnableTearOffMenus
Creates and initializes a [CMenuTearOffManager](../vs140/cmenutearoffmanager-class.md) object.  
  
## Syntax  
  
```  
BOOL EnableTearOffMenus(  
   LPCTSTR lpszRegEntry,  
   const UINT uiCmdFirst,  
   const UINT uiCmdLast   
);  
```  
  
#### Parameters  
 [in] `lpszRegEntry`  
 A string that contains the path of a registry key. The application uses this registry key to store information for the tear-off menus.  
  
 [in] `uiCmdFirst`  
 The first tear off menu ID.  
  
 [in] `uiCmdLast`  
 The last tear off menu ID.  
  
## Return Value  
 `True` if the `CMenuTearOffManager` is created and initialized successfully; `false` if an error occurs or if the `CMenuTearOffManager` already exists.  
  
## Remarks  
 Use this function to enable tear-off menus in your application. You should call this function from `InitInstance`.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CMenuTearOffManager Class](../vs140/cmenutearoffmanager-class.md)