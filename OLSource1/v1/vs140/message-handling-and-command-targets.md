---
title: "Message Handling and Command Targets"
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
  - "command targets"
  - "message handling, active documents"
  - "IOleCommandTarget interface"
  - "command routing, command targets"
ms.assetid: e45ce14c-e6b6-4262-8f3b-4e891e0ec2a3
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Message Handling and Command Targets
The command dispatch interface <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> defines a simple and extensible mechanism to query and execute commands. This mechanism is simpler than Automation's <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> because it relies entirely on a standard set of commands; commands rarely have arguments, and no type information is involved (type safety is diminished for command arguments as well).  
  
 In the command dispatch interface design, each command belongs to a "command group" which is itself identified with a **GUID**. Therefore, anyone can define a new group and define all the commands within that group without any need to coordinate with Microsoft or any other vendor. (This is essentially the same means of definition as a **dispinterface** plus **dispIDs** in Automation. There is overlap here, although this command routing mechanism is only for command routing and not for scripting/programmability on a large scale as Automation handles.)  
  
 <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> handles the following scenarios:  
  
-   When an object is in-place activated, only the object's toolbars are typically displayed and the object's toolbars may have buttons for some of the container commands like **Print**, **Print Preview**, **Save**, <CodeContentPlaceHolder>3\</CodeContentPlaceHolder>, **Zoom**, and others. (In-place activation standards recommend that objects remove such buttons from their toolbars, or at least disable them. This design allows those commands to be enabled and yet routed to the right handler.) Currently, there is no mechanism for the object to dispatch these commands to the container.  
  
-   When an active document is embedded in an active document container (such as Office Binder), the container may need to send commands such **Print**, **Page Setup**, **Properties**, and others to the contained active document.  
  
 This simple command routing could be handled through existing Automation standards and <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. However, the overhead involved with <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> is more than is necessary here, so <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> provides a simpler means to achieve the same ends:  
  
 <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
  
 The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method here tests whether a particular set of commands, the set being identified with a **GUID**, is supported. This call fills an array of **OLECMD** values (structures) with the supported list of commands as well as returning text describing the name of a command and/or status information. When the caller wishes to invoke a command, it can pass the command (and the set **GUID**) to **Exec** along with options and arguments, getting back a return value.  
  
## See Also  
 [Active Document Containers](../vs140/active-document-containers.md)