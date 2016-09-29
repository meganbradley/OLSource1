---
title: "Windows Forms Application Basics (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "Windows applications"
  - "Windows Forms, Visual Basic"
ms.assetid: 0b919d30-7fd6-42db-85c8-543d15312441
caps.latest.revision: 24
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Windows Forms Application Basics (Visual Basic)
An important part of [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] is the ability to create Windows Forms applications that run locally on users' computers. You can use Visual Studio to create the application and user interface using Windows Forms. A Windows Forms application is built on classes from the <xref:System.Windows.Forms*> namespace.  
  
## Designing Windows Forms Applications  
 You can create Windows Forms and Windows service applications with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]. For more information, see the following topics:  
  
-   [Getting Started with Windows Forms](assetId:///a031aa58-5027-4082-b590-df7c12c77dec). Provides information on how to create and program Windows Forms.  
  
-   [Windows Forms Walkthroughs](assetId:///fd44d13d-4733-416f-aefc-32592e59e5d9). Lists topics that provide a step-by-step development of commonly created Windows Forms applications based on Windows Forms.  
  
-   [Windows Forms Controls](assetId:///f050de8f-4ebd-4042-94b8-edf9a1dbd52a). Collection of topics detailing the use of Windows Forms controls.  
  
-   [Windows Service Applications](assetId:///ba72d648-9553-4849-b829-069ad5ea014b). Lists topics that explain how to create Windows services.  
  
## Building Rich, Interactive User Interfaces  
 Windows Forms is the smart-client component of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], a set of managed libraries that enable common application tasks such as reading and writing to the file system. Using a development environment like [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], you can create Windows Forms applications that display information, request input from users, and communicate with remote computers over a network.  
  
 In Windows Forms, a form is a visual surface on which you display information to the user. You commonly build Windows Forms applications by placing controls on forms and developing responses to user actions, such as mouse clicks or key presses. A *control* is a discrete user interface (UI) element that displays data or accepts data input.  
  
### Events  
 When a user does something to your form or one of its controls, it generates an event. Your application reacts to these events by using code, and processes the events when they occur. For more information, see [Event Handling in Windows Forms](assetId:///6514e530-c6b8-489c-a8d2-eda7b7072701).  
  
### Controls  
 Windows Forms contains a variety of controls that you can place on forms: controls that display text boxes, buttons, drop-down boxes, radio buttons, and even Web pages. For a list of all the controls you can use on a form, see [Controls to Use on Windows Forms](assetId:///dec51976-eae0-4398-a537-20bca7974722). If an existing control does not meet your needs, Windows Forms also supports creating your own custom controls using the <xref:System.Windows.Forms.UserControl*> class.  
  
 Windows Forms has rich UI controls that emulate features in high-end applications like Microsoft Office. Using the <xref:System.Windows.Forms.ToolStrip*> and <xref:System.Windows.Forms.MenuStrip*> control, you can create toolbars and menus that contain text and images, display submenus, and host other controls such as text boxes and combo boxes.  
  
 With the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] drag-and-drop forms designer, you can easily create Windows Forms applications: just select the controls with your cursor and place them where you want on the form. The designer provides tools such as grid lines and "snap lines" to take the hassle out of aligning controls. And whether you use [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] or compile at the command line, you can use the <xref:System.Windows.Forms.FlowLayoutPanel*>, <xref:System.Windows.Forms.TableLayoutPanel*> and <xref:System.Windows.Forms.SplitContainer*> controls to create advanced form layouts with minimal time and effort.  
  
### Custom UI Elements  
 Finally, if you must create your own custom UI elements, the <xref:System.Drawing*> namespace contains all of the classes you need to render lines, circles, and other shapes directly on a form.  
  
 For step-by-step information about using these features, see the following Help topics.  
  
|To|See|  
|--------|---------|  
|Create a new Windows Forms application with [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)]|[Walkthrough: Creating a Simple Windows Form](assetId:///2d9daec0-0543-41d0-acb1-964f685bddbb)|  
|Use controls on forms|[How to: Add Controls to Windows Forms](assetId:///2af86001-9d62-4154-87fb-66db2c3cd9fd)|  
|Handle events from a form and its controls|[How to: Create Event Handlers Using the Designer](assetId:///8461e9b8-14e8-406f-936e-3726732b23d2)|  
|Use the <xref:System.Windows.Forms.ToolStrip*> Control|[How to: Create a Basic ToolStrip with Standard Items in Windows Forms](assetId:///028deb1a-acf8-4911-979a-ba8431cd9d82)|  
|Create graphics with <xref:System.Drawing*>|[Getting Started with Graphics Programming](assetId:///eb0f6d6f-9e52-4167-9592-ff4b82fb5869)|  
|Create custom controls|[How to: Inherit from the UserControl Class](assetId:///67713625-e2e4-4f6a-bce7-0855ee5043d9)|  
  
## Displaying and Manipulating Data  
 Many applications must display data from a database, XML file, XML Web service, or other data source. Windows Forms provides a flexible control called the <xref:System.Windows.Forms.DataGridView*> control for rendering such tabular data in a traditional row and column format, so that every piece of data occupies its own cell. Using <xref:System.Windows.Forms.DataGridView*> you can customize the appearance of individual cells, lock arbitrary rows and columns in place, and display complex controls inside cells, among other features.  
  
 Connecting to data sources over a network is a simple task with Windows Forms smart clients. The <xref:System.Windows.Forms.BindingSource*> component, new with Windows Forms in [!INCLUDE[vsprvslong](../vs140/includes/vsprvslong_md.md)] and the [!INCLUDE[dnprdnlong](../vs140/includes/dnprdnlong_md.md)], represents a connection to a data source, and exposes methods for binding data to controls, navigating to the previous and next records, editing records, and saving changes back to the original source. The <xref:System.Windows.Forms.BindingNavigator*> control provides a simple interface over the <xref:System.Windows.Forms.BindingSource*> component for users to navigate between records.  
  
### Data-Bound Controls  
 You can create data-bound controls easily using the Data Sources window, which displays data sources such as databases, Web services, and objects in your project. You can create data-bound controls by dragging items from this window onto forms in your project. You can also data-bind existing controls to data by dragging objects from the Data Sources window onto existing controls.  
  
### Settings  
 Another type of data binding you can manage in Windows Forms is settings. Most smart-client applications must retain some information about their run-time state, such as the last-known size of forms, and retain user-preference data, such as default locations for saved files. The application-settings feature addresses these requirements by providing an easy way to store both types of settings on the client computer. Once defined using either [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] or a code editor, these settings are persisted as XML and automatically read back into memory at run time.  
  
 For step-by-step information about using these features, see the following Help topics.  
  
|To|See|  
|--------|---------|  
|Use the <xref:System.Windows.Forms.BindingSource*> component|[How to: Bind Windows Forms Controls With the BindingSource Component Using the Designer](assetId:///391ae170-de5c-40f8-8233-91cb2ee4683a)|  
|Work with [!INCLUDE[vstecado](../vs140/includes/vstecado_md.md)] data sources|[How to: Sort and Filter ADO.NET Data with the Windows Forms BindingSource Component](assetId:///6c206daf-d706-4602-9dbe-435343052063)|  
|Use the Data Sources window|[Walkthrough: Displaying Data on a Windows Form](assetId:///f6e08c2c-c792-43de-adf3-3e52c0100225)|  
|Use application settings|[How to: Create Application Settings Using the Designer](assetId:///53b3af80-1c02-4e35-99c6-787663148945)|  
  
## Deploying Applications to Client Computers  
 Once you have written your application, you must send it to your users so that they can install and run it on their own client computers. Using the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] technology, you can deploy your applications from within [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] by using just a few clicks and provide users with a URL pointing to your application on the Web. [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] manages all of the elements and dependencies in your application and ensures that the application is properly installed on the client computer.  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] applications can be configured to run only when the user is connected to the network, or to run both online and offline. When you specify that an application should support offline operation, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] adds a link to your application in the user's **Start** menu, so that the user can open it without using the URL.  
  
 When you update your application, you publish a new deployment manifest and a new copy of your application to your Web server. [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] detects that there is an update available and upgrades the user's installation; no custom programming is required to update old assemblies.  
  
 For a full introduction to [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)], see [ClickOnce Security and Deployment](../vs140/clickonce-security-and-deployment.md). For step-by-step information about using these features, see the following Help topics:  
  
|To|See|  
|--------|---------|  
|Deploy an application with [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]|[How to: Publish a ClickOnce Application](../vs140/how-to--publish-a-clickonce-application-using-the-publish-wizard.md)<br /><br /> [Walkthrough: Deploying a ClickOnce Application Manually](../vs140/walkthrough--manually-deploying-a-clickonce-application.md)|  
|Update a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment|[How to: Manage Updates for a ClickOnce Application](../vs140/how-to--manage-updates-for-a-clickonce-application.md)|  
|Manage security with [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]|[How to: Enable ClickOnce Security Settings](../vs140/how-to--enable-clickonce-security-settings.md)|  
  
## Other Controls and Features  
 There are many other features in Windows Forms that make implementing common tasks fast and easy, such as support for creating dialog boxes, printing, adding Help and documentation, and localizing your application to multiple languages. In addition, Windows Forms relies on the robust security system of the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)], enabling you to release more secure applications to your customers.  
  
 For step-by-step information about using these features, see the following Help topics:  
  
|To|See|  
|--------|---------|  
|Print the contents of a form|[How to: Print Graphics in Windows Forms](assetId:///32b891e6-52ff-4fea-a9ff-2ce5db20a4c6)<br /><br /> [How to: Print Text in Windows Forms](assetId:///362427f8-03d4-4826-b49f-60ab066ad322)|  
|Globalize a Windows Forms application|[Walkthrough: Localizing Windows Forms](assetId:///9a96220d-a19b-4de0-9f48-01e5d82679e5)|  
|Learn more about Windows Forms security|[Security in Windows Forms Overview](assetId:///4810dc9f-ea23-4ce1-8ea1-657f0ff1d820)|  
  
## See Also  
 <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase*>   
 [Windows Forms Overview](assetId:///3a2b6284-c8d6-4e1c-8c69-0bed38f38cd4)   
 [My.Forms Object](../vs140/my.forms-object.md)