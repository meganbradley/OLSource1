---
title: "How to: Write an Extension Method (Visual Basic)"
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
  - "extending data types"
  - "writing extension methods"
  - "extension methods [Visual Basic]"
ms.assetid: fb2739cc-958d-4ef4-a38b-214a74c93413
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Write an Extension Method (Visual Basic)
Extension methods enable you to add methods to an existing class. The extension method can be called as if it were an instance of that class.  
  
### To define an extension method  
  
1.  Open a new or existing Visual Basic application in Visual Studio.  
  
2.  At the top of the file in which you want to define an extension method, include the following import statement:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Within a module in your new or existing application, begin the method definition with the extension attribute:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Declare your method in the ordinary way, except that the type of the first parameter must be the data type you want to extend.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following example declares an extension method in module <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. A second module, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, imports <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and calls the method. The extension method must be in scope when it is called. Extension method <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> extends the \<xref:System.String*> class with a method that displays the string instance followed by a string of punctuation symbols sent in as a parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Notice that the method is defined with two parameters and called with only one. The first parameter, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, in the method definition is bound to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the instance of <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> that calls the method. The output of the example is as follows:  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
## See Also  
 \<xref:System.Runtime.CompilerServices.ExtensionAttribute*>   
 [Extension Methods](../vs140/extension-methods--visual-basic-.md)   
 [Module Statement](../vs140/module-statement.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Scope in Visual Basic](../vs140/scope-in-visual-basic.md)