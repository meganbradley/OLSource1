---
title: "How to: Define Value Equality for a Type (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "overriding Equals method [C#]"
  - "object equivalence [C#]"
  - "Equals method [C#] , overriding"
  - "value equality [C#]"
  - "equivalence [C#]"
ms.assetid: 4084581e-b931-498b-9534-cf7ef5b68690
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Define Value Equality for a Type (C# Programming Guide)
When you define a class or struct, you decide whether it makes sense to create a custom definition of value equality (or equivalence) for the type. Typically, you implement value equality when objects of the type are expected to be added to a collection of some sort, or when their primary purpose is to store a set of fields or properties. You can base your definition of value equality on a comparison of all the fields and properties in the type, or you can base the definition on a subset. But in either case, and in both classes and structs, your implementation should follow the five guarantees of equivalence:  
  
1.  x.<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>(x) returns <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> This is called the reflexive property.  
  
2.  x.<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>(y) returns the same value as y.<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>(x). This is called the symmetric property.  
  
3.  if (x.<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>(y) && y.<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>(z)) returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, then x.<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>(z) returns <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. This is called the transitive property.  
  
4.  Successive invocations of x.<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>(y) return the same value as long as the objects referenced by x and y are not modified.  
  
5.  x.<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>(null) returns <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>. However, null.Equals(null) throws an exception; it does not obey rule number two above.  
  
 Any struct that you define already has a default implementation of value equality that it inherits from the \<xref:System.ValueType*?displayProperty=fullName> override of the \<xref:System.Object.Equals(System.Object)?displayProperty=fullName> method. This implementation uses reflection to examine all the public and non-public fields and properties in the type. Although this implementation produces correct results, it is relatively slow compared to a custom implementation that you write specifically for the type.  
  
 The implementation details for value equality are different for classes and structs. However, both classes and structs require the same basic steps for implementing equality:  
  
1.  Override the [virtual](../vs140/virtual--csharp-reference-.md)\<xref:System.Object.Equals(System.Object)?displayProperty=fullName> method. In most cases, your implementation of <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> should just call into the type-specific <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method that is the implementation of the <xref:System.IEquatable<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>1*?displayProperty=fullName> interface by providing a type-specific <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> method. This is where the actual equivalence comparison is performed. For example, you might decide to define equality by comparing only one or two fields in your type. Do not throw exceptions from <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For classes only: This method should examine only fields that are declared in the class. It should call <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> to examine fields that are in the base class. (Do not do this if the type inherits directly from \<xref:System.Object*>, because the \<xref:System.Object*> implementation of \<xref:System.Object.Equals(System.Object)?displayProperty=fullName> performs a reference equality check.)  
  
3.  Optional but recommended: Overload the [==](../vs140/==-operator--csharp-reference-.md) and [!=](../vs140/!=-operator--csharp-reference-.md) operators.  
  
4.  Override \<xref:System.Object.GetHashCode*?displayProperty=fullName> so that two objects that have value equality produce the same hash code.  
  
5.  Optional: To support definitions for "greater than" or "less than," implement the <xref:System.IComparable<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>==<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>!=<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Equals<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>==<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>!=<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Equals` method in a stuct, the purpose is to provide a more efficient means of performing the value equality check and optionally to base the comparison on some subset of the struct's field or properties.  
  
 The [==](../vs140/==-operator--csharp-reference-.md) and [!=](../vs140/!=-operator--csharp-reference-.md) operators cannot operate on a struct unless the struct explicitly overloads them.  
  
## See Also  
 [Equality Comparisons](../vs140/equality-comparisons--csharp-programming-guide-.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)