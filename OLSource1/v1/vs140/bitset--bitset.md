---
title: "bitset::bitset"
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
  - "bitset::bitset"
  - "bitset.bitset"
  - "std.bitset.bitset"
  - "std::bitset::bitset"
  - "bitset/std::bitset::bitset"
  - "bitset"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "bitset class, constructor"
  - "bitset method"
ms.assetid: 8f412b9a-6a51-4fe6-8c99-45d308bbefa7
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::bitset
Constructs an object of class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and initializes the bits to zero, or to some specified value, or to values obtained from characters in a string.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The unsigned integer whose base two representation is used to initialize the bits in the bitset being constructed.  
  
 <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
 The string of zeros and ones used to initialize the bitset bit values.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A C-style string of zeros and ones used to initialize the bitset bit values.  
  
 <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 The position of the character in the string, counting from left to right and starting with zero, used to initialize the first bit in the bitset.  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
 The number of characters in the string that is used to provide initial values for the bits in the bitset.  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
 The character that is used to represent a zero. The default is '0'.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
 The character that is used to represent a one. The default is '1'.  
  
## Remarks  
 Three constructors can be used to construct obects of class <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>:  
  
-   The first constructor accepts no parameters, constructs an object of class <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and initializes all N bits to a default value of zero.  
  
-   The second constructor constructs an object of class <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and initializes the bits by using the single <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> parameter.  
  
-   The third constructor constructs an object of class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, initializing the N bits to values that correspond to the characters provided in a c-style character string of zeros and ones. You call the constructor without casting the string into a string type: <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 There are also two constructor templates provided:  
  
-   The first constructor template constructs an object of class <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and initializes bits from the characters provided in a string of zeros and ones. If any characters of the string are other than 0 or 1, the constructor throws an object of class [invalid argument](../vs140/invalid_argument-class.md). If the position specified (<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>) is beyond the length of the string, then the constructor throws an object of class [out_of_range](../vs140/out_of_range-class.md). The constructor sets only those bits at position *j* in the bitset for which the character in the string at position <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> is 1. By default, <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is 0.  
  
-   The second constructor template is similar to the first, but includes an additional parameter (<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>) that is used to specify the number of bits to initialize. It also has two optional parameters, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, which indicate what character in <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> is to be interpreted to mean a 0 bit and a 1 bit, respectively.  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The set of bits in bitset\<2> b0 is: ( 00 ).**  
**The set of bits in bitset\<5> b1( 6 ) is: ( 00110 ).**  
**The set of bits in bitset\<2 \* sizeof ( int ) > b2 is: ( 00000000 ).**  
**The set of bits in bitset\<3> b3( 6 ) is ( 110 ).**  
**The set of bits in bitset\<5> b4( bitval4 ) is ( 10011 ).**  
**The set of bits in bitset\<11> b5( bitval, 3, 6 ) is ( 100110 ).**  
**The set of bits in bitset\<11> b6( bitval5, 3, 5 ) is ( 00000010011 ).**  
**The set of bits in bitset\<9> b7( bitval, 2 ) is ( 110011011 ).**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)