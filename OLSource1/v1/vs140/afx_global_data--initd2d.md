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
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The threading model of the D2D factory and the resources it creates.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value that specifies whether the write factory object will be shared or isolated  
  
## Return Value  
 Returns TRUE if the factories were intilalizrd, FALSE - otherwise  
  
## Requirements  
 **Header:** afxglobals.h  
  
## See Also  
 [AFX_GLOBAL_DATA Structure](../vs140/afx_global_data-structure.md)