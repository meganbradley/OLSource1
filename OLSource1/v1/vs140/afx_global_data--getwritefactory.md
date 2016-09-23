---
title: "AFX_GLOBAL_DATA::GetWriteFactory"
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
  - GetWriteFactory
  - afxglobals/AFX_GLOBAL_DATA::GetWriteFactory
dev_langs: 
  - C++
helpviewer_keywords: 
  - GetWriteFactory method
ms.assetid: 818e7538-28bb-44f5-baa7-755e7d425442
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# AFX_GLOBAL_DATA::GetWriteFactory
Returns a pointer to the IDWriteFactory interface that is stored in the global data. If the interface is not initialized, it is created and has the default parameters.  
  
## Syntax  
  
```  
IDWriteFactory* GetWriteFactory();  
```  
  
## Return Value  
 A pointer to IDWriteFactory interface if creation of a factory succeeds, or NULL if creation fails or current Operation System don't have DirectWrite support.  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)