---
title: "omp_get_dynamic"
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
  - "omp_get_dynamic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_get_dynamic OpenMP function"
ms.assetid: efa843c5-7266-4a75-8db3-22992663d9db
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_get_dynamic
Returns a value that indicates if the number of threads available in subsequent parallel region can be adjusted by the run time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If nonzero, dynamic adjustment of threads is enabled.  
  
## Remarks  
 Dynamic adjustment of threads is specified with [omp_set_dynamic](../vs140/omp_set_dynamic.md) and [OMP_DYNAMIC](../vs140/omp_dynamic.md).  
  
 For more information, see [3.1.7 omp_set_dynamic Function](../vs140/3.1.7-omp_set_dynamic-function.md).  
  
## Example  
 See [omp_set_dynamic](../vs140/omp_set_dynamic.md) for an example of using <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## See Also  
 [Functions](../vs140/openmp-functions.md)