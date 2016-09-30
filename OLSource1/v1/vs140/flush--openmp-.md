---
title: "flush (OpenMP)"
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
  - "Flush"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "flush OpenMP directive"
ms.assetid: 150ca46e-d4f7-4423-b0a4-838df40aeb67
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# flush (OpenMP)
Specifies that all threads have the same view of memory for all shared objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (optional)  
 A comma-separated list of variables that represent objects you want to synchronize. If <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is not specified, all memory is flushed.  
  
## Remarks  
 The **flush** directive supports no OpenMP clauses.  
  
 For more information, see [2.6.5 flush Directive](../vs140/2.6.5-flush-directive.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Thread 0: read data**  
**Thread 1: process data**  
**data = 2**   
## See Also  
 [Directives](../vs140/openmp-directives.md)