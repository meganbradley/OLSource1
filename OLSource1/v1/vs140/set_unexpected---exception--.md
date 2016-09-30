---
title: "set_unexpected (&lt;exception&gt;)"
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
  - "std::set_unexpected"
  - "std.set_unexpected"
  - "set_unexpected"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_unexpected function"
ms.assetid: 2132735f-3249-407e-b860-3e99be782614
caps.latest.revision: 18
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# set_unexpected (&lt;exception&gt;)
Establishes a new <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to be when an unexpected exception is encountered.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The function to be called when an unexpected exception is encountered.  
  
## Return Value  
 The address of the previous <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> must not be a null pointer.  
  
 The C++ Standard requires that <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is called when a function throws an exception that is not on its throw list. The current implementation does not support this. The following example calls <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> directly, which then calls the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<exception>  
  
 **Namespace:** std  
  
## See Also  
 [\<exception>](../vs140/-exception-.md)   
 [get_unexpected](../vs140/get_unexpected.md)