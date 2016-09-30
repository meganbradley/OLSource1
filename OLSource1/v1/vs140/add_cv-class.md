---
title: "add_cv Class"
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
  - "std.tr1.add_cv"
  - "add_cv"
  - "std::tr1::add_cv"
  - "std.add_cv"
  - "std::add_cv"
  - "type_traits/std::add_cv"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "add_cv class [TR1]"
  - "add_cv"
ms.assetid: a5572c78-a097-45d7-b476-ed4876889dea
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# add_cv Class
Makes const/volatile type from type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of the type modifier holds the modified-type [add_volatile](../vs140/add_volatile-class.md)<CodeContentPlaceHolder>3\</CodeContentPlaceHolder> [add_const](../vs140/add_const-class.md)<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **add_cv_t\<int> == int**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [remove_const](../vs140/remove_const-class.md)   
 [remove_volatile](../vs140/remove_volatile-class.md)