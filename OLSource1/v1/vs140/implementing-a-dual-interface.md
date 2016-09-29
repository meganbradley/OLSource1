---
title: "Implementing a Dual Interface"
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
  - "IDispatchImpl class, implementing dual interfaces"
  - "dual interfaces, implementing"
ms.assetid: d1da3633-b445-4dcd-8a0a-3efdafada3ea
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing a Dual Interface
You can implement a dual interface using the [IDispatchImpl](../vs140/idispatchimpl-class.md) class, which provides a default implementation of the `IDispatch` methods in a dual interface. For more information, see [Implementing the IDispatch Interface](assetId:///0e171f7f-0022-4e9b-ac8e-98192828e945).  
  
 To use this class:  
  
-   Define your dual interface in a type library.  
  
-   Derive your class from a specialization of `IDispatchImpl` (pass information about the interface and type library as the template arguments).  
  
-   Add an entry (or entries) to the COM map to expose the dual interface through `QueryInterface`.  
  
-   Implement the vtable part of the interface in your class.  
  
-   Ensure that the type library containing the interface definition is available to your objects at run time.  
  
## ATL Simple Object Wizard  
 If you want to create a new interface and a new class to implement it, you can use the [ATL Add Class dialog box](../vs140/add-class-dialog-box.md), and then the [ATL Simple Object Wizard](../vs140/atl-simple-object-wizard.md).  
  
## Implement Interface Wizard  
 If you have an existing interface, you can use the [Implement Interface Wizard](../vs140/adding-a-new-interface-in-an-atl-project.md) to add the necessary base class, COM map entries, and skeleton method implementations to an existing class.  
  
> [!NOTE]
>  You may need to adjust the generated base class so that the major and minor version numbers of the type library are passed as template arguments to your `IDispatchImpl` base class. The Implement Interface Wizard doesn't check the type library version number for you.  
  
## Implementing IDispatch  
 You can use an `IDispatchImpl` base class to provide an implementation of a dispinterface just by specifying the appropriate entry in the COM map (using the [COM_INTERFACE_ENTRY2](../vs140/com_interface_entry2.md) or [COM_INTERFACE_ENTRY_IID](../vs140/com_interface_entry_iid.md) macro) as long as you have a type library describing a corresponding dual interface. It is quite common to implement the `IDispatch` interface this way, for example. The ATL Simple Object Wizard and Implement Interface Wizard both assume that you intend to implement `IDispatch` in this way, so they will add the appropriate entry to the map.  
  
> [!NOTE]
>  ATL offers the [IDispEventImpl](../vs140/idispeventimpl-class.md) and [IDispEventSimpleImpl](../vs140/idispeventsimpleimpl-class.md) classes to help you implement dispinterfaces without requiring a type library containing the definition of a compatible dual interface.  
  
## See Also  
 [Dual Interfaces and ATL](../vs140/dual-interfaces-and-atl.md)