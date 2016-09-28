---
title: "CWinAppEx::LoadCustomState"
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
  - "LoadCustomState"
  - "CWinAppEx::LoadCustomState"
  - "CWinAppEx.LoadCustomState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "LoadCustomState method"
ms.assetid: 03c65bc8-f7b8-4900-8f19-b7a044746a2d
caps.latest.revision: 14
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::LoadCustomState
The framework calls this method after it loads the state of the application from the registry.  
  
## Syntax  
  
```  
virtual void LoadCustomState();  
```  
  
## Remarks  
 Override this method if you want to do any processing after the application loads the state from the registry. By default, this method does nothing.  
  
 In order to load custom state information from the registry, the information must first be saved by using [CWinAppEx::SaveCustomState](../vs140/cwinappex--savecustomstate.md).  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::SaveCustomState](../vs140/cwinappex--savecustomstate.md)