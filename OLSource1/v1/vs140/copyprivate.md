---
title: "copyprivate"
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
  - "copyprivate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "copyprivate OpenMP clause"
ms.assetid: 02c0209d-abe8-4797-8365-a82b53c3f15d
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# copyprivate
Specifies that one or more variables should be shared among all threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One or more variables to share. If more than one variable is specified, separate variable names with a comma.  
  
## Remarks  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> applies to the [single](../vs140/single.md) directive.  
  
 For more information, see [2.7.2.8 copyprivate](../vs140/2.7.2.8-copyprivate.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **call CopyPrivate from a single thread**  
**Value = 1.001000, thread = 0**  
**Value = 1.002000, thread = 0**  
**Value = 1.003000, thread = 0**  
**Value = 1.004000, thread = 0**  
**call CopyPrivate from a parallel region**  
**Value = 1.005000, thread = 0**  
**Value = 1.005000, thread = 1**  
**Value = 1.006000, thread = 0**  
**Value = 1.006000, thread = 1**  
**Value = 1.007000, thread = 0**  
**Value = 1.007000, thread = 1**  
**Value = 1.008000, thread = 0**  
**Value = 1.008000, thread = 1**   
## See Also  
 [Clauses](../vs140/openmp-clauses.md)