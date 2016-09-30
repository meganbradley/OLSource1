---
title: "Creating Variant Generic Interfaces (C#)"
ms.custom: na
ms.date: "09/22/2016"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
ms.assetid: 30330ec4-9df2-4838-a535-6c406d0ed4df
caps.latest.revision: 7
---
# Creating Variant Generic Interfaces (C#)
You can declare generic type parameters in interfaces as covariant or contravariant. *Covariance* allows interface methods to have more derived return types than that defined by the generic type parameters. *Contravariance* allows interface methods to have argument types that are less derived than that specified by the generic parameters. A generic interface that has covariant or contravariant generic type parameters is called *variant*.  
  
> [!NOTE]
>  .NET Framework 4 introduced variance support for several existing generic interfaces. For the list of the variant interfaces in the .NET Framework, see [Variance in Generic Interfaces (C#)](../vs140/variance-in-generic-interfaces--csharp-.md).  
  
## Declaring Variant Generic Interfaces  
 You can declare variant generic interfaces by using the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> keywords for generic type parameters.  
  
> [!IMPORTANT]
>  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> parameters in C# cannot be variant. Value types also do not support variance.  
  
 You can declare a generic type parameter covariant by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword. The covariant type must satisfy the following conditions:  
  
-   The type is used only as a return type of interface methods and not used as a type of method arguments. This is illustrated in the following example, in which the type <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> is declared covariant.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     There is one exception to this rule. If you have a contravariant generic delegate as a method parameter, you can use the type as a generic type parameter for the delegate. This is illustrated by the type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> in the following example. For more information, see [Variance in Delegates (C#)](../vs140/variance-in-delegates--csharp-.md) and [Using Variance for Func and Action Generic Delegates (C#)](../vs140/using-variance-for-func-and-action-generic-delegates--csharp-.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   The type is not used as a generic constraint for the interface methods. This is illustrated in the following code.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 You can declare a generic type parameter contravariant by using the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> keyword. The contravariant type can be used only as a type of method arguments and not as a return type of interface methods. The contravariant type can also be used for generic constraints. The following code shows how to declare a contravariant interface and use a generic constraint for one of its methods.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 It is also possible to support both covariance and contravariance in the same interface, but for different type parameters, as shown in the following code example.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## Implementing Variant Generic Interfaces  
 You implement variant generic interfaces in classes by using the same syntax that is used for invariant interfaces. The following code example shows how to implement a covariant interface in a generic class.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Classes that implement variant interfaces are invariant. For example, consider the following code.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
## Extending Variant Generic Interfaces  
 When you extend a variant generic interface, you have to use the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> keywords to explicitly specify whether the derived interface supports variance. The compiler does not infer the variance from the interface that is being extended. For example, consider the following interfaces.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 In the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> interface, the generic type parameter <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is invariant, whereas in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> the type parameter is covariant, although both interfaces extend the same interface. The same rule is applied to contravariant generic type parameters.  
  
 You can create an interface that extends both the interface where the generic type parameter <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> is covariant and the interface where it is contravariant if in the extending interface the generic type parameter <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> is invariant. This is illustrated in the following code example.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 However, if a generic type parameter <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> is declared covariant in one interface, you cannot declare it contravariant in the extending interface, or vice versa. This is illustrated in the following code example.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
### Avoiding Ambiguity  
 When you implement variant generic interfaces, variance can sometimes lead to ambiguity. This should be avoided.  
  
 For example, if you explicitly implement the same variant generic interface with different generic type parameters in one class, it can create ambiguity. The compiler does not produce an error in this case, but it is not specified which interface implementation will be chosen at runtime. This could lead to subtle bugs in your code. Consider the following code example.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 In this example, it is unspecified how the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method chooses between <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>. This could cause problems in your code.  
  
## See Also  
 [Variance in Generic Interfaces (C#)](../vs140/variance-in-generic-interfaces--csharp-.md)   
 [Using Variance for Func and Action Generic Delegates (C#)](../vs140/using-variance-for-func-and-action-generic-delegates--csharp-.md)