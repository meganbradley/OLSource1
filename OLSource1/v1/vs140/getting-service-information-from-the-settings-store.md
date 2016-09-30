---
title: "Getting Service Information from the Settings Store"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 7028d440-d16d-4b08-9b94-eb8cc93b25fc
caps.latest.revision: 8
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Getting Service Information from the Settings Store
You can use the settings store to find all available services or to determine whether a particular service is installed. You must know the type of the service class.  
  
### To list the available services  
  
1.  Create a VSIX project named FindServicesExtension and then add a custom command named FindServicesCommand. For more information about how to create a custom command, see [Creating an Extension with a Menu Command](../vs140/creating-an-extension-with-a-menu-command.md)  
  
2.  In FindServicesCommand.cs, add the following using statements:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
3.  Get the configuration settings store, then find the subcollection named Services. This collection includes all the available services. In the MenuItemCommand method, remove the existing code and replace it with the following:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
4.  Build the project and start debugging. The experimental instance appears.  
  
5.  In the experimental instance, on the **Tools** menu, click **Invoke FindServicesCommand**.  
  
     You should see a message box listing all the services.  
  
     To verify these settings, you can use the registry editor.  
  
## Finding a Specific Service  
 You can also use the \<xref:Microsoft.VisualStudio.Settings.SettingsStore.CollectionExists*> method to determine whether a particular service is installed. You must know the type of the service class.  
  
1.  In the MenuItemCallback of the project you created in the previous procedure, search the configuration settings store for the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> collection that has the subcollection named by the GUID of the service. In this case we will look for the Help service.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Build the project and start debugging.  
  
3.  In the experimental instance, on the **Tools** menu, click **Invoke FindServicesCommand**.  
  
     You should see a message with the text **Help Service Available:**  followed by **True** or **False**. To verify this setting, you can use a registry editor, as shown in the earlier steps.