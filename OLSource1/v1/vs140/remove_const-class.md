---
title: "remove_const Class"
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
  - "std.tr1.remove_const"
  - "std::tr1::remove_const"
  - "remove_const"
  - "std.remove_const"
  - "std::remove_const"
  - "type_traits/std::remove_const"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_const class [TR1]"
  - "remove_const"
ms.assetid: feb76fb3-9228-41d6-80f6-2fbb04daec43
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# remove_const Class
Makes a non const type from type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> holds a modified-type that is <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> is of the form <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
  **remove_const_t\<const int> == int**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [add_const](../vs140/add_const-class.md)   
 [remove_cv](../vs140/remove_cv-class.md)