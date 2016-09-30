---
title: "swap (&lt;utility&gt;)"
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
  - "std.swap"
  - "std::swap"
  - "utility/std::swap"
  - "swap"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "swap function"
ms.assetid: f2420c89-c6ab-4aa2-92b3-30ff088cda3e
caps.latest.revision: 16
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# swap (&lt;utility&gt;)
Exchanges the elements of two [pair](../vs140/pair-structure.md) objects.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
  
## Remarks  
 One advantage of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is that the types of objects that are being stored are determined automatically by the compiler and do not have to be explicitly specified. Don't use explicit template arguments such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> when you use <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> because it is unnecessarily verbose and adds complex rvalue reference problems that might cause compilation failure.  
  
## Requirements  
 **Header:** \<utility>  
  
 **Namespace:** std  
  
## See Also  
 [\<utility>](../vs140/-utility-.md)