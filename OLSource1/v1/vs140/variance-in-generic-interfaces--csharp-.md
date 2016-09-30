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
---
# Variance in Generic Interfaces (C#)
.NET Framework 4 introduced variance support for several existing generic interfaces. Variance support enables implicit conversion of classes that implement these interfaces. The following interfaces are now variant:  
  
-   <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> (T is covariant)  
  
-   <xref:System.Linq.IQueryable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>2*> (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are covariant)  
  
-   <xref:System.Collections.Generic.IComparer<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*> (T is contravariant)  
  
-   <xref:System.IComparable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>IEnumerable<Object><CodeContentPlaceHolder>10\</CodeContentPlaceHolder>IEnumerable<String><CodeContentPlaceHolder>11\</CodeContentPlaceHolder>IEnumerable<String><CodeContentPlaceHolder>12\</CodeContentPlaceHolder>IEnumerable<Object><CodeContentPlaceHolder>13\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Option Strict On<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>strings<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>objects<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>1*> interface is covariant.  
  
 Contravariance permits a method to have argument types that are less derived than that specified by the generic parameter of the interface. To illustrate contravariance, assume that you have created a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class to compare instances of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class implements the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface. Because the <xref:System.Collections.Generic.IEqualityComparer<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>BaseComparer<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>BaseClass<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>IEnumerable<int><CodeContentPlaceHolder>26\</CodeContentPlaceHolder>IEnumerable<object><CodeContentPlaceHolder>27\</CodeContentPlaceHolder>1*> implements the covariant interface <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>List<Object><CodeContentPlaceHolder>29\</CodeContentPlaceHolder>List<String>`. This is illustrated in the following code example.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Using Variance in Interfaces for Generic Collections (C#)](../vs140/using-variance-in-interfaces-for-generic-collections--csharp-.md)   
 [Creating Variant Generic Interfaces (C#)](../vs140/creating-variant-generic-interfaces--csharp-.md)   
 [Generic Interfaces](assetId:///88bf5b04-d371-4edb-ba38-01ec7cabaacf)   
 [Variance in Delegates (C#)](../vs140/variance-in-delegates--csharp-.md)