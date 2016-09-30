---
title: "codecvt::encoding"
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
  - "std::codecvt::encoding"
  - "locale/std::codecvt::encoding"
  - "encoding"
  - "codecvt.encoding"
  - "std.codecvt.encoding"
  - "codecvt::encoding"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "encoding method"
ms.assetid: 44591fbb-04ff-4ca5-91a7-6a406d94015e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# codecvt::encoding
Tests if the encoding of the **Byte** stream is state dependent, whether the ratio between the **Byte**s used and the **CharType**s produced is constant, and, if so, determines the value of that ratio.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Return Value  
 If the return value is positive then that value is the constant number of **Byte** characters required to produce the **CharType** character.  
  
 The protected virtual member function returns:  
  
-   –1, if the encoding of sequences of type <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> is state dependent.  
  
-   0, if the encoding involves sequences of varying lengths.  
  
-   *N*, if the encoding involves only sequences of length *N.*  
  
## Remarks  
 The member function returns [do_encoding](../vs140/codecvt--do_encoding.md).  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **1**  
**1**  
**1**   
## Requirements  
 **Header:** \<locale>  
  
 **Namespace:** std  
  
## See Also  
 [codecvt Class](../vs140/codecvt-class.md)