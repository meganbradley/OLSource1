---
title: "basic_ios::good"
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
  - "std::basic_ios::good"
  - "basic_ios::good"
  - "ios/std::basic_ios::good"
  - "good"
  - "basic_ios.good"
  - "std.basic_ios.good"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "good method"
ms.assetid: 77f0aa17-2ae1-48ae-8040-592d301e3972
caps.latest.revision: 18
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# basic_ios::good
Indicates the stream is in good condition.  
  
## Syntax  
  
```  
bool good( ) const;  
```  
  
## Return Value  
 `true` if [rdstate](../vs140/basic_ios--rdstate.md) `== goodbit` (no state flags are set), otherwise, `false`.  
  
 For more information on `goodbit`, see [ios_base::iostate](../vs140/ios_base--iostate.md).  
  
## Example  
 See [basic_ios::bad](../vs140/basic_ios--bad.md) for an example of using `good`.  
  
## Requirements  
 **Header:** <ios\>  
  
 **Namespace:** std  
  
## See Also  
 [basic_ios Class](../vs140/basic_ios-class.md)   
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)