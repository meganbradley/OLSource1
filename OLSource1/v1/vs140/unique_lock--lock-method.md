---
title: "unique_lock::lock Method"
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
  - "mutex/std::unique_lock::lock"
dev_langs: 
  - "C++"
ms.assetid: 71ded894-2ed9-4a66-9460-1331c9da334b
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::lock Method
Blocks the calling thread until the thread obtains ownership of the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 If the stored <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, this method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the associated <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, this method throws a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 Otherwise, this method calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> on the associated <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and sets the internal thread ownership flag to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)