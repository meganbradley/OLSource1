---
title: "Conversions from Signed Integral Types"
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
  - "integral conversions, from signed"
  - "integers, converting"
  - "conversions [C++], integral"
  - "data type conversion [C++], signed and unsigned integers"
  - "type conversion [C++], signed and unsigned integers"
ms.assetid: 5eea32f8-8b14-413d-acac-c063b3d118d7
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversions from Signed Integral Types
When a signed integer is converted to an unsigned integer with equal or greater size and the value of the signed integer is not negative, the value is unchanged. The conversion is made by sign-extending the signed integer. A signed integer is converted to a shorter signed integer by truncating the high-order bits. The result is interpreted as an unsigned value, as shown in this example.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 No information is lost when a signed integer is converted to a floating value, except that some precision may be lost when a **long int** or **unsigned long int** value is converted to a **float** value.  
  
 The following table summarizes conversions from signed integral types. This table assumes that the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> type is signed by default. If you use a compile-time option to change the default for the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> type to unsigned, the conversions given in the [Conversions from Unsigned Integral Types](../vs140/conversions-from-unsigned-integral-types.md) table for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> type apply instead of the conversions in the following table, Conversions from Signed Integral Types.  
  
### Conversions from Signed Integral Types  
  
|From|To|Method|  
|----------|--------|------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>1|**short**|Sign-extend|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|**long**|Sign-extend|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Preserve pattern; high-order bit loses function as sign bit|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|**unsigned short**|Sign-extend to **short**; convert **short** to **unsigned short**|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Sign-extend to **long**; convert **long** to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|**float**|Sign-extend to **long**; convert **long** to **float**|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|**double**|Sign-extend to **long**; convert **long** to **double**|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Sign-extend to **long**; convert **long** to **double**|  
|**short**|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**short**|**long**|Sign-extend|  
|**short**|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**short**|**unsigned short**|Preserve bit pattern; high-order bit loses function as sign bit|  
|**short**|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Sign-extend to **long**; convert **long** to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|  
|**short**|**float**|Sign-extend to **long**; convert **long** to **float**|  
|**short**|**double**|Sign-extend to **long**; convert **long** to **double**|  
|**short**|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Sign-extend to **long**; convert **long** to **double**|  
|**long**|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**long**|**short**|Preserve low-order word|  
|**long**|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Preserve low-order byte|  
|**long**|**unsigned short**|Preserve low-order word|  
|**long**|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Preserve bit pattern; high-order bit loses function as sign bit|  
|**long**|**float**|Represent as **float**. If **long** cannot be represented exactly, some precision is lost.|  
|**long**|**double**|Represent as **double**. If **long** cannot be represented exactly as a **double**, some precision is lost.|  
|**long**|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Represent as **double**. If **long** cannot be represented exactly as a **double**, some precision is lost.|  
  
 1. All <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> entries assume that the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> type is signed by default.  
  
 **Microsoft Specific**  
  
 For the Microsoft 32-bit C compiler, an integer is equivalent to a **long**. Conversion of an <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> value proceeds the same as for a **long**.  
  
 **END Microsoft Specific**  
  
## See Also  
 [Assignment Conversions](../vs140/assignment-conversions.md)