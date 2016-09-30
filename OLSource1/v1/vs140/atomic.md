---
title: "atomic"
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
  - "atomic"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "atomic OpenMP directive"
ms.assetid: 275e0338-cf2f-4525-97b5-696250000df7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# atomic
Specifies that a memory location that will be updated atomically.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The statement containing the lvalue whose memory location you want to protect against multiple writes. For more information about legal expression forms, see the OpenMP specification.  
  
## Remarks  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive supports no OpenMP clauses.  
  
 For more information, see [2.6.4 atomic Construct](../vs140/2.6.4-atomic-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Number of threads: 10**   
## See Also  
 [OpenMP](../vs140/openmp-in-visual-c--.md)