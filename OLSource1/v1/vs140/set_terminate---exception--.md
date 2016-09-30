---
title: "set_terminate (&lt;exception&gt;)"
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
  - "std::set_terminate"
  - "set_terminate"
  - "std.set_terminate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_terminate function"
ms.assetid: b949bd45-75ae-4fe8-af2c-f6ce67167d67
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_terminate (&lt;exception&gt;)
Establishes a new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be called at the termination of the program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The function to be called at termination.  
  
## Return Value  
 The address of the previous function that used to be called at termination.  
  
## Remarks  
 The function establishes a new [terminate_handler](../vs140/terminate_handler.md) as the function *<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. Thus, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must not be a null pointer. The function returns the address of the previous terminate handler.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [get_terminate](../vs140/get_terminate.md)