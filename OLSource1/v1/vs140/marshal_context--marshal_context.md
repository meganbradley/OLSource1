---
title: "marshal_context::marshal_context"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "msclr::interop::marshal_context::marshal_context"
  - "marshal_context::marshal_context"
  - "msclr.interop.marshal_context.marshal_context"
  - "marshal_context.marshal_context"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "marshal_context class [C++], operations"
ms.assetid: 5f08c895-60b0-4f72-97ff-7ae37c68e853
caps.latest.revision: 13
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# marshal_context::marshal_context
Constructs a `marshal_context` object to use for data conversion between managed and native data types.  
  
## Syntax  
  
```  
marshal_context();  
```  
  
## Remarks  
 Some data conversions require a marshal context. See [Marshaling Overview in C++](../vs140/overview-of-marshaling-in-c--.md) for more information about which translations require a context and which marshaling file has to be included in your application.  
  
## Example  
 See the example for [marshal_context::marshal_as](../vs140/marshal_context--marshal_as.md).  
  
## Requirements  
 **Header file:** <msclr\marshal.h>, <msclr\marshal_windows.h>, <msclr\marshal_cppstd.h>, or <msclr\marshal_atl.h>  
  
 **Namespace:** msclr::interop  
  
## See Also  
 [Marshaling Overview in C++](../vs140/overview-of-marshaling-in-c--.md)   
 [marshal_as](../vs140/marshal_as.md)   
 [marshal_context Class](../vs140/marshal_context-class.md)