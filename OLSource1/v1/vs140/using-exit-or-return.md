---
title: "Using exit or return"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "Exit"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "exit function"
  - "return keyword [C++], using for program termination"
ms.assetid: b5136c5c-2505-4229-8691-2a1d6a98760b
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using exit or return
When you call **exit** or execute a <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> statement from **main**, static objects are destroyed in the reverse order of their initialization. The following example shows how such initialization and cleanup works.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the preceding example, the static objects <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> are created and initialized before entry to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. After this program terminates using the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> statement, first <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is destroyed and then <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. The destructor for the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class closes the files associated with these static objects. (For more information about initialization, constructors, and destructors, see [Special Member Functions](../vs140/special-member-functions--c---.md).)  
  
 Another way to write this code is to declare the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects with block scope, allowing them to be destroyed when they go out of scope:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Additional Termination Considerations](../vs140/additional-termination-considerations.md)