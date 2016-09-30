---
title: "bitset::reference"
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
  - "bitset::reference"
  - "Reference"
  - "std::bitset::reference"
  - "bitset.reference"
  - "std.bitset.reference"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "reference method"
ms.assetid: 7aea1fdf-8aae-4011-bb21-21f5a5529a35
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# bitset::reference
A proxy class that provides references to bits contained in a bitset that is used to access and manipulate the individual bits as a helper class for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> of class bitset.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The value of the object of type <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> to be assigned to a bit in a bitset.  
  
 <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 A reference of the form *x [ i ]* to the bit at position *i* in bitset *x*.  
  
## Return Value  
 A reference to the bit in the bitset specified by the argument position for the first, second, and fifth member functions of class reference, and **true** or **false**, to reflect the value of the modified bit in the bitset for the third and fourth member functions of class reference.  
  
## Remarks  
 The class reference exists only as a helper class for the bitset <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The member class describes an object that can access an individual bit within a bitset. Let *b* be an object of type <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, *x* and *y* objects of type **bitset\<***N***>**, and *i* and *j* valid positions within such an object. The notation *x [i]* references the bit at position *i* in bitset *x*. The member functions of class reference provide, in order, the following operations:  
  
|Operation|Definition|  
|---------------|----------------|  
|*x*[*i*] = *b*|Stores <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> value *b* at bit position *i* in bitset *x*.|  
|*x*[*i*] = *y*[*j*]|Stores the value of the bit *y*[*j*] at bit position *i* in bitset *x*.|  
|*b* = ~*x*[*i*]|Stores the flipped value of the bit *x*[*i*] in <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> *b*.|  
|*b* = *x*[*i*]|Stores the value of the bit *x*[*i*] in <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> *b*.|  
|*x*[*i*].<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>( )|Stores the flipped value of the bit *x*[*i*] back at bit position *i* in *x*.|  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **The initialized bitset\<5> b1( 2 ) is: ( 00010 ).**  
**The initialized bitset\<5> b2( 6 ) is: ( 00110 ).**  
**The bitset\<5> b1 with the bit at position 0 set to 1 is: ( 00011 )**  
**The bitset\<5> b2 with the bit at position 4 set to the value**  
 **of the bit at position 0 of the bit in bitset\<5> b1 is: ( 10110 )**  
**The value of the object b = ~b2 [4] of type bool is false.**  
**The value of the object b = b2 [4] of type bool is true.**  
**Before flipping the value of the bit at position 4 in bitset b2,**  
 **it is ( 10110 ).**  
**After flipping the value of the bit at position 4 in bitset b2,**  
 **it becomes ( 00110 ).**  
**After a second toggle, the value of the position 4 bit in b2 is now: 1.**   
## Requirements  
 **Header:** \<bitset>  
  
 **Namespace:** std  
  
## See Also  
 [bitset Class](../vs140/bitset-class.md)   
 [Thread Safety in the C++ Standard Library](../vs140/thread-safety-in-the-c---standard-library.md)