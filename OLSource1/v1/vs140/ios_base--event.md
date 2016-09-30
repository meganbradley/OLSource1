---
title: "ios_base::event"
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
  - "ios_base.event"
  - "event"
  - "ios_base::event"
  - "ios/std::ios_base::event"
  - "std.ios_base.event"
  - "std::ios_base::event"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event typedef"
ms.assetid: 68579814-5ae0-430b-b6df-4c04ed4d5b2e
caps.latest.revision: 18
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ios_base::event
Specifies event types.  
  
## Syntax  
  
```  
enum event {erase_event, imbue_event, copyfmt_event};  
```  
  
## Remarks  
 The type is an enumerated type that describes an object that can store the callback event used as an argument to a function registered with [register_callback](../vs140/ios_base--register_callback.md). The distinct event values are:  
  
-   **copyfmt_event**, to identify a callback that occurs near the end of a call to [copyfmt](../vs140/basic_ios--copyfmt.md), just before the [exception mask](../vs140/ios_base-class.md) is copied.  
  
-   **erase_event**, to identify a callback that occurs at the beginning of a call to [copyfmt](../vs140/basic_ios--copyfmt.md), or at the beginning of a call to the destructor for **\*this**.  
  
-   **imbue_event**, to identify a callback that occurs at the end of a call to [imbue](../vs140/ios_base--imbue.md), just before the function returns.  
  
## Example  
 See [register_callback](../vs140/ios_base--register_callback.md) for an example.  
  
## Requirements  
 **Header:** \<ios>  
  
 **Namespace:** std  
  
## See Also  
 [iostream Programming](../vs140/iostream-programming.md)   
 [iostreams Conventions](../vs140/iostreams-conventions.md)