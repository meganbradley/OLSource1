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
 When you use a GUI library like Windows Forms or Windows Presentation Foundation (WPF), much of the code in your application runs in response to events that are predefined by the library. These predefined events are members of GUI classes such as forms and controls. You can add custom behavior to a preexisting event, such as a button click, by referencing the specific named event of interest (for example, the `Click` event of the `Form` class) and invoking the `Add` method, as shown in the following code. If you run this from F# Interactive, omit the call to <xref:System.Windows.Forms.Application.Run*>.  
  
 [!code[FsLangRef2#3601](../vs140/codesnippet/FSharp/events--fsharp-_1.fs)]  
  
 The type of the `Add` method is `('a -> unit) -> unit`. Therefore, the event handler method takes one parameter, typically the event arguments, and returns `unit`. The previous example shows the event handler as a lambda expression. The event handler can also be a function value, as in the following code example. The following code example also shows the use of the event handler parameters, which provide information specific to the type of event. For a `MouseMove` event, the system passes a <xref:System.Windows.Forms.MouseEventArgs*> object, which contains the `X` and `Y` position of the pointer.  
  
 [!code[FsLangRef2#3602](../vs140/codesnippet/FSharp/events--fsharp-_2.fs)]  
  
## Creating Custom Events  
 F# events are represented by the F# [Event](../vs140/control.event--t--class--fsharp-.md) class, which implements the [IEvent](../vs140/control.ievent--delegate--args--interface--fsharp-.md) interface. `IEvent` is itself an interface that combines the functionality of two other interfaces, <xref:System.IObservable`1*> and [IDelegateEvent](../vs140/control.idelegateevent--delegate--interface--fsharp-.md). Therefore, `Event`s have the equivalent functionality of delegates in other languages, plus the additional functionality from `IObservable`, which means that F# events support event filtering and using F# first-class functions and lambda expressions as event handlers. This functionality is provided in the [Event module](../vs140/control.event-module--fsharp-.md).  
  
 To create an event on a class that acts just like any other .NET Framework event, add to the class a `let` binding that defines an `Event` as a field in a class. You can specify the desired event argument type as the type argument, or leave it blank and have the compiler infer the appropriate type. You also must define an event member that exposes the event as a CLI event. This member should have the [CLIEvent](../vs140/core.clieventattribute-class--fsharp-.md) attribute. It is declared like a property and its implementation is just a call to the [Publish](../vs140/event.publish--t--property--fsharp-.md) property of the event. Users of your class can use the `Add` method of the published event to add a handler. The argument for the `Add` method can be a lambda expression. You can use the `Trigger` property of the event to raise the event, passing the arguments to the handler function. The following code example illustrates this. In this example, the inferred type argument for the event is a tuple, which represents the arguments for the lambda expression.  
  
 [!code[FsLangRef2#3605](../vs140/codesnippet/FSharp/events--fsharp-_3.fs)]  
  
 The output is as follows.  
  
<CodeContentPlaceHolder>0</CodeContentPlaceHolder>  
 The additional functionality provided by the `Event` module is illustrated here. The following code example illustrates the basic use of `Event.create` to create an event and a trigger method, add two event handlers in the form of lambda expressions, and then trigger the event to execute both lambda expressions.  
  
 [!code[FsLangRef2#3603](../vs140/codesnippet/FSharp/events--fsharp-_4.fs)]  
  
 The output of the previous code is as follows.  
  
<CodeContentPlaceHolder>1</CodeContentPlaceHolder>  
## Processing Event Streams  
 Instead of just adding an event handler for an event by using the [Event.add](../vs140/event.add--t--del--function--fsharp-.md) function, you can use the functions in the `Event` module to process streams of events in highly customized ways. To do this, you use the forward pipe (`|>`) together with the event as the first value in a series of function calls, and the `Event` module functions as subsequent function calls.  
  
 The following code example shows how to set up an event for which the handler is only called under certain conditions.  
  
 [!code[FsLangRef2#3604](../vs140/codesnippet/FSharp/events--fsharp-_5.fs)]  
  
 The [Observable module](../vs140/control.observable-module--fsharp-.md) contains similar functions that operate on observable objects. Observable objects are similar to events but only actively subscribe to events if they themselves are being subscribed to.  
  
## Implementing an Interface Event  
 As you develop UI components, you often start by creating a new form or a new control that inherits from an existing form or control. Events are frequently defined on an interface, and, in that case, you must implement the interface to implement the event. The <xref:System.ComponentModel.INotifyPropertyChanged*> interface defines a single <xref:System.ComponentModel.INotifyPropertyChanged.PropertyChanged*> event. The following code illustrates how to implement the event that this inherited interface defined:  
  
<CodeContentPlaceHolder>2</CodeContentPlaceHolder>  
 If you want to hook up the event in the constructor, the code is a bit more complicated because the event hookup must be in a `then` block in an additional constructor, as in the following example:  
  
```f#  
module CustomForm  
  
open System.Windows.Forms  
open System.ComponentModel  
  
// Create a private constructor with a dummy argument so that the public  
// constructor can have no arguments.  
type AppForm private (dummy) as this =  
   inherit Form()  
  
   // Define the propertyChanged event.  
   let propertyChanged = Event<PropertyChangedEventHandler, PropertyChangedEventArgs>()  
   let mutable underlyingValue = "text0"  
  
   // Set up a click event to change the properties.  
   do  
      this.Click |> Event.add(fun evArgs -> this.Property1 <- "text2"  
                                            this.Property2 <- "text3")  
  
   // This property does not have the property changed event set.  
   member val Property1 : string = "text" with get, set  
  
   // This property has the property changed event set.  
   member this.Property2  
        with get() = underlyingValue  
        and set(newValue) =  
            underlyingValue <- newValue  
            propertyChanged.Trigger(this, new PropertyChangedEventArgs("Property2"))  
  
   [<CLIEvent>]  
   member this.PropertyChanged = propertyChanged.Publish  
  
   // Define the add and remove methods to implement this interface.  
   interface INotifyPropertyChanged with  
       member this.add_PropertyChanged(handler) = this.PropertyChanged.AddHandler(handler)  
       member this.remove_PropertyChanged(handler) = this.PropertyChanged.RemoveHandler(handler)  
  
   // This is the event handler method.  
   member this.OnPropertyChanged(args : PropertyChangedEventArgs) =  
       let newProperty = this.GetType().GetProperty(args.PropertyName)  
       let newValue = newProperty.GetValue(this :> obj) :?> string  
       printfn "Property %s changed its value to %s" args.PropertyName newValue  
  
   new() as this =  
        new AppForm(0)  
          then  
          let inpc = this :> INotifyPropertyChanged  
          inpc.PropertyChanged.Add(this.OnPropertyChanged)  
  
// Create a form, hook up the event handler, and start the application.  
let appForm = new AppForm()  
Application.Run(appForm)  
```  
  
## See Also  
 [Members (F#)](../vs140/members--fsharp-.md)   
 [Handling and Raising Events](assetId:///b6f65241-e0ad-4590-a99f-200ce741bb1f)   
 [Lambda Expressions: the fun keyword](../vs140/lambda-expressions--the-fun-keyword--fsharp-.md)   
 [Control.Event Module (F#)](../vs140/control.event-module--fsharp-.md)   
 [Control.Event<'T> Class (F#)](../vs140/control.event--t--class--fsharp-.md)   
 [Control.Event<'Delegate,'Args> Class (F#)](../vs140/control.event--delegate--args--class--fsharp-.md)