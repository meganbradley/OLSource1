---
title: "&lt;ostream&gt;"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "std.<ostream>"
  - "<ostream>"
  - "ostream/std::<ostream>"
  - "std::<ostream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "ostream header"
ms.assetid: 90c3b6fb-57cd-4ae7-99b8-8512f24a67d2
caps.latest.revision: 22
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;ostream&gt;
Defines the template class [basic_ostream](../vs140/basic_ostream-class.md), which mediates insertions for the iostreams. The header also defines several related manipulators. (This header is typically included for you by another of the iostreams headers. You rarely need to include it directly.)  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Typedefs  
  
|||  
|-|-|  
|[ostream](../vs140/-ostream--typedefs.md#ostream)|Creates a type from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> that is specialized on <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> specialized on <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|[wostream](../vs140/-ostream--typedefs.md#wostream)|Creates a type from <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> that is specialized on <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> specialized on <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.|  
  
### Manipulators  
  
|||  
|-|-|  
|[endl](../vs140/-ostream--functions.md#endl)|Terminates a line and flushes the buffer.|  
|[ends](../vs140/-ostream--functions.md#ends)|Terminates a string.|  
|[flush](../vs140/-ostream--functions.md#flush)|Flushes the buffer.|  
|[swap](../vs140/-ostream--functions.md#swap)|Exchanges the values of the left <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object parameter for those of the right <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object parameter.|  
  
### Operators  
  
|||  
|-|-|  
|[operator<<](../vs140/-ostream--operators.md#operator_lt__lt_)|Writes various types to the stream.|  
  
### Classes  
  
|||  
|-|-|  
|[basic_ostream](../vs140/basic_ostream-class.md)|The template class describes an object that controls insertion of elements and encoded objects into a stream buffer.|  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)