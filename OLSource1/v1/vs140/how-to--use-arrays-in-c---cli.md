---
title: "How to: Use Arrays in C++-CLI"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "How to: Use Arrays in C++/CLI"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "arrays [C++], single-dimension"
ms.assetid: 301cfb3e-199f-42c8-8151-629dce9e87f3
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Use Arrays in C++-CLI
This article describes how to use arrays in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)].  
  
## Single-dimension arrays  
 The following sample shows how to create single-dimension arrays of reference, value, and native pointer types. It also shows how to return a single-dimension array from a function and how to pass a single-dimension array as an argument to a function.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Output**  
  
 **MyClass0[0] = 0**  
**MyClass0[1] = 1**  
**IntArray[0] = 10**  
**IntArray[1] = 11**  
**MyClass1[0] = 20**  
**MyClass1[1] = 21**  
**MyClass2[0] = 30**  
**MyClass2[1] = 31**  
**MyClass2[0] = 32**  
**MyClass2[1] = 33**  
**MyStruct1[0] = 40**  
**MyStruct1[1] = 41** The next sample shows how to perform aggregate initialization on single-dimension managed arrays.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Output**  
  
 **MyClass0[0, 0] = 0**  
**MyClass0[0, 1] = 0**  
**MyClass0[1, 0] = 1**  
**MyClass0[1, 1] = 1**  
**IntArray[0, 0] = 10**  
**IntArray[0, 1] = 10**  
**IntArray[1, 0] = 11**  
**IntArray[1, 1] = 11** This example shows how to perform aggregate initialization on a multi-dimension managed array:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Jagged arrays  
 This section shows how to create single-dimension arrays of managed arrays of reference, value, and native pointer types. It also shows how to return a single-dimension array of managed arrays from a function and how to pass a single-dimension array as an argument to a function.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **MyClass0[0] = 0**  
**MyClass0[0] = 0**  
**MyClass0[1] = 1**  
**MyClass0[1] = 1**  
**IntArray[0] = 10**  
**IntArray[0] = 10**  
**IntArray[1] = 11**  
**IntArray[1] = 11**  
**40**  
**41** The following sample shows how to perform aggregate initialization with jagged arrays.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 **Output**  
  
 **MyClass0[0] = 0**  
**MyClass0[0] = 0**  
**MyClass0[1] = 1**  
**MyClass0[1] = 1**  
**[ 1 2 ]**  
**[ 3 4 5 ]**  
**[ 0 1 ]**  
**[ 2 3 4 ]**  
**[ a b c d e f ]**  
**[ g h ]**   
## Managed arrays as template type parameters  
 This example shows how to use a managed array as a parameter to a template:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 **Output**  
  
 **Return Code: 0**   
## typedefs for managed arrays  
 This example shows how to make a typedef for a managed array:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Sorting arrays  
 Unlike standard C++ arrays, managed arrays are implicitly derived from an array base class from which they inherit common behavior. An example is the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method, which can be used to order the items in any array.  
  
 For arrays that contain basic intrinsic types, you can call the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> method. You can override the sort criteria, and doing so is required when you want to sort for arrays of complex types. In this case, the array element type must implement the [IComparable::CompareTo](https://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx) method.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## Sorting arrays by using custom criteria  
 To sort arrays that contain basic intrinsic types, just call the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method. However, to sort arrays that contain complex types or to override the default sort criteria, override the [IComparable::CompareTo](https://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx) method.  
  
 In the following example, a structure named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> is derived from \<xref:System.IComparable*>, and written to provide a \<xref:System.IComparable.CompareTo*> method that uses the average of two integers as the sort criterion.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
## Array covariance  
 Given reference class D that has direct or indirect base class B, an array of type D can be assigned to an array variable of type B.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 An assignment to an array element shall be assignment-compatible with the dynamic type of the array. An assignment to an array element that has an incompatible type causes <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to be thrown.  
  
 Array covariance doesn't apply to arrays of value class type. For example, arrays of Int32 cannot be converted to Object^ arrays, not even by using boxing.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
## See Also  
 [Arrays](../vs140/arrays--c---component-extensions-.md)