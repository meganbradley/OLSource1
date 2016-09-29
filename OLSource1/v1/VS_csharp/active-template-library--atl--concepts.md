---
title: "Active Template Library (ATL) Concepts"
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
  - "ATL, about ATL"
ms.assetid: a3960991-4d76-4da5-9568-3fa7fde53ff4
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Active Template Library (ATL) Concepts
The Active Template Library (ATL) is a set of template-based C++ classes that let you create small, fast Component Object Model (COM) objects. It has special support for key COM features, including stock implementations, dual interfaces, standard COM enumerator interfaces, connection points, tear-off interfaces, and ActiveX controls.  
  
 If you do a lot of ATL programming, you will want to learn more about attributes, a new feature in Visual C++ .NET that is designed to simplify COM programming. For more information, see [Attributed Programming](../VS_csharp/attributed-programming-concepts.md).  
  
## In This Section  
 [ATL Tutorial](../VS_csharp/active-template-library--atl--tutorial.md)  
 Leads you through the creation of a control and demonstrates some ATL fundamentals in the process.  
  
 [Introduction to COM and ATL](../VS_csharp/introduction-to-com-and-atl.md)  
 Introduces the major concepts behind the Component Object Model (COM). This article also briefly explains what ATL is and when you should use it.  
  
 [Fundamentals of ATL COM Objects](../VS_csharp/fundamentals-of-atl-com-objects.md)  
 Discusses the relationship among various ATL classes and how those classes are implemented.  
  
 [Dual Interfaces and ATL](../VS_csharp/dual-interfaces-and-atl.md)  
 Describes dual interfaces from an ATL perspective.  
  
 [ATL Collections and Enumerators](../VS_csharp/atl-collections-and-enumerators.md)  
 Describes the implementation and creation of collections and enumerators in ATL.  
  
 [Composite Control Fundamentals](../VS_csharp/atl-composite-control-fundamentals.md)  
 Provides step-by-step instructions for creating a composite control. A composite control is a type of ActiveX control that can contain other ActiveX controls or Windows controls.  
  
 [ATL Control Containment FAQ](../VS_csharp/atl-control-containment-faq.md)  
 Covers the fundamental questions related to hosting controls with ATL.  
  
 [ATL COM Property Pages](../VS_csharp/atl-com-property-pages.md)  
 Shows you how to specify and implement COM property pages.  
  
 [ATL Support for DHTML Controls](../VS_csharp/atl-support-for-dhtml-controls.md)  
 Provides step-by-step instructions for creating a DHTML control.  
  
 [ATL Connection Points](../VS_csharp/atl-connection-points.md)  
 Explains what connection points are and how ATL implements them.  
  
 [Event Handling and ATL](../VS_csharp/event-handling-and-atl.md)  
 Describes the steps that you need to take to handle COM events using ATL's [IDispEventImpl](../VS_csharp/idispeventimpl-class.md) and [IDispEventSimpleImpl](../VS_csharp/idispeventsimpleimpl-class.md) classes.  
  
 [ATL and the Free Threaded Marshaler](../VS_csharp/atl-and-the-free-threaded-marshaler.md)  
 Provides details on the ATL Simple Object Wizard's option that allows your class to aggregate the free threaded marshaler (FTM).  
  
 [Specifying the Project's Threading Model](../VS_csharp/specifying-the-threading-model-for-a-project--atl-.md)  
 Describes the macros that are available to control run-time performance related to threading in your project.  
  
 [ATL Module Classes](../VS_csharp/atl-module-classes.md)  
 Discusses the module classes new for ATL 7.0. Module classes implement the basic functionality required by ATL.  
  
 [ATL Services](../VS_csharp/atl-services.md)  
 Covers the series of events that occur when a service is implemented. Also talks about some of the concepts related to developing a service.  
  
 [ATL Window Classes](../VS_csharp/atl-window-classes.md)  
 Describes how to create, superclass, and subclass windows in ATL. The ATL window classes are not COM classes.  
  
 [ATL Collection Classes](../VS_csharp/atl-collection-classes.md)  
 Describes how to use arrays and maps in ATL.  
  
 [The ATL Registry Component (Registrar)](../VS_csharp/atl-registry-component--registrar-.md)  
 Discusses ATL scripting syntax and replaceable parameters. It also explains how to set up a static link to the Registrar.  
  
 [Programming with ATL and C Run-Time Code](../VS_csharp/programming-with-atl-and-c-run-time-code.md)  
 Discusses the benefits of linking statically or dynamically to the C Run-Time Library (CRT).  
  
 [Programming with CComBSTR](../VS_csharp/programming-with-ccombstr--atl-.md)  
 Discusses several situations that require caution when programming with `CComBSTR`.  
  
 [ATL Encoding Reference](../VS_csharp/atl-encoding-reference.md)  
 Provides functions and macros that support encoding in a range of common Internet standards such as uuencode, hexadecimal, and UTF8 in atlenc.h.  
  
 [ATL Utilities Reference](../VS_csharp/atl-utilities-reference.md)  
 Provides code for manipulating paths and URLs in the form of [CPathT](../VS_csharp/cpatht-class.md) and [CUrl](../VS_csharp/curl-class.md). A thread pool, [CThreadPool](../VS_csharp/cthreadpool-class.md), can be used in your own applications. This code can be found in atlpath.h and atlutil.h.  
  
## Related Sections  
 [ATL Samples](../VS_csharp/visual-c---samples.md)  
 Provides descriptions of and links to the ATL sample programs.  
  
 [Creating an ATL Project](../VS_csharp/creating-an-atl-project.md)  
 Contains information on the ATL Project Wizard.  
  
 [ATL Control Wizard](../VS_csharp/atl-control-wizard.md)  
 Discusses how to add classes.  
  
 [Attributed Programming](../VS_csharp/attributed-programming-concepts.md)  
 Provides an overview on using attributes to simplify COM programming plus a list of links to more detailed topics.  
  
 [ATL Class Overview](../VS_csharp/atl-class-overview.md)  
 Provides reference information and links to the ATL classes.