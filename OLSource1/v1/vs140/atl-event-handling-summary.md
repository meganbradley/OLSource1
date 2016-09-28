---
title: "ATL Event Handling Summary"
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
  - "event handling, implementing"
ms.assetid: e8b47ef0-0bdc-47ff-9dd6-34df11dde9a2
caps.latest.revision: 12
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Event Handling Summary
In general, handling COM events is a relatively simple process. There are three main steps:  
  
-   Implement the event interface on your object.  
  
-   Advise the event source that your object wants to receive events.  
  
-   Unadvise the event source when your object no longer needs to receive events.  
  
## Implementing the Interface  
 There are four main ways of implementing an interface using ATL.  
  
|Derive from|Suitable for Interface type|Requires you to implement all methods*|Requires a type library at run time|  
|-----------------|---------------------------------|---------------------------------------------|-----------------------------------------|  
|The interface|Vtable|Yes|No|  
|[IDispatchImpl](../vs140/idispatchimpl-class.md)|Dual|Yes|Yes|  
|[IDispEventImpl](../vs140/idispeventimpl-class.md)|Dispinterface|No|Yes|  
|[IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md)|Dispinterface|No|No|  
  
 \* When using ATL support classes, you are never required to implement the **IUnknown** or `IDispatch` methods manually.  
  
## Advising and Unadvising the Event Source  
 There are three main ways of advising and unadvising an event source using ATL.  
  
|Advise function|Unadvise function|Most suitable for use with|Requires you to keep track of a cookie?|Comments|  
|---------------------|-----------------------|--------------------------------|---------------------------------------------|--------------|  
|[AtlAdvise](../vs140/atladvise.md), [CComPtrBase::Advise](../vs140/ccomptrbase--advise.md)|[AtlUnadvise](../vs140/atlunadvise.md)|Vtable or dual interfaces|Yes|`AtlAdvise` is a global ATL function. `CComPtrBase::Advise` is used by [CComPtr](../vs140/ccomptr-class.md) and [CComQIPtr](../vs140/ccomqiptr-class.md).|  
|[IDispEventSimpleImpl::DispEventAdvise](../vs140/idispeventsimpleimpl--dispeventadvise.md)|[IDispEventSimpleImpl::DispEventUnadvise](../vs140/idispeventsimpleimpl--dispeventunadvise.md)|[IDispEventImpl](../vs140/idispeventimpl-class.md) or [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md)|No|Fewer parameters than `AtlAdvise` since the base class does more work.|  
|[CComCompositeControl::AdviseSinkMap(TRUE)](../vs140/ccomcompositecontrol--advisesinkmap.md)|[CComCompositeControl::AdviseSinkMap(FALSE)](../vs140/ccomcompositecontrol--advisesinkmap.md)|ActiveX controls in Composite controls|No|`CComCompositeControl::AdviseSinkMap` advises all entries in the event sink map. The same function unadvises the entries. This method is called automatically by the `CComCompositeControl` class.|  
|[CAxDialogImpl::AdviseSinkMap(TRUE)](../vs140/caxdialogimpl--advisesinkmap.md)|[CAxDialogImpl::AdviseSinkMap(FALSE)](../vs140/caxdialogimpl--advisesinkmap.md)|ActiveX controls in a dialog box|No|`CAxDialogImpl::AdviseSinkMap` advises and unadvises all ActiveX controls in the dialog resource. This is done automatically for you.|  
  
## See Also  
 [Event Handling](../vs140/event-handling-and-atl.md)   
 [Supporting IDispEventImpl](../vs140/supporting-idispeventimpl.md)