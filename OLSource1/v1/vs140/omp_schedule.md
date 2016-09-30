---
title: "OMP_SCHEDULE"
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
  - "OMP_SCHEDULE"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "OMP_SCHEDULE OpenMP environment variable"
ms.assetid: 2295a801-e584-4d2f-826f-7ca4c88846a6
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OMP_SCHEDULE
Modifies the behavior of the [schedule](../vs140/schedule.md) clause when <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is specified in a <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> directive.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (optional)  
 Specifies the size of iterations. <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> must be a positive integer. The default is 1, except when <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is static. Not valid when <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The kind of scheduling:  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
## Remarks  
 The default value in the Visual C++ implementation of the OpenMP standard is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
 For more information, see [4.1 OMP_SCHEDULE](../vs140/4.1-omp_schedule.md).  
  
## Example  
 The following command sets the **OMP_SCHEDULE** environment variable:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following command displays the current setting of the **OMP_SCHEDULE** environment variable:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Environment Variables](../vs140/openmp-environment-variables.md)