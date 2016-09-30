---
title: "A.6   Using the lastprivate Clause"
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
ms.assetid: cf3bf0cc-aa46-4e44-9433-e2969e3be2c1
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# A.6   Using the lastprivate Clause
Correct execution sometimes depends on the value that the last iteration of a loop assigns to a variable. Such programs must list all such variables as arguments to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> clause ([Section 2.7.2.3](../vs140/2.7.2.3-lastprivate.md) on page 27) so that the values of the variables are the same as when the loop is executed sequentially.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding example, the value of <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> at the end of the parallel region will equal <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, as in the sequential case.