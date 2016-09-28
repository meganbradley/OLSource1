---
title: "CWinAppEx::CWinAppEx"
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
  - "CWinAppEx"
  - "CWinAppEx.CWinAppEx"
  - "CWinAppEx::CWinAppEx"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CWinAppEx class, constructors"
ms.assetid: 1d47a941-c900-41b8-8527-ecd97f04c2f2
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::CWinAppEx
Constructs a `CWinAppEx` object.  
  
## Syntax  
  
```  
CWinAppEx(  
   BOOL bResourceSmartUpdate = FALSE  
);  
```  
  
#### Parameters  
 [in] `bResourceSmartUpdate`  
 A Boolean parameter that specifies whether the workspace object should detect and handle resource updates.  
  
## Remarks  
 The `CWinAppEx` class has initialization methods, provides functionality for saving and loading application information to the registry, and controls global application settings. It also enables you to use global managers such as the [CKeyboardManager Class](../vs140/ckeyboardmanager-class.md) and the [CUserToolsManager Class](../vs140/cusertoolsmanager-class.md). Each application can have only one instance of the `CWinAppEx` class.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)