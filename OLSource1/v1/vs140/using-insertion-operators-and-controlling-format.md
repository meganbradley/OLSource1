---
title: "Using Insertion Operators and Controlling Format"
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
  - "insertion operators"
ms.assetid: cdefe986-6548-4cd1-8a67-b431d7d36a1c
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Using Insertion Operators and Controlling Format
This topic shows how to control format and how to create insertion operators for your own classes. The insertion (**<<**) operator, which is preprogrammed for all standard C++ data types, sends bytes to an output stream object. Insertion operators work with predefined "manipulators," which are elements that change the default format of integer arguments.  
  
 You can control the format with the following options:  
  
-   [Output Width](#vclrfoutputwidthanchor3)  
  
-   [Alignment](#vclrfalignmentanchor4)  
  
-   [Precision](#vclrfprecisionanchor5)  
  
-   [Radix](#vclrfradixanchor6)  
  
##  \<a name="vclrfoutputwidthanchor3">\</a> Output Width  
 To align output, you specify the output width for each item by placing the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> manipulator in the stream or by calling the **width** member function. This example right-aligns the values in a column at least 10 characters wide:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Output  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 Leading blanks are added to any value fewer than 10 characters wide.  
  
 To pad a field, use the **fill** member function, which sets the value of the padding character for fields that have a specified width. The default is a blank. To pad the column of numbers with asterisks, modify the previous **for** loop as follows:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> manipulator replaces the newline character (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>). The output looks like this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 To specify widths for data elements in the same line, use the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> manipulator:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
### Output  
 The **width** member function is declared in \<iostream>. If you use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> or any other manipulator with arguments, you must include \<iomanip>. In the output, strings are printed in a field of width 6 and integers in a field of width 10:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 Neither <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> nor **width** truncates values. If formatted output exceeds the width, the entire value prints, subject to the stream's precision setting. Both <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and **width** affect the following field only. Field width reverts to its default behavior (the necessary width) after one field has been printed. However, the other stream format options remain in effect until changed.  
  
##  \<a name="vclrfalignmentanchor4">\</a> Alignment  
 Output streams default to right-aligned text. To left-align the names in the previous example and right-align the numbers, replace the **for** loop as follows:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The output looks like this:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The left-align flag is set by using the [setiosflags](../vs140/setiosflags.md) manipulator with the [left](../vs140/left.md) enumerator. This enumerator is defined in the [ios](../vs140/ios.md) class, so its reference must include the **ios::** prefix. The [resetiosflags](../vs140/resetiosflags.md) manipulator turns off the left-align flag. Unlike **width** and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, the effect of <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is permanent.  
  
##  \<a name="vclrfprecisionanchor5">\</a> Precision  
 The default value for floating-point precision is six. For example, the number 3466.9768 prints as 3466.98. To change the way this value prints, use the [setprecision](../vs140/setprecision.md) manipulator. The manipulator has two flags: [fixed](../vs140/fixed.md) and [scientific](../vs140/scientific.md). If [fixed](../vs140/fixed.md) is set, the number prints as 3466.976800. If **scientific** is set, it prints as 3.4669773+003.  
  
 To display the floating-point numbers shown in [Alignment](#vclrfalignmentanchor4) with one significant digit, replace the **for** loop as follows:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The program prints this list:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 To eliminate scientific notation, insert this statement before the **for** loop:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
 With fixed notation, the program prints with one digit after the decimal point.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
 If you change the **ios::fixed** flag to **ios::scientific**, the program prints this:  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
 Again, the program prints one digit after the decimal point. If either **ios::fixed** or **ios::scientific** is set, the precision value determines the number of digits after the decimal point. If neither flag is set, the precision value determines the total number of significant digits. The <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> manipulator clears these flags.  
  
##  \<a name="vclrfradixanchor6">\</a> Radix  
 The **dec**, **oct**, and **hex** manipulators set the default radix for input and output. For example, if you insert the **hex** manipulator into the output stream, the object correctly translates the internal data representation of integers into a hexadecimal output format. The numbers are displayed with digits a through f in lower case if the [uppercase](../vs140/uppercase.md) flag is clear (the default); otherwise, they are displayed in upper case. The default radix is **dec** (decimal).  
  
## Quoted strings (C++14)  
 When you insert a string into a stream, you can easily retrieve the same string back by calling the stringstream::str() member function. However, if you want to use the extraction operator to insert the stream into a new string at a later point, you may get an unexpected result because the >> operator by default will stop when it encounters the first whitespace character.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
 This behavior can be overcome manually, but to make string round-tripping more convenient, C++14 adds the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> stream manipulator in <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. Upon insertion, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> surrounds the string with a delimiter (double quote ' " ' by default) and upon extraction manipulates the stream to extract all characters until the final delimiter is encountered. Any embedded quotes are escaped with an escape character ('\\\\' by default).  
  
 The delimiters are present only in the stream object; they are not present in the extracted string but they are present in the string returned by [basic_stringstream::str](../vs140/basic_stringstream--str.md)().  
  
 The whitespace behavior of the insertion and extraction operations is independent of how a string is represented in code, so the quoted operator is useful regardless of whether the input string is a raw string literal or a regular string. The input string, whatever its format, can have embedded quotes, line breaks, tabs, and so on and all these will be preserved by the quoted() manipulator.  
  
 For more information and full code examples, see [quoted](../vs140/quoted.md).  
  
## See Also  
 [Output Streams](../vs140/output-streams.md)   
 [quoted](../vs140/quoted.md)