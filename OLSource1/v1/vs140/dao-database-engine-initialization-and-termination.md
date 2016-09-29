---
title: "DAO Database Engine Initialization and Termination"
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
  - "vc.mfc.macros.data"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "DAO (Data Access Objects), termination"
  - "DAO (Data Access Objects), initialization"
ms.assetid: a7edf31c-e7c2-4f3e-aada-63c3e48781da
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# DAO Database Engine Initialization and Termination
When using MFC DAO objects, the DAO database engine must first be initialized and then terminated before your application or DLL quits. Two functions, `AfxDaoInit` and `AfxDaoTerm`, perform these tasks.  
  
### DAO Database Engine Initialization and Termination  
  
|||  
|-|-|  
|[AfxDaoInit](../vs140/afxdaoinit.md)|Initializes the DAO database engine.|  
|[AfxDaoTerm](../vs140/afxdaoterm.md)|Terminates the DAO database engine.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)