---
title: "Managing Universal Windows Projects"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 47926aa1-3b41-410d-bca8-f77fc950cbe7
caps.latest.revision: 18
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Managing Universal Windows Projects
Universal Windows apps are apps that target both Windows 8.1 and Windows Phone 8.1, allowing developers to use code and other assets on both platforms. The shared code and resources are kept in a shared project, while the platform-specific code and resources are kept in separate projects, one for Windows and the other for Windows Phone. For more information about universal Windows apps, see [Universal Windows Apps](http://msdn.microsoft.com/library/windows/apps/dn609832.aspx). Visual Studio extensions that manage projects should be aware that universal Windows app projects have a structure that differs from single-platform apps. This walkthrough shows you how to navigate the shared project and manage the shared items.  
  
## Prerequisites  
 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Installing the Visual Studio SDK](../vs140/installing-the-visual-studio-sdk.md).  
  
### Navigate the shared project  
  
1.  Create a C# VSIX project named **TestUniversalProject**. (**File, New, Project** and then **C#, Extensibility, Visual Studio Package**). Add a **Custom Command** project item template (on the Solution Explorer, right-click the project node and select **Add / New Item**, then go to **Extensibility**). Name the file **TestUniversalProject**.  
  
2.  Add a reference to Microsoft.VisualStudio.Shell.Interop.12.1.DesignTime.dll and Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime.dll (in the **Extensions** section).  
  
3.  Open TestUniversalProject.cs and add the following <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
4.  In the TestUniversalProject class add a private field pointing to the **Output** window.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
5.  Set the reference to the output pane inside TestUniversalProject constructor:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
6.  Remove the existing code from the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
7.  Get the DTE object, which we will use for several different purposes in this walkthrough. Also, make sure that a solution is loaded when the menu button is clicked.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
8.  Find the shared project. The shared project is a pure container; it does not build or produce outputs. The following method finds the first shared project in the solution by looking for the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> object that has the shared project capability.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
9. In the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> method, output the caption (the project name that appears in the **Solution Explorer**) of the shared project.  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
10. Get the active platform project. Platform projects are the projects that contain platform-specific code and resources. The following method uses the new field \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID7.VSHPROPID_SharedItemContextHierarchy*> to get the active platform project.  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
11. In the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> method, output the caption of the active platform project.  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
12. Iterate through the platform projects. The following method gets all the importing (platform) projects from the shared project.  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
    > [!IMPORTANT]
    >  If the user has opened a C++ universal Windows app project in the experimental instance, the code above throws an exception. This is a known issue. To avoid the exception, replace the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> block above with the following:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
13. In the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> method, output the caption of each platform project. Insert the following code after the line that outputs the caption of the active platform project. Only the platform projects that are loaded appear in this list.  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
14. Change the active platform project. The following method sets the active project using \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.SetProperty*>.  
  
<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>  
15. In the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> method, change the active platform project. Insert this code inside the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>  
16. Now try it out. Press F5 to launch the experimental instance. Create a C# universal hub app project in the experimental instance (in the **New Project** dialog box, **Visual C# / Windows / Windows 8 / Universal / Hub App**). After the solution is loaded, go to the **Tools** menu and click **Invoke TestUniversalProject**, and then check the text in the **Output** pane. You should see something like the following:  
  
<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>  
### Manage the shared items in the platform project  
  
1.  Find the shared items in the platform project. The items in the shared project appear in the platform project as shared items. You can’t see them in the **Solution Explorer**, but you can walk the project hierarchy to find them. The following method walks the hierarchy and collects all the shared items. It optionally outputs the caption of each item,. The shared items are identified by the new property \<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID7.VSHPROPID_IsSharedItem*>.  
  
<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
2.  In the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method, add the following code to walk the platform project hierarchy items. Insert it inside the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> block.  
  
<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>  
3.  Read the shared items. The shared items appear in the platform project as hidden linked files, and you can read all the properties as ordinary linked files. The following code reads the full path of the first shared item.  
  
