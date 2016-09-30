---
title: "A.24   Example of the private Clause"
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
ms.assetid: f90a5b49-81ff-4746-ae03-37bbd33f6c08
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.24   Example of the private Clause
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause ([Section 2.7.2.1](../vs140/2.7.2.1-private.md) on page 25) of a parallel region is only in effect for the lexical extent of the region, not for the dynamic extent of the region.  Therefore, in the example that follows, any uses of the variable *a* within the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> loop in the routine *f* refers to a private copy of *a*, while a usage in routine *g* refers to the global *a*.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>