---
title: "basic_filebuf::seekoff"
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
  - "seekoff"
  - "std::basic_filebuf::seekoff"
  - "basic_filebuf.seekoff"
  - "std.basic_filebuf.seekoff"
  - "fstream/std::basic_filebuf::seekoff"
  - "basic_filebuf::seekoff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekoff method"
ms.assetid: 13d37790-45ea-4d7d-9e7c-6f9ede87255a
caps.latest.revision: 17
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::seekoff
Tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position to seek for relative to <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The starting point for offset operations. See [seekdir](../vs140/ios_base--seekdir.md) for possible values.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 Returns the new position or an invalid stream position.  
  
## Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class [basic_filebuf](../vs140/basic_filebuf-class.md)<<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>>, a stream position can be represented by an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, which stores an offset and any state information needed to parse a wide stream. Offset zero designates the first element of the stream. (An object of type [pos_type](../vs140/basic_streambuf--pos_type.md) stores at least an <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> object.)  
  
 For a file opened for both reading and writing, both the input and output streams are positioned in tandem. To switch between inserting and extracting, you must call either [pubseekoff](../vs140/basic_streambuf--pubseekoff.md) or [pubseekpos](../vs140/basic_streambuf--pubseekpos.md). Calls to <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> (and hence to <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>) have various limitations for [text streams](../vs140/text-and-binary-streams.md), [binary streams](../vs140/text-and-binary-streams.md), and [wide streams](../vs140/byte-and-wide-streams.md).  
  
 If the file pointer **fp** is a null pointer, the function fails. Otherwise, it endeavors to alter the stream position by calling <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>(**fp**, <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>). If that function succeeds and the resulting position **fposn** can be determined by calling <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>(**fp**, **&fposn**), the function succeeds. If the function succeeds, it returns a value of type **pos_type** containing **fposn**. Otherwise, it returns an invalid stream position.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)