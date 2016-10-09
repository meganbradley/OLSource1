---
title: "How to: Use a Generic Class (Visual Basic)"
ms.custom: na
ms.date: "10/06/2016"
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
  - "type parameters, defining"
  - "data type arguments, defining"
  - "arguments [Visual Basic], data types"
  - "Of keyword, using"
  - "generic parameters"
  - "data type parameters"
  - "generics [Visual Basic], about generics"
  - "data types [Visual Basic], as parameters"
  - "data types [Visual Basic], as arguments"
  - "parameters, type"
  - "types [Visual Basic], generic"
  - "parameters, generic"
  - "generics [Visual Basic], creating generic types"
  - "data type arguments"
  - "parameters, data type"
  - "data type parameters, defining"
  - "type arguments, defining"
  - "arguments [Visual Basic], type"
ms.assetid: 242dd2a6-86c4-4ce7-83f2-f2661803f752
caps.latest.revision: 24
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Use a Generic Class (Visual Basic)
A class that takes *type parameters* is called a *generic class*. If you are using a generic class, you can generate a *constructed class* from it by supplying a *type argument* for each of these parameters. You can then declare a variable of the constructed class type, and you can create an instance of the constructed class and assign it to that variable.  
  
 In addition to classes, you can also define and use generic structures, interfaces, procedures, and delegates.  
  
 The following procedure takes a generic class defined in the [!INCLUDE[dnprdnshort](../VS_visualbasic/includes/dnprdnshort_md.md)] and creates an instance from it.  
  
### To use a class that takes a type parameter  
  
1.  At the beginning of your source file, include an [Imports Statement (.NET Namespace and Type)](../VS_visualbasic/imports-statement--.net-namespace-and-type-.md) to import the \<xref:System.Collections.Generic?displayProperty=fullName> namespace. This allows you to refer to the <xref:System.Collections.Generic.Queue`1?displayProperty=fullName> class without having to fully qualify it to differentiate it from other queue classes such as <xref:System.Collections.Queue?displayProperty=fullName>.  
  
2.  Create the object in the normal way, but add `(Of` `type``)` immediately after the class name.  
  
     The following example uses the same class (\<xref:System.Collections.Generic.Queue`1?displayProperty=fullName>) to create two queue objects that hold items of different data types. It adds items to the end of each queue and then removes and displays items from the front of each queue.  
  
     [!code[VbVbalrDataTypes#9](../VS_visualbasic/codesnippet/VisualBasic/how-to--use-a-generic-class--visual-basic-_1.vb)]  
  
## See Also  
 [Data Types](../VS_visualbasic/data-types-in-visual-basic.md)   
 [Generic Types in Visual Basic](../VS_visualbasic/generic-types-in-visual-basic--visual-basic-.md)   
 [Language Independence and Language-Independent Components](../Topic/Language%20Independence%20and%20Language-Independent%20Components.md)   
 [Of](../VS_visualbasic/of-clause--visual-basic-.md)   
 [Imports Statement (.NET Namespace and Type)](../VS_visualbasic/imports-statement--.net-namespace-and-type-.md)   
 [How to: Define a Class That Can Provide Identical Functionality on Different Data Types](../VS_visualbasic/a914adf8-e68f-4819-a6b1-200d1cf1c21c.md)   
 [Iterators](../Topic/Iterators%20\(C%23%20and%20Visual%20Basic\).md)