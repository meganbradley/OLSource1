---
title: "recursive_mutex::try_lock Method"
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
  - "mutex/std::recursive_mutex::try_lock"
dev_langs: 
  - "C++"
ms.assetid: cc6fcc2a-a5bf-4b35-85c1-504341c334a0
caps.latest.revision: 9
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# recursive_mutex::try_lock Method
Attempts to obtain ownership of the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> without blocking.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> if the method successfully obtains ownership of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> or if the calling thread already owns the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 If the calling thread already owns the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, the function immediately returns <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, and the previous lock remains in effect.  
  
## Requirements  
 **Header:** mutex  
  
 **Namespace:** std  
  
## See Also  
 [recursive_mutex Class](../vs140/recursive_mutex-class.md)   
 [\<mutex>](../vs140/-mutex-.md)