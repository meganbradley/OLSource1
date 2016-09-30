---
title: "Arrays (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "cli::array"
  - "details::array"
  - "lang::array"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "array keyword [C++]"
  - "declaring arrays, about declaring arrays"
  - "arrays [C++], multidimensional"
  - "multidimensional arrays"
  - "arrays [C++]"
ms.assetid: 49445812-d775-4db1-a231-869598dbb955
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Arrays (C++ Component Extensions)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> type in [!INCLUDE[cppwrt_short](../vs140/includes/cppwrt_short_md.md)], or the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> keyword in [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)], declares an array of a specified type and initial value.  
  
## All Platforms  
 The array must be declared by using the handle-to-object (^) modifier after the closing angle bracket (>) in the declaration.  
  
 The number of elements of the array is not part of the type. One array variable can refer to arrays of different sizes.  
  
 Unlike standard C++, subscripting is not a synonym for pointer arithmetic and is not commutative.  
  
 For more information about arrays, see:  
  
-   [Array Covariance](../vs140/array-covariance.md)  
  
-   [How to: Use Arrays in C++/CLI](../vs140/how-to--use-arrays-in-c---cli.md)  
  
-   [How to: Create Multidimension Arrays](../vs140/how-to--create-multidimension-arrays.md)  
  
-   [How to: Create Arrays of Managed Arrays (Jagged Arrays)](../vs140/how-to--create-arrays-of-managed-arrays--jagged-arrays-.md)  
  
-   [How to: Make Typedefs for Managed Arrays](../vs140/how-to--make-typedefs-for-managed-arrays.md)  
  
-   [How to: Use Managed Arrays as Template Type Parameters](../vs140/how-to--use-managed-arrays-as-template-type-parameters.md)  
  
-   [Variable Argument Lists (...) (C++/CLI)](../vs140/variable-argument-lists--...---c---cli-.md)  
  
-   [How to: Sort Arrays](../vs140/how-to--sort-arrays.md)  
  
-   [How to: Sort Arrays Using Custom Criteria](../vs140/how-to--sort-arrays-using-custom-criteria.md)  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
 Arrays are members of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace. Arrays can be only one-dimensional.  
  
 **Syntax**  
  
 The first example of the syntax uses the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> aggregate keyword to allocate an array. The second example declares a local array.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 *qualifiers* [optional]  
 One or more of these storage class specifiers: [mutable](../vs140/mutable-data-members--c---.md), [volatile](../vs140/volatile--c---.md), [const](../vs140/const--c---.md), [extern](../vs140/using-extern-to-specify-linkage.md), [static](../vs140/static--c---.md).  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The type of the array variable. Valid types are [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] classes and fundamental types, ref classes and structs, value classes and structs, and native pointers (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> [optional]  
 The number of dimensions of the array. Must be 1.  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 The name of the array variable.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 The type of the values that initialize the array. Typically, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> are the same type. However, the types can be different if there is a conversion from <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>—for example, if <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> [optional]  
 A comma-delimited list of values in curly brackets that initialize the elements of the array. For example, if <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> were <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, which declares a one-dimensional array of 3 elements, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> could be <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>.  
  
 **Remarks**  
  
 You can detect at compile time whether a type is a reference-counted array with <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
### Requirements  
 Compiler option: **/ZW**  
  
### Examples  
 The following example creates a one-dimensional array that has 100 elements.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 **Syntax**  
  
 The first example of the syntax uses the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> keyword to allocate an array. The second example declares a local array.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 *qualifiers* [optional]  
 One or more of these storage class specifiers: [mutable](../vs140/mutable-data-members--c---.md), [volatile](../vs140/volatile--c---.md), [const](../vs140/const--c---.md), [extern](../vs140/using-extern-to-specify-linkage.md), [static](../vs140/static--c---.md).  
  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 The type of the array variable. Valid types are [!INCLUDE[wrt](../vs140/includes/wrt_md.md)] classes and fundamental types, ref classes and structs, value classes and structs, native pointers (<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>), and native POD (plain old data) types.  
  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> [optional]  
 The number of dimensions of the array. The default is 1; the maximum is 32. Each dimension of the array is itself an array.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 The name of the array variable.  
  
 <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>  
 The type of the values that initialize the array. Typically, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> are the same type. However, the types can be different if there is a conversion from <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>—for example, if <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> is derived from <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
 A comma-delimited list of the size of each dimension in the array. Alternatively, if the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> parameter is specified, the compiler can deduce the size of each dimension and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> can be omitted. For more information, see [How to: Create Multidimension Arrays](../vs140/how-to--create-multidimension-arrays.md).  
  
 <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> [optional]  
 A comma-delimited list of values in curly brackets that initialize the elements of the array. Or a comma-delimited list of nested *initialization-list* items that initialize the elements in a multi-dimensional array.  
  
 For example, if <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> were <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, which declares a one-dimensional array of 3 elements, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> could be <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> were <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, which declares a three-dimensional array of 3 elements in the first dimension, 2 elements in the second, and 4 elements in the third, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> could be <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>.)  
  
 **Remarks**  
  
 <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> is in the [cli](../vs140/platform--default--and-cli-namespaces---c---component-extensions-.md) namespace.  
  
 Like standard C++, the indices of an array are zero-based, and an array is subscripted by using square brackets ([]). Unlike standard C++, the indices of a multi-dimensional array are specified in a list of indices for each dimension instead of a set of square-bracket ([]) operators for each dimension. For example, *identifier*[*index1*, *index2*] instead of *identifier*[*index1*][ *index2*].  
  
 All managed arrays inherit from <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>. Any method or property of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> can be applied directly to the array variable.  
  
 When you allocate an array whose element type is pointer-to a managed class, the elements are 0-initialized.  
  
 When you allocate an array whose element type is a value type <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, the default constructor for <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is applied to each array element. For more information, see [.NET Framework Equivalents to C++ Native Types (C++/CLI)](../vs140/.net-framework-equivalents-to-c---native-types--c---cli-.md).  
  
 At compile time, you can detect whether a type is a common language runtime (CLR) array with<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>. For more information, see [Intrinsic Support for Type Traits](../vs140/compiler-support-for-type-traits--c---component-extensions-.md).  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 The following example creates a one-dimensional array that has 100 elements, and a three-dimensional array that has 3 elements in the first dimension, 5 elements in the second, and 6 elements in the third.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)