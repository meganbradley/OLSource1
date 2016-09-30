---
title: "Output Streams"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "output streams"
ms.assetid: b49410e3-5caa-4153-9d0d-c4266408dc83
caps.latest.revision: 15
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Output Streams
An output stream object is a destination for bytes. The three most important output stream classes are <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class, through the derived class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, supports the predefined stream objects:  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> standard output  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> standard error with limited buffering  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> similar to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> but with full buffering  
  
 Objects are rarely constructed from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>; predefined objects are generally used. In some cases, you can reassign predefined objects after program startup. The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class, which can be configured for buffered or unbuffered operation, is best suited to sequential text-mode output. All functionality of the base class, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, is included in <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If you construct an object of class <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, you must specify a <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> object to the constructor.  
  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class supports disk file output. If you need an output-only disk, construct an object of class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. You can specify whether <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> objects accept binary or text-mode data when constructing the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object or when calling the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> member function of the object. Many formatting options and member functions apply to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> objects, and all functionality of the base classes <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is included.  
  
 If you specify a filename in the constructor, that file is automatically opened when the object is constructed. Otherwise, you can use the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> member function after invoking the default constructor.  
  
 Like the run-time function <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> class supports output to in-memory strings. To create a string in memory by using I/O stream formatting, construct an object of class <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
## In This Section  
 [Constructing Output Stream Objects](../vs140/constructing-output-stream-objects.md)  
  
 [Using Insertion Operators and Controlling Format](../vs140/using-insertion-operators-and-controlling-format.md)  
  
 [Output File Stream Member Functions](../vs140/output-file-stream-member-functions.md)  
  
 [The Effects of Buffering](../vs140/effects-of-buffering.md)  
  
 [Binary Output Files](../vs140/binary-output-files.md)  
  
 [Overloading the << Operator for Your Own Classes](../vs140/overloading-the----operator-for-your-own-classes.md)  
  
 [Writing Your Own Manipulators Without Arguments](../vs140/writing-your-own-manipulators-without-arguments.md)  
  
## See Also  
 [\<ostream> Members](assetId:///a5afd034-0e3c-41ee-bbd7-468d9188da1d)   
 [ofstream](../vs140/ofstream.md)   
 [ostringstream](../vs140/ostringstream.md)   
 [basic_ostream Members](assetId:///82e5cc91-7c0c-4950-a8ce-ac779cfbbd93)   
 [iostream Programming](../vs140/iostream-programming.md)