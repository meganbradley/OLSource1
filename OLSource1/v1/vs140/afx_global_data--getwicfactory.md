---
title: "AFX_GLOBAL_DATA::GetWICFactory"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - afxglobals/AFX_GLOBAL_DATA::GetWICFactory
  - GetWICFactory
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWICFactory method
ms.assetid: 88a0a515-b225-4466-a55f-01ec4c2bb760
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AFX_GLOBAL_DATA::GetWICFactory
Returns a pointer to the IWICImagingFactory interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.  
  
## Syntax  
  
```  
IWICImagingFactory* GetWICFactory();  
```  
  
## Return Value  
 A pointer to IWICImagingFactory interface if creation of a factory succeeds, or NULL if creation fails or current Operation System don't have WIC support.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)