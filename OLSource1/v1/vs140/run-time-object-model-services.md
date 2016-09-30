---
title: "Run-Time Object Model Services"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vc.mfc.macros"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "run-time object model services macros"
ms.assetid: 4a3e79df-2ee3-43a4-8193-20298828de85
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Run-Time Object Model Services
The classes [CObject](../vs140/cobject-class.md) and [CRuntimeClass](../vs140/cruntimeclass-structure.md) encapsulate several object services, including access to run-time class information, serialization, and dynamic object creation. All classes derived from <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> inherit this functionality.  
  
 Access to run-time class information enables you to determine information about an object's class at run time. The ability to determine the class of an object at run time is useful when you need extra type-checking of function arguments and when you must write special-purpose code based on the class of an object. Run-time class information is not supported directly by the C++ language.  
  
 Serialization is the process of writing or reading an object's contents to or from a file. You can use serialization to store an object's contents even after the application exits. The object can then be read from the file when the application is restarted. Such data objects are said to be "persistent."  
  
 Dynamic object creation enables you to create an object of a specified class at run time. For example, document, view, and frame objects must support dynamic creation because the framework needs to create them dynamically.  
  
 The following table lists the MFC macros that support run-time class information, serialization, and dynamic creation.  
  
 For more information on these run-time object services and serialization, see the article [CObject Class: Accessing Run-Time Class Information](../vs140/accessing-run-time-class-information.md).  
  
### Run-Time Object Model Services Macros  
  
|||  
|-|-|  
|[DECLARE_DYNAMIC](../vs140/declare_dynamic.md)|Enables access to run-time class information (must be used in the class declaration).|  
|[DECLARE_DYNCREATE](../vs140/declare_dyncreate.md)|Enables dynamic creation and access to run-time class information (must be used in the class declaration).|  
|[DECLARE_SERIAL](../vs140/declare_serial.md)|Enables serialization and access to run-time class information (must be used in the class declaration).|  
|[IMPLEMENT_DYNAMIC](../vs140/implement_dynamic.md)|Enables access to run-time class information (must be used in the class implementation).|  
|[IMPLEMENT_DYNCREATE](../vs140/implement_dyncreate.md)|Enables dynamic creation and access to run-time information (must be used in the class implementation).|  
|[IMPLEMENT_SERIAL](../vs140/implement_serial.md)|Permits serialization and access to run-time class information (must be used in the class implementation).|  
|[RUNTIME_CLASS](../vs140/runtime_class.md)|Returns the <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> structure that corresponds to the named class.|  
  
 OLE frequently requires the dynamic creation of objects at run time. For example, an OLE server application must be able to create OLE items dynamically in response to a request from a client. Similarly, an automation server must be able to create items in response to requests from automation clients.  
  
 The Microsoft Foundation Class Library provides two macros specific to OLE.  
  
### Dynamic Creation of OLE Objects  
  
|||  
|-|-|  
|[DECLARE_OLECREATE](../vs140/declare_olecreate.md)|Enables objects to be created through OLE automation.|  
|[IMPLEMENT_OLECREATE](../vs140/implement_olecreate.md)|Enables objects to be created by the OLE system.|  
  
## See Also  
 [Macros and Globals](../vs140/mfc-macros-and-globals.md)