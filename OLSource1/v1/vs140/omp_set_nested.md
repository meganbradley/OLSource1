---
title: "omp_set_nested"
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
  - "omp_set_nested"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "omp_set_nested OpenMP function"
ms.assetid: fa1cb08c-7b8b-42c9-8654-2c33dcffb5b6
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# omp_set_nested
Enables nested parallelism.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 If nonzero, enables nested parallelism. If zero, disables nested parallelism.  
  
## Remarks  
 OMP nested parallelism can be turned on with <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, or by setting the [OMP_NESTED](../vs140/omp_nested.md) environment variable.  
  
 The setting for <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> will override the setting of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> environment variable.  
  
 When enabled, the environment variable can break an otherwise operational program because the number of threads increases exponentially when nesting parallel regions.  For example a function that recurses 6 times with the number of OMP threads set to 4 requires 4,096 (4 to the power of 6) threads  In general, the performance of your application will degrade if the number of thread exceeds the number of processors. One exception to this would be I/O bound applications.  
  
 Use [omp_get_nested](../vs140/omp_get_nested.md) to display the current setting of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
 For more information, see [3.1.9 omp_set_nested Function](../vs140/3.1.9-omp_set_nested-function.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**1**   
## See Also  
 [Functions](../vs140/openmp-functions.md)