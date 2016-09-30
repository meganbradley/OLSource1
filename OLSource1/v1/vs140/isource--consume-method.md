---
title: "ISource::consume Method"
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
  - "agents/concurrency::ISource::consume"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "consume method"
ms.assetid: 075b670e-7ca1-4ae6-86ea-78d05b3d82a7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ISource::consume Method
When overridden in a derived class, consumes a message previously offered by this <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> block and successfully reserved by the target, transferring ownership to the caller.  
  
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
 [ISource Class](../vs140/isource-class.md)