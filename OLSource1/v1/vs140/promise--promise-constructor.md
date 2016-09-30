---
title: "promise::promise Constructor"
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
  - "future/std::promise::promise"
dev_langs: 
  - "C++"
ms.assetid: 65fc9d4b-d9ef-4c64-b3eb-f212c12085e6
caps.latest.revision: 10
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# promise::promise Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A memory allocator. See [\<allocators>](../vs140/-allocators-.md) for more information.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor constructs an *empty*<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object.  
  
 The second constructor constructs an empty <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object and uses <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> for memory allocation.  
  
 The third constructor constructs a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object and transfers the associated asynchronous state from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and leaves <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> empty.  
  
## Requirements  
 **Header:** future  
  
 **Namespace:** std  
  
## See Also  
 [promise Class](../vs140/promise-class.md)   
 [\<future>](../vs140/-future-.md)