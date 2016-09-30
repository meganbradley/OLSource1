---
title: "Declaration of a CLR Array"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array keyword [C++]"
ms.assetid: 36a8883c-2663-43f0-a90c-28f27035e036
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Declaration of a CLR Array
The syntax for declaring, instantiating, and initializing a managed array has changed from Managed Extensions for C++ to [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)].  
  
 The declaration of a CLR array object in Managed Extensions was an extension of the standard array declaration in which a <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword was placed between the name of the array object and its possibly comma-filled dimension, as in the following pair of examples:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This has been simplified in the new syntax, in which we use a template-like declaration similar to the STL <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> declaration. The first parameter indicates the element type. The second parameter specifies the array dimension (with a default value of 1, so only multiple dimensions require a second argument). The array object itself is a tracking handle, and so must be given a hat. If the element type is also a reference type, it also requires a hat. For example, the above example, when expressed in the new syntax, looks as follows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Because a reference type is a tracking handle rather than an object, it is possible to specify a CLR array as the return type of a function. (In contrast, it is not possible to specify the native array as the return type of a function.) The syntax for doing this in Managed Extensions was somewhat non-intuitive. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In [!INCLUDE[cpp_current_long](../vs140/includes/cpp_current_long_md.md)], the declaration is much simpler. For example,  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The shorthand initialization of a local managed array is supported in both versions of the language. For example:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 is considerably simplified in the new syntax (note that because boxing is implicit in the new syntax, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> operator has been eliminated – see [Value Types and Their Behaviors](../vs140/value-types-and-their-behaviors--c---cli-.md) for a discussion):  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Because an array is a CLR reference type, the declaration of each array object is a tracking handle. Therefore, array objects must be allocated on the CLR heap. (The shorthand notation hides the managed heap allocation.) Here is the explicit form of an array object initialization under Managed Extensions:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Under the new syntax, the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> expression is replaced with <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>. The dimension sizes are passed as parameters to the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> expression, as follows:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In the new syntax, an explicit initialization list can follow the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> expression; this was not supported in Managed Extensions. For example:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## See Also  
 [The Managed Types](../vs140/managed-types--c---cl-.md)   
 [array](../vs140/arrays--c---component-extensions-.md)