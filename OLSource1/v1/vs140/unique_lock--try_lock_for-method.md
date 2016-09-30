---
title: "unique_lock::try_lock_for Method"
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
  - "mutex/std::unique_lock::try_lock_for"
dev_langs: 
  - "C++"
ms.assetid: f33be1a9-eb08-4d29-ad5b-4b081f413c04
caps.latest.revision: 10
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# unique_lock::try_lock_for Method
Attempts to obtain ownership of the associated <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [chrono::duration](../vs140/duration-class.md) object that specifies the maximum amount of time that the method attempts to obtain ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>.  
  
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