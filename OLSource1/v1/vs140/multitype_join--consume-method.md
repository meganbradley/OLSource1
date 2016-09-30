---
title: "multitype_join::consume Method"
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
  - "agents/concurrency::multitype_join::consume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume method"
ms.assetid: 22793e21-5b7f-488f-8834-d2808af48ba4
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# multitype_join::consume Method
Consumes a message previously offered by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block and successfully reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the reserved <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
## Remarks  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method is similar to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, but must always be preceded by a call to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> that returned <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [multitype_join Class](../vs140/multitype_join-class.md)