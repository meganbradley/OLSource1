---
title: "erf, erff, erfl, erfc, erfcf, erfcl"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
apiname: 
  - "erff"
  - "erfl"
  - "erf"
apilocation: 
  - "msvcr90.dll"
  - "msvcr120.dll"
  - "msvcrt.dll"
  - "msvcr110_clr0400.dll"
  - "msvcr100.dll"
  - "msvcr110.dll"
  - "msvcr80.dll"
apitype: "DLLExport"
f1_keywords: 
  - "erfl"
  - "erf"
  - "erff"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "erfl function"
  - "erff function"
  - "erf function"
ms.assetid: 144d90d3-e437-41c2-a659-cd57596023b5
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# erf, erff, erfl, erfc, erfcf, erfcl
Computes the error function or the complementary error function of a value.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### Parameters  
 <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 A floating-point value.  
  
## Return Value  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> functions return the Gauss error function of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>. The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> functions return the complementary Gauss error function of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> functions calculate the Gauss error function of x, which is defined as:  
  
 ![The error function of x](../vs140/media/crt_erf_formula.PNG "CRT_erf_formula")  
  
 The complementary Gauss error function is defined as 1 – erf(x). The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions return a value in the range -1.0 to 1.0. There is no error return. The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> functions return a value in the range 0 to 2. If <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> is too large for <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> variable is set to <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>.  
  
 Because C++ allows overloading, you can call overloads of <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> that take and return <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> types. In a C program, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> always take and return a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## Requirements  
  
|Function|Required header|  
|--------------|---------------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|\<math.h>|  
  
 For additional compatibility information, see [Compatibility](../vs140/compatibility.md).  
  
## .NET Framework Equivalent  
 Not applicable. To call the standard C function, use <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>. For more information, see [Platform Invoke Examples](assetId:///15926806-f0b7-487e-93a6-4e9367ec689f).  
  
## See Also  
 [Floating-Point Support](../vs140/floating-point-support.md)