---
title: "AFX_GLOBAL_DATA::GetDirect2dFactory"
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
  - "GetDirect2dFactory"
  - "afxglobals/AFX_GLOBAL_DATA::GetDirect2dFactory"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "GetDirect2dFactory method"
ms.assetid: 1790156d-6f56-46df-9270-9dfa04f2da84
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::GetDirect2dFactory
Returns a pointer to the ID2D1Factory interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.  
  
## Syntax  
  
```  
ID2D1Factory* GetDirect2dFactory();  
```  
  
## Return Value  
 A pointer to ID2D1Factory interface if creation of a factory succeeds, or NULL if creation fails or current Operation System don't have D2D support.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)