---
title: "basic_ifstream::basic_ifstream"
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
  - "fstream/std::basic_ifstream::basic_ifstream"
  - "basic_ifstream"
  - "std.basic_ifstream.basic_ifstream"
  - "basic_ifstream.basic_ifstream"
  - "basic_ifstream::basic_ifstream"
  - "std::basic_ifstream::basic_ifstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ifstream class, constructor"
  - "basic_ifstream method"
ms.assetid: f2915c41-838e-4a72-a94b-dec9cd8aa9e2
caps.latest.revision: 24
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ifstream::basic_ifstream
Constructs an object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_istream](../vs140/basic_istream-class.md)(<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>>. It also initializes <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> by calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder><<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>>.  
  
 The second and third constructors initializes the base class by calling <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>(<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>). It also initializes <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> by calling [basic_filebuf](../vs140/basic_filebuf--basic_filebuf.md)<<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>>, then <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.[open](../vs140/basic_filebuf--open.md)(<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios--setstate.md)(<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>).  
  
 The fourth constructor initializes the object with the contents of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
## Example  
 The following example shows how to read in text from a file. To create the file, see the example for [basic_ofstream::basic_ofstream](../vs140/basic_ofstream--basic_ofstream.md).  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input: basic_ifstream_ctor.txt  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ifstream Class](../vs140/basic_ifstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)