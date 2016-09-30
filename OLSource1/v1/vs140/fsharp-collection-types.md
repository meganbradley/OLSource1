---
title: "F# Collection Types"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "collection types, F#"
ms.assetid: 19614f04-2b0e-422b-9556-3ad0c6508f77
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# F# Collection Types
By reviewing this topic, you can determine which F# collection type best suits a particular need. These collection types differ from the collection types in the .NET Framework, such as those in the \<xref:System.Collections.Generic*> namespace, in that the F# collection types are designed from a functional programming perspective rather than an object-oriented perspective. More specifically, only the array collection has mutable elements. Therefore, when you modify a collection, you create an instance of the modified collection instead of altering the original collection.  
  
 Collection types also differ in the type of data structure in which objects are stored. Data structures such as hash tables, linked lists, and arrays have different performance characteristics and a different set of available operations.  
  
## F# Collection Types  
 The following table shows F# collection types.  
  
|Type|Description|Related Links|  
|----------|-----------------|-------------------|  
|[List](../vs140/collections.list--t--union--fsharp-.md)|An ordered, immutable series of elements of the same type. Implemented as a linked list.|[Lists (F#)](../vs140/lists--fsharp-.md)\<br />\<br /> [List Module](../vs140/collections.list-module--fsharp-.md)|  
|[Array](../vs140/collections.array-module--fsharp-.md)|A fixed-size, zero-based, mutable collection of consecutive data elements that are all of the same type.|[Arrays (F#)](../vs140/arrays--fsharp-.md)\<br />\<br /> [Array Module](../vs140/collections.array-module--fsharp-.md)\<br />\<br /> [Array2D Module](../vs140/collections.array2d-module--fsharp-.md)\<br />\<br /> [Array3D Module](../vs140/collections.array3d-module--fsharp-.md)|  
|[seq](../vs140/collections.seq--t--type-abbreviation--fsharp-.md)|A logical series of elements that are all of one type. Sequences are particularly useful when you have a large, ordered collection of data but don't necessarily expect to use all the elements. Individual sequence elements are computed only as required, so a sequence can perform better than a list if not all the elements are used. Sequences are represented by the seq\<'T> type, which is an alias for IEnumerable\<T>. Therefore, any .NET Framework type that implements <xref:System.Collections.Generic.IEnumerable<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>f<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>x<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>Some(f(x))<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>false<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>true<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>None<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>None<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Some<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>None`.|  
|unfold|-|-|O(N)|-|-|Returns a sequence that contains the elements that the given computation generates.|  
|union|-|-|-|-|O(M * log N)|Computes the union of the two sets.|  
|unionMany|-|-|-|-|O(N1 * N2 ...)|Computes the union of a sequence of sets.|  
|unzip|O(N)|O(N)|O(N)|-|-|Splits a list of pairs into two lists.|  
|unzip3|O(N)|O(N)|O(N)|-|-|Splits a list of triples into three lists.|  
|windowed|-|-|O(N)|-|-|Returns a sequence that yields sliding windows of containing elements that are drawn from the input sequence. Each window is returned as a fresh array.|  
|zip|O(N)|O(N)|O(N)|-|-|Combines the two collections into a list of pairs. The two lists must have equal lengths.|  
|zip3|O(N)|O(N)|O(N)|-|-|Combines the three collections into a list of triples. The lists must have equal lengths.|  
  
## See Also  
 [F# Types](../vs140/fsharp-types.md)   
 [F# Language Reference](../vs140/fsharp-language-reference.md)