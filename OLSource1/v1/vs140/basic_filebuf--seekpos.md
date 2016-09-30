---
title: "basic_filebuf::seekpos"
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
  - "basic_filebuf.seekpos"
  - "std::basic_filebuf::seekpos"
  - "std.basic_filebuf.seekpos"
  - "seekpos"
  - "basic_filebuf::seekpos"
  - "fstream/std::basic_filebuf::seekpos"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "seekpos method"
ms.assetid: 4df70fdb-7248-4029-b3bd-852d949d2422
caps.latest.revision: 19
robots: noindex,nofollow
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_filebuf::seekpos
Tries to alter the current positions for the controlled streams.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 The position to seek for.  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 Specifies the mode for the pointer position. The default is to allow you to modify the read and write positions.  
  
## Return Value  
 If the file pointer **fp** is a null pointer, the function fails. Otherwise, it endeavors to alter the stream position by calling <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>(**fp**, **&fposn**), where **fposn** is the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> object stored in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>. If that function succeeds, the function returns <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. Otherwise, it returns an invalid stream position. To determine if the stream position is invalid, compare the return value with <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
## Remarks  
 The protected virtual member function endeavors to alter the current positions for the controlled streams. For an object of class [basic_filebuf](../vs140/basic_filebuf-class.md)\<**Elem**, **Tr**>, a stream position can be represented by an object of type <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, which stores an offset and any state information needed to parse a wide stream. Offset zero designates the first element of the stream. (An object of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> stores at least an <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> object.)  
  
 For a file opened for both reading and writing, both the input and output streams are positioned in tandem. To switch between inserting and extracting, you must call either [pubseekoff](../vs140/basic_streambuf--pubseekoff.md) or [pubseekpos](../vs140/basic_streambuf--pubseekpos.md). Calls to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> (and hence to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) have various limitations for text streams, binary streams, and wide streams.  
  
 For a wide stream, if any insertions have occurred since the stream was opened, or since the last call to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, the function calls [overflow](../vs140/basic_filebuf--overflow.md). It also inserts any sequence needed to restore the initial conversion state, by using the file conversion facet **fac** to call **fac**<CodeContentPlaceHolder>14\</CodeContentPlaceHolder> as needed. Each element **byte** of type <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> thus produced is written to the associated stream designated by the file pointer **fp** as if by successive calls of the form <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>(**byte**, **fp**). If the call to **fac.unshift** or any write fails, the function does not succeed.  
  
## Requirements  
 **Header:** \<fstream>  
  
 **Namespace:** std  
  
## See Also  
 [basic_filebuf Class](../vs140/basic_filebuf-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)