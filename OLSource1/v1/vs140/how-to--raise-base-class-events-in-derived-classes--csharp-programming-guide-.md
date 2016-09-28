---
title: "How to: Raise Base Class Events in Derived Classes (C# Programming Guide)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "events [C#], in derived classes"
ms.assetid: 2d20556a-0aad-46fc-845e-f85d86ea617a
caps.latest.revision: 28
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Raise Base Class Events in Derived Classes (C# Programming Guide)
The following simple example shows the standard way to declare events in a base class so that they can also be raised from derived classes. This pattern is used extensively in Windows Forms classes in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] class library.  
  
 When you create a class that can be used as a base class for other classes, you should consider the fact that events are a special type of delegate that can only be invoked from within the class that declared them. Derived classes cannot directly invoke events that are declared within the base class. Although sometimes you may want an event that can only be raised by the base class, most of the time, you should enable the derived class to invoke base class events. To do this, you can create a protected invoking method in the base class that wraps the event. By calling or overriding this invoking method, derived classes can invoke the event indirectly.  
  
> [!NOTE]
>  Do not declare virtual events in a base class and override them in a derived class. The C# compiler does not handle these correctly and it is unpredictable whether a subscriber to the derived event will actually be subscribing to the base class event.  
  
## Example  
 [!code[csProgGuideEvents#1](../vs140/codesnippet/CSharp/how-to--raise-base-class-events-in-derived-classes--csharp-programming-guide-_1.cs)]  
  
## See Also  
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [Events (C# Programmer's Reference)](../vs140/events--csharp-programming-guide-.md)   
 [Delegates (C# Programmer's Reference)](../vs140/delegates--csharp-programming-guide-.md)   
 [Access Modifiers (C# Programming Guide)](../vs140/access-modifiers--csharp-programming-guide-.md)   
 [Creating Event Handlers in Windows Forms](assetId:///6514e530-c6b8-489c-a8d2-eda7b7072701)