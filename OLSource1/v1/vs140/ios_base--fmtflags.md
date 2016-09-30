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
  
```  
namespace std {  
   class ios_base {  
   public:  
      typedef implementation-defined-bitmask-type fmtflags;  
      static const fmtflags boolalpha;  
      static const fmtflags dec;  
      static const fmtflags fixed;  
      static const fmtflags hex;  
      static const fmtflags internal;  
      static const fmtflags left;  
      static const fmtflags oct;  
      static const fmtflags right;  
      static const fmtflags scientific;  
      static const fmtflags showbase;  
      static const fmtflags showpoint;  
      static const fmtflags showpos;  
      static const fmtflags skipws;  
      static const fmtflags unitbuf;  
      static const fmtflags uppercase;  
      static const fmtflags adjustfield;  
      static const fmtflags basefield;  
      static const fmtflags floatfield;  
      ...  
   };  
}  
```  
  
## Remarks  
 Supports the manipulators in [ios](../vs140/-ios-.md).  
  
 The type is a bitmask type that describes an object that can store format flags. The distinct flag values (elements) are:  
  
-   `dec`, to insert or extract integer values in decimal format.  
  
-   `hex`, to insert or extract integer values in hexadecimal format.  
  
-   `oct`, to insert or extract integer values in octal format.  
  
-   `showbase`, to insert a prefix that reveals the base of a generated integer field.  
  
-   `internal`, to pad to a field width as needed by inserting fill characters at a point internal to a generated numeric field. (For information on setting the field width, see [setw](../vs140/setw.md)).  
  
-   `left`, to pad to a field width as needed by inserting fill characters at the end of a generated field (left justification).  
  
-   `right`, to pad to a field width as needed by inserting fill characters at the beginning of a generated field (right justification).  
  
-   `boolalpha`, to insert or extract objects of type `bool` as names (such as `true` and `false`) rather than as numeric values.  
  
-   `fixed`, to insert floating-point values in fixed-point format (with no exponent field).  
  
-   `scientific`, to insert floating-point values in scientific format (with an exponent field).  
  
-   `showpoint`, to insert a decimal point unconditionally in a generated floating-point field.  
  
-   `showpos`, to insert a plus sign in a nonnegative generated numeric field.  
  
-   `skipws`, to skip leading white space before certain extractions.  
  
-   `unitbuf`, to flush output after each insertion.  
  
-   `uppercase`, to insert uppercase equivalents of lowercase letters in certain insertions.  
  
 In addition, several useful values are:  
  
-   `adjustfield`, a bitmask defined as `internal` &#124; `left` &#124; `right`  
  
-   `basefield`, defined as `dec` &#124; `hex` &#124; `oct`  
  
-   `floatfield`, defined as `fixed` &#124; `scientific`  
  
 For examples of functions that modify these format flags, see [\<iomanip>](../vs140/-iomanip-.md).  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)