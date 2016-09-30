---
title: "&lt;iostream&gt;"
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
  - "std.<iostream>"
  - "std::<iostream>"
  - "<iostream>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iostream header"
ms.assetid: de5d39e1-7e77-4b55-bcd1-7c77b41515c8
caps.latest.revision: 23
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;iostream&gt;
Declares objects that control reading from and writing to the standard streams. This is often the only header you need to include to perform input and output from a C++ program.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The objects fall into two groups:  
  
-   [cin](#cin), [cout](#cout), [cerr](#cerr), and [clog](#clog) are byte oriented, performing conventional byte-at-a-time transfers.  
  
-   [wcin](#wcin), [wcout](#wcout), [wcerr](#wcerr), and [wclog](#wclog) are wide oriented, translating to and from the wide characters that the program manipulates internally.  
  
 Once you perform certain operations on a stream, such as the standard input, you cannot perform operations of a different orientation on the same stream. Therefore, a program cannot operate interchangeably on both [cin](#cin) and [wcin](#wcin), for example.  
  
 All the objects declared in this header share a peculiar property — you can assume they are constructed before any static objects you define, in a translation unit that includes \<iostream>. Equally, you can assume that these objects are not destroyed before the destructors for any such static objects you define. (The output streams are, however, flushed during program termination.) Therefore, you can safely read from or write to the standard streams before program startup and after program termination.  
  
 This guarantee is not universal, however. A static constructor may call a function in another translation unit. The called function cannot assume that the objects declared in this header have been constructed, given the uncertain order in which translation units participate in static construction. To use these objects in such a context, you must first construct an object of class [ios_base::Init](../vs140/ios_base-class.md#ios_base__init).  
  
### Global Stream Objects  
  
|||  
|-|-|  
|[cerr](#cerr)|Specifies the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> global stream.|  
|[cin](#cin)|Specifies the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> global stream.|  
|[clog](#clog)|Specifies the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> global stream.|  
|[cout](#cout)|Specifies the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> global stream.|  
|[wcerr](#wcerr)|Specifies the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> global stream.|  
|[wcin](#wcin)|Specifies the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> global stream.|  
|[wclog](#wclog)|Specifies the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> global stream.|  
|[wcout](#wcout)|Specifies the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> global stream.|  
  
###  \<a name="cerr">\</a>  cerr  
 The object <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> controls output to a stream buffer associated with the object <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, declared in \<cstdio>.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
#### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls unbuffered insertions to the standard error output as a byte stream. Once the object is constructed, the expression <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>[flags](../vs140/ios_base-class.md#ios_base__flags) <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>.  
  
#### Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
###  \<a name="cin">\</a>  cin  
 Specifies the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### Return Value  
 An [istream](../vs140/-istream--typedefs.md#istream) object.  
  
#### Remarks  
 The object controls extractions from the standard input as a byte stream. Once the object is constructed, the call <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>[cout](#cout).  
  
#### Example  
  In this example, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> sets the fail bit on the stream when it encounters non-numeric characters. The program clears the fail bit and strips the invalid character from the stream to proceed.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
   **<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>**     
###  \<a name="clog">\</a>  clog  
 Specifies the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
#### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls buffered insertions to the standard error output as a byte stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>.  
  
###  \<a name="cout">\</a>  cout  
 Specifies the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
#### Return Value  
 An [ostream](../vs140/-ostream--typedefs.md#ostream) object.  
  
#### Remarks  
 The object controls insertions to the standard output as a byte stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.  
  
###  \<a name="wcerr">\</a>  wcerr  
 Specifies the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
#### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls unbuffered insertions to the standard error output as a wide stream. Once the object is constructed, the expression <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>[flags](../vs140/ios_base-class.md#ios_base__flags) <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> [unitbuf](../vs140/-ios--functions.md#unitbuf) is nonzero.  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.  
  
###  \<a name="wcin">\</a>  wcin  
 Specifies the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
#### Return Value  
 A [wistream](../vs140/-istream--typedefs.md#wistream) object.  
  
#### Remarks  
 The object controls extractions from the standard input as a wide stream. Once the object is constructed, the call <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>[tie](../vs140/basic_ios-class.md#basic_ios__tie) returns <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>[wcout](#wcout).  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>.  
  
###  \<a name="wclog">\</a>  wclog  
 Specifies the <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
#### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls buffered insertions to the standard error output as a wide stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>.  
  
###  \<a name="wcout">\</a>  wcout  
 Specifies the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> global stream.  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
#### Return Value  
 A [wostream](../vs140/-ostream--typedefs.md#wostream) object.  
  
#### Remarks  
 The object controls insertions to the standard output as a wide stream.  
  
#### Example  
  See [cerr](#cerr) for an example of using <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>.  
  
 <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> instances in a <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> statement must be cast to <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, as shown in the following example.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 For more information, see [Basic CString Operations](../vs140/basic-cstring-operations.md).  
  
## See Also  
 [Header Files](../vs140/c---standard-library-header-files.md)   
 [Thread Safety in the Standard C++ Library](../vs140/thread-safety-in-the-c---standard-library.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)