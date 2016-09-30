---
title: "A.9   Using single Directives"
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
ms.assetid: 0c0f9495-5794-4db9-883b-a12e3a9f1328
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.9   Using single Directives
The following example demonstrates the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive ([Section 2.4.3](../vs140/2.4.3-single-construct.md) on page 15). In the example, only one thread (usually the first thread that encounters the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive) prints the progress message. The user must not make any assumptions as to which thread will execute the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> section. All other threads will skip the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> section and stop at the barrier at the end of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> construct. If other threads can proceed without waiting for the thread executing the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> section, a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> clause can be specified on the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directive.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>