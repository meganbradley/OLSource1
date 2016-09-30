---
title: "&lt;deployment&gt; Element (ClickOnce Deployment)"
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
  - "urn:schemas-microsoft-com:asm.v2#subscription"
  - "urn:schemas-microsoft-com:asm.v2#beforeApplicationStartup"
  - "urn:schemas-microsoft-com:asm.v2#deploymentProvider"
  - "urn:schemas-microsoft-com:asm.v2#update"
  - "urn:schemas-microsoft-com:asm.v2#deployment"
  - "urn:schemas-microsoft-com:asm.v2#expiration"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<deployment> element [ClickOnce deployment manifest]"
ms.assetid: 4fafa9c2-97a0-4cea-b8fd-9746dca33af4
caps.latest.revision: 34
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;deployment&gt; Element (ClickOnce Deployment)
Identifies the attributes used for the deployment of updates and exposure to the system.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is required and is in the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> namespace. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Specifies whether this application defines a presence on the Windows **Start** menu and in the Control Panel **Add or Remove Programs** application. Valid values are <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will always run the latest version of this application from the network, and will not recognize the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element.|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Optional. Specifies the minimum version of this application that can run on the client. If the version number of the application is less than the version number supplied in the deployment manifest, the application will not run. Version numbers must be specified in the format <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>, where <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> is an unsigned integer. If the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> attribute is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> must not be set.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Optional. Defaults to <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, all files in the deployment must have a .deploy extension. [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will strip this extension off these files as soon as it downloads them from the Web server. If you publish your application by using [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)], it automatically adds this extension to all files. This parameter allows all the files within a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment to be downloaded from a Web server that blocks transmission of files ending in "unsafe" extensions such as .exe.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional. Defaults to <CodeContentPlaceHolder>19\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>20\</CodeContentPlaceHolder>, prevents an installed application from being started by clicking the URL or entering the URL into Internet Explorer. If the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> attribute is not present, this attribute is ignored.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Optional. Defaults to <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>, allows the URL to contain query string parameters that are passed into the application, much like command-line arguments are passed to a command-line application. For more information, see [How to: Retrieve Query String Information in a ClickOnce Application](../vs140/how-to--retrieve-query-string-information-in-an-online-clickonce-application.md).\<br />\<br /> If the <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> attribute is <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> must either be excluded from the manifest, or explicitly set to <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.|  
  
 The <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> element also contains the following child elements.  
  
## subscription  
 Optional. Contains the <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> element has no attributes. If the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> element does not exist, the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application will never scan for updates. If the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element is <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>, the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element is ignored, because a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application that is launched from the network always uses the latest version.  
  
## update  
 Required. This element is a child of the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> element and contains either the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> or the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> element. <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> cannot both be specified in the same deployment manifest.  
  
 The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> element has no attributes.  
  
## beforeApplicationStartup  
 Optional. This element is a child of the <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> element and has no attributes. When the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element exists, the application will be blocked when [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] checks for updates, if the client is online. If this element does not exist, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] will first scan for updates based on the values specified for the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> element. <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> cannot both be specified in the same deployment manifest.  
  
## expiration  
 Optional. This element is a child of the <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> element, and has no children. <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> cannot both be specified in the same deployment manifest. When the update check occurs and an updated version is detected, the new version caches while the existing version runs. The new version then installs on the next launch of the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application.  
  
 The <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> element supports the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Required. Identifies how old the current update should become before the application performs an update check. The unit of time is determined by the <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> attribute.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Required. Identifies the unit of time for <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. Valid units are <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>.|  
  
## deploymentProvider  
 For the .NET Framework 2.0, this element is required if the deployment manifest contains a <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> section. For the .NET Framework 3.5 and later, this element is optional, and will default to the server and file path in which the deployment manifest was discovered.  
  
 This element is a child of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> element and has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Required. Identifies the location, as a Uniform Resource Identifier (URI), of the deployment manifest that is used to update the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. This element also allows for forwarding update locations for CD-based installations. Must be a valid URI.|  
  
## Remarks  
 You can configure your [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application to scan for updates on startup, scan for updates after startup, or never check for updates. To scan for updates on startup, ensure that the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> element exists under the <CodeContentPlaceHolder>63\</CodeContentPlaceHolder> element. To scan for updates after startup, ensure that the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element exists under the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element, and that update intervals are provided.  
  
 To disable checking for updates, remove the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> element. When you specify in the deployment manifest to never scan for updates, you can still manually check for updates by using the \<xref:System.Deployment.Application.ApplicationDeployment.CheckForUpdate*> method.  
  
 For more information on how deploymentProvider relates to updates, see [Choosing a ClickOnce Update Strategy](../vs140/choosing-a-clickonce-update-strategy.md).  
  
## Examples  
 The following code example illustrates a <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment manifest. The example uses a <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> element to indicate the preferred update location.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)