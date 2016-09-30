---
title: "&lt;trustInfo&gt; Element (ClickOnce Application)"
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
  - "urn:schemas-microsoft-com:asm.v2#IPermission"
  - "urn:schemas-microsoft-com:asm.v2#PermissionSet"
  - "urn:schemas-microsoft-com:asm.v2#assemblyRequest"
  - "urn:schemas-microsoft-com:asm.v2#trustInfo"
  - "urn:schemas-microsoft-com:asm.v2#defaultAssemblyRequest"
  - "urn:schemas-microsoft-com:asm.v2#security"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "manifests [ClickOnce], trustInfo element"
  - "<trustInfo> element [ClickOnce application manifest]"
ms.assetid: 8a813a74-e158-4308-be78-565937f6af83
caps.latest.revision: 20
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;trustInfo&gt; Element (ClickOnce Application)
Describes the minimum security permissions required for the application to run on the client computer.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element is required and is in the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> namespace. It has no attributes and contains the following elements.  
  
## security  
 Required. This element is a child of the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element. It contains the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element and has no attributes.  
  
## applicationRequestMinimum  
 Required. This element is a child of the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> element and contains the <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>elements. This element has no attributes.  
  
## PermissionSet  
 Required. This element is a child of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element and contains the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element. This element has the following attributes.  
  
-   <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>  
  
     Required. Identifies the permission set. This attribute can be any value. The ID is referenced in the <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> attributes.  
  
-   <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>  
  
     Required. Identifies the version of the permission. Normally this value is <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>.  
  
## IPermission  
 Optional. This element is a child of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> element fully identifies a permission class in the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)]. The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element has the following attributes, but can have additional attributes that correspond to properties on the permission class. To find out the syntax for a specific permission, see the examples listed in the Security.config file.  
  
-   <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>  
  
     Required. Identifies the permission class by strong name. For example, the following code identifies the <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> type.  
  
     <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>  
  
-   <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>  
  
     Required. Identifies the version of the permission. Usually this value is <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>.  
  
-   <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>  
  
     Required. Identifies whether the application needs an unrestricted grant of this permission. If <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, the permission grant is unconditional. If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, or if this attribute is undefined, it is restricted according to the permission-specific attributes defined on the <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> tag. Take the following permissions:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     In this example, the declaration for \<xref:System.Security.Permissions.EnvironmentPermission*> restricts the application to reading only the environment variable USERNAME, whereas the declaration for \<xref:System.Security.Permissions.FileDialogPermission*> gives the application unrestricted use of all \<xref:System.Windows.Forms.FileDialog*> classes.  
  
## defaultAssemblyRequest  
 Optional. Identifies the set of permissions granted to all assemblies. This element is a child of the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> element and has the following attribute.  
  
-   <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>  
  
     Required. Identifies the ID of the permission set that is the default permission. The permission set is declared in the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element.  
  
## assemblyRequest  
 Optional. Identifies permissions for a specific assembly. This element is a child of the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> element and has the following attributes.  
  
-   <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>  
  
     Required. Identifies the assembly name.  
  
-   <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>  
  
     Required. Identifies the ID of the permission set that this assembly requires. The permission set is declared in the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> element.  
  
## requestedPrivileges  
 Optional. This element is a child of the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> element and contains the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element. This element has no attributes.  
  
## requestedExecutionLevel  
 Optional. Identifies the security level at which the application requests to be executed. This element has no children and has the following attributes.  
  
-   <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>  
  
     Required. Indicates the security level the application is requesting. Possible values are:  
  
     <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, requesting no additional permissions. This level requires no additional trust prompts.  
  
     <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, requesting the highest permissions available to the parent process.  
  
     <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, requesting full administrator permissions.  
  
     [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] applications will only install with a value of <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. Installing with any other value will fail.  
  
-   <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>  
  
     Optional. Indicates whether the application requires access to protected user interface elements. Values are either <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, and the default is false. Only signed applications should have a value of true.  
  
## Remarks  
 If a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application asks for more permissions than the client computer will grant by default, the common language runtime's Trust Manager will ask the user if she wants to grant the application this elevated level of trust. If she says no, the application will not run; otherwise, it will run with the requested permissions.  
  
 All permissions requested using <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> will be granted without user prompting if the deployment manifest has a valid Trust License.  
  
 For more information about Permission Elevation, see [ClickOnce Deployment and Security](../vs140/securing-clickonce-applications.md). For more information about policy deployment, see [Trusted Application Deployment Overview](../vs140/trusted-application-deployment-overview.md).  
  
## Examples  
 The following three code examples illustrate <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> elements for the default named security zones—Internet, LocalIntranet, and FullTrust—for use in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment's application manifest.  
  
 The first example illustrates the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> element for the default permissions available in the Internet security zone.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 The second example illustrates the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> element for the default permissions available in the LocalIntranet security zone.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 The third example illustrates the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element for the default permissions available in the FullTrust security zone.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [Trusted Application Deployment Overview](../vs140/trusted-application-deployment-overview.md)   
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)