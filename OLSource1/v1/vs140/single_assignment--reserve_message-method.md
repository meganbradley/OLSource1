---
title: "single_assignment::reserve_message Method"
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
  - "agents/concurrency::single_assignment::reserve_message"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reserve_message method"
ms.assetid: 3fca8253-72d1-4f85-a0dc-37c90e9c478c
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# single_assignment::reserve_message Method
Reserves a message previously offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> messaging block.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object being reserved.  
  
## Return Value  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if the message was successfully reserved, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> otherwise.  
  
## Remarks  
 After <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called, if it returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, either <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> must be called to either take or release ownership of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [single_assignment Class](../vs140/single_assignment-class.md)