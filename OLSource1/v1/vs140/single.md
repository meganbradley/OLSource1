---
title: "single"
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
  - "Single"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "single OpenMP directive"
ms.assetid: 85cf94fb-cb9c-4d82-8609-adffa9f552e1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single
Lets you specify that a section of code should be executed on a single thread, not necessarily the master thread.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (optional)  
 Zero or more clauses. See the Remarks section for a list of the clauses supported by **single**.  
  
## Remarks  
 The **single** directive supports the following OpenMP clauses:  
  
-   [copyprivate](../vs140/copyprivate.md)  
  
-   [firstprivate](../vs140/firstprivate.md)  
  
-   [nowait](../vs140/nowait.md)  
  
-   [private](../vs140/private--openmp-.md)  
  
 The [master](../vs140/master.md) directive lets you specify that a section of code should be executed only on the master thread.  
  
 For more information, see [2.4.3 single Construct](../vs140/2.4.3-single-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **read input**  
**compute results**  
**compute results**  
**write output**   
## See Also  
 [Directives](../vs140/openmp-directives.md)