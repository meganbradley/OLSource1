---
title: "EDITBIN Options"
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
  - "editbin"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "EDITBIN program, options"
ms.assetid: 2da9f88e-cbab-4d64-bb66-ef700535230f
caps.latest.revision: 15
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# EDITBIN Options
You can use EDITBIN to modify object files, executable files, and dynamic-link libraries (DLLs). Options specify the changes that EDITBIN makes.  
  
 An option consists of an option specifier, which is either a dash ( – ) or a forward slash ( / ), followed by the name of the option. Option names cannot be abbreviated. Some options take arguments that are specified after a colon ( : ). No spaces or tabs are allowed within an option specification. Use one or more spaces or tabs to separate option specifications on the command line. Option names and their keyword arguments or file name arguments are not case-sensitive. For example, -bind and /BIND mean the same thing.  
  
 EDITBIN has the following options:  
  
|Option|Purpose|  
|------------|-------------|  
|[/ALLOWBIND](../vs140/-allowbind.md)|Specifies whether a DLL can be bound.|  
|[/ALLOWISOLATION](../vs140/-allowisolation.md)|Specifies DLL or executable file manifest lookup behavior.|  
|[/APPCONTAINER](../vs140/-appcontainer.md)|Specifies whether the app must run within an AppContainer—for example, a [!INCLUDE[win8_appname_long](../vs140/includes/win8_appname_long_md.md)] app.|  
|[/BIND](../vs140/-bind.md)|Sets the addresses for the entry points in the specified objects to speed load time.|  
|[/DYNAMICBASE](../vs140/-dynamicbase.md)|Specifies whether the DLL or executable image can be randomly rebased at load-time by using address space layout randomization (ASLR).|  
|[/ERRORREPORT](../vs140/-errorreport--editbin.exe-.md)|Reports internal errors to Microsoft.|  
|[/HEAP](../vs140/-heap.md)|Sets the size of the executable image’s heap in bytes.|  
|[/HIGHENTROPYVA](../vs140/-highentropyva.md)|Specifies whether the DLL or executable image supports high entropy (64-bit) address space layout randomization (ASLR).|  
|[/INTEGRITYCHECK](../vs140/-integritycheck.md)|Specifies whether to check the digital signature at load time.|  
|[/LARGEADDRESSAWARE](../vs140/-largeaddressaware.md)|Specifies whether the object supports addresses that are larger than two gigabytes.|  
|[/NOLOGO](../vs140/-nologo--editbin-.md)|Suppresses the EDITBIN startup banner.|  
|[/NXCOMPAT](../vs140/-nxcompat.md)|Specifies whether the executable image is compatible with Windows Data Execution Prevention.|  
|[/REBASE](../vs140/-rebase.md)|Sets the base addresses for the specified objects.|  
|[/RELEASE](../vs140/-release.md)|Sets the checksum in the header.|  
|[/SECTION](../vs140/-section--editbin-.md)|Overrides the attributes of a section.|  
|[/STACK](../vs140/-stack.md)|Sets the size of the executable image’s stack in bytes.|  
|[/SUBSYSTEM](../vs140/-subsystem.md)|Specifies the execution environment.|  
|[/SWAPRUN](../vs140/-swaprun.md)|Specifies that the executable image must be copied to the swap file, and then run from there.|  
|[/TSAWARE](../vs140/-tsaware.md)|Specifies that the app is designed to run in a multi-user environment.|  
|[/VERSION](../vs140/-version.md)|Sets the version number in the header.|  
  
## See Also  
 [C/C++ Build Tools](../vs140/c-c---build-tools.md)   
 [EDITBIN Reference](../vs140/editbin-reference.md)