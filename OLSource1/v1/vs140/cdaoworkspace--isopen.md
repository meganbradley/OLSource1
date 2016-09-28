---
title: "CDaoWorkspace::IsOpen"
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
  - "IsOpen"
  - "CDaoWorkspace.IsOpen"
  - "CDaoWorkspace::IsOpen"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "open state"
  - "workspaces [C++], open states"
  - "DAO [C++], is workspace open"
  - "IsOpen method"
  - "open state, DAO workspaces"
ms.assetid: 7b6f9f54-7d4f-4bb4-ad45-89b067094092
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDaoWorkspace::IsOpen
Call this member function to determine whether the `CDaoWorkspace` object is open — that is, whether the MFC object has been initialized by a call to [Open](../vs140/cdaoworkspace--open.md) or a call to [Create](../vs140/cdaoworkspace--create.md).  
  
## Syntax  
  
```  
  
BOOL IsOpen( ) const;  
  
```  
  
## Return Value  
 Nonzero if the workspace object is open; otherwise 0.  
  
## Remarks  
 You can call any of the member functions of a workspace that is in an open state.  
  
## Requirements  
 **Header:** afxdao.h  
  
## See Also  
 [CDaoWorkspace Class](../vs140/cdaoworkspace-class.md)   
 [Hierarchy Chart](../vs140/hierarchy-chart.md)