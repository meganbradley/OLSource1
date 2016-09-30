---
title: "remove_reference Class"
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
  - "std.tr1.remove_reference"
  - "std::tr1::remove_reference"
  - "remove_reference"
  - "std.remove_reference"
  - "std::remove_reference"
  - "type_traits/std::remove_reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "remove_reference class [TR1]"
  - "remove_reference"
ms.assetid: 294e1965-3ae3-46ee-bc42-4fdf60c24717
caps.latest.revision: 20
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# remove_reference Class
Makes non reference type from type.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The type to modify.  
  
## Remarks  
 An instance of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> holds a modified-type that is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> when <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is of the form <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, otherwise <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
  **remove_reference_t\<int&> == int**    
## Requirements  
 **Header:** \<type_traits>  
  
 **Namespace:** std  
  
## See Also  
 [\<type_traits>](../vs140/-type_traits-.md)   
 [add_reference](../vs140/add_lvalue_reference-class.md)