---
title: "Events (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "events [F#]"
  - "event handling [F#]"
ms.assetid: 25dd45b6-008d-4d49-a613-bc56300510c5
caps.latest.revision: 39
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Events (F#)
Events enable you to associate function calls with user actions and are important in GUI programming. Events can also be triggered by your applications or by the operating system.  
  
## Handling Events  
 When you use a GUI library like Windows Forms or Windows Presentation Foundation (WPF), much of the code in your application runs in response to events that are predefined by the library. These predefined events are members of GUI classes such as forms and controls. You can add custom behavior to a preexisting event, such as a button click, by referencing the specific named event of interest (for example, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> event of the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> class) and invoking the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> method, as shown in the following code. If you run this from F# Interactive, omit the call to \<xref:System.Windows.Forms.Application.Run*>.  
  
 [!code[FsLangRef2#3601](../vs140/codesnippet/FSharp/events--fsharp-_1.fs)]  
  
 The type of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> method is <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Therefore, the event handler method takes one parameter, typically the event arguments, and returns <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The previous example shows the event handler as a lambda expression. The event handler can also be a function value, as in the following code example. The following code example also shows the use of the event handler parameters, which provide information specific to the type of event. For a <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event, the system passes a \<xref:System.Windows.Forms.MouseEventArgs*> object, which contains the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> position of the pointer.  
  
 [!code[FsLangRef2#3602](../vs140/codesnippet/FSharp/events--fsharp-_2.fs)]  
  
## Creating Custom Events  
 F# events are represented by the F# [Event](../vs140/control.event--t--class--fsharp-.md) class, which implements the [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md) interface. <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> is itself an interface that combines the functionality of two other interfaces, <xref:System.IObservable<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>Event<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>IObservable<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>let<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>Event<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>Add<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>Trigger<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>Event<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>Event.create<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>Event<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|><CodeContentPlaceHolder>25\</CodeContentPlaceHolder>Event<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>then` block in an additional constructor, as in the following example:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)   
 [Handling and Raising Events](assetId:///b6f65241-e0ad-4590-a99f-200ce741bb1f)   
 [Lambda Expressions: the fun keyword](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md)   
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Control.Event\<'T> Class (F#)](../vs140/control.event--t--class--fsharp-.md)   
 [Control.Event\<'Delegate,'Args> Class (F#)](../vs140/control.event--delegate--args--class--fsharp-.md)