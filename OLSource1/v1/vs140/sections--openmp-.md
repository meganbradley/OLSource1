---
title: "sections (OpenMP)"
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
  - "section"
  - "SECTIONS"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "sections OpenMP directive"
ms.assetid: 4cd1d776-e198-470e-930a-01fb0ab0a0bd
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# sections (OpenMP)
Identifies code sections to be divided among all threads.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 where,  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> (optional)  
 Zero or more clauses. See the Remarks section for a list of the clauses supported by **sections**.  
  
## Remarks  
 The **sections** directive can contain zero or more **section** directives.  
  
 The **sections** directive supports the following OpenMP clauses:  
  
-   [firstprivate](../vs140/firstprivate.md)  
  
-   [lastprivate](../vs140/lastprivate.md)  
  
-   [nowait](../vs140/nowait.md)  
  
-   [private](../vs140/private--openmp-.md)  
  
-   [reduction](../vs140/reduction.md)  
  
 If **parallel** is also specified, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> can be any clause accepted by the **parallel** or **sections** directives, except <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 For more information, see [2.4.2 sections Construct](../vs140/2.4.2-sections-construct.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Hello from thread 0**  
**Hello from thread 0**   
## See Also  
 [Directives](../vs140/openmp-directives.md)