---
title: "ios_base::iostate"
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
  - "ios_base::iostate"
  - "iostate"
  - "ios_base.iostate"
  - "std::ios_base::iostate"
  - "xiosbase/std::ios_base::iostate"
  - "std.ios_base.iostate"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "iostate typedef"
ms.assetid: 09b5849e-3ab8-4829-aecc-82f799bb9370
caps.latest.revision: 21
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::iostate
The type of constants that describe the state of a stream.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Remarks  
 The type is a bitmask type that describes an object that can store stream state information. The distinct flag values (elements) are:  
  
-   <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, to record a loss of integrity of the stream buffer.  
  
-   <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>, to record end-of-file while extracting from a stream.  
  
-   <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, to record a failure to extract a valid field from a stream.  
  
 In addition, a useful value is <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>, where none of the previously mentioned bits are set (<CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is guaranteed to be zero).  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [ios_base Class](../vs140/ios_base-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)