---
title: "Variance in Generic Interfaces (C#)"
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
ms.assetid: 4828a8f9-48c0-4128-9749-7fcd6bf19a06
caps.latest.revision: 7
author: ""
ms.author: ""
manager: ""
---
# Variance in Generic Interfaces (C#)
.NET Framework 4 introduced variance support for several existing generic interfaces. Variance support enables implicit conversion of classes that implement these interfaces. The following interfaces are now variant:  
  
-   <xref:System.Collections.Generic.IEnumerable`1*> (T is covariant)  
  
-   <xref:System.Collections.Generic.IEnumerator`1*> (T is covariant)  
  
-   <xref:System.Linq.IQueryable`1*> (T is covariant)  
  
-   <xref:System.Linq.IGrouping`2*> (`TKey` and `TElement` are covariant)  
  
-   <xref:System.Collections.Generic.IComparer`1*> (T is contravariant)  
  
-   <xref:System.Collections.Generic.IEqualityComparer`1*> (T is contravariant)  
  
-   <xref:System.IComparable`1*> (T is contravariant)  
  
 Covariance permits a method to have a more derived return type than that defined by the generic type parameter of the interface. To illustrate the covariance feature, consider these generic interfaces: `IEnumerable<Object>` and `IEnumerable<String>`. The `IEnumerable<String>` interface does not inherit the `IEnumerable<Object>` interface. However, the `String` type does inherit the `Object` type, and in some cases you may want to assign objects of these interfaces to each other. This is shown in the following code example.  
  
```c#  
IEnumerable<String> strings = new List<String>();  
IEnumerable<Object> objects = strings;  
```  
  
 In earlier versions of the .NET Framework, this code causes a compilation error in C# with `Option Strict On`. But now you can use `strings` instead of `objects`, as shown in the previous example, because the <xref:System.Collections.Generic.IEnumerable`1*> interface is covariant.  
  
 Contravariance permits a method to have argument types that are less derived than that specified by the generic parameter of the interface. To illustrate contravariance, assume that you have created a `BaseComparer` class to compare instances of the `BaseClass` class. The `BaseComparer` class implements the `IEqualityComparer<BaseClass>` interface. Because the <xref:System.Collections.Generic.IEqualityComparer`1*> interface is now contravariant, you can use `BaseComparer` to compare instances of classes that inherit the `BaseClass` class. This is shown in the following code example.  
  
```c#  
// Simple hierarchy of classes.  
class BaseClass { }  
class DerivedClass : BaseClass { }  
  
// Comparer class.  
class BaseComparer : IEqualityComparer<BaseClass>   
{  
    public int GetHashCode(BaseClass baseInstance)  
    {  
        return baseInstance.GetHashCode();  
    }  
    public bool Equals(BaseClass x, BaseClass y)  
    {  
        return x == y;  
    }  
}  
class Program  
{  
    static void Test()  
    {  
        IEqualityComparer<BaseClass> baseComparer = new BaseComparer();  
  
        // Implicit conversion of IEqualityComparer<BaseClass> to   
        // IEqualityComparer<DerivedClass>.  
        IEqualityComparer<DerivedClass> childComparer = baseComparer;  
    }  
}  
```  
  
 For more examples, see [Using Variance in Interfaces for Generic Collections (C#)](../vs140/using-variance-in-interfaces-for-generic-collections--csharp-.md).  
  
 Variance in generic interfaces is supported for reference types only. Value types do not support variance. For example, `IEnumerable<int>` cannot be implicitly converted to `IEnumerable<object>`, because integers are represented by a value type.  
  
```c#  
IEnumerable<int> integers = new List<int>();  
// The following statement generates a compiler errror,  
// because int is a value type.  
// IEnumerable<Object> objects = integers;  
```  
  
 It is also important to remember that classes that implement variant interfaces are still invariant. For example, although <xref:System.Collections.Generic.List`1*> implements the covariant interface <xref:System.Collections.Generic.IEnumerable`1*>, you cannot implicitly convert `List<Object>` to `List<String>`. This is illustrated in the following code example.  
  
```c#  
// The following line generates a compiler error  
// because classes are invariant.  
// List<Object> list = new List<String>();  
  
// You can use the interface object instead.  
IEnumerable<Object> listObjects = new List<String>();  
```  
  
## See Also  
 [Using Variance in Interfaces for Generic Collections (C#)](../vs140/using-variance-in-interfaces-for-generic-collections--csharp-.md)   
 [Creating Variant Generic Interfaces (C#)](../vs140/creating-variant-generic-interfaces--csharp-.md)   
 [Generic Interfaces](assetId:///88bf5b04-d371-4edb-ba38-01ec7cabaacf)   
 [Variance in Delegates (C#)](../vs140/variance-in-delegates--csharp-.md)