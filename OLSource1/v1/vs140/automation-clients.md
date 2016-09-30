---
title: "Automation Clients"
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
  - "clients, Automation"
  - "Automation clients"
  - "type libraries, Automation clients"
  - "clients"
ms.assetid: 84e34a79-06f6-4752-a33b-ae0ede1d8ecf
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Automation Clients
Automation makes it possible for your application to manipulate objects implemented in another application, or to expose objects so they can be manipulated. An Automation client is an application that can manipulate exposed objects belonging to another application. The application that exposes the objects is called the Automation server. The client manipulates the server application's objects by accessing those objects' properties and functions.  
  
### Types of Automation Clients  
 There are two types of Automation clients:  
  
-   Clients that dynamically (at run time) acquire information about the properties and operations of the server.  
  
-   Clients that possess static information (provided at compile time) that specifies the properties and operations of the server.  
  
 Clients of the first kind acquire information about the server's methods and properties by querying the OLE system's <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> mechanism. Although it is adequate to use for dynamic clients, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> is difficult to use for static clients, where the objects being driven must be known at compile time. For static bound clients, the Microsoft Foundation classes provide the [COleDispatchDriver](../vs140/coledispatchdriver-class.md) class.  
  
 Static bound clients use a proxy class that is statically linked with the client application. This class provides a type-safe C++ encapsulation of the server application's properties and operations.  
  
 The class <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> provides the principal support for the client side of Automation. Using the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> dialog box, you create a class derived from <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 You then specify the type-library file describing the properties and functions of the server application's object. The Add Item dialog box reads this file and creates the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>-derived class, with member functions that your application can call to access the server application's objects in C++ in a type-safe manner. Additional functionality inherited from <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> simplifies the process of calling the proper Automation server.  
  
### Handling Events in Automation Clients  
 If you want to handle events in your automation client, you need to add a sink interface. MFC provides wizard support to add sink interfaces for ActiveX controls, but not support for other COM servers. For information on how to add a sink interface in an MFC client for source interfaces described by COM servers, see HOWTO: Create a Sink Interface in MFC-Based COM Client (KB 181845) at [http://support.microsoft.com/default.aspx?scid=kb;en-us;181845](http://support.microsoft.com/default.aspx?scid=kb;en-us;181845).  
  
## See Also  
 [Automation Clients: Using Type Libraries](../vs140/automation-clients--using-type-libraries.md)   
 [Automation](../vs140/automation.md)   
 [MFC Application Wizard](../vs140/mfc-application-wizard.md)