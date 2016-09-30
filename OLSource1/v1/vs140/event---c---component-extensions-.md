---
title: "event  (C++ Component Extensions)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "language-reference"
f1_keywords: 
  - "event"
  - "event_cpp"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event keyword [C++]"
ms.assetid: c4998e42-883c-4419-bbf4-36cdc979dd27
caps.latest.revision: 36
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event  (C++ Component Extensions)
The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> keyword declares an *event*, which is a notification to registered subscribers (*event handlers*) that something of interest has occurred.  
  
## All Runtimes  
 C++/CX supports declaring an *event member* or an *event block*. An event member is shorthand for declaring an event block. By default, an event member declares the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> functions that are declared explicitly in an event block. To customize the functions in an event member, declare an event block instead and then override the functions that you require.  
  
 **Syntax**  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *modifier*  
 A modifier that can be used on either the event declaration or an event accessor method.  Possible values are <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.  
  
 *delegate*  
 The [delegate](../vs140/delegate---c---component-extensions-.md), whose signature the event handler must match.  
  
 *event_name*  
 The name of the event.  
  
 *return_value*  
 The return value of the event accessor method.  To be verifiable, the return type must be <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.  
  
 *parameters*  
 (optional) Parameters for the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method, which match the signature of the *delegate* parameter.  
  
 **Remarks**  
  
 An event is an association between a delegate and a member function (event handler) that responds to the triggering of the event and allows clients from any class to register methods that comply with the signature and return type of the underlying delegate.  
  
 There are two kinds of events declarations:  
  
 *event data member*  
 The compiler automatically creates storage for the event in the form of a member of the delegate type, and creates internal <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> member functions. An event data member must be declared inside a class. The return type of the return type of the delegate must match the return type of the event handler.  
  
 *event block*  
 An event block enables you to explicitly declare and customize the behavior of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> methods.  
  
 You can use <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> to add and remove an event handler, or call the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> methods explicitly.  
  
 <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> is a context-sensitive keyword; see [Context-Sensitive Keywords](../vs140/context-sensitive-keywords---c---component-extensions-.md) for more information.  
  
## [!INCLUDE[wrt](../vs140/includes/wrt_md.md)]  
  
