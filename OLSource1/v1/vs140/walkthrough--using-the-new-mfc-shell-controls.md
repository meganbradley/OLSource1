---
title: "Walkthrough: Using the New MFC Shell Controls"
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
  - "shell controls (MFC)"
ms.assetid: f0015caa-199d-4aaf-9501-5a239fce9095
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Walkthrough: Using the New MFC Shell Controls
In this walkthrough, you will create an application that resembles File Explorer. You will create a window that contains two panes. The left pane will contain a [CMFCShellTreeCtrl](../vs140/cmfcshelltreectrl-class.md) object that displays your Desktop in a hierarchical view. The right pane will contain a [CMFCShellListCtrl](../vs140/cmfcshelllistctrl-class.md) that shows the files in the folder that is selected in the left pane.  
  
## Prerequisites  
 This walkthrough assumes that you have set up [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to use **General Development Settings**. If you are using a different development setting, some [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] windows that we use in this walkthrough might not be displayed by default.  
  
### To create a new MFC application by using the MFC Application Wizard  
  
1.  Use the **MFC Application Wizard** to create a new MFC application. To run the wizard, from the **File** menu select **New**, and then select **Project**. The **New Project** dialog box will be displayed.  
  
2.  In the **New Project** dialog box, expand the **Visual C++** node in the **Project types** pane and select **MFC**. Then, in the **Templates** pane, select **MFC Application**. Type a name for the project, such as <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> and click **OK**. The **MFC Application Wizard** will be displayed.  
  
3.  In the **MFC Application Wizard** dialog box, click **Next**. The **Application Type** pane will be displayed.  
  
4.  On the **Application Type** pane, under **Application type**, clear the **Tabbed documents** option. Next, select **Single document** and select **Document/View architecture support**. Under **Project style**, select **Visual Studio**, and from the **Visual style and colors** drop down list select **Office 2007 (Blue theme)**. Leave all other options as they are. Click **Next** to display the **Compound Document Support** pane.  
  
5.  On the **Compound Document Support** pane, select **None**. Click **Next** to display the **Document Template Strings** pane.  
  
6.  Do not make any changes to the **Document Template Strings** pane. Click **Next** to display the **Database Support** pane.  
  
7.  On the **Database Support** pane, select **None** because this application does not use a database. Click **Next** to display the **User Interface Features** pane.  
  
8.  On the **User Interface Features** pane, make sure that the **Use a menu bar and toolbar** option is selected. Leave all other options as they are. Click **Next** to display the **Advanced Features** pane.  
  
9. On the **Advanced Features** pane, under **Advanced features**, select only **ActiveX controls** and **Common Control Manifest**. Under **Advanced frame panes**, select only the **Navigation pane** option. This will cause the wizard to create the pane to the left of the window with a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> already embedded. Click **Next** to display the **Generated Classes** pane.  
  
10. We are not going to make any changes to the **Generated Classes** pane. Therefore, click **Finish** to create your new MFC project.  
  
11. Verify that the application was created successfully by building and running it. To build the application, from the **Build** menu select **Build Solution**. If the application builds successfully, run the application by selecting **Start Debugging** from the **Debug** menu.  
  
     The wizard automatically creates an application that has a standard menu bar, a standard toolbar, a standard status bar, and an Outlook bar to the left of the window with a **Folders** view and a **Calendar** view.  
  
### To add the shell list control to the document view  
  
1.  In this section, you will add an instance of <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> to the view that the wizard created. Open the view header file by double-clicking MFCShellControlsView.h in the **Solution Explorer**.  
  
     Locate the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> directive near the top of the header file. Immediately underneath it add this code to include the header file for <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     Now add a member variable of type <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. First, locate the following comment in the header file:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     Immediately above that comment add this code:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  The **MFC Application Wizard** already created a <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> object in the <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> class, but it is a protected member. We will access this object later. Therefore, create an accessor for it now. Open the MainFrm.h header file by double-clicking it in the **Solution Explorer**. Locate the following comment:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
     Immediately under it, add the following method declaration:  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
     Next, open the MainFrm.cpp source file by double-clicking it in the **Solution Explorer**. At the bottom of that file, add the following method definition:  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
3.  Now we update the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> class to handle the **WM_CREATE** windows message. Open the MFCShellControlsView.h header file and click on this line of code:  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
     Next, in the **Properties** window, click the **Messages** icon. Scroll down until you find the **WM_CREATE** message. From the drop down list next to **WM_CREATE**, select **\<Add> OnCreate**. This creates a message handler for us and automatically updates the MFC message map.  
  
     In the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method we will now create our <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> object. Find the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> method definition in the MFCShellControlsView.cpp source file, and replace its implementation with the following code:  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
4.  Repeat the previous step but for the **WM_SIZE** message. This will cause your applications view to be redrawn whenever a user changes the size of the application window. Replace the definition for the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> method with the following code:  
  
<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>  
5.  The last step is to connect the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> objects by using the [CMFCShellTreeCtrl::SetRelatedList](../vs140/cmfcshelltreectrl--setrelatedlist.md) method. After you call this method, the <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will automatically display the contents of the item selected in the <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>. We will do this in the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> method, which is overridden from [CView::OnActivateView](../vs140/cview--onactivateview.md).  
  
     In the MFCShellControlsView.h header file, inside the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> class declaration, add the following method declaration:  
  
<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>  
     Next, add the definition for this method to the MFCShellControlsView.cpp source file:  
  
<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>  
     Because we are calling methods from the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> class, we must add an <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> directive at the top of the MFCShellControlsView.cpp source file:  
  
<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>  
6.  Verify that the application was created successfully by building and running it. To build the application, from the **Build** menu select **Build Solution**. If the application builds successfully, run it by selecting **Start Debugging** from the **Debug** menu.  
  
     You should now see the details for the item selected in the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> in the view pane. When you click a node in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> will be automatically updated. Likewise, if you double-click a folder in the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> should be automatically updated.  
  
     Right click any item in the tree control or in the list control. Note that you get the same context menu as if you were using the real File Explorer.  
  
## Next Steps  
  
-   The wizard created an Outlook bar with both a **Folders** pane and a **Calendar** pane. It probably does not make sense to have a **Calendar** pane in an Explorer window. Therefore, remove that pane now.  
  
-   The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> supports viewing files in different modes, such as **Large Icons**, **Small Icons**, **List**, and **Details**. Update your application to implement this functionality. Hint: see [Explorer Sample: MFC Windows Explorer Application](../vs140/visual-c---samples.md).  
  
## See Also  
 [Walkthroughs (MFC Feature Pack)](../vs140/walkthroughs--mfc-.md)