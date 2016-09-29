---
title: "ATLS_DEFAULT_THREADSPERPROC"
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
  - "ATLS_DEFAULT_THREADSPERPROC"
  - "ATLUTIL/ATLS_DEFAULT_THREADSPERPROC"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ATLS_DEFAULT_THREADSPERPROC macro"
ms.assetid: e0dcf107-72a9-4122-abb4-83c63aa7d571
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATLS_DEFAULT_THREADSPERPROC
This macro defines the default number of threads per processor used by [CThreadPool](../VS_csharp/cthreadpool-class.md).  
  
## Syntax  
  
```  
  
#define ATLS_DEFAULT_THREADSPERPROC  
  
```  
  
## Remarks  
 The default is 2 threads per processor. If necessary, you can define your own positive integer value for this symbol before including atlutil.h.  
  
## Requirements  
 **Header:** atlutil.h  
  
## See Also  
 [ATL Concepts](../VS_csharp/active-template-library--atl--concepts.md)   
 [ATL Reference](../VS_csharp/atl-com-desktop-components.md)   
 [ATL Macros Alphabetical Reference](../VS_csharp/atl-macros-alphabetical-reference.md)