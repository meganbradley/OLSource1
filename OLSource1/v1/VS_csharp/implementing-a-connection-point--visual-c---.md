---
title: "Implementing a Connection Point (Visual C++)"
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
  - "Implement Connection Point Wizard [C++]"
  - "connection points [C++], implementing"
ms.assetid: 5b37e4f9-73c9-4bef-b26d-365bc0662260
caps.latest.revision: 10
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing a Connection Point (Visual C++)
To implement a connection point using the Implement Connection Point Wizard, you must have created a project as an ATL COM application or as an MFC application that contains ATL support. You can use the [ATL Project Wizard](../VS_csharp/atl-project-wizard.md) to create an ATL application, or [add an ATL object to your MFC application](../VS_csharp/adding-atl-support-to-your-mfc-project.md) to implement ATL support for an MFC application.  
  
> [!NOTE]
>  For information about implementing connection points for an MFC project, see [Connection Points](../VS_csharp/connection-points.md).  
  
 Once you create the project, to implement a connection point, you must first add an ATL object. See [Adding Objects and Controls to an ATL Project](../VS_csharp/adding-objects-and-controls-to-an-atl-project.md) for a list of wizards that add objects to your ATL project.  
  
> [!NOTE]
>  The wizard does not support ATL dialogs, XML Web services created with ATL Server, performance objects, or performance counters.  
  
 A connectable object (that is, a source) can expose a connection point for each of its outgoing interfaces. Each outgoing interface can be implemented by a client on an object (that is, a sink). For more information, see [ATL Connection Points](../VS_csharp/atl-connection-points.md).  
  
### To implement a connection point  
  
1.  In Class View, right-click the class name for your ATL object.  
  
2.  Click **Add** from the shortcut menu, and then click **Add Connection Point** to display the [Implement Connection Point Wizard](../VS_csharp/implement-connection-point-wizard.md).  
  
3.  Select the connection point interfaces to implement from the appropriate type libraries and click **Finish**.  
  
4.  In Class View, examine the proxy classes created for each connection point. The classes appear as CProxy*InterfaceName*<T\> and are derived from [IConnectionPointImpl](../VS_csharp/iconnectionpointimpl-class.md).  
  
5.  Double-click the connection point class to display the definition of the connection point's class.  
  
    -   If you implement a connection point for your own project's interface, the following definition appears  
  
        ```  
        template< class T >  
        class CProxyInterfaceName :  
           public IConnectionPointImpl< T, &IID_InterfaceName >  
        {  
        public:  
        };  
        ```  
  
         If you implement a local interface, methods and properties appear in the class body.  
  
    -   If you implement a connection point for another interface, the definition includes the interface's methods, each preceded by `Fire_`.  
  
## See Also  
 [Adding Functionality with Code Wizards](../VS_csharp/adding-functionality-with-code-wizards--c---.md)   
 [Adding Connection Points to an Object](../VS_csharp/adding-connection-points-to-an-object.md)