---
title: "OLE in MFC"
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
  - "MFC [C++], OLE and"
  - "OLE items"
  - "OLE applications [C++], about OLE"
  - "OLE [C++]"
  - "OLE containers, about OLE"
  - "applications [OLE], about OLE"
  - "OLE component object model (COM)"
ms.assetid: 5193479d-1239-4697-aea4-e82f92c707ab
caps.latest.revision: 13
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# OLE in MFC
These articles explain the fundamentals of OLE programming using MFC. MFC provides the easiest way to write programs that use OLE:  
  
-   To use OLE visual editing (in-place activation).  
  
-   To work as OLE containers or servers.  
  
-   To implement drag-and-drop functionality.  
  
-   To work with date and time data.  
  
-   To manage the state data of MFC modules, including exported DLL function entry points, OLE/COM interface entry points, and window procedure entry points.  
  
 You can also use [Automation](../vs140/automation.md) or [Remote Automation](../vs140/remote-automation.md) to operate another program from your program.  
  
> [!NOTE]
>  The term OLE denotes the technologies associated with linking and embedding, including OLE containers, OLE servers, OLE items, in-place activation (or visual editing), trackers, drag and drop, and menu merging. The term Active applies to the Component Object Model (COM) and COM-based objects such as ActiveX controls. OLE Automation is now called Automation.  
  
## In This Section  
 [OLE Background](../vs140/ole-background.md)  
 Discusses OLE and provides conceptual information about how it works.  
  
 [Activation](../vs140/activation--c---.md)  
 Describes the role of activation in editing OLE items.  
  
 [Containers](../vs140/containers.md)  
 Provides links to using containers in OLE.  
  
 [Data Objects and Data Sources](../vs140/data-objects-and-data-sources--ole-.md)  
 Provides links to topics discussing the use of the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> classes.  
  
 [Drag and Drop](../vs140/drag-and-drop--ole-.md)  
 Discusses using copying and pasting with OLE.  
  
 [OLE Menus and Resources](../vs140/menus-and-resources--ole-.md)  
 Explains the use of menus and resources in MFC OLE document applications.  
  
 [Registration](../vs140/registration.md)  
 Discusses server installation and initialization.  
  
 [Servers](../vs140/servers.md)  
 Describes how to create OLE items (or components) for use by container applications.  
  
 [Trackers](../vs140/trackers.md)  
 Provides information about the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class, which provides a graphical interface to enable users to interact with OLE client items.  
  
## Related Sections  
 [Connection Points](../vs140/connection-points.md)  
 Explains how to implement connection points (formerly known as OLE connection points) using the MFC classes <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.  
  
 [Container/Server COM Components](../vs140/containers--advanced-features.md)  
 Describes the steps necessary to incorporate optional advanced features into existing container applications.  
  
 [The Component Object Model](http://msdn.microsoft.com/library/windows/desktop/ms694363)  
 Describes using OLE without MFC.  
  
## See Also  
 [MFC](../vs140/mfc-concepts.md)