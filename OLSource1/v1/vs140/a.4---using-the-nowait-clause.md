---
title: "A.4   Using the nowait Clause"
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
ms.assetid: d3de2111-05ea-4ee3-a66c-57bd988712af
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.4   Using the nowait Clause
If there are multiple independent loops within a parallel region, you can use the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause ([Section 2.4.1](../vs140/2.4.1-for-construct.md) on page 11) to avoid the implied barrier at the end of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive, as follows:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>