---
title: "event (C# Reference)"
ms.custom: na
ms.date: "10/03/2016"
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
caps.latest.revision: 28
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# event (C# Reference)
The `event` keyword is used to declare an event in a publisher class.  
  
## Example  
 The following example shows how to declare and raise an event that uses \<xref:System.EventHandler> as the underlying delegate type. For the complete code example that also shows how to use the generic <xref:System.EventHandler`1> delegate type and how to subscribe to an event and create an event handler method, see [How to: Publish Events that Conform to .NET Framework Guidelines](../VS_csharp/how-to--publish-events-that-conform-to-.net-framework-guidelines--csharp-programming-guide-.md).  
  
 [!code[csrefKeywordsModifiers#7](../VS_csharp/codesnippet/CSharp/event--csharp-reference-_1.cs)]  
  
 Events are a special kind of multicast delegate that can only be invoked from within the class or struct where they are declared (the publisher class). If other classes or structs subscribe to the event, their event handler methods will be called when the publisher class raises the event. For more information and code examples, see [Events](../VS_csharp/events--csharp-programming-guide-.md) and [Delegates](../VS_csharp/delegates--csharp-programming-guide-.md).  
  
 Events can be marked as [public](../VS_csharp/public--csharp-reference-.md), [private](../VS_csharp/private--csharp-reference-.md), [protected](../VS_csharp/protected--csharp-reference-.md), [internal](../VS_csharp/internal--csharp-reference-.md), or `protected``internal`. These access modifiers define how users of the class can access the event. For more information, see [Access Modifiers](../VS_csharp/access-modifiers--csharp-programming-guide-.md).  
  
## Keywords and Events  
 The following keywords apply to events.  
  
|Keyword|Description|For more information|  
|-------------|-----------------|--------------------------|  
|[static](../VS_csharp/static--csharp-reference-.md)|Makes the event available to callers at any time, even if no instance of the class exists.|[Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md)|  
|[virtual](../VS_csharp/virtual--csharp-reference-.md)|Allows derived classes to override the event behavior by using the [override](../VS_csharp/override--csharp-reference-.md) keyword.|[Inheritance](../VS_csharp/inheritance--csharp-programming-guide-.md)|  
|[sealed](../VS_csharp/sealed--csharp-reference-.md)|Specifies that for derived classes it is no longer virtual.||  
|[abstract](../VS_csharp/abstract--csharp-reference-.md)|The compiler will not generate the `add` and `remove` event accessor blocks and therefore derived classes must provide their own implementation.||  
  
 An event may be declared as a static event by using the [static](../VS_csharp/static--csharp-reference-.md) keyword. This makes the event available to callers at any time, even if no instance of the class exists. For more information, see [Static Classes and Static Class Members](../VS_csharp/static-classes-and-static-class-members--csharp-programming-guide-.md).  
  
 An event can be marked as a virtual event by using the [virtual](../VS_csharp/virtual--csharp-reference-.md) keyword. This enables derived classes to override the event behavior by using the [override](../VS_csharp/override--csharp-reference-.md) keyword. For more information, see [Inheritance](../VS_csharp/inheritance--csharp-programming-guide-.md). An event overriding a virtual event can also be [sealed](../VS_csharp/sealed--csharp-reference-.md), which specifies that for derived classes it is no longer virtual. Lastly, an event can be declared [abstract](../VS_csharp/abstract--csharp-reference-.md), which means that the compiler will not generate the `add` and `remove` event accessor blocks. Therefore derived classes must provide their own implementation.  
  
## C# Language Specification  
 [!INCLUDE[CSharplangspec](../VS_csharp/includes/csharplangspec_md.md)]  
  
## See Also  
 [C# Reference](../VS_csharp/csharp-reference.md)   
 [C# Programming Guide](../VS_csharp/csharp-programming-guide.md)   
 [C# Keywords](../VS_csharp/csharp-keywords.md)   
 [add](../VS_csharp/add--csharp-reference-.md)   
 [remove](../VS_csharp/remove--csharp-reference-.md)   
 [Modifiers](../VS_csharp/modifiers--csharp-reference-.md)   
 [How to: Combine Delegates (Multicast Delegates)](../VS_csharp/how-to--combine-delegates--multicast-delegates--csharp-programming-guide-.md)