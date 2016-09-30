---
title: "basic_ofstream::basic_ofstream"
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
  - "basic_ofstream::basic_ofstream"
  - "basic_ofstream"
  - "basic_ofstream.basic_ofstream"
  - "fstream/std::basic_ofstream::basic_ofstream"
  - "std::basic_ofstream::basic_ofstream"
  - "std.basic_ofstream.basic_ofstream"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "basic_ofstream method"
  - "basic_ofstream class, constructor"
ms.assetid: 06b702e7-428c-497e-996a-351f38c5347c
caps.latest.revision: 25
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ofstream::basic_ofstream
Creates an object of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The name of the file to open.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 One of the enumerations in [ios_base::openmode](../vs140/ios_base--openmode.md).  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The default file opening protection, equivalent to the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> parameter in [_fsopen, _wsfopen](../vs140/_fsopen--_wfsopen.md).  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The rvalue reference to the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object being used to initialize this <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> object.  
  
## Remarks  
 The first constructor initializes the base class by calling [basic_ostream](../vs140/basic_ostream-class.md)(**sb**), where **sb** is the stored object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>>. It also initializes **sb** by calling <CodeContentPlaceHolder>12\</CodeContentPlaceHolder><<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>>.  
  
 The second and third constructors initializes the base class by calling <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>(**sb**). It also initializes **sb** by calling <CodeContentPlaceHolder>16\</CodeContentPlaceHolder><<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>> and then **sb**.[open](../vs140/basic_filebuf--open.md)(<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>). If the latter function returns a null pointer, the constructor calls [setstate](../vs140/basic_ios--setstate.md)(**failbit**).  
  
 The fourth constructor is a copy function. It initializes the object with the contents of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, treated as an rvalue reference.  
  
## Example  
 The following example shows how to create a <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object and write text to it.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ofstream Class](../vs140/basic_ofstream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)