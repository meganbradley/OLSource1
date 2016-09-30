---
title: "A.12   Using the atomic Directive"
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
ms.assetid: d3ba3c87-413d-4efa-8a45-8a7f28ab0164
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.12   Using the atomic Directive
The following example avoids race conditions (simultaneous updates of an element of *x* by multiple threads) by using the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> directive ([Section 2.6.4](../vs140/2.6.4-atomic-construct.md) on page 19):  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The advantage of using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> directive in this example is that it allows updates of two different elements of x to occur in parallel. If a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> directive  ([Section 2.6.2](../vs140/2.6.2-critical-construct.md) on page 18) were used instead, then all updates to elements of *x* would be executed serially (though not in any guaranteed order).  
  
 Note that the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> directive applies only to the C or C++ statement immediately following it.  As a result, elements of *y* are not updated atomically in this example.