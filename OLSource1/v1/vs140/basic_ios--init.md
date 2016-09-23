---
title: "basic_ios::init"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
f1_keywords: 
  - basic_ios.init
  - std::basic_ios::init
  - ios/std::basic_ios::init
  - init
  - Init
  - std.basic_ios.init
  - basic_ios::init
dev_langs: 
  - C++
helpviewer_keywords: 
  - init method
ms.assetid: b720b665-b3c3-4ba3-8721-4317dd6880d6
caps.latest.revision: 18
translation.priority.mt: 
  - de-de
  - ja-jp
---
# basic_ios::init
Called by basic_ios constructors.  
  
## Syntax  
  
```  
void init(  
    basic_streambuf<Elem,Traits> *_Sb,  
    bool _Isstd = false  
);  
```  
  
#### Parameters  
 `_Sb`  
 Standard buffer to store input or output elements.  
  
 `_Isstd`  
 Specifies whether this is a standard stream.  
  
## Remarks  
 The member function stores values in all member objects, so that:  
  
-   [rdbuf](../vs140/basic_ios--rdbuf.md) returns *_Sb.*  
  
-   [tie](../vs140/basic_ios--tie.md) returns a null pointer.  
  
-   [rdstate](../vs140/basic_ios--rdstate.md) returns [goodbit](../vs140/ios_base--iostate.md) if `_Sb` is nonzero; otherwise, it returns [badbit](../vs140/ios_base--iostate.md).  
  
-   [exceptions](../vs140/basic_ios--exceptions.md) returns **goodbit**.  
  
-   [flags](../vs140/ios_base--flags.md) returns [skipws](../vs140/ios_base--fmtflags.md) &#124; [dec](../vs140/ios_base--fmtflags.md).  
  
-   [width](../vs140/ios_base--width.md) returns 0.  
  
-   [precision](../vs140/ios_base--precision.md) returns 6.  
  
-   [fill](../vs140/basic_ios--fill.md) returns the space character.  
  
-   [getloc](../vs140/ios_base--getloc.md) returns `locale::classic`.  
  
-   [iword](../vs140/ios_base--iword.md) returns zero, and [pword](../vs140/ios_base--pword.md) returns a null pointer for all argument values.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)