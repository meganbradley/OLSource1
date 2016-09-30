---
title: "Input Streams"
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
  - "reading data [C++], from input streams"
  - "data [C++], reading from input stream"
  - "input streams"
  - "input stream objects"
ms.assetid: f14d8954-8f8c-4c3c-8b99-14ddb3683f94
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input Streams
An input stream object is a source of bytes. The three most important input stream classes are [istream](assetId:///6801779e-260e-416d-b4ec-fef5ff1b2371), [ifstream](../vs140/ifstream.md), and [istringstream](../vs140/istringstream.md).  
  
 The <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> class is best used for sequential text-mode input. You can configure objects of class <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> for buffered or unbuffered operation. All functionality of the base class, <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, is included in <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. You will rarely construct objects from class <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. Instead, you will generally use the predefined <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> object, which is actually an object of class [ostream](../vs140/-ostream-.md). In some cases, you can assign <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> to other stream objects after program startup.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> class supports disk file input. If you need an input-only disk file, construct an object of class <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. You can specify binary or text-mode data. If you specify a filename in the constructor, the file is automatically opened when the object is constructed. Otherwise, you can use the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> function after invoking the default constructor. Many formatting options and member functions apply to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> objects. All functionality of the base classes <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is included in <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.  
  
 Like the library function <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> class supports input from in-memory strings. To extract data from a character array that has a null terminator, allocate and initialize the string, then construct an object of class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.  
  
## In This Section  
 [Constructing Input Stream Objects](../vs140/constructing-input-stream-objects.md)  
  
 [Using Extraction Operators](../vs140/using-extraction-operators.md)  
  
 [Testing for Extraction Errors](../vs140/testing-for-extraction-errors.md)  
  
 [Input Stream Manipulators](../vs140/input-stream-manipulators.md)  
  
 [Input Stream Member Functions](../vs140/input-stream-member-functions.md)  
  
 [Overloading the >> Operator for Your Own Classes](../vs140/overloading-the----operator-for-your-own-classes.md)  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)