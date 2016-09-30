---
title: "Reference Counting"
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
  - "AddRef method [C++], reference counting"
  - "reference counting"
  - "AddRef method [C++]"
  - "reference counts"
  - "references, counting"
ms.assetid: b1fd4514-6de6-429f-9e60-2777c0d07a3d
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Reference Counting
COM itself does not automatically try to remove an object from memory when it thinks the object is no longer being used. Instead, the object programmer must remove the unused object. The programmer determines whether an object can be removed based on a reference count.  
  
 COM uses the **IUnknown** methods, [AddRef](http://msdn.microsoft.com/library/windows/desktop/ms691379) and [Release](http://msdn.microsoft.com/library/windows/desktop/ms682317), to manage the reference count of interfaces on an object. The general rules for calling these methods are:  
  
-   Whenever a client receives an interface pointer, <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> must be called on the interface.  
  
-   Whenever the client has finished using the interface pointer, it must call **Release**.  
  
 In a simple implementation, each <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> call increments and each **Release** call decrements a counter variable inside the object. When the count returns to zero, the interface no longer has any users and is free to remove itself from memory.  
  
 Reference counting can also be implemented so that each reference to the object (not to an individual interface) is counted. In this case, each <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> and **Release** call delegates to a central implementation on the object, and **Release** frees the entire object when its reference count reaches zero.  
  
> [!NOTE]
>  When a <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>-derived object is constructed using the **new** operator, the reference count is 0. Therefore, a call to <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> must be made after successfully creating the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived object.  
  
## See Also  
 [Introduction to COM](../vs140/introduction-to-com.md)   
 [Managing Object Lifetimes through Reference Counting](http://msdn.microsoft.com/library/windows/desktop/ms687260)