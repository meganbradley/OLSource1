---
title: "event (C# Reference)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "event"
  - "remove"
  - "event_CSharpKeyword"
  - "add"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "event keyword [C#]"
ms.assetid: 7858fd85-153b-4259-85d0-6aa13c35f174
caps.latest.revision: 32
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event (C# Reference)
The `event` keyword is used to declare an event in a publisher class.  
  
## Example  
 The following example shows how to declare and raise an event that uses \<xref:System.EventHandler*> as the underlying delegate type. For the complete code example that also shows how to use the generic <xref:System.EventHandler`1*> delegate type and how to subscribe to an event and create an event handler method, see [How to: Publish Events that Conform to .NET Framework Guidelines (C# Programming Guide)](../vs140/how-to--publish-events-that-conform-to-.net-framework-guidelines--csharp-programming-guide-.md).  
  
 [!code[csrefKeywordsModifiers#7](../vs140/codesnippet/CSharp/event--csharp-reference-_1.cs)]  
  
 Events are a special kind of multicast delegate that can only be invoked from within the class or struct where they are declared (the publisher class). If other classes or structs subscribe to the event, their event handler methods will be called when the publisher class raises the event. For more information and code examples, see [Events (C#)](../vs140/events--csharp-programming-guide-.md) and [Delegates ( C#)](../vs140/delegates--csharp-programming-guide-.md).  
  
 Events can be marked as [public](../vs140/public--csharp-reference-.md), [private](../vs140/private--csharp-reference-.md), [protected](../vs140/protected--csharp-reference-.md), [internal](../vs140/internal--csharp-reference-.md), or `protected``internal`. These access modifiers define how users of the class can access the event. For more information, see [Access Modifiers](../vs140/access-modifiers--csharp-programming-guide-.md).  
  
## Keywords and Events  
 The following keywords apply to events.  
  
|Keyword|Description|For more information|  
|-------------|-----------------|--------------------------|  
|[static](../vs140/static--csharp-reference-.md)|Makes the event available to callers at any time, even if no instance of the class exists.|[Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md)|  
|[virtual](../vs140/virtual--csharp-reference-.md)|Allows derived classes to override the event behavior by using the [override](../vs140/override--csharp-reference-.md) keyword.|[Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md)|  
|[sealed](../vs140/sealed--csharp-reference-.md)|Specifies that for derived classes it is no longer virtual.||  
|[abstract](../vs140/abstract--csharp-reference-.md)|The compiler will not generate the `add` and `remove` event accessor blocks and therefore derived classes must provide their own implementation.||  
  
 An event may be declared as a static event by using the [static](../vs140/static--csharp-reference-.md) keyword. This makes the event available to callers at any time, even if no instance of the class exists. For more information, see [Static Classes and Static Class Members](../vs140/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 An event can be marked as a virtual event by using the [virtual](../vs140/virtual--csharp-reference-.md) keyword. This enables derived classes to override the event behavior by using the [override](../vs140/override--csharp-reference-.md) keyword. For more information, see [Inheritance (Visual C#)](../vs140/inheritance--csharp-programming-guide-.md). An event overriding a virtual event can also be [sealed](../vs140/sealed--csharp-reference-.md), which specifies that for derived classes it is no longer virtual. Lastly, an event can be declared [abstract](../vs140/abstract--csharp-reference-.md), which means that the compiler will not generate the `add` and `remove` event accessor blocks. Therefore derived classes must provide their own implementation.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../vs140/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../vs140/csharp-reference.md)   
 [C# Programming Guide](../vs140/csharp-programming-guide.md)   
 [C# Keywords](../vs140/csharp-keywords.md)   
 [add](../vs140/add--csharp-reference-.md)   
 [remove](../vs140/remove--csharp-reference-.md)   
 [Modifiers](../vs140/modifiers--csharp-reference-.md)   
 [How to: Combine Delegates](../vs140/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-.md)