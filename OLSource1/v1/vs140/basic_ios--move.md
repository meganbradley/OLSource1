---
title: "basic_ios::move"
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
  - "std.basic_ios.move"
  - "move"
  - "basic_ios.move"
  - "basic_ios::move"
  - "std::basic_ios::move"
  - "ios/std::basic_ios::move"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "move method"
ms.assetid: 1f622771-3877-477f-852b-1b77dd1cd754
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::move
Moves all values, except the pointer to the stream buffer, from the parameter to the current object.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> object to move values from.  
  
## Property Value/Return Value  
  
## Exceptions  
  
## Remarks  
 The protected member function moves all the values stored in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> except the stored <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, which is unchanged in <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and set to a null pointer in <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. The stored <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is set to a null pointer in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [lvalues and rvalues](../vs140/lvalues-and-rvalues--visual-c---.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)