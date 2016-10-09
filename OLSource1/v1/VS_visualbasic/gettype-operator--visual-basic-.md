---
title: "GetType Operator (Visual Basic)"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vb.GetType"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "GetType operator"
  - "GetType keyword"
ms.assetid: 4f733297-2503-4607-850c-15eba65fff90
caps.latest.revision: 17
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# GetType Operator (Visual Basic)
Returns a \<xref:System.Type> object for the specified type. The \<xref:System.Type> object provides information about the type such as its properties, methods, and events.  
  
## Syntax  
  
```  
GetType(typename)  
```  
  
#### Parameters  
  
|||  
|-|-|  
|Parameter|Description|  
|`typename`|The name of the type for which you desire information.|  
  
## Remarks  
 The `GetType` operator returns the \<xref:System.Type> object for the specified `typename`. You can pass the name of any defined type in `typename`. This includes the following:  
  
-   Any Visual Basic data type, such as `Boolean` or `Date`.  
  
-   Any .NET Framework class, structure, module, or interface, such as \<xref:System.ArgumentException?displayProperty=fullName> or \<xref:System.Double?displayProperty=fullName>.  
  
-   Any class, structure, module, or interface defined by your application.  
  
-   Any array defined by your application.  
  
-   Any delegate defined by your application.  
  
-   Any enumeration defined by Visual Basic, the .NET Framework, or your application.  
  
 If you want to get the type object of an object variable, use the \<xref:System.Type.GetType*?displayProperty=fullName> method.  
  
 The `GetType` operator can be useful in the following circumstances:  
  
-   You must access the metadata for a type at run time. The \<xref:System.Type> object supplies metadata such as type members and deployment information. You need this, for example, to reflect over an assembly. For more information, see \<xref:System.Reflection?displayProperty=fullName>.  
  
-   You want to compare two object references to see if they refer to instances of the same type. If they do, `GetType` returns references to the same \<xref:System.Type> object.  
  
## Example  
 The following examples show the `GetType` operator in use.  
  
 [!code[VbVbalrOperators#26](../VS_visualbasic/codesnippet/VisualBasic/gettype-operator--visual-basic-_1.vb)]  
  
## See Also  
 [Operator Precedence in Visual Basic](../VS_visualbasic/operator-precedence-in-visual-basic.md)   
 [Operators Listed by Functionality](../VS_visualbasic/operators-listed-by-functionality--visual-basic-.md)   
 [Operators and Expressions](../VS_visualbasic/operators-and-expressions-in-visual-basic.md)