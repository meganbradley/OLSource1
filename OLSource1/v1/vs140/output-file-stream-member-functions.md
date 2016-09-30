---
title: "Output File Stream Member Functions"
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
  - "output streams, member functions"
ms.assetid: 38aaf710-8035-4a34-a0c4-123a5327f28a
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Output File Stream Member Functions
Output stream member functions have three types: those that are equivalent to manipulators, those that perform unformatted write operations, and those that otherwise modify the stream state and have no equivalent manipulator or insertion operator. For sequential, formatted output, you might use only insertion operators and manipulators. For random-access binary disk output, you use other member functions, with or without insertion operators.  
  
## The open Function for Output Streams  
 To use an output file stream ([ofstream](../vs140/ofstream.md)), you must associate that stream with a specific disk file in the constructor or the **open** function. If you use the **open** function, you can reuse the same stream object with a series of files. In either case, the arguments describing the file are the same.  
  
 When you open the file associated with an output stream, you generally specify an **open_mode** flag. You can combine these flags, which are defined as enumerators in the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class, with the bitwise OR ( &#124; ) operator. See [ios_base::openmode](../vs140/ios_base--openmode.md) for a list of the enumerators.  
  
 Three common output stream situations involve mode options:  
  
-   Creating a file. If the file already exists, the old version is deleted.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
-   Appending records to an existing file or creating one if it does not exist.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
-   Opening two files, one at a time, on the same stream.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## The put Function  
 The **put** function writes one character to the output stream. The following two statements are the same by default, but the second is affected by the stream's format arguments:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## The write Function  
 The **write** function writes a block of memory to an output file stream. The length argument specifies the number of bytes written. This example creates an output file stream and writes the binary value of the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> structure to it:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The **write** function does not stop when it reaches a null character, so the complete class structure is written. The function takes two arguments: a <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> pointer and a count of characters to write. Note the required cast to **char\*** before the address of the structure object.  
  
## The seekp and tellp Functions  
 An output file stream keeps an internal pointer that points to the position where data is to be written next. The <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> member function sets this pointer and thus provides random-access disk file output. The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function returns the file position. For examples that use the input stream equivalents to <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, see [The seekg and tellg Functions](../vs140/input-stream-member-functions.md).  
  
## The close Function for Output Streams  
 The **close** member function closes the disk file associated with an output file stream. The file must be closed to complete all disk output. If necessary, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> destructor closes the file for you, but you can use the **close** function if you need to open another file for the same stream object.  
  
 The output stream destructor automatically closes a stream's file only if the constructor or the **open** member function opened the file. If you pass the constructor a file descriptor for an already-open file or use the **attach** member function, you must close the file explicitly.  
  
##  \<a name="vclrferrorprocessingfunctionsanchor10">\</a> Error Processing Functions  
 Use these member functions to test for errors while writing to a stream:  
  
|Function|Return value|  
|--------------|------------------|  
|[bad](../vs140/basic_ios--bad.md)|Returns **true** if there is an unrecoverable error.|  
|[fail](../vs140/basic_ios--fail.md)|Returns **true** if there is an unrecoverable error or an "expected" condition, such as a conversion error, or if the file is not found. Processing can often resume after a call to **clear** with a zero argument.|  
|[good](../vs140/basic_ios--good.md)|Returns **true** if there is no error condition (unrecoverable or otherwise) and the end-of-file flag is not set.|  
|[eof](../vs140/basic_ios--eof.md)|Returns **true** on the end-of-file condition.|  
|[clear](../vs140/basic_ios--clear.md)|Sets the internal error state. If called with the default arguments, it clears all error bits.|  
|[rdstate](../vs140/basic_ios--rdstate.md)|Returns the current error state.|  
  
 The **!** operator is overloaded to perform the same function as the **fail** function. Thus the expression:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 is equivalent to:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The **void\*()** operator is overloaded to be the opposite of the **!** operator; thus the expression:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 is equal to:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The **void\*()** operator is not equivalent to **good** because it does not test for the end of file.  
  
## See Also  
 [Output Streams](../vs140/output-streams.md)