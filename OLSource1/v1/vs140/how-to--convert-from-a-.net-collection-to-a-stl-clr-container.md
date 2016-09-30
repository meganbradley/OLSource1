---
title: "How to: Convert from a .NET Collection to a STL-CLR Container"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
H1: "How to: Convert from a .NET Collection to a STL/CLR Container"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "STL/CLR, converting from .NET collections"
  - "STL/CLR Containers [STL/CLR]"
ms.assetid: bb927c48-78e8-4150-bd0b-787c651f4a87
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Convert from a .NET Collection to a STL-CLR Container
This topic shows how to convert .NET collections to their equivalent STL/CLR containers. As an example we show how to convert a .NET <xref:System.Collections.Generic.List<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>2*> to a STL/CLR [map](../vs140/map--stl-clr-.md), but the procedure is similar for all collections and containers.  
  
### To create a container from a collection  
  
1.  To convert an entire collection, create a STL/CLR container and pass the collection to the constructor.  
  
     The first example demonstrates this procedure.  
  
 -OR-  
  
1.  Create a generic STL/CLR container by creating a [collection_adapter](../vs140/collection_adapter--stl-clr-.md) object. This template class takes a .NET collection interface as an argument. To verify which interfaces are supported, see [collection_adapter (STL/CLR)](../vs140/collection_adapter--stl-clr-.md).  
  
2.  Copy the contents of the .NET collection to the container. This can be done by using a STL/CLR [algorithm](../vs140/algorithm--stl-clr-.md), or by iterating over the .NET collection and inserting a copy of each element into the STL/CLR container.  
  
     The second example demonstrates this procedure.  
  
## Example  
 In this example, we create a generic <xref:System.Collections.Generic.List<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>vector<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1*> as an argument.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **The contents of the cliext::vector are:**  
**2**  
**3**  
**5**  
**7**  
**11**   
## Example  
 In this example, we create a generic <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>collection_adapter<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>2*> as a simple STL/CLR container. Finally, we create a <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and copy the contents of the <xref:System.Collections.Generic.Dictionary<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>map<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>collection_adapter<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>make_pair<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>map`.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The contents of the cliext::map are:**  
**Key: 0.00 Value: 0**  
**Key: 13.00 Value: 13**  
**Key: 22.00 Value: 22**  
**Key: 42.00 Value: 42**  
**Key: 74.00 Value: 74**   
## See Also  
 [STL/CLR Library Reference](../vs140/stl-clr-library-reference.md)   
 [adapter (STL/CLR)](../vs140/adapter--stl-clr-.md)   
 [How to: Convert from a STL/CLR Container to a .NET Collection](../vs140/how-to--convert-from-a-stl-clr-container-to-a-.net-collection.md)