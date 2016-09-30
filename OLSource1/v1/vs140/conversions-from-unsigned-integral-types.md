---
title: "Conversions from Unsigned Integral Types"
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
  - "C"
helpviewer_keywords: 
  - "integers, converting"
  - "type casts, involving integers"
  - "data type conversion [C++], signed and unsigned integers"
  - "type conversion [C++], signed and unsigned integers"
  - "integral conversions, from unsigned"
ms.assetid: 60fb7e10-bff9-4a13-8a48-e19f25a36a02
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversions from Unsigned Integral Types
An unsigned integer is converted to a shorter unsigned or signed integer by truncating the high-order bits, or to a longer unsigned or signed integer by zero-extending (see the [Conversions from Unsigned Integral Types](#_clang_table_4..3) table).  
  
 When the value with integral type is demoted to a signed integer with smaller size, or an unsigned integer is converted to its corresponding signed integer, the value is unchanged if it can be represented in the new type. However, the value it represents changes if the sign bit is set, as in the following example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 If it cannot be represented, the result is implementation-defined. See [Type-Cast Conversions](../vs140/type-cast-conversions.md) for information on the Microsoft C compiler's handling of demotion of integers. The same behavior results from integer conversion or from type casting the integer.  
  
 Unsigned values are converted in a way that preserves their value and is not representable directly in C. The only exception is a conversion from <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> to **float**, which loses at most the low-order bits. Otherwise, value is preserved, signed or unsigned. When a value of integral type is converted to floating, and the value is outside the range representable, the result is undefined. (See [Storage of Basic Types](../vs140/storage-of-basic-types.md) for information about the range for integral and floating-point types.)  
  
 The following table summarizes conversions from unsigned integral types.  
  
### Conversions from Unsigned Integral Types  
  
|From|To|Method|  
|----------|--------|------------|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Preserve bit pattern; high-order bit becomes sign bit|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|**short**|Zero-extend|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|**long**|Zero-extend|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|**unsigned short**|Zero-extend|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Zero-extend|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|**float**|Convert to **long**; convert **long** to **float**|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|**double**|Convert to **long**; convert **long** to **double**|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to **double**|  
|**unsigned short**|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**unsigned short**|**short**|Preserve bit pattern; high-order bit becomes sign bit|  
|**unsigned short**|**long**|Zero-extend|  
|**unsigned short**|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**unsigned short**|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Zero-extend|  
|**unsigned short**|**float**|Convert to **long**; convert **long** to **float**|  
|**unsigned short**|**double**|Convert to **long**; convert **long** to **double**|  
|**unsigned short**|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to **double**|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Preserve low-order byte|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|**short**|Preserve low-order word|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|**long**|Preserve bit pattern; high-order bit becomes sign bit|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Preserve low-order byte|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|**unsigned short**|Preserve low-order word|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|**float**|Convert to **long**; convert **long** to **float**|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|**double**|Convert directly to **double**|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to **double**|  
  
 **Microsoft Specific**  
  
 For the Microsoft 32-bit C compiler, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> type is equivalent to the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> type. Conversion of an <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> value proceeds in the same way as conversion of an <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. Conversions from <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> values to **float** are not accurate if the value being converted is larger than the maximum positive signed **long** value.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Assignment Conversions](../vs140/assignment-conversions.md)