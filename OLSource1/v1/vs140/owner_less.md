---
title: "owner_less"
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
  - "owner_less"
  - "std::owner_less"
  - "memory/std::owner_less"
  - "std.owner_less"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "owner_less struct"
  - "owner_less function"
ms.assetid: b143c891-707a-4c68-8aaa-bab9dcc65c41
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# owner_less
Allows ownership-based mixed comparisons of shared and weak pointers. Returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> if the left parameter is ordered before right parameter by the member function <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A shared or weak pointer.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 A shared or weak pointer.  
  
## Property Value/Return Value  
 Returns <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> if <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is ordered before <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> by the member function <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template classes define all their member operators as returning <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<memory>  
  
 **Namespace:** std  
  
## See Also  
 [shared_ptr::owner_before](../vs140/shared_ptr--owner_before.md)   
 [weak_ptr::owner_before](../vs140/weak_ptr--owner_before.md)   
 [\<memory>](../vs140/-memory-.md)