### Remarks  
 For more information, see [Events (C++/CX)](http://msdn.microsoft.com/library/windows/apps/hh755799.aspx).  
  
 If you intend to add and then remove an event handler, you must save the EventRegistrationToken structure that is returned by the add operation. Then in the remove operation, you must use the saved EventRegistrationToken structure to identify the event handler to be removed.  
  
### Requirements  
 Compiler option: **/ZW**  
  
## [!INCLUDE[clr_for_headings](../vs140/includes/clr_for_headings_md.md)]  
 The <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> keyword lets you declare an event. An event is a way for a class to provide notifications when something of interest happens.  
  
 **Syntax**  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 **Parameters**  
  
 *modifier*  
 A modifier that can be used on either the event declaration or an event accessor method.  Possible values are <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.  
  
 *delegate*  
 The [delegate](../vs140/delegate---c---component-extensions-.md), whose signature the event handler must match.  
  
 *event_name*  
 The name of the event.  
  
 *return_value*  
 The return value of the event accessor method.  To be verifiable, the return type must be <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.  
  
 *parameters*  
 (optional) Parameters for the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> method, which match the signature of the *delegate* parameter.  
  
 **Remarks**  
  
 An event is an association between a delegate and a member function (event handler) that responds to the triggering of the event and allows clients from any class to register methods that comply with the signature and return type of the underlying delegate.  
  
 The delegate can have one or more associated methods that will be called when your code indicates that the event has occurred. An event in one program can be made available to other programs that target the .NET Framework common language runtime. See [Raising an Event Defined in a Different Assembly](../vs140/how-to--raise-events-defined-in-a-different-assembly.md) for a sample.  
  
 There are two kinds of events declarations:  
  
 *event data members*  
 Storage for the event, in the form of a member of the delegate type, is created by the compiler for data member events.  An event data member must be declared inside a class. This is also known as a trivial event (see code sample below.)  
  
 *event blocks*  
 Event blocks let you customize the behavior of the add, remove, and raise methods, by implementing add, remove, and raise methods. The signature of the add, remove, and raise methods must match the signature of the delegate.  Event block events are not data members and any use as a data member will generate a compiler error. See [Defining Event Accessor Methods](../vs140/how-to--define-event-accessor-methods.md) for a sample.  
  
 The return type of the event handler must match the return type of the delegate.  
  
 In the .NET Framework, you can treat a data member as if it were a method itself (that is, the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> method of its corresponding delegate). You must predefine the delegate type for declaring a managed event data member. In contrast, a managed event method implicitly defines the corresponding managed delegate if it is not already defined.  See the code sample at the end of this topic for an example.  
  
 When declaring a managed event, you can specify add and remove accessors that will be called when event handlers are added or removed using operators += and -=. The add, remove and raise methods can be called explicitly.  
  
 The following steps must be taken in order to create and use events in Visual C++:  
  
1.  Create or identify a delegate. If you are defining your own event, you must also ensure that there is a delegate to use with the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> keyword. If the event is predefined, in the .NET Framework for example, then consumers of the event need only know the name of the delegate.  
  
2.  Create a class that contains:  
  
    -   An event created from the delegate.  
  
    -   (optional) A method that verifies that an instance of the delegate declared with the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> keyword exists. Otherwise, this logic must be placed in the code that fires the event.  
  
    -   Methods that call the event. These methods can be overrides of some base class functionality.  
  
     This class defines the event.  
  
3.  Define one or more classes that connect methods to the event. Each of these classes will associate one or more methods with the event in the base class.  
  
4.  Use the event:  
  
    -   Create an object of the class that contains the event declaration.  
  
    -   Create an object of the class that contains the event definition.  
  
 For more information on [!INCLUDE[cppcli](../vs140/includes/cppcli_md.md)] events, see  
  
-   [Events in an Interface](../vs140/how-to--use-events-in-c---cli.md)  
  
-   [Overriding the Default Access of add, remove, and raise Methods](../vs140/how-to--override-default-access-of-add--remove--and-raise-methods.md)  
  
-   [Multiple Handlers to an Event](../vs140/how-to--add-multiple-handlers-to-events.md)  
  
-   [Managed Virtual Events](../vs140/how-to--implement-managed-virtual-events.md)  
  
-   [Event Accessor Methods](../vs140/how-to--define-event-accessor-methods.md)  
  
-   [Static Events](../vs140/how-to--define-and-use-static-events.md)  
  
-   [Raising an Event Defined in a Different Assembly](../vs140/how-to--raise-events-defined-in-a-different-assembly.md)  
  
-   [Abstract Events](../vs140/how-to--implement-abstract-events.md)  
  
### Requirements  
 Compiler option: **/clr**  
  
### Examples  
 **Example**  
  
 The following code example demonstrates declaring pairs of delegates, events, and event handlers; subscribing (adding) the event handlers; invoking the event handlers; and then unsubscribing (removing) the event handlers.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 **Output**  
  
 **OnClick: 7, 3.14159**   
 **OnDblClick: Hello** **Example**  
  
 The following code example demonstrates the logic used to generate the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method of a trivial event: If the event has one or more subscribers, calling the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method implicitly or explicitly calls the delegate. If the delegate's return type is not <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> and if there are zero event subscribers, the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method returns the default value for the delegate type. If there are no event subscribers, calling the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method simply returns and no exception is raised. If the delegate return type is not <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, the delegate type is returned.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 **Output**  
  
 **0**   
 **688**   
## See Also  
 [Language Extensions for Runtime Platforms](../vs140/component-extensions-for-runtime-platforms.md)