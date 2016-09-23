---
title: "Marshaling"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-cpp
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - C++
helpviewer_keywords: 
  - marshaling, COM interop
  - marshaling
  - COM interfaces, marshaling
ms.assetid: 40644b0a-1106-4fc8-9dfb-9bee9915d825
caps.latest.revision: 12
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Marshaling
The COM technique of marshaling allows interfaces exposed by an object in one process to be used in another process. In marshaling, COM provides code (or uses code provided by the interface implementor) both to pack a method's parameters into a format that can be moved across processes (as well as, across the wire to processes running on other machines) and to unpack those parameters at the other end. Likewise, COM must perform these same steps on the return from the call.  
  
> [!NOTE]
>  Marshaling is typically not necessary when an interface provided by an object is being used in the same process as the object. However, marshaling may be needed between threads.  
  
## See Also  
 [Introduction to COM](../vs140/introduction-to-com.md)   
 [Marshaling Details](http://msdn.microsoft.com/library/windows/desktop/ms692621)