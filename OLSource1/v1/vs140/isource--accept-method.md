---
title: "ISource::accept Method"
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
  - "agents/concurrency::ISource::accept"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "accept method"
ms.assetid: de3a1339-603d-493b-b38d-ffd3936173f6
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::accept Method
When overridden in a derived class, accepts a message that was offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block, transferring ownership to the caller.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> of the offered <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A pointer to the target block that is calling the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method.  
  
## Return Value  
 A pointer to the message that the caller now has ownership of.  
  
## Remarks  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is called by a target while a message is being offered by this <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> block. The message pointer returned may be different from the one passed into the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> method of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> block, if this source decides to make a copy of the message.  
  
## Requirements  
 **Header:** agents.h  
  
 **Namespace:** concurrency  
  
## See Also  
 [ISource Class](../vs140/isource-class.md)