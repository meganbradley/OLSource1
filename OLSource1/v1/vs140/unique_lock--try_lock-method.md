---
title: "unique_lock::try_lock Method"
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
  - "mutex/std::unique_lock::try_lock"
dev_langs: 
  - "C++"
ms.assetid: 5ab2cf55-089f-4e60-83b3-697e4e2d8c22
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::try_lock Method
Attempts to obtain ownership of the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the stored <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> pointer is <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the method throws a [system_error](../vs140/system_error-class.md) that has an error code of <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
 If the calling thread already owns the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, the method throws a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> that has an error code of <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [unique_lock Class](../vs140/unique_lock-class.md)   
 [\<mutex>](../vs140/-mutex-.md)