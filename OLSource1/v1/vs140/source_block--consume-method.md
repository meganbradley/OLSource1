---
title: "source_block::consume Method"
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
  - "agents/concurrency::source_block::consume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume method"
ms.assetid: 878b910d-b686-427a-8aa4-a292ce8a72fb
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::consume Method
Consumes a message previously offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object and successfully reserved by the target, transferring ownership to the caller.  
  
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
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The method throws a [bad_target](../vs140/bad_target-class.md) exception if the parameter <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> does not represent the target that called <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method is similar to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, but must always be preceded by a call to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that returned <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)