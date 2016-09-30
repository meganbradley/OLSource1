---
title: "Variance in Delegates (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
ms.assetid: 38e9353f-74f8-4211-a8f0-7a495414df4a
caps.latest.revision: 7
---
# Variance in Delegates (Visual Basic)
.NET Framework 3.5 introduced variance support for matching method signatures with delegate types in all delegates in C# and Visual Basic. This means that you can assign to delegates not only methods that have matching signatures, but also methods that return more derived types (covariance) or that accept parameters that have less derived types (contravariance) than that specified by the delegate type. This includes both generic and non-generic delegates.  
  
 For example, consider the following code, which has two classes and two delegates: generic and non-generic.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 When you create delegates of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> types, you can assign any one of the following methods to those delegates.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The following code example illustrates the implicit conversion between the method signature and the delegate type.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 For more examples, see [Using Variance in Delegates (Visual Basic)](../vs140/using-variance-in-delegates--visual-basic-.md) and [Using Variance for Func and Action Generic Delegates (Visual Basic)](../vs140/using-variance-for-func-and-action-generic-delegates--visual-basic-.md).  
  
## Variance in Generic Type Parameters  
 In .NET Framework 4 and later you can enable implicit conversion between delegates, so that generic delegates that have different types specified by generic type parameters can be assigned to each other, if the types are inherited from each other as required by variance.  
  
 To enable implicit conversion, you must explicitly declare generic parameters in a delegate as covariant or contravariant by using the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> keyword.  
  
 The following code example shows how you can create a delegate that has a covariant generic type parameter.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If you use only variance support to match method signatures with delegate types and do not use the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> keywords, you may find that sometimes you can instantiate delegates with identical lambda expressions or methods, but you cannot assign one delegate to another.  
  
 In the following code example, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> can't be explicitly converted to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, although <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> inherits <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>. You can fix this problem by marking the generic parameter <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> with the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> keyword.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Generic Delegates That Have Variant Type Parameters in the .NET Framework  
 .NET Framework 4 introduced variance support for generic type parameters in several existing generic delegates:  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> delegates from the \<xref:System*> namespace, for example, <xref:System.Action<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>2*>  
  
-   <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> delegates from the \<xref:System*> namespace, for example, <xref:System.Func<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>2*>  
  
-   The <xref:System.Predicate<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>1*> delegate  
  
-   The <xref:System.Converter<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>out<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>in<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>ByRef<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>+<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>DVariant(Of Int)<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>DVariant(Of Object)<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>DVariant(Of Long)`, because integer is a value type.  
  
 The following example demonstrates that variance in generic type parameters is not supported for value types.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## Relaxed Delegate Conversion in Visual Basic  
 Relaxed delegate conversion enables more flexibility in matching method signatures with delegate types. For example, it lets you omit parameter specifications and omit function return values when you assign a method to a delegate. For more information, see [Relaxed Delegate Conversion](../vs140/relaxed-delegate-conversion--visual-basic-.md).  
  
## See Also  
 [Generics in the .NET Framework](assetId:///2994d786-c5c7-4666-ab23-4c83129fe39c)   
 [Using Variance for Func and Action Generic Delegates (Visual Basic)](../vs140/using-variance-for-func-and-action-generic-delegates--visual-basic-.md)