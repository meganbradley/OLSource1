---
title: "extent Class"
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
  - "std.tr1.extent"
  - "extent"
  - "std::tr1::extent"
  - "std.extent"
  - "std::extent"
  - "type_traits/std::extent"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "extent class [TR1]"
  - "extent"
ms.assetid: 6d16263d-90b2-4330-9ec7-b59ed898792d
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# extent Class
Gets an array dimension.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to query.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The array bound to query.  
  
## Remarks  
 If <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> is an array type that has at least <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> dimensions, the type query holds the number of elements in the dimension specified by <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is not an array type or its rank is less than <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, or if <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is zero and <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is of type "array of unknown bound of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>", the type query holds the value 0.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **extent 0 == 5**  
**extent 1 == 10**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_all_extents](../vs140/remove_all_extents-class.md)   
 [remove_extent](../vs140/remove_extent-class.md)