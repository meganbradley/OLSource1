---
title: "Explicit Instantiation"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "templates, instantiation"
  - "explicit instantiation"
  - "instantiation, explicit"
ms.assetid: 8b0d4e32-45a6-49d5-8041-1ebdd674410e
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Explicit Instantiation
You can use explicit instantiation to create an instantiation of a templated class or function without actually using it in your code. Because this is useful when you are creating library (.lib) files that use templates for distribution, uninstantiated template definitions are not put into object (.obj) files.  
  
 This code explicitly instantiates <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> variables and six items:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This statement creates an instantiation of <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> without reserving any storage for an object. Code is generated for all members.  
  
 The next line explicitly instantiates only the constructor member function:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 You can explicitly instantiate function templates by using a specific type argument to re-declare them, as shown in the example in [Function Template Instantiation](../vs140/function-template-instantiation.md).  
  
 You can use the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> keyword to prevent the automatic instantiation of members. For example:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Similarly, you can mark specific members as being external and not instantiated:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 You can use the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> keyword to keep the compiler from generating the same instantiation code in more than one object module. You must instantiate the template function by using the specified explicit template parameters in at least one linked module if the function is called, or you will get a linker error when the program is built.  
  
> [!NOTE]
>  The <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> keyword in the specialization only applies to member functions defined outside of the body of the class. Functions defined inside the class declaration are considered inline functions and are always instantiated.  
  
## See Also  
 [Function Templates](../vs140/function-templates.md)