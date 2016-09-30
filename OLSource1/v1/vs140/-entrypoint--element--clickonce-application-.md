---
title: "&lt;entryPoint&gt; Element (ClickOnce Application)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "urn:schemas-microsoft-com:asm.v2#commandLine"
  - "urn:schemas-microsoft-com:asm.v2#entryPoint"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<entryPoint> element [ClickOnce application manifest]"
  - "manifests [ClickOnce], entryPoint element"
ms.assetid: 10ad3083-10c1-4189-a870-9bba2eab244f
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;entryPoint&gt; Element (ClickOnce Application)
Identifies the assembly that should be executed when this [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application is run on a client computer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element is required and is in the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> namespace. There may only be one <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element defined in an application manifest.  
  
 The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>|Optional. This value is not used by .NET Framework.|  
  
 <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> has the following elements.  
  
## assemblyIdentity  
 Required. The role of <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> and its attributes is defined in [\<assemblyIdentity> Element (ClickOnce Reference)](../vs140/-assemblyidentity--element--clickonce-application-.md).  
  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> attribute of this element and the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> attribute defined in the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> elsewhere in the application manifest must match.  
  
## commandLine  
 Required. Must be a child of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element. It has no child elements and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Required. A local reference to the startup assembly for the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. This value cannot contain forward slash (/) or backslash (\\) path separators.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Required. Describes the action to take with the entry point. The only valid value is <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>; if a blank string is supplied, <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> is assumed.|  
  
## customHostRequired  
 Optional. If included, specifies that this deployment contains a component that will be deployed inside of a custom host, and is not a stand-alone application.  
  
 If this element is present, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> elements must not also be present. If they are, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will raise a validation error during installation.  
  
 This element has no attributes and no children.  
  
## customUX  
 Optional. Specifies that the application is installed and maintained by a custom installer, and does not create a Start menu entry, shortcut, or Add or Remove Programs entry.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 An application that includes the customUX element must provide a custom installer that uses the \<xref:System.Deployment.Application.InPlaceHostingManager*> class to perform install operations. An application with this element cannot be installed by double-clicking its manifest or setup.exe prerequisite bootstrapper. The custom installer can create Start menu entries, shortcuts, and Add or Remove Programs entries. If the custom installer does not create an Add or Remove Programs entry, it must store the subscription identifier provided by the \<xref:System.Deployment.Application.GetManifestCompletedEventArgs.SubscriptionIdentity*> property and enable the user to uninstall the application later by calling the \<xref:System.Deployment.Application.InPlaceHostingManager.UninstallCustomUXApplication*> method. For more information, see [Walkthrough: Creating a Custom Installer for a ClickOnce Application](../vs140/walkthrough--creating-a-custom-installer-for-a-clickonce-application.md).  
  
## Remarks  
 This element identifies the assembly and entry point for the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.  
  
 You cannot use <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> to pass parameters into your application at run time. You can access query string parameters for a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment from the application's \<xref:System.AppDomain*>. For more information, see [How to: Retrieve Query String Information in a ClickOnce Application](../vs140/how-to--retrieve-query-string-information-in-an-online-clickonce-application.md).  
  
## Example  
 The following code example illustrates an <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element in an application manifest for a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. This code example is part of a larger example provided for the [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md) topic.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)