<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>  
4.  Now try it out. Press F5 to launch the experimental instance. Create a C# universal hub app project in the experimental instance (in the **New Project** dialog box, **Visual C# / Windows / Windows 8 / Universal / Hub App**) go to the **Tools** menu and click **Invoke TestUniversalProject**, and then check the text in the **Output** pane. You should see something like the following:  
  
<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
### Detecting changes in platform projects and shared projects  
  
1.  You can use hierarchy and project events to detect changes in shared projects, just as you can for platform projects. However, the project items in the shared project are not visible, which means that certain events do not fire when shared project items are changed.  
  
     Consider the sequence of events when a file in a project is renamed:  
  
    1.  The file name is changed on disk.  
  
    2.  The project file is updated to include the new name of the file.  
  
     Hierarchy events (for example, \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents*>) generally track the changes displayed in the UI, as in the **Solution Explorer**. Hierarchy events consider a file rename operation to consist of a file deletion and then a file addition. However, when invisible items are changed, the hierarchy event system fires an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted*> event but not an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded*> event. Therefore, if you rename a file in a platform project, you get both \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded*>, but if you rename a file in a shared project, you get only \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted*>.  
  
     To track changes in project items, you can handle DTE project item events (the ones found in \<xref:EnvDTE.ProjectItemsEventsClass*>). However, if you are handling large numbers of events, you can get better performance handling the events in \<xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2*>. In this walkthrough we show only the hierarchy events and the DTE events. In this procedure you add an event listener to a shared project and a platform project. Then, when you rename one file in a shared project and another file in a platform project, you can see the events that are fired for each rename operation.  
  
     In this procedure you add an event listener to a shared project and a platform project. Then, when you rename one file in a shared project and another file in a platform project, you can see the events that are fired for each rename operation.  
  
2.  Add an event listener. Add a new class file to the project and call it HierarchyEventListener.cs.  
  
3.  Open the HierarchyEventListener.cs file and add the following using statements:  
  
<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>  
4.  Have the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> class implement \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents*>:  
  
<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>  
5.  Implement the members of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents*>, as in the code below.  
  
<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>  
6.  In the same class add another event handler for the DTE event \<xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed*>, which occurs whenever a project item is renamed.  
  
<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>  
7.  Sign up for the hierarchy events. You need to sign up separately for every project you are tracking. Add the following code in <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, one for the shared project, and the other for one of the platform projects.  
  
<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
8.  Sign up for the DTE project item event \<xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed*>. Add the following code after you hook up the second listener.  
  
<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>  
9. Modify the shared item. You can’t modify shared items in a platform project; instead, you must modify them in the shared project that is the actual owner of these items. You can get the corresponding item ID in the shared project with \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.IsDocumentInProject*>, giving it the shared item’s full path. Then you can modify the shared item. The change is propagated to the platform projects.  
  
    > [!IMPORTANT]
    >  You should find out whether or not a project item is a shared item before modifying it.  
  
     The following method modifies the name of a project item file.  
  
<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
10. Call this method after all the other code in <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> to modify the file name the item in the shared project. Insert this after the code that gets the full path of the item in the shared project.  
  
<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
11. Build and run the project. Create a C# universal hub app in the experimental instance, go to the **Tools** menu and click **Invoke TestUniversalProject**, and check the text in the general output pane. The name of the first item in the shared project (we expect it to be the App.xaml file) should be changed, and you should see that the \<xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed*> event has fired. In this case, since renaming App.xaml causes App.xaml.cs to be renamed as well, you should see four events (two for each platform project). (DTE events do not track the items in the shared project.) You should see two \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted*> events (one for each of platform projects), but no \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded*> events.  
  
12. Now try renaming a file in a platform project, and you can see the difference in the events that get fired. Add the following code in <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> after the call to <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>.  
  
<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>  
13. Build and run the project. Create a C# Universal Project in the experimental instance, go to the **Tools** menu and click **Invoke TestUniversalProject**, and check the text in the general output pane. After the file in the platform project is renamed, you should see both an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded*> event and an \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted*> event. Since changing the file caused no other files to be changed, and since changes to items in a platform project don't get propagated anywhere, there is only one each of these events.