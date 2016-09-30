---
title: "Conversions from Floating-Point Types"
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
  - "converting floating point"
  - "floating-point conversion"
ms.assetid: 96804c8e-fa3b-4742-9006-0082ed9e57f2
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Conversions from Floating-Point Types
A **float** value converted to a **double** or <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>, or a **double** converted to a <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, undergoes no change in value. A **double** value converted to a **float** value is represented exactly, if possible. Precision may be lost if the value cannot be represented exactly. If the result is out of range, the behavior is undefined. See [Limits on Floating-Point Constants](../vs140/limits-on-floating-point-constants.md) for the range of floating-point types.  
  
 A floating value is converted to an integral value by first converting to a **long**, then from the **long** value to the specific integral value. The decimal portion of the floating value is discarded in the conversion to a **long**. If the result is still too large to fit into a **long**, the result of the conversion is undefined.  
  
 **Microsoft Specific**  
  
 When converting a **double** or <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> floating-point number to a smaller floating-point number, the value of the floating-point variable is truncated toward zero when an underflow occurs. An overflow causes a run-time error. Note that the Microsoft C compiler maps <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> to type **double**.  
  
 **END Microsoft Specific**  
  
 The following table summarizes conversions from floating types.  
  
### Conversions from Floating-Point Types  
  
|From|To|Method|  
|----------|--------|------------|  
|**float**|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|  
|**float**|**short**|Convert to **long**; convert **long** to **short**|  
|**float**|**long**|Truncate at decimal point. If result is too large to be represented as **long**, result is undefined.|  
|**float**|**unsigned short**|Convert to **long**; convert **long** to <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> **short**|  
|**float**|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> **long**|  
|**float**|**double**|Change internal representation|  
|**float**|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Change internal representation|  
|**double**|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Convert to **float**; convert **float** to <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|  
|**double**|**short**|Convert to **float**; convert **float** to **short**|  
|**double**|**long**|Truncate at decimal point. If result is too large to be represented as **long**, result is undefined.|  
|**double**|**unsigned short**|Convert to **long**; convert **long** to **unsigned short**|  
|**double**|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> **long**|  
|**double**|**float**|Represent as a **float**. If **double** value cannot be represented exactly as **float**, loss of precision occurs. If value is too large to be represented as **float**, the result is undefined.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Convert to **float**; convert **float** to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|**short**|Convert to **float**; convert **float** to **short**|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|**long**|Truncate at decimal point. If result is too large to be represented as **long**, result is undefined.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|**unsigned short**|Convert to **long**; convert **long** to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> **short**|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Convert to **long**; convert **long** to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> **long**|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|**float**|Represent as a **float**. If **double** value cannot be represented exactly as **float**, loss of precision occurs. If value is too large to be represented as **float**, the result is undefined.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|**double**|The **long double** value is treated as **double**.|  
  
 Conversions from **float**, **double**, or <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> values to <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> are not accurate if the value being converted is larger than the maximum positive **long** value.  
  
## See Also  
 [Assignment Conversions](../vs140/assignment-conversions.md)