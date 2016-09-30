---
title: "critical"
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
  - "Critical"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "critical OpenMP directive"
ms.assetid: 2ab87d6d-5ca4-43ae-9f0a-1f517a6a2bab
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# critical
Specifies that code is only be executed on one thread at a time.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 (<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>) (optional)  
 A name to identify the critical code. Note that name must be enclosed in parentheses.  
  
## Remarks  
 The **critical** directive supports no OpenMP clauses.  
  
 For more information, see [2.6.2 critical Construct](../vs140/2.6.2-critical-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **41**  
**18467**  
**6334**  
**26500**  
**19169**  
**15724**  
**11478**  
**29358**  
**26962**  
**24464**  
**max = 29358**   
## See Also  
 [Directives](../vs140/openmp-directives.md)