---
title: "Objects (Visual Basic)"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-visual-basic
ms.tgt_pltfrm: na
ms.topic: article
dev_langs: 
  - VB
helpviewer_keywords: 
  - objects [Visual Basic]
ms.assetid: 651c73e4-dca8-402b-9c6b-e3902b3a3f4b
caps.latest.revision: 26
translation.priority.ht: 
  - de-de
  - ja-jp
---
# Objects (Visual Basic)
This topic provides links to other topics that document the Visual Basic run-time objects and contain tables of their member procedures, properties, and events.  
  
## Visual Basic Run-time Objects  
  
|||  
|-|-|  
|<xref:Microsoft.VisualBasic.Collection?qualifyHint=False>|Provides a convenient way to see a related group of items as a single object.|  
|<xref:Microsoft.VisualBasic.Information.Err?qualifyHint=False>|Contains information about run-time errors.|  
|The `My.Application` object consists of the following classes:<br /><br /> <xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase?qualifyHint=False> provides members that are available in all projects.<br /><br /> <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase?qualifyHint=False> provides members available in Windows Forms applications.<br /><br /> <xref:Microsoft.VisualBasic.ApplicationServices.ConsoleApplicationBase?qualifyHint=False> provides members available in console applications.|Provides data that is associated only with the current application or DLL. No system-level information can be altered with `My.Application`.<br /><br /> Some members are available only for Windows Forms or console applications.|  
|`My.Application.Info` (<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase.Info?qualifyHint=False>)|Provides properties for getting the information about an application, such as the version number, description, loaded assemblies, and so on.|  
|`My.Application.Log` (<xref:Microsoft.VisualBasic.ApplicationServices.ApplicationBase.Log?qualifyHint=False>)|Provides a property and methods to write event and exception information to the application's log listeners.|  
|`My.Computer` (<xref:Microsoft.VisualBasic.Devices.Computer?qualifyHint=False>)|Provides properties for manipulating computer components such as audio, the clock, the keyboard, the file system, and so on.|  
|`My.Computer.Audio` (<xref:Microsoft.VisualBasic.Devices.Audio?qualifyHint=False>)|Provides methods for playing sounds.|  
|`My.Computer.Clipboard` (<xref:Microsoft.VisualBasic.Devices.Computer.Clipboard?qualifyHint=False>)|Provides methods for manipulating the Clipboard.|  
|`My.Computer.Clock` (<xref:Microsoft.VisualBasic.Devices.Clock?qualifyHint=False>)|Provides properties for accessing the current local time and Universal Coordinated Time (equivalent to Greenwich Mean Time) from the system clock.|  
|`My.Computer.FileSystem` (<xref:Microsoft.VisualBasic.FileIO.FileSystem?qualifyHint=False>)|Provides properties and methods for working with drives, files, and directories.|  
|`My.Computer.FileSystem.SpecialDirectories` (<xref:Microsoft.VisualBasic.FileIO.SpecialDirectories?qualifyHint=False>)|Provides properties for accessing commonly referenced directories.|  
|`My.Computer.Info` (<xref:Microsoft.VisualBasic.Devices.ComputerInfo?qualifyHint=False>)|Provides properties for getting information about the computer's memory, loaded assemblies, name, and operating system.|  
|`My.Computer.Keyboard` (<xref:Microsoft.VisualBasic.Devices.Keyboard?qualifyHint=False>)|Provides properties for accessing the current state of the keyboard, such as what keys are currently pressed, and provides a method to send keystrokes to the active window.|  
|`My.Computer.Mouse` (<xref:Microsoft.VisualBasic.Devices.Mouse?qualifyHint=False>)|Provides properties for getting information about the format and configuration of the mouse that is installed on the local computer.|  
|`My.Computer.Network` (<xref:Microsoft.VisualBasic.Devices.Network?qualifyHint=False>)|Provides a property, an event, and methods for interacting with the network to which the computer is connected.|  
|`My.Computer.Ports` (<xref:Microsoft.VisualBasic.Devices.Ports?qualifyHint=False>)|Provides a property and a method for accessing the computer's serial ports.|  
|`My.Computer.Registry` (<xref:Microsoft.VisualBasic.MyServices.RegistryProxy?qualifyHint=False>)|Provides properties and methods for manipulating the registry.|  
|[My.Forms Object](../vs140/my.forms-object.md)|Provides properties for accessing an instance of each Windows Form declared in the current project.|  
|`My.Log` (<xref:Microsoft.VisualBasic.Logging.AspLog?qualifyHint=False>)|Provides a property and methods for writing event and exception information to the application's log listeners for Web applications.|  
|[My.Request Object](../vs140/my.request-object.md)|Gets the <xref:System.Web.HttpRequest?qualifyHint=False> object for the requested page. The `My.Request` object contains information about the current HTTP request.<br /><br /> The `My.Request` object is available only for [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] applications.|  
|[My.Resources Object](../vs140/my.resources-object.md)|Provides properties and classes for accessing an application's resources.|  
|[My.Response Object](../vs140/my.response-object.md)|Gets the <xref:System.Web.HttpResponse?qualifyHint=False> object that is associated with the <xref:System.Web.UI.Page?qualifyHint=False>. This object allows you to send HTTP response data to a client and contains information about that response.<br /><br /> The `My.Response` object is available only for [!INCLUDE[vstecasp](../vs140/includes/vstecasp_md.md)] applications.|  
|[My.Settings Object](../vs140/my.settings-object.md)|Provides properties and methods for accessing an application's settings.|  
|`My.User` (<xref:Microsoft.VisualBasic.ApplicationServices.User?qualifyHint=False>)|Provides access to information about the current user.|  
|[My.WebServices Object](../vs140/my.webservices-object.md)|Provides properties for creating and accessing a single instance of each Web service that is referenced by the current project.|  
|<xref:Microsoft.VisualBasic.FileIO.TextFieldParser?qualifyHint=False>|Provides methods and properties for parsing structured text files.|  
  
## See Also  
 [Visual Basic Language Reference](../vs140/visual-basic-language-reference.md)   
 [Visual Basic](../vs140/visual-basic.md)