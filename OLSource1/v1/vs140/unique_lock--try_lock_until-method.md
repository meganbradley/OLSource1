---
title: "unique_lock::try_lock_until Method"
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
  - "mutex/std::unique_lock::try_lock_until"
dev_langs: 
  - "C++"
ms.assetid: 410e9db7-7ee1-4fd0-ba7e-91adca8dad6d
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::try_lock_until Method
Attempts to obtain ownership of the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A point in time that specifies the threshold after which the method no longer attempts to obtain ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
## Return Value  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the stored <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the method throws a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)   
 [time_point Class](../vs140/time_point-class.md)