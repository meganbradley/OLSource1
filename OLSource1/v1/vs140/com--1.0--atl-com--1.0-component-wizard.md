---
title: "COM+ 1.0, ATL COM+ 1.0 Component Wizard"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "reference"
f1_keywords: 
  - "vc.codewiz.class.atl.mts.options"
dev_langs: 
  - "C++"
ms.assetid: 2fbe259c-6be1-4d0e-9cfe-721c75c97cb1
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM+ 1.0, ATL COM+ 1.0 Component Wizard
Use this page of the ATL COM+ 1.0 Component Wizard to specify interface type and additional interfaces to be supported.  
  
 For more information on ATL projects and ATL COM classes, see [ATL Reference](../vs140/atl-com-desktop-components.md).  
  
 **Interface**  
 Indicates the type of interface the object supports. By default, the object supports a dual interface.  
  
|Option|Description|  
|------------|-----------------|  
|**Dual**|Specifies that the object supports a dual interface (its vtable has custom interface functions and late-binding `IDispatch` methods). Allows both COM clients and Automation controllers to access the object.|  
|**Custom**|Specifies that the object supports a custom interface (its vtable has custom interface functions). A custom interface can be faster than a dual interface, especially across process boundaries.<br /><br /> -   **Automation compatible** Adds automation support to the custom interface. For attributed projects, sets the **oleautomation** attribute in the coclass.|  
  
 **Queueable**  
 Indicates that clients can call this component asynchronously using message queues. Adds the component attributed macro custom(TLBATTR_QUEUEABLE, 0) to the .h file (attributed projects) or to the .idl file (nonattributed projects).  
  
 **Support**  
 Indicates additional support for error handling and object control.  
  
|Option|Description|  
|------------|-----------------|  
|**ISupportErrorInfo**|Creates support for the [ISupportErrorInfo](../vs140/isupporterrorinfoimpl-class.md) interface so the object can return error information to the client.|  
|**IObjectControl**|Provides your object access to the three [IObjectControl](http://msdn.microsoft.com/library/windows/desktop/ms686474) methods: [Activate](http://msdn.microsoft.com/library/windows/desktop/ms681303), [CanBePooled](http://msdn.microsoft.com/library/windows/desktop/ms684322), and [Deactivate](http://msdn.microsoft.com/library/windows/desktop/ms687094).|  
|**IObjectConstruct**|Creates support for the [IObjectConstruct](http://msdn.microsoft.com/library/windows/desktop/ms680583) interface to manage passing in parameters from other methods or objects.|  
  
 **Transaction**  
 Indicates that the object supports transactions. Includes the file mtxattr.h in the .idl file (nonattributed projects).  
  
|Option|Description|  
|------------|-----------------|  
|**Supported**|Specifies that the object is never the root of a transaction stream by adding the component attribute macro custom(TLBATTR_TRANS_SUPPORTED,0) to the .h file (attributed projects) or to the .idl file (nonattributed projects).|  
|**Required**|Specifies that the object may or may not be the root of a transaction stream by adding the component attribute macro custom(TLBATTR_TRANS_REQUIRED,0) to the .h file (attributed projects) or to the .idl file (nonattributed projects).|  
|**Not supported**|Specifies that the object excludes transactions. Adds the component attribute macro custom(TLBATTR_TRANS_NOTSUPP,0) to the .h file (attributed projects) or to the .idl file (nonattributed projects).|  
|**Requires new**|Specifies that the object is always the root of a transaction stream by adding the component attribute macro custom(TLBATTR_TRANS_REQNEW,0) to the .h file (attributed projects) or to the .idl file (nonattributed projects).|  
  
## See Also  
 [ATL COM+ 1.0 Component Wizard](../vs140/atl-com--1.0-component-wizard.md)   
 [ATL COM+ 1.0 Component](../vs140/adding-an-atl-com--1.0-component.md)