---
title: "A.15   Determining the Number of Threads Used"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
ms.assetid: 026bb59a-f668-40db-a7cb-69a1bae83d2d
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.15   Determining the Number of Threads Used
Consider the following incorrect example (for [Section 3.1.2](../vs140/3.1.2-omp_get_num_threads-function.md) on page 37):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> call returns 1 in the serial section of the code, so *np* will always be equal to 1 in the preceding example. To determine the number of threads that will be deployed for the parallel region, the call should be inside the parallel region.  
  
 The following example shows how to rewrite this program without including a query for the number of threads:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>