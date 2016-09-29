---
title: "_ATL_MULTI_THREADED"
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
  - "_ATL_MULTI_THREADED"
  - "ATL._ATL_MULTI_THREADED"
  - "ATL::_ATL_MULTI_THREADED"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATL_MULTI_THREADED macro"
  - "_ATL_MULTI_THREADED macro"
ms.assetid: 23fb6460-e651-46e6-b207-8559ccf49608
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# _ATL_MULTI_THREADED
A symbol that indicates the project will have objects that are marked as Both, Free or Neutral.  
  
## Syntax  
  
```  
  
_ATL_MULTI_THREADED  
  
```  
  
## Remarks  
 If this symbol is defined, ATL will pull in code that will correctly synchronize access to global data. New code should use the equivalent macro [_ATL_FREE_THREADED](../vs140/_atl_free_threaded.md) instead.  
  
## See Also  
 [Compiler Options Macros](../vs140/compiler-options-macros.md)   
 [Macros](../vs140/atl-macros.md)