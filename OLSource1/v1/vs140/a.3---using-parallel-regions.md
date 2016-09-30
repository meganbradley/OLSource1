---
title: "A.3   Using Parallel Regions"
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
ms.assetid: 575216a1-960a-47f7-9c82-7f660291fcfe
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.3   Using Parallel Regions
The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive ([Section 2.3](../vs140/2.3-parallel-construct.md) on page 8) can be used in coarse-grain parallel programs. In the following example, each thread in the parallel region decides what part of the global array <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> to work on, based on the thread number:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>