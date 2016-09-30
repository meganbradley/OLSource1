---
title: "ios_base::fmtflags"
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
  - "fmtflags"
  - "std.ios_base.fmtflags"
  - "ios_base::fmtflags"
  - "ios_base.fmtflags"
  - "xiosbase/std::ios_base::fmtflags"
  - "std::ios_base::fmtflags"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "fmtflags typedef"
ms.assetid: 1f849089-fb62-482b-b9fb-afc895b14ada
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::fmtflags
Constants to specify the appearance of output.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 Supports the manipulators in [ios](../vs140/-ios-.md).  
  
 The type is a bitmask type that describes an object that can store format flags. The distinct flag values (elements) are:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, to insert or extract integer values in decimal format.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to insert or extract integer values in hexadecimal format.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to insert or extract integer values in octal format.  
  
-   <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, to insert a prefix that reveals the base of a generated integer field.  
  
-   <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at a point internal to a generated numeric field. (For information on setting the field width, see [setw](../vs140/setw.md)).  
  
-   <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at the end of a generated field (left justification).  
  
-   <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, to pad to a field width as needed by inserting fill characters at the beginning of a generated field (right justification).  
  
-   <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, to insert or extract objects of type <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> as names (such as <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>) rather than as numeric values.  
  
-   <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, to insert floating-point values in fixed-point format (with no exponent field).  
  
-   <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, to insert floating-point values in scientific format (with an exponent field).  
  
-   <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>, to insert a decimal point unconditionally in a generated floating-point field.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, to insert a plus sign in a nonnegative generated numeric field.  
  
-   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, to skip leading white space before certain extractions.  
  
-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, to flush output after each insertion.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>, to insert uppercase equivalents of lowercase letters in certain insertions.  
  
 In addition, several useful values are:  
  
-   <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>, a bitmask defined as <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, defined as <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, defined as <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> &#124; <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
  
 For examples of functions that modify these format flags, see [\<iomanip>](../vs140/-iomanip-.md).  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)