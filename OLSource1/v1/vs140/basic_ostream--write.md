---
title: "basic_ostream::write"
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
  - "basic_ostream::write"
  - "std::basic_ostream::write"
  - "Write"
  - "std.basic_ostream.write"
  - "write"
  - "ostream/std::basic_ostream::write"
  - "basic_ostream.write"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "write method"
ms.assetid: 673f9510-ea4d-4037-887d-0c3e3358c30e
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
robots: noindex,nofollow
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# basic_ostream::write
Put characters in a stream.  
  
## Syntax  
  
```  
basic_ostream<_Elem, _Tr>& write(  
    const char_type *_Str,  
    streamsize _Count  
);  
```  
  
#### Parameters  
 `_Count`  
 Count of characters to put into the stream.  
  
 `_Str`  
 Characters to put into the stream.  
  
## Return Value  
 A reference to the basic_ostream object.  
  
## Remarks  
 The [unformatted output function](../vs140/basic_ostream-class.md) inserts the sequence of `_Count` elements beginning at `_Str`.  
  
## Example  
 See [streamsize](../vs140/streamsize.md) for an example using `write`.  
  
## Requirements  
 **Header:** <ostream\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ostream Class](../vs140/basic_ostream-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)