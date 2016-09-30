---
title: "Logging in a Multi-Processor Environment"
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
  - "MSBuild, multi-processor logging"
  - "MSBuild, logging"
ms.assetid: dd4dae65-ed04-4883-b48d-59bcb891c4dc
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Logging in a Multi-Processor Environment
The ability of MSBuild to use multiple processors can greatly decrease project building time, but it also adds complexity to logging. In a single-processor environment, the logger can handle incoming events, messages, warnings, and errors in a predictable, sequential manner. However, in a multi-processor environment, events from several sources can arrive simultaneously or out of sequence. MSBuild provides a new multi-processor-aware logger and enables the creation of custom "forwarding loggers."  
  
## Logging Multiple-Processor Builds  
 When you build one or more projects in a multi-processor or multi-core system, MSBuild build events for all the projects are generated simultaneously. An avalanche of event data may arrive at the logger at the same time or out of sequence. This can overwhelm the logger and cause increased build times, incorrect logger output, or even a broken build. To address these issues, the MSBuild logger can process out-of-sequence events and correlate events and their sources.  
  
 You can improve logging efficiency even more by creating a custom forwarding logger. A custom-forwarding logger acts as a filter by letting you choose, before you build, the events you want to monitor. When you use a custom forwarding logger, unwanted events do not overwhelm the logger, clutter your logs, or slow build times.  
  
### Central Logging Model  
 For multi-processor builds, MSBuild uses a "central logging model." In the central logging model, an instance of MSBuild.exe acts as the primary build process, or "central node." Secondary instances of MSBuild.exe, or "secondary nodes," are attached to the central node. Any ILogger-based loggers attached to the central node are known as "central loggers" and loggers attached to secondary nodes are known as "secondary loggers."  
  
 When a build occurs, the secondary loggers route their event traffic to the central loggers. Because events originate at several secondary nodes, the data arrives at the central node simultaneously but interleaved. To resolve event-to-project and event-to-target references, the event arguments include additional build event context information.  
  
 Although only \<xref:Microsoft.Build.Framework.ILogger*> is required to be implemented by the central logger, we recommend that you also implement \<xref:Microsoft.Build.Framework.INodeLogger*> if you want the central logger to initialize with the number of nodes that are participating in the build. The following overload of the \<xref:Microsoft.Build.Framework.ILogger.Initialize*> method is invoked when the engine initializes the logger:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
### Distributed Logging Model  
 In the central logging model, too much incoming message traffic, such as when many projects build at once, can overwhelm the central node, which stresses the system and lowers build performance.  
  
 To reduce this problem, MSBuild also enables a "distributed logging model" that extends the central logging model by letting you create forwarding loggers. A forwarding logger is attached to a secondary node and receives incoming build events from that node. The forwarding logger is just like a regular logger except that it can filter the events and then forward only the desired ones to the central node. This reduces the message traffic at the central node and therefore enables better performance.  
  
 You can create a forwarding logger by implementing the \<xref:Microsoft.Build.Framework.IForwardingLogger*> interface, which derives from \<xref:Microsoft.Build.Framework.ILogger*>. The interface is defined as:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 To forward events in a forwarding logger, call the \<xref:Microsoft.Build.Framework.IEventRedirector.ForwardEvent*> method of the \<xref:Microsoft.Build.Framework.IEventRedirector*> interface. Pass the appropriate \<xref:Microsoft.Build.Framework.BuildEventArgs*>, or a derivative, as the parameter.  
  
 For more information, see [How to: Create a Forwarding Logger](../vs140/creating-forwarding-loggers.md).  
  
### Attaching a Distributed Logger  
 To attaching a distributed logger on a command line build, use the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> (or, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> for short) switch. The format for specifying the names of the logger types and classes are the same as those for the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> switch, except that a distributed logger is comprised of two logging classes: a forwarding logger and a central logger. Following is an example of attaching a distributed logger:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 An asterisk (*) separates the two logger names in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> switch.  
  
## See Also  
 [How To: Write a Logger](../vs140/build-loggers.md)   
 [How to: Create a Forwarding Logger](../vs140/creating-forwarding-loggers.md)