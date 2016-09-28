---
title: "CDocument::SetChunkValue"
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
  - "SetChunkValue"
  - "afxwin/CDocument::SetChunkValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "SetChunkValue"
ms.assetid: fd1f6342-7aa4-4de2-906e-7c477356cb8d
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::SetChunkValue
Sets a chunk value.  
  
## Syntax  
  
```  
virtual BOOL SetChunkValue (  
   IFilterChunkValue* pValue  
);  
```  
  
#### Parameters  
 `pValue`  
 Specifies a chunk value to set.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)