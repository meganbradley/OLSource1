---
title: "codecvt::do_encoding"
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
  - "do_encoding"
  - "std::codecvt::do_encoding"
  - "codecvt.do_encoding"
  - "xlocale/std::codecvt::do_encoding"
  - "std.codecvt.do_encoding"
  - "codecvt::do_encoding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "do_encoding method"
ms.assetid: af9dfc5d-40d2-4dd7-8220-d07361480494
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::do_encoding
A virtual function that tests if the encoding of the **Byte** stream is state dependent, whether the ratio between the **Byte**s used and the **CharType**s produced is constant and, if so, determines the value of that ratio.  
  
## Syntax  
  
```  
virtual int do_encoding( ) const throw( );  
```  
  
## Return Value  
 The protected virtual member function returns:  
  
-   –1, if the encoding of sequences of type `extern_type` is state dependent.  
  
-   0, if the encoding involves sequences of varying lengths.  
  
-   *N*, if the encoding involves only sequences of length *N*  
  
## Example  
 See the example for [encoding](../vs140/codecvt--encoding.md), which calls `do_encoding`.  
  
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)