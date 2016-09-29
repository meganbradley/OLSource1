---
title: "CDocument::ReadNextChunkValue"
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
  - "afxwin/CDocument::ReadNextChunkValue"
  - "ReadNextChunkValue"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ReadNextChunkValue"
ms.assetid: 023c6321-32ef-4a33-8331-c54e1518c900
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# CDocument::ReadNextChunkValue
Reads the next chunk value.  
  
## Syntax  
  
```  
virtual BOOL ReadNextChunkValue(  
   IFilterChunkValue** ppValue  
);  
```  
  
#### Parameters  
 `ppValue`  
 [out] When the function returns, `ppValue` contains the value that was read.  
  
## Return Value  
 Nonzero if successful; otherwise 0.  
  
## Remarks  
  
## Requirements  
 **Header:** afxwin.h  
  
## See Also  
 [CDocument Class](../vs140/cdocument-class.md)