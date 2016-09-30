---
title: "omp_set_dynamic"
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
  - "omp_set_dynamic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_set_dynamic OpenMP function"
ms.assetid: 3845faf2-a0ca-45a5-ae70-2a7a6164f1e8
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_set_dynamic
Indicates that the number of threads available in subsequent parallel region can be adjusted by the run time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A value that indicates if the number of threads available in subsequent parallel region can be adjusted by the runtime.  If nonzero, the runtime can adjust the number of threads, if zero, the runtime will not dynamically adjust the number of threads.  
  
## Remarks  
 The number of threads will never exceed the value set by [omp_set_num_threads](../vs140/omp_set_num_threads.md) or by [OMP_NUM_THREADS](../vs140/omp_num_threads.md).  
  
 Use [omp_get_dynamic](../vs140/omp_get_dynamic.md) to display the current setting of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
 The setting for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will override the setting of the [OMP_DYNAMIC](../vs140/omp_dynamic.md) environment variable.  
  
 For more information, see [3.1.7 omp_set_dynamic Function](../vs140/3.1.7-omp_set_dynamic-function.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**1**   
## See Also  
 [Functions](../vs140/openmp-functions.md)