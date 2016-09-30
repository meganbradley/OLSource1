---
title: "What Does Remote Automation Provide?"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "Remote Automation, DCOM"
ms.assetid: 269ad218-e164-40ef-9b87-25fcc8ba21de
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# What Does Remote Automation Provide?
Remote Automation allows programs to invoke <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> implementations on one machine from another. It also supports other interfaces required by Automation, specifically **IEnumVARIANT** for collection support. It does not provide the ability to distribute any other COM interface (except **IUnknown**, of course) and, like regular Automation, it contains marshaling support only for those data types supported by Automation.  
  
 This set of facilities allows a program to access the methods and properties, including those that return collections or further automation objects, of an object running on an accessible network node. If the client machine is also running the appropriate software, it is possible for the server to call back to the client, again using Automation facilities (this works for 32-bit and 64-bit clients only, and is conceptually similar to events, although it does not use the same mechanism).  
  
 For an application to be operable as a Remote Automation server, it must be implemented as an executable (that is, as a "local server" rather than as an "inproc server").  
  
## See Also  
 [Where Does Remote Automation Fit In?](../vs140/where-does-remote-automation-fit-in-.md)   
 [History of DCOM](../vs140/history-of-dcom.md)