---
title: "Input Stream Member Functions"
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
  - "input stream objects"
  - "input streams, member functions"
ms.assetid: b4b9465d-0da9-4ccf-859d-72a68418982e
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Input Stream Member Functions
Input stream member functions are used for disk input. The member functions include:  
  
-   [The open Function for Input Streams](#vclrftheopenfunctionforinputstreamsanchor11)  
  
-   [The get Function](#vclrfthegetfunctionanchor12)  
  
-   [The getline Function](#vclrfthegetlinefunctionanchor13)  
  
-   [The read Function](#vclrfthereadfunctionanchor14)  
  
-   [The seekg and tellg Functions](#vclrftheseekgandtellgfunctionsanchor7)  
  
-   [The close Function for Input Streams](#vclrftheclosefunctionforinputstreamsanchor15)  
  
##  \<a name="vclrftheopenfunctionforinputstreamsanchor11">\</a> The open Function for Input Streams  
 If you are using an input file stream (ifstream), you must associate that stream with a specific disk file. You can do this in the constructor, or you can use the **open** function. In either case, the arguments are the same.  
  
 You generally specify an [ios_base::openmode](../vs140/ios_base--openmode.md) flag when you open the file associated with an input stream (the default mode is **ios::in**). For a list of the **open_mode** flags, see [The open Function](#vclrftheopenfunctionforinputstreamsanchor11). The flags can be combined with the bitwise OR ( &#124; ) operator.  
  
 To read a file, first use the **fail** member function to determine whether it exists:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
##  \<a name="vclrfthegetfunctionanchor12">\</a> The get Function  
 The unformatted **get** member function works like the **>>** operator with two exceptions. First, the **get** function includes white-space characters, whereas the extractor excludes white space when the [skipws](../vs140/skipws.md) flag is set (the default). Second, the **get** function is less likely to cause a tied output stream (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, for example) to be flushed.  
  
 A variation of the **get** function specifies a buffer address and the maximum number of characters to read. This is useful for limiting the number of characters sent to a specific variable, as this example shows:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
### Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
### Sample Output  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
##  \<a name="vclrfthegetlinefunctionanchor13">\</a> The getline Function  
 The **getline** member function is similar to the **get** function. Both functions allow a third argument that specifies the terminating character for input. The default value is the newline character. Both functions reserve one character for the required terminating character. However, **get** leaves the terminating character in the stream and **getline** removes the terminating character.  
  
 The following example specifies a terminating character for the input stream:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Input  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
##  \<a name="vclrfthereadfunctionanchor14">\</a> The read Function  
 The **read** member function reads bytes from a file to a specified area of memory. The length argument determines the number of bytes read. If you do not include that argument, reading stops when the physical end of file is reached or, in the case of a text-mode file, when an embedded <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> character is read.  
  
 This example reads a binary record from a payroll file into a structure:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The program assumes that the data records are formatted exactly as specified by the structure with no terminating carriage-return or linefeed characters.  
  
##  \<a name="vclrftheseekgandtellgfunctionsanchor7">\</a> The seekg and tellg Functions  
 Input file streams keep an internal pointer to the position in the file where data is to be read next. You set this pointer with the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> function, as shown here:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 To use <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> to implement record-oriented data management systems, multiply the fixed-length record size by the record number to obtain the byte position relative to the end of the file, and then use the **get** object to read the record.  
  
 The <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> member function returns the current file position for reading. This value is of type <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> defined in \<iostream>. The following example reads a file and displays messages showing the positions of spaces.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
##  \<a name="vclrftheclosefunctionforinputstreamsanchor15">\</a> The close Function for Input Streams  
 The **close** member function closes the disk file associated with an input file stream and frees the operating system file handle. The [ifstream](../vs140/basic_ifstream-class.md) destructor closes the file for you, but you can use the **close** function if you need to open another file for the same stream object.  
  
## See Also  
 [Input Streams](../vs140/input-streams.md)