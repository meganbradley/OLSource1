---
title: "VsgDbg Class"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 6722263c-ccef-40c7-a0ae-87a863fbab00
caps.latest.revision: 9
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# VsgDbg Class
Represents an interface for programmatic control of the in-app component of graphics diagnostics.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Members  
 The <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> class supports the following members.  
  
### Public Constructors  
  
|Name|Description|  
|----------|-----------------|  
|[VsgDbg (Constructor)](../vs140/vsgdbg--vsgdbg--constructor-.md)|Constructs an instance of the <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> class and optionally prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[~VsgDbg (Destructor)](../vs140/vsgdbg--~vsgdbg--destructor-.md)|Destroys an instance of the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class.|  
  
### Public Methods  
  
|Name|Description|  
|----------|-----------------|  
|[AddMessage](../vs140/addmessage.md)|Adds a custom message to the graphics diagnostics HUD (Head-Up Display).|  
|[BeginCapture](../vs140/begincapture.md)|Begins a capture interval that will end with <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>.|  
|[CaptureCurrentFrame](../vs140/capturecurrentframe.md)|Captures the remainder of the current frame to the graphics log file.|  
|[Copy (Programmatic Capture)](../vs140/copy--programmatic-capture-.md)|Copies the contents of the active graphics log (.vsglog) file into a new file.|  
|[EndCapture](../vs140/endcapture.md)|Ends a capture interval that was started with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>.|  
|[Init](../vs140/init.md)|Prepares the in-app component of graphics diagnostics to actively capture and record graphics information.|  
|[ToggleHUD](../vs140/togglehud.md)|Toggles the graphics diagnostics HUD overlay on or off.|  
|[UnInit](../vs140/uninit.md)|Finalizes the graphics log file, closes it, and frees resources that were used while the app was actively recording graphics information.|  
  
## Remarks  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> class represents an interface that you can use to control graphics diagnostics features programmatically. You can use some features even when you're not actively capturing and recording graphics information; this includes the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> member function and <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> member function. The other member functions either prepare the in-app component of graphics diagnostics to start or stop the active capture of graphics information, or must be called while the app is actively capturing and recording graphics information to a graphics log file.