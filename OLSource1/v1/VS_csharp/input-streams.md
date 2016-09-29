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
An input stream object is a source of bytes. The three most important input stream classes are [istream](assetId:///6801779e-260e-416d-b4ec-fef5ff1b2371), [ifstream](../Topic/ifstream.md), and [istringstream](../Topic/istringstream.md).  
  
 The `istream` class is best used for sequential text-mode input. You can configure objects of class `istream` for buffered or unbuffered operation. All functionality of the base class, `ios`, is included in `istream`. You will rarely construct objects from class `istream`. Instead, you will generally use the predefined `cin` object, which is actually an object of class [ostream](../VS_csharp/-ostream-.md). In some cases, you can assign `cin` to other stream objects after program startup.  
  
 The `ifstream` class supports disk file input. If you need an input-only disk file, construct an object of class `ifstream`. You can specify binary or text-mode data. If you specify a filename in the constructor, the file is automatically opened when the object is constructed. Otherwise, you can use the `open` function after invoking the default constructor. Many formatting options and member functions apply to `ifstream` objects. All functionality of the base classes `ios` and `istream` is included in `ifstream`.  
  
 Like the library function `sscanf_s`, the `istringstream` class supports input from in-memory strings. To extract data from a character array that has a null terminator, allocate and initialize the string, then construct an object of class `istringstream`.  
  
## In This Section  
 [Constructing Input Stream Objects](../VS_csharp/constructing-input-stream-objects.md)  
  
 [Using Extraction Operators](../VS_csharp/using-extraction-operators.md)  
  
 [Testing for Extraction Errors](../VS_csharp/testing-for-extraction-errors.md)  
  
 [Input Stream Manipulators](../VS_csharp/input-stream-manipulators.md)  
  
 [Input Stream Member Functions](../VS_csharp/input-stream-member-functions.md)  
  
 [Overloading the >> Operator for Your Own Classes](../VS_csharp/overloading-the----operator-for-your-own-classes.md)  
  
## See Also  
 [iostream Programming](../VS_csharp/iostream-programming.md)