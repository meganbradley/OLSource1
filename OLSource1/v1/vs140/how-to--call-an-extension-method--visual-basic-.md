---
title: "How to: Call an Extension Method (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "calling extension methods"
  - "extension methods [Visual Basic]"
ms.assetid: df07750f-40f4-4c07-a79e-1113a27cfbea
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Call an Extension Method (Visual Basic)
Extension methods enable you to add methods to an existing class. After an extension method is declared and brought into scope, you can call it like an instance method of the type that it extends. For more information about how to write an extension method, see [How to: Write an Extension Method](../vs140/how-to--write-an-extension-method--visual-basic-.md).  
  
 The following instructions refer to extension method <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, which will display the string instance that invokes it, followed by whatever value is sent in for the second parameter, <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The method must be in scope when it is called.  
  
### To call an extension method  
  
1.  Declare a variable that has the data type of the first parameter of the extension method. For <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, you need a \<xref:System.String*> variable:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  That variable will invoke the extension method, and its value is bound to the first parameter, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The following calling statement will display <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Notice that the call to this extension method looks just like a call to any one of the \<xref:System.String*> instance methods that require one parameter:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
3.  Declare another string variable and call the method again to see that it works with any string.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     The result this time is: <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
## Example  
 The following code is a complete example of the creation and use of a simple extension method.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
## See Also  
 [How to: Write an Extension Method](../vs140/how-to--write-an-extension-method--visual-basic-.md)   
 [Extension Methods](../vs140/extension-methods--visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)