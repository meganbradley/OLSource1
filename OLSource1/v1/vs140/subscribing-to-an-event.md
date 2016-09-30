---
title: "Subscribing to an Event"
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
  - "running document table (RDT), responding to events"
  - "running document table (RDT), subscribing to events"
ms.assetid: e94a4fea-94df-488e-8560-9538413422bc
caps.latest.revision: 39
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Subscribing to an Event
This walkthrough explains how to create a tool window that responds to events in a running document table (RDT). A tool window hosts a user control that implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents*>. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents*> method connects the interface to the events.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
## Subscribing to RDT Events  
  
#### To create an extension with a tool window  
  
1.  Create a project named **RDTExplorer** using the VSIX template, and add a custom tool window item template named **RDTExplorerWindow**.  
  
     For more information about creating an extension with a tool window, see [Creating an Extension with a Tool Window](../vs140/creating-an-extension-with-a-tool-window.md).  
  
#### To subscribe to RDT events  
  
1.  Open the RDTExplorerWindowControl.xaml file and delete the button named <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. Add a \<xref:System.Windows.Forms.ListBox*> control and accept the default name. The Grid element should look like this:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
2.  Open the RDTExplorerWindow.cs file in code view. Add the following using statements to the start of the file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
3.  Modify the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> class so that, in addition to deriving from the \<xref:Microsoft.VisualStudio.Shell.ToolWindowPane*> class, it implements the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents*> interface.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
4.  Implement \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents*>.  
  
    -   Implement the interface. Place the cursor on the IVsRunningDocTableEvents name. You should see a light bulb in the left margin. Click the Down arrow to the right of the light bulb and select **Implement interface**.  
  
5.  In each method in the interface, replace the line <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> with this:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
6.  Add a cookie field to the RDTExplorerWindow class.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     This holds the cookie that is returned by the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents*> method.  
  
7.  Override the RDTExplorerWindow’s Initialize() method to register for RDT events. You should always get services in the ToolWindowPane’s Initialize() method, not in the constructor.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
     The \<xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable*> service is called to obtain an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable*> interface. The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents*> method connects RDT events to an object that implements \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents*>, in this case, a RDTExplorer object.  
  
8.  Update the RDTExplorerWindow’s Dispose() method.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.UnadviseRunningDocTableEvents*> method deletes the connection between <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and RDT event notification.  
  
9. Add the following line to the body of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents.OnBeforeLastDocumentUnlock*> handler, just before the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> statement.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
10. Add a similar line to the body of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents.OnAfterFirstDocumentLock*> handler and to other events that you want to see in the list box.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
11. Build the project and start debugging. The Visual Studio experimental instance appears.  
  
12. Open the **RDTExplorerWindow** (**View / Other Windows / RDTExplorerWindow**).  
  
     The **RDTExplorerWindow** window opens with an empty event list.  
  
13. Open or create a solution.  
  
     As <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> events are fired, notification of each event appears in the event list.