---
title: "event_source"
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
  - "vc-attr.event_source"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "event handling, attributes"
  - "event logs, event source"
  - "event sources, creating"
  - "event_source attribute"
  - "event sources"
  - "event handling, creating event source"
ms.assetid: 0983e36a-6127-4fbb-8a22-8dfec6564c16
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# event_source
Creates an event source.  
  
## Syntax  
  
```  
  
      [ event_source(  
   type,  
   optimize=[speed | size],  
   decorate=[true | false]  
) ]  
```  
  
#### Parameters  
 `type`  
 An enumeration of one of the following values:  
  
-   `native` for unmanaged C/C++ code (default for unmanaged classes).  
  
-   `com` for COM code. You must use `coclass` when `type`=`com`. This value requires that you include the following header files:  
  
    ```  
    #define _ATL_ATTRIBUTES  
    #include <atlbase.h>  
    #include <atlcom.h>  
    ```  
  
 **optimize**  
 When `type` is **native**, you can specify **optimize=size**, to indicate that there is 4 bytes of storage (minimum) for all events in a class or **optimize=speed** (the default) to indicate that there is 4 * (# of events) bytes of storage.  
  
 **decorate**  
 When `type` is **native**, you can specify **decorate=false**, to indicate that the expanded name in the merged (.mrg) file should not include the enclosing class name. [/Fx](../VS_csharp/-fx--merge-injected-code-.md) lets you generate .mrg files. **decorate=false**, which is the default, results in fully-qualified type names in the merged file.  
  
## Remarks  
 The **event_source** C++ attribute specifies that the class or structure to which it is applied will be an event source.  
  
 **event_source** is used in conjunction with the [event_receiver](../VS_csharp/event_receiver.md) attribute and the [__event](../VS_csharp/__event.md) keyword. Use **event_receiver** to create event receivers. Use `__event` on methods within the event source to specify those methods as events.  
  
> [!NOTE]
>  A templated class or struct cannot contain events.  
  
## Requirements  
  
### Attribute Context  
  
|||  
|-|-|  
|**Applies to**|**class**, `struct`|  
|**Repeatable**|No|  
|**Required attributes**|**coclass** when `type`=**com**|  
|**Invalid attributes**|None|  
  
 For more information, see [Attribute Contexts](../VS_csharp/attribute-contexts.md).  
  
## See Also  
 [Compiler Attributes](../VS_csharp/compiler-attributes.md)   
 [event_receiver](../VS_csharp/event_receiver.md)   
 [__event](../VS_csharp/__event.md)   
 [__hook](../VS_csharp/__hook.md)   
 [__unhook](../VS_csharp/__unhook.md)   
 [Class Attributes](../VS_csharp/class-attributes.md)   
 [Attributes Samples](assetId:///558ebdb2-082f-44dc-b442-d8d33bf7bdb8)