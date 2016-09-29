---
title: "How to: Get a Service"
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
  - "services, consuming"
ms.assetid: 1f000020-8fb7-4e39-8e1e-2e38c7fec3d4
caps.latest.revision: 24
author: ""
ms.author: "gregvanl"
manager: ""
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# How to: Get a Service
You often need to get Visual Studio services to access different features. In general, a Visual Studio service provides one or more interfaces that you can use. You can get most services from a VSPackage.  
  
 Any VSPackage that derives from <xref:Microsoft.VisualStudio.Shell.Package*> and that has been correctly sited can ask for any global service. Because the Package class implements <xref:System.IServiceProvider*>, any VSPackage that derives from Package is also a service provider.  
  
 When Visual Studio loads a <xref:Microsoft.VisualStudio.Shell.Package*>, it passes an <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider*> object to the [SetSite](assetId:///M:Microsoft.VisualStudio.Shell.Interop.IVsPackage.SetSite(Microsoft.VisualStudio.OLE.Interop.IServiceProvider)?qualifyHint=False&autoUpgrade=True) method during initialization. This is called *siting* the VSPackage. The Package class wraps this service provider and provides the [GetService](assetId:///M:Microsoft.VisualStudio.Shell.Package.GetService(System.Type)?qualifyHint=False&autoUpgrade=True) method for getting services.  
  
## Getting a service from an initialized VSPackage  
  
1.  Every Visual Studio extension starts with a VSIX deployment project which will contain the extension assets. Create a [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] VSIX project named `GetServiceExtension`. You can find the VSIX project template in the **New Project** dialog under **Visual C# / Extensibility**.  
  
2.  Now add a custom command item template named **GetServiceCommand**. In the **Add New Item** dialog, go to **Visual C# / Extensibility** and select **Custom Command**. In the **Name** field at the bottom of the window, change the command file name to **GetServiceCommand.cs**. For more information about how to create a custom command, [Creating an Extension with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md)  
  
3.  In GetServiceCommand.cs, remove the body of the MenuItemCommand method and add the following code:  
  
    ```c#  
    IVsActivityLog activityLog = ServiceProvider.GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
    if (activityLog == null) return;  
    System.Windows.Forms.MessageBox.Show("Found the activity log service.");  
  
    ```  
  
     This code gets an SVsActivityLog service and casts it to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog*> interface, which can be used to write to the activity log. For an example, see [How to: Write to the Activity Log (C#)](../vs140/how-to--use-the-activity-log.md).  
  
4.  Build the project and start debugging. The experimental instance appears.  
  
5.  On the Tools menu of the experimental instance, find the **Invoke GetServiceCommand** button. When you click this button, you should see a message box that says **Found the activity log service.**  
  
## Getting a service from a tool window or control container  
 Sometimes you may need to get a service from a tool window or control container that has not been sited, or else has been sited with a service provider that does not know about the service you want. For example, you might want to write to the activity log from within a control.  
  
 The static [GetGlobalService](assetId:///M:Microsoft.VisualStudio.Shell.Package.GetGlobalService(System.Type)?qualifyHint=False&autoUpgrade=True) method relies on a cached service provider that is initialized the first time any VSPackage derived from <xref:Microsoft.VisualStudio.Shell.Package*> is sited.  
  
 Because the VSPackage constructor is called before the VSPackage is sited, global services are typically unavailable from within the VSPackage constructor. See [How to: Use GetGlobalService](../vs140/how-to--troubleshoot-services.md) for a workaround.  
  
 Here’s an example of the way to get a service in a tool window or other non-VSPackage element.  
  
```c#  
IVsActivityLog log = Package.GetGlobalService(typeof(SVsActivityLog)) as IVsActivityLog;  
if (log == null) return;  
```  
  
## Getting a service from the DTE object  
 You can also get services from <xref:EnvDTE.DTEClass*> object. However, you must get the DTE object as a service from a VSPackage or by calling the static assetId:///M:Microsoft.VisualStudio.Shell.Package.GetGlobalService(System.Type)?qualifyHint=False&autoUpgrade=True method.  
  
 The DTE object implements <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider*>, which you can use to query for a service by using [GetService](assetId:///M:Microsoft.VisualStudio.Shell.ServiceProvider.GetService(System.Type)?qualifyHint=False&autoUpgrade=True).  
  
 Here’s how to get a service from the DTE object.  
  
```c#  
// Start with the DTE object, for example:   
// using EnvDTE;  
// DTE dte = (DTE)GetService(typeof(DTE));  
  
ServiceProvider sp = new ServiceProvider((Microsoft.VisualStudio.OLE.Interop.IServiceProvider)dte);  
if (sp != null)  
{  
    IVsActivityLog log = sp.GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
    if (log != null)  
    {   
        System.Windows.Forms.MessageBox.Show("Found the activity log service.");  
    }  
}  
```  
  
## See Also  
 [How to Provide a Service (C#)](../vs140/how-to--provide-a-service.md)   
 [Services](../vs140/using-and-providing-services.md)   
 [Service Essentials](../vs140/service-essentials.md)