---
title: "join::consume_message Method"
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
  - "agents/concurrency::join::consume_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume_message method"
ms.assetid: 9ad4a2ba-3ef6-4fea-a8b8-75528dd7c106
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# join::consume_message Method
Consumes a message previously offered by the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block and reserved by the target, transferring ownership to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object being consumed.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
## Remarks  
 Similar to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, but is always preceded by a call to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [join Class](../vs140/join-class.md)