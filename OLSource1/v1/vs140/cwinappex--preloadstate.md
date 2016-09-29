---
title: "CWinAppEx::PreLoadState"
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
  - "CWinAppEx.PreLoadState"
  - "CWinAppEx::PreLoadState"
  - "PreLoadState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "PreLoadState method"
ms.assetid: 8a5f23da-a062-4a2e-883c-4fe261bfede8
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::PreLoadState
The framework calls this method immediately before it loads the state of the application from the registry.  
  
## Syntax  
  
```  
virtual void PreLoadState();  
```  
  
## Remarks  
 Override this method if you want to do any processing immediately before the framework loads the application state.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)