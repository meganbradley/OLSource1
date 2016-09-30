---
title: "source_block::accept Method"
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
  - "agents/concurrency::source_block::accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept method"
ms.assetid: 8380d558-06f3-4ae7-a8a4-536e7b6fa069
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# source_block::accept Method
Accepts a message that was offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object, transferring ownership to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the offered <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Return Value  
 A pointer to the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> object that the caller now has ownership of.  
  
## Remarks  
 The method throws an [invalid_argument](../vs140/invalid_argument-class.md) exception if the parameter <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> method is called by a target while a message is being offered by this <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> block. The message pointer returned may be different from the one passed into the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> block, if this source decides to make a copy of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [source_block Class](../vs140/source_block-class.md)