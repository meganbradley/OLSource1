---
title: "TN071: MFC IOleCommandTarget Implementation"
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
  - "IOleCommandTarget"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "TN071"
  - "IOleCommandTarget interface"
ms.assetid: 3eef571e-6357-444d-adbb-6f734a0c3161
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# TN071: MFC IOleCommandTarget Implementation
> [!NOTE]
>  The following technical note has not been updated since it was first included in the online documentation. As a result, some procedures and topics might be out of date or incorrect. For the latest information, it is recommended that you search for the topic of interest in the online documentation index.  
  
 The <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> interface enables objects and their containers to dispatch commands to each other. For example, an object's toolbars may contain buttons for commands such as **Print**, **Print Preview**, **Save**, <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>, and **Zoom**. If such an object were embedded in a container that supports <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, the object could enable its buttons and forward the commands to the container for processing when the user clicked them. If a container wanted the embedded object to print itself, it could make this request by sending a command through the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> interface of the embedded object.  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> is an Automation-like interface in that it is used by a client to invoke methods on a server. However, using <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> saves the overhead of making calls via Automation interfaces because programmers don't have to use the typically expensive <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> method of <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 In MFC, the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> interface is used by Active document servers to allow Active document containers to dispatch commands to the server. The Active document server class, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, uses MFC interface maps (see [TN038: MFC/OLE IUnknown Implementation](../vs140/tn038--mfc-ole-iunknown-implementation.md)) to implement the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> interface.  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is also implemented in the **COleFrameHook** class. **COleFrameHook** is an undocumented MFC class that implements the frame window functionality of in-place editing containers. **COleFrameHook** also uses MFC interface maps to implement the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> interface. **COleFrameHook**'s implementation of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> forwards OLE commands to <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>-derived Active document containers. This allows any MFC Active document container to receive messages from contained Active document servers.  
  
## MFC OLE Command Maps  
 MFC developers can take advantage of <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> by using MFC OLE command maps. OLE command maps are like message maps because they can be used to map OLE commands to member functions of the class that contains the command map. To make this work, place macros in the command map to specify the OLE command group of the command you want to handle, the OLE command, and the command ID of the [WM_COMMAND](http://msdn.microsoft.com/library/windows/desktop/ms647591) message that will be sent when the OLE command is received. MFC also provides a number of predefined macros for standard OLE commands. For a list of the standard OLE commands that were originally designed for use with Microsoft Office applications, see the OLECMDID enumeration, which is defined in docobj.h.  
  
 When an OLE command is received by an MFC application that contains an OLE command map, MFC tries to find the command ID and command group for the requested command in the OLE command map of the application. If a match is found, a **WM_COMMAND** message is dispatched to the application containing the command map with the ID of the requested command. (See the description of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> below.) In this way, OLE commands dispatched to an application are turned into **WM_COMMAND** messages by MFC. The **WM_COMMAND** messages are then routed through the application's message maps using the MFC standard [command routing](../vs140/command-routing.md) architecture.  
  
 Unlike message maps, MFC OLE command maps are not supported by ClassWizard. MFC developers must add OLE command map support and OLE command map entries by hand. OLE command maps can be added to MFC Active document servers in any class that is in the **WM_COMMAND** message-routing chain at the time the Active document is in-place active in a container. These classes include the application's classes derived from [CWinApp](../vs140/cwinapp-class.md), [CView](../vs140/cview-class.md), [CDocument](../vs140/cdocument-class.md), and [COleIPFrameWnd](../vs140/coleipframewnd-class.md). In Active document containers, OLE command maps can only be added to the [COleDocObjectItem](../vs140/coledocobjectitem-class.md)-derived class. Also, in Active document containers, the **WM_COMMAND** messages will only be dispatched to the message map in the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>-derived class.  
  
## OLE Command Map Macros  
 Use the following macros to add command map functionality to your class:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 This macro goes in the class declaration (typically in the header file) of the class that contains the command map.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
 Name of the class that contains the command map.  
  
 <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
 Name of the base class of the class that contains the command map.  
  
 This macro marks the beginning of the command map. Use this macro in the implementation file for the class that contains the command map.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 This macro marks the end of the command map. Use this macro in the implementation file for the class that contains the command map. This macro must always follow the **BEGIN_OLECMD_MAP** macro.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
 Pointer to the GUID of the OLE command's command group. This parameter is **NULL** for the standard OLE command group.  
  
 *olecmdid*  
 OLE command ID of the command to be invoked.  
  
 <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>  
 ID of the **WM_COMMAND** message to be sent to the application containing the command map when this OLE command is invoked.  
  
 Use the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> macro in the command map to add entries for the OLE commands you want to handle. When the OLE commands are received, they will be converted to the specified **WM_COMMAND** message and routed through the application's message map using the standard MFC command-routing architecture.  
  
## Example  
 The following example shows how to add OLE command-handling capability to an MFC Active document server to handle the [OLECMDID_PRINT](http://msdn.microsoft.com/library/windows/desktop/ms691264) OLE command. This example assumes that you used AppWizard to generate an MFC application that is an Active document server.  
  
1.  In your <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>-derived class's header file, add the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> macro to the class declaration.  
  
    > [!NOTE]
    >  Use the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>-derived class because it is one of the classes in the Active document server that is in the **WM_COMMAND** message-routing chain.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  In the implementation file for the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>-derived class, add the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> macros:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  To handle the standard OLE print command, add an [ON_OLECMD](../vs140/on_olecmd.md) macro to the command map specifying the OLE command ID for the standard print command and **ID_FILE_PRINT** for the **WM_COMMAND** ID. **ID_FILE_PRINT** is the standard print command ID used by AppWizard-generated MFC applications:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
 Note that one of the standard OLE command macros, defined in afxdocob.h, could be used in place of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> macro because **OLECMDID_PRINT** is a standard OLE command ID. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> macro will accomplish the same task as the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> macro shown above.  
  
 When a container application sends this server an **OLECMDID_PRINT** command through the server's <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> interface, the MFC printing command handler will be invoked in the server, causing the server to print the application. The Active document container's code to invoke the print command added in the steps above would look something like this:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
## See Also  
 [Technical Notes by Number](../vs140/technical-notes-by-number.md)   
 [Technical Notes by Category](../vs140/technical-notes-by-category.md)