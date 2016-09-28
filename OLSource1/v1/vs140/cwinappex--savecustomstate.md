---
title: "CWinAppEx::SaveCustomState"
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
  - "SaveCustomState"
  - "CWinAppEx::SaveCustomState"
  - "CWinAppEx.SaveCustomState"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SaveCustomState method"
ms.assetid: 80ee8b5a-a69d-478d-a340-2a95e4616be1
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CWinAppEx::SaveCustomState
The framework calls this method after it saves the state of the application to the registry.  
  
## Syntax  
  
```  
virtual void SaveCustomState();  
```  
  
## Remarks  
 Override this method if you want to do any processing after the application saves the state to the registry. By default, this method does nothing.  
  
## Requirements  
 **Header:** afxwinappex.h  
  
## See Also  
 [CWinAppEx Class](../vs140/cwinappex-class.md)   
 [Hierarchy Chart (MFC Feature Pack)](../vs140/hierarchy-chart.md)   
 [CWinAppEx::LoadCustomState](../vs140/cwinappex--loadcustomstate.md)