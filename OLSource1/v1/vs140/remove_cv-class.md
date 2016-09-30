---
title: "remove_cv Class"
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
  - "remove_cv"
  - "std::tr1::remove_cv"
  - "std.tr1.remove_cv"
  - "std.remove_cv"
  - "std::remove_cv"
  - "type_traits/std::remove_cv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_cv class [TR1]"
  - "remove_cv"
ms.assetid: 8502602a-1c80-479c-84e0-33bd1d6496d6
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# remove_cv Class
Makes non const/volatile type from type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> holds a modified-type that is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is of the form <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **remove_cv_t\<const volatile int> == int**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_const](../vs140/remove_const-class.md)   
 [remove_volatile](../vs140/remove_volatile-class.md)