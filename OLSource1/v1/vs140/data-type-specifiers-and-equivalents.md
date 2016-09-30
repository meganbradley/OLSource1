---
title: "Data Type Specifiers and Equivalents"
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
  - "type specifiers [C++], list"
  - "widening integers"
  - "data types [C++], equivalents"
  - "sign-extending integral types"
  - "zero-extending"
  - "identifiers, data type"
  - "data types [C++], specifiers"
  - "simple types, names"
  - "type names [C++], simple"
ms.assetid: 0d4b515a-4f68-4786-83cf-a5d43c7cb6f3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Data Type Specifiers and Equivalents
This book generally uses the forms of the type specifiers listed in the following table rather than the long forms, and it assumes that the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> type is signed by default. Therefore, throughout this book, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is equivalent to **signed char**.  
  
### Type Specifiers and Equivalents  
  
|Type Specifier|Equivalent(s)|  
|--------------------|---------------------|  
|**signed char**1|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|  
|**signed int**|**signed**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|  
|**signed short int**|**short**, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|  
|**signed long int**|**long**, **signed long**|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|—|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|  
|**unsigned short int**|**unsigned short**|  
|**unsigned long int**|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|  
|**float**|—|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>2|—|  
  
 1   When you make the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> type unsigned by default (by specifying the /J compiler option), you cannot abbreviate **signed char** as <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>.  
  
 2   In 32-bit operating systems, the Microsoft C compiler maps **long double** to type **double**.  
  
 **Microsoft Specific**  
  
 You can specify the /J compiler option to change the default <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> type from signed to unsigned. When this option is in effect, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> means the same as <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, and you must use the **signed** keyword to declare a signed character value. If a <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> value is explicitly declared signed, the /J option does not affect it, and the value is sign-extended when widened to an <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> type. The <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> type is zero-extended when widened to <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> type.  
  
 **END Microsoft Specific**  
  
## See Also  
 [C Type Specifiers](../vs140/c-type-specifiers.md)