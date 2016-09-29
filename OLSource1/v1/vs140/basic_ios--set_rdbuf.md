---
title: "basic_ios::set_rdbuf"
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
  - "basic_ios::set_rdbuf"
  - "std.basic_ios.set_rdbuf"
  - "set_rdbuf"
  - "basic_ios.set_rdbuf"
  - "std::basic_ios::set_rdbuf"
  - "ios/std::basic_ios::set_rdbuf"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "set_rdbuf method"
ms.assetid: 6171b861-7be9-4e33-9804-374b5461bad3
caps.latest.revision: 13
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::set_rdbuf
Assigns a stream buffer to be the read buffer for this stream object.  
  
## Syntax  
  
```  
void set_rdbuf(  
    basic_streambuf<Elem, Tr> *_Strbuf  
)  
```  
  
#### Parameters  
 `_Strbuf`  
 The stream buffer to become the read buffer.  
  
## Property Value/Return Value  
  
## Remarks  
 The protected member function stores `_Strbuf` in the `stream buffer pointer`.It does not call `clear`.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)