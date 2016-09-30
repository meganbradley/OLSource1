---
title: "Exposing Events in the Visual Studio SDK"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "events [Visual Studio], exposing"
  - "automation [Visual Studio SDK], exposing events"
ms.assetid: 70bbc258-c221-44f8-b0d7-94087d83b8fe
caps.latest.revision: 20
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Exposing Events in the Visual Studio SDK
[!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] lets you source events by using automation. We recommend that you source events for projects and project items.  
  
 Events are retrieved by automation consumers from the \<xref:EnvDTE.DTEClass.Events*> object or \<xref:EnvDTE.DTEClass.GetObject*> ("EventObjectName"). The environment calls <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> by using the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> flags to return an event.  
  
 The following process explains how VSPackage-specific events are returned.  
  
1.  The environment starts.  
  
2.  It reads from the registry all value names under the Automation, AutomationEvents and AutomationProperties keys of all VSPackages, and stores those names in a table.  
  
3.  An automation consumer calls, in this example, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.  
  
4.  The environment finds the string parameter in the table and loads the corresponding VSPackage.  
  
5.  The environment calls the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*> method by using the name passed in the call; in this example, AutomationProjectsEvents or AutomationProjectItemsEvents.  
  
6.  The VSPackage creates a root object that has methods such as <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> and then returns an IDispatch pointer to the object.  
  
7.  The environment calls the appropriate method based on the name passed into the automation call.  
  
8.  The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> method creates another IDispatch-based event object that implements both the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> interface and the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> interface and returns an IDispatchpointer to the object.  
  
 To expose an event by using automation, you must respond to \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*> and watch for the strings that you add to the registry. In the Basic Project sample, the strings are "BscProjectsEvents" and "BscProjectItemsEvents".  
  
## Registry Entries from the Basic Project Sample  
 This section shows where to add automation event values to the registry.  
  
 [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0\Packages\\<PkgGUID\>\AutomationEvents]  
  
 "AutomationProjectEvents"="Returns the AutomationProjectEvents Object"  
  
 "AutomationProjectItemEvents"="Returns the AutomationProjectItemsEvents Object"  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|Default (@)|REG_SZ|Unused|Unused. You can use the data field for documentation.|  
|AutomationProjectsEvents|REG_SZ|Name of your event object.|Only the key name is relevant. You can use the data field for documentation.\<br />\<br /> This example comes from the Basic Project sample.|  
|AutomationProjectItemEvents|REG_SZ|Name of your event object|Only the key name is relevant. You can use the data field for documentation.\<br />\<br /> This example comes from the Basic Project sample.|  
  
 When any of your event objects are requested by an automation consumer, create a root object that has methods for any event that your VSPackage supports. The environment calls the appropriate <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> method on this object. For example, if <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is called, the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> method on the root object is invoked.  
  
 ![Visual Studio Project Events](../vs140/media/projectevents.gif "ProjectEvents")  
Automation model for events  
  
 The class <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> represents the source object for BscProjectsEvents, while <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> represents the source object for BscProjectItemsEvents.  
  
 In most cases, you must return a new object for every event request because most event objects take a filter object. When you fire your event, check this filter to verify that the event handler is being called.  
  
 AutomationEvents.h and AutomationEvents.cpp contain declarations and implementations of the classes in the following table.  
  
|Class|Description|  
|-----------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Implements an event root object, retrieved from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> object.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Implement the event source objects that fire the corresponding events.|  
  
 The following code example shows how to respond to a request for an event object.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 In the code above, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> is the name of your project collection ("FigProjects"), <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> ("FigProjectsEvents") and <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> ("FigProjectItemEvents") are the names of project events and project items events that are sourced from your VSPackage implementation.  
  
 Event objects are retrieved from the same central location, the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> object. This way, all event objects are grouped together so that an end user does not have to browse the entire object model to find a specific event. This also lets you provide your specific VSPackage objects, instead of requiring you to implement your own code for system-wide events. However, for the end user,who must find an event for your <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interface, it is not immediately clear from where that event object is retrieved.  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*>   
 [Basic Project](../vs140/vssdk-samples.md)