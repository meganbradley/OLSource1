---
title: "Variance in Generic Interfaces (Visual Basic)"
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
ms.assetid: cf4096d0-4bb3-45a9-9a6b-f01e29a60333
caps.latest.revision: 3
---
# Variance in Generic Interfaces (Visual Basic)
.NET Framework 4 introduced variance support for several existing generic interfaces. Variance support enables implicit conversion of classes that implement these interfaces. The following interfaces are now variant:  
  
-   <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> (T is covariant)  
  
-   <xref:System.Linq.IQueryable<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>2*> (<CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> are covariant)  
  
-   <xref:System.Collections.Generic.IComparer<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>1*> (T is contravariant)  
  
-   <xref:System.IComparable<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>IEnumerable(Of Object)<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>IEnumerable(Of String)<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>IEnumerable(Of Object)<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>String<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Object<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>Option Strict On<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>strings<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>objects<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>1*> interface is covariant.  
  
 Contravariance permits a method to have argument types that are less derived than that specified by the generic parameter of the interface. To illustrate contravariance, assume that you have created a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class to compare instances of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> class implements the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface. Because the <xref:System.Collections.Generic.IEqualityComparer<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>BaseComparer<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>BaseClass<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>IEnumerable(Of Integer)<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>IEnumerable(Of Object)<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>1*> implements the covariant interface <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>List(Of Object)<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>List(Of String)`. This is illustrated in the following code example.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Using Variance in Interfaces for Generic Collections (Visual Basic)](../vs140/using-variance-in-interfaces-for-generic-collections--visual-basic-.md)   
 [Creating Variant Generic Interfaces (Visual Basic)](../vs140/creating-variant-generic-interfaces--visual-basic-.md)   
 [Generic Interfaces](assetId:///88bf5b04-d371-4edb-ba38-01ec7cabaacf)   
 [Variance in Delegates (Visual Basic)](../vs140/variance-in-delegates--visual-basic-.md)