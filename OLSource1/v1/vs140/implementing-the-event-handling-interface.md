---
title: "Implementing the Event Handling Interface"
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
  - "ATL, event handling"
  - "event handling, ATL"
  - "interfaces, event and event sink"
ms.assetid: eb2a5b33-88dc-4ce3-bee0-c5c38ea050d7
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing the Event Handling Interface
ATL helps you with all three elements required for handling events: implementing the event interface, advising the event source, and unadvising the event source. The precise steps you'll need to take depend on the type of the event interface and the performance requirements of your application.  
  
 The most common ways of implementing an interface using ATL are:  
  
-   Deriving from a custom interface directly.  
  
-   Deriving from [IDispatchImpl](../vs140/idispatchimpl-class.md) for dual interfaces described in a type library.  
  
-   Deriving from [IDispEventImpl](../vs140/idispeventimpl-class.md) for dispinterfaces described in a type library.  
  
-   Deriving from [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) for dispinterfaces not described in a type library or when you want to improve efficiency by not loading the type information at run time.  
  
 If you are implementing a custom or dual interface, you should advise the event source by calling [AtlAdvise](../vs140/atladvise.md) or [CComPtrBase::Advise](../vs140/ccomptrbase--advise.md). You will need to keep track of the cookie returned by the call yourself. Call [AtlUnadvise](../vs140/atlunadvise.md) to break the connection.  
  
 If you are implementing a dispinterface using <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>1\</CodeContentPlaceHolder>, you should advise the event source by calling [IDispEventSimpleImpl::DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md). Call [IDispEventSimpleImpl::DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md) to break the connection.  
  
 If you are using <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> as a base class of a composite control, the event sources listed in the sink map will be advised and unadvised automatically using [CComCompositeControl::AdviseSinkMap](../vs140/ccomcompositecontrol--advisesinkmap.md).  
  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> classes manage the cookie for you.  
  
## See Also  
 [Event Handling](../vs140/event-handling-and-atl.md)