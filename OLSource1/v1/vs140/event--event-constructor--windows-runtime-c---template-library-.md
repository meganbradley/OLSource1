---
title: "Event::Event Constructor (Windows Runtime C++ Template Library)"
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
  - "corewrappers/Microsoft::WRL::Wrappers::Event::Event"
dev_langs: 
  - "C++"
ms.assetid: 21495297-9612-4095-9256-16e168cc0021
caps.latest.revision: 8
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Event::Event Constructor (Windows Runtime C++ Template Library)
Initializes a new instance of the Event class.  
  
## Syntax  
  
```  
explicit Event(  
   HANDLE h = HandleT::Traits::GetInvalidValue()  
);  
WRL_NOTHROW Event(  
   _Inout_ Event&& h  
);  
```  
  
#### Parameters  
 `h`  
 Handle to an event. By default, `h` is initialized to `nullptr`.  
  
## Requirements  
 **Header:** corewrappers.h  
  
 **Namespace:** Microsoft::WRL::Wrappers  
  
## See Also  
 [Event Class](../vs140/event-class--windows-runtime-c---template-library-.md)