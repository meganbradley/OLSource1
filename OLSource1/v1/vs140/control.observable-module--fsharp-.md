---
title: "Control.Observable Module (F#)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-fsharp"
ms.tgt_pltfrm: na
ms.topic: "reference"
apiname: 
  - "Control.Observable"
apilocation: 
  - "FSharp.Core.dll"
apitype: "Assembly"
f1_keywords: 
  - "Microsoft.FSharp.Control.ObservableModule"
dev_langs: 
  - "FSharp"
helpviewer_keywords: 
  - "ObservableModule module [F#]"
  - "Observable module [F#]"
ms.assetid: 16b8610b-b30a-4df7-aa99-d9d352276227
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Control.Observable Module (F#)
Basic operations on first class event and other observable objects.  
  
 **Namespace/Module Path:** Microsoft.FSharp.Control  
  
 **Assembly:** FSharp.Core (in FSharp.Core.dll)  
  
## Syntax  
  
```  
module Observable  
```  
  
## Remarks  
  
## Values  
  
|Value|Description|  
|-----------|-----------------|  
|[add](../vs140/observable.add--t--function--fsharp-.md)  `: ('T -> unit) -> IObservable<'T> -> unit`|Creates an observer which permanently subscribes to the given observable and which calls the given function for each observation.|  
|[choose](../vs140/observable.choose--t--u--function--fsharp-.md)  `: ('T -> 'U option) -> IObservable<'T> -> IObservable<'U>`|Returns an observable which chooses a projection of observations from the source using the given function. The returned object will trigger observations for which the splitter returns a `Some`value. The returned object also propagates all errors arising from the source and completes when the source completes.|  
|[filter](../vs140/observable.filter--t--function--fsharp-.md)  `: ('T -> bool) -> IObservable<'T> -> IObservable<'T>`|Returns an observable which filters the observations of the source by the given function. The observable will see only those observations for which the predicate returns `true`. The predicate is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.|  
|[map](../vs140/observable.map--t--u--function--fsharp-.md)  `: ('T -> 'U) -> IObservable<'T> -> IObservable<'U>`|Returns an observable which transforms the observations of the source by the given function. The transformation function is executed once for each subscribed observer. The returned object also propagates error observations arising from the source and completes when the source completes.|  
|[merge](../vs140/observable.merge--t--function--fsharp-.md)  `: IObservable<'T> -> IObservable<'T> -> IObservable<'T>`|Returns an observable for the merged observations from the sources. The returned object propagates success and error values arising from either source and completes when both the sources have completed.|  
|[pairwise](../vs140/observable.pairwise--t--function--fsharp-.md)  `: IObservable<'T> -> IObservable<'T * 'T>`|Returns a new observable that triggers on the second and subsequent triggerings of the input observable. The Nth triggering of the input observable passes the arguments from the N-1th and Nth triggering as a pair. The argument passed to the N-1th triggering is held in hidden internal state until the Nth triggering occurs.|  
|[partition](../vs140/observable.partition--t--function--fsharp-.md)  `: ('T -> bool) -> IObservable<'T> -> IObservable<'T> * IObservable<'T>`|Returns two observables which partition the observations of the source by the given function. The first will trigger observations for those values for which the predicate returns `true`. The second will trigger observations for those values where the predicate returns `false`. The predicate is executed once for each subscribed observer. Both also propagate all error observations arising from the source and each completes when the source completes.|  
|[scan](../vs140/observable.scan--u--t--function--fsharp-.md)  `: ('U -> 'T -> 'U) -> 'U -> IObservable<'T> -> IObservable<'T>`|Returns an observable which, for each observer, allocates an item of state and applies the given accumulating function to successive values arising from the input. The returned object will trigger observations for each computed state value, excluding the initial value. The returned object propagates all errors arising from the source and completes when the source completes.|  
|[split](../vs140/observable.split--t--u1--u2--function--fsharp-.md)  `: ('T -> Choice<'U1,'U2>) -> IObservable<'T> -> IObservable<'U1> * IObservable<'U2>`|Returns two observables which split the observations of the source by the given function. The first will trigger observations for which the splitter returns `Choice1Of2`. The second will trigger observations `y` for which the splitter returns `Choice2Of2`. The splitter is executed once for each subscribed observer. Both also propagate error observations arising from the source and each completes when the source completes.|  
|[subscribe](../vs140/observable.subscribe--t--function--fsharp-.md)  `: ('T -> unit) -> IObservable<'T> -> IDisposable`|Creates an observer which subscribes to the given observable and which calls the given function for each observation.|  
  
## Example  
 The following code example shows how to use observables. The `ObserverSource` class defined in this example is a general-purpose reusable class that you can use as a source of observable events. Examples of using some of the functions in this module are shown here; for functions that are not demonstrated here, you can refer to the code examples in [Event module](../vs140/control.event-module--fsharp-.md).  
  
 [!code[FsObservables#1](../vs140/codesnippet/FSharp/control.observable-module--fsharp-_1.fs)]  
  
## Platforms  
 Windows 8, Windows 7, Windows Server 2012, Windows Server 2008 R2  
  
## Version Information  
 **F# Core Library Versions**  
  
 Supported in: 2.0, 4.0, Portable  
  
## See Also  
 [Microsoft.FSharp.Control Namespace (F#)](../vs140/microsoft.fsharp.control-namespace--fsharp-.md)