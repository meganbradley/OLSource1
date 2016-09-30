---
title: "How to: Convert from a STL-CLR Container to a .NET Collection"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "How to: Convert from a STL/CLR Container to a .NET Collection"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "STL/CLR Containers [STL/CLR]"
  - "STL/CLR, converting to .NET collections"
ms.assetid: 70b2dfd9-869c-4e0f-9a29-b1ee0cb0d107
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert from a STL-CLR Container to a .NET Collection
This topic shows how to convert STL/CLR containers to their equivalent .NET collections. As an example, we show how to convert a STL/CLR [vector](../vs140/vector--stl-clr-.md) to a .NET <xref:System.Collections.Generic.ICollection<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>2*>, but the procedure is similar for all collections and containers.  
  
### To create a collection from a container  
  
1.  Use one of the following methods:  
  
    -   To convert part of a container, call the [make_collection](../vs140/make_collection--stl-clr-.md) function, and pass the begin iterator and end iterator of the STL/CLR container to be copied into the .NET collection. This template function takes an STL/CLR iterator as a template argument. The first example demonstrates this method.  
  
    -   To convert an entire container, cast the container to an appropriate .NET collection interface or interface collection. The second example demonstrates this method.  
  
## Example  
 In this example, we create a STL/CLR <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and add 5 elements to it. Then, we create a .NET collection by calling the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> function. Finally, we display the contents of the newly created collection.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **The contents of the System::Collections::Generic::ICollection are:**  
**3**  
**5**  
**7**   
## Example  
 In this example, we create a STL/CLR <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and add 5 elements to it. Then, we create a .NET <xref:System.Collections.Generic.IDictionary<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>map` directly to it. Finally, we display the contents of the newly created collection.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The contents of the IDictionary are:**  
**Key: 0.00 Value: 0**  
**Key: 13.00 Value: 13**  
**Key: 22.00 Value: 22**  
**Key: 42.00 Value: 42**  
**Key: 74.00 Value: 74**   
## See Also  
 [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md)   
 [How to: Convert from a .NET Collection to a STL/CLR Container](../vs140/how-to--convert-from-a-.net-collection-to-a-stl-clr-container.md)   
 [range_adapter (STL/CLR)](../vs140/range_adapter--stl-clr-.md)