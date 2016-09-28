---
title: "IDiaSectionContrib::get_remove"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSectionContrib::get_remove method"
ms.assetid: fd30ab7b-022b-4402-a42a-2d38e274c1b1
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# IDiaSectionContrib::get_remove
Retrieves a flag that indicates whether the section is removed before it is made part of the in-memory image.  
  
## Syntax  
  
```cpp#  
HRESULT get_remove (   
   BOOL* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns `TRUE` if the section is not to be added to the in-memory image; otherwise, returns `FALSE`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if this property is not supported. Otherwise, returns an error code.  
  
## See Also  
 [IDiaSectionContrib](../vs140/idiasectioncontrib.md)