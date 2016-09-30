---
title: "basic_istringstream::basic_istringstream"
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
  - "std::basic_istringstream::basic_istringstream"
  - "basic_istringstream::basic_istringstream"
  - "basic_istringstream.basic_istringstream"
  - "sstream/std::basic_istringstream::basic_istringstream"
  - "basic_istringstream"
  - "std.basic_istringstream.basic_istringstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_istringstream class, constructor"
  - "basic_istringstream method"
ms.assetid: d38deb70-ff11-416a-add4-f266d04e10df
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_istringstream::basic_istringstream
Constructs an object of type <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 An object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 An rvalue reference of a <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_istream](../vs140/basic_istream-class.md)(<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is the stored object of class [basic_stringbuf](../vs140/basic_stringbuf-class.md)<<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>>. It also initializes <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>13\</CodeContentPlaceHolder><<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>>(<CodeContentPlaceHolder>17\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>).  
  
 The second constructor initializes the base class by calling <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. It also initializes <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>21\</CodeContentPlaceHolder><<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>>(<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>).  
  
 The third constructor initializes the object with the contents of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
## Requirements  
 **Header:** \<sstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_istringstream Class](../vs140/basic_istringstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)