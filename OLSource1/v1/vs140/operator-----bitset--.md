---
title: "operator&gt;&gt; (&lt;bitset&gt;)"
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
  - "std::operator>>"
  - "std::>>"
  - "std.>>"
  - "bitset/std::operator>>"
  - ">>"
  - "std.operator>>"
  - "operator>>"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "operator>>"
  - "operator >>, bitsets"
  - "operator>>, bitsets"
  - ">> operator, bitsets"
ms.assetid: 9136f8b8-8c75-4396-bb2e-eea62bea91ba
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# operator&gt;&gt; (&lt;bitset&gt;)
Reads a string of bit characters into a bitset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The string that is entered into the input stream to be inserted into the bitset.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The bitset that is receiving the bits from the input stream.  
  
## Return Value  
 The template function returns the string <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The template function overloads **operator>>** to store in the bitset _*Right* the value bitset(<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>), where <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> is an object of type [basic_string](../vs140/basic_string--basic_string.md)<**CharType**, **Traits**, **allocator**\<**CharType**> >**&** extracted from <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>.  
  
 The template function extracts elements from <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and inserts them into the bitset until:  
  
-   All the bit elements have been extracted from the input stream and stored in the bitset.  
  
-   The bitset is filled up with bits from the input stream.  
  
-   An input element is encountered that is neither 0 nor 1.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Input  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std