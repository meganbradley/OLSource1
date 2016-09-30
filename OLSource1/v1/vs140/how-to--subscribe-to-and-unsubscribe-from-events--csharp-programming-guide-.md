---
title: "How to: Subscribe to and Unsubscribe from Events (C# Programming Guide)"
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
  - "event handlers [C#], creating"
  - "Code Editor, event handlers"
  - "events [C#], creating using the IDE"
ms.assetid: 6319f39f-282c-4173-8a62-6c4657cf51cd
caps.latest.revision: 19
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# How to: Subscribe to and Unsubscribe from Events (C# Programming Guide)
You subscribe to an event that is published by another class when you want to write custom code that is called when that event is raised. For example, you might subscribe to a button's <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> event in order to make your application do something useful when the user clicks the button.  
  
### To subscribe to events by using the Visual Studio IDE  
  
1.  If you cannot see the **Properties** window, in **Design** view, right-click the form or control for which you want to create an event handler, and select **Properties**.  
  
2.  On top of the **Properties** window, click the **Events** icon.  
  
3.  Double-click the event that you want to create, for example the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> event.  
  
     [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] creates an empty event handler method and adds it to your code. Alternatively you can add the code manually in **Code** view. For example, the following lines of code declare an event handler method that will be called when the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> class raises the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> event.  
  
     [!code[csProgGuideEvents#11](../vs140/codesnippet/CSharp/how-to--subscribe-to-and-unsubscribe-from-events--csharp-programming-guide-_1.cs)]  
  
     The line of code that is required to subscribe to the event is also automatically generated in the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method in the Form1.Designer.cs file in your project. It resembles this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### To subscribe to events programmatically  
  
1.  Define an event handler method whose signature matches the delegate signature for the event. For example, if the event is based on the \<xref:System.EventHandler*> delegate type, the following code represents the method stub:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
2.  Use the addition assignment operator (<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>) to attach your event handler to the event. In the following example, assume that an object named <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> has an event named <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>. Note that the subscriber class needs a reference to the publisher class in order to subscribe to its events.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     Note that the previous syntax is new in C# 2.0. It is exactly equivalent to the C# 1.0 syntax in which the encapsulating delegate must be explicitly created by using the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> keyword:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     An event handler can also be added by using a lambda expression:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     For more information, see [How To: Use Lamba Expressions Outside of LINQ](../vs140/how-to--use-lambda-expressions-outside-linq--csharp-programming-guide-.md).  
  
### To subscribe to events by using an anonymous method  
  
-   If you will not have to unsubscribe to an event later, you can use the addition assignment operator (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>) to attach an anonymous method to the event. In the following example, assume that an object named <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> has an event named <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and that a <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class has also been defined to carry some kind of specialized event information. Note that the subscriber class needs a reference to <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> in order to subscribe to its events.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     It is important to notice that you cannot easily unsubscribe from an event if you used an anonymous function to subscribe to it. To unsubscribe in this scenario, it is necessary to go back to the code where you subscribe to the event, store the anonymous method in a delegate variable, and then add the delegate to the event. In general, we recommend that you do not use anonymous functions to subscribe to events if you will have to unsubscribe from the event at some later point in your code. For more information about anonymous functions, see [Anonymous Functions (C# Programming Guide)](../vs140/anonymous-functions--csharp-programming-guide-.md).  
  
## Unsubscribing  
 To prevent your event handler from being invoked when the event is raised, unsubscribe from the event. In order to prevent resource leaks, you should unsubscribe from events before you dispose of a subscriber object. Until you unsubscribe from an event, the multicast delegate that underlies the event in the publishing object has a reference to the delegate that encapsulates the subscriber's event handler. As long as the publishing object holds that reference, garbage collection will not delete your subscriber object.  
  
#### To unsubscribe from an event  
  
-   Use the subtraction assignment operator (<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>) to unsubscribe from an event:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     When all subscribers have unsubscribed from an event, the event instance in the publisher class is set to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>.  
  
## See Also  
 [Events (C# Programming Guide)](../vs140/events--csharp-programming-guide-.md)   
 [event (C# Reference)](../vs140/event--csharp-reference-.md)   
 [How to: Publish Events that Conform to .NET Framework Guidelines (C# Programming Guide)](../vs140/how-to--publish-events-that-conform-to-.net-framework-guidelines--csharp-programming-guide-.md)   
 [-= Operator (C# Reference)](../vs140/-=-operator--csharp-reference-2.md)   
 [+= Operator (C# Reference)](../vs140/-=-operator--csharp-reference-.md)