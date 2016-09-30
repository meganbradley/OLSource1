---
title: "choice::reserve Method"
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
  - "agents/concurrency::choice::reserve"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve method"
ms.assetid: e43d4d64-076c-4bbe-94a6-cab83d6d7ec0
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# choice::reserve Method
Reserves a message previously offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object being reserved.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Return Value  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> if the message was successfully reserved, <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> otherwise. Reservations can fail for many reasons, including: the message was already reserved or accepted by another target, the source could deny reservations, and so forth.  
  
## Remarks  
 After you call <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, if it succeeds, you must call either <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> in order to take or give up possession of the message, respectively.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [choice Class](../vs140/choice-class.md)