---
title: "time_point::time_point Constructor"
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
  - "chrono/std::chrono::time_point::time_point"
dev_langs: 
  - "C++"
ms.assetid: 7dbe4eb0-dcd1-47fa-900c-fd24e5ea8d12
caps.latest.revision: 13
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# time_point::time_point Constructor
Constructs a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 A [duration](../vs140/duration-class.md) object.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 A <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor constructs an object whose stored <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> value is equal to [duration::zero](../vs140/duration--zero-method.md).  
  
 The second constructor constructs an object whose stored duration value is equal to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Unless <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>*holds true*, the second constructor does not participate in overload resolution. For more information, see [\<type_traits>](../vs140/-type_traits-.md).  
  
 The third constructor initializes its <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value by using <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** chrono  
  
 **Namespace:** std::chrono  
  
## See Also  
 [time_point Class](../vs140/time_point-class.md)   
 [\<chrono>](../vs140/-chrono-.md)   
 [time_point::time_since_epoch Method](../vs140/time_point--time_since_epoch-method.md)   
 [is_convertible Class](../vs140/is_convertible-class.md)