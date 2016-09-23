---
title: "Extension methods must declare at least one parameter"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - vbc36552
  - bc36552
helpviewer_keywords: 
  - BC36552
ms.assetid: a8cc8cdd-cdb5-42ca-b5a1-c9a71abd46eb
caps.latest.revision: 19
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Extension methods must declare at least one parameter
Extension methods must declare at least one parameter. The first parameter specifies which type to extend.  
  
 An extension method without parameters is not valid because the first parameter specifies which data type the method extends. The first parameter is bound to the instance of the data type that invokes the method.  
  
 **Error ID:** BC36552  
  
### To correct this error  
  
-   Add a parameter of the type that your method extends.  
  
## Example  
 The first parameter in the following example indicates that the `Print` method extends the `String` data type.  
  
```  
<Extension()> _  
Public Sub Print (ByVal str As String)  
    Console.WriteLine(str)  
End Sub  
```  
  
 When the extension method is called as follows, parameter `str` in the method is bound to `greeting`, the instance of `String` that calls `Print`. The compiler will use `greeting` as the argument to extension method `Print`.  
  
```  
Dim greeting As String = "Hello"  
greeting.Print()  
```  
  
## See Also  
 [Extension Methods (Visual Basic)](../vs140/extension-methods--visual-basic-.md)   
 [Procedure Parameters and Arguments](../vs140/procedure-parameters-and-arguments--visual-basic-.md)   
 [Procedures in Visual Basic](../vs140/procedures-in-visual-basic.md)