---
title: "AFX_GLOBAL_DATA::InitD2D"
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
  - "InitD2D"
  - "afxglobals/AFX_GLOBAL_DATA::InitD2D"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "InitD2D method"
ms.assetid: 49d2f99f-aeee-43f6-b38c-7f7b750ab5a1
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# AFX_GLOBAL_DATA::InitD2D
Initializes D2D, DirectWrite, and WIC factories. Call this method before the main window is initialized.  
  
## Syntax  
  
```  
BOOL InitD2D(  
   D2D1_FACTORY_TYPE d2dFactoryType = D2D1_FACTORY_TYPE_SINGLE_THREADED,  
   DWRITE_FACTORY_TYPE writeFactoryType = DWRITE_FACTORY_TYPE_SHARED  
);  
```  
  
#### Parameters  
 `d2dFactoryType`  
 The threading model of the D2D factory and the resources it creates.  
  
 `writeFactoryType`  
 A value that specifies whether the write factory object will be shared or isolated  
  
## Return Value  
 Returns TRUE if the factories were intilalizrd, FALSE - otherwise  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../VS_csharp/afx_global_data-structure.md)