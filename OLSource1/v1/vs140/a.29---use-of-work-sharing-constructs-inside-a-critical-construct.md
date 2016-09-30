---
title: "A.29   Use of Work-Sharing Constructs Inside a critical Construct"
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
ms.assetid: d5c8a83f-2f51-4f23-8ddf-d267e347507f
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.29   Use of Work-Sharing Constructs Inside a critical Construct
The following example demonstrates using a work-sharing construct inside a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> construct. This example is compliant because the work-sharing construct and the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> construct do not bind to the same parallel region.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>