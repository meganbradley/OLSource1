---
title: "&lt;dependency&gt; Element (ClickOnce Deployment)"
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
  - "urn:schemas-microsoft-com:asm.v2#osVersionInfo"
  - "urn:schemas-microsoft-com:asm.v2#os"
  - "http://www.w3.org/2000/09/xmldsig#Transform"
  - "urn:schemas-microsoft-com:asm.v2#dependency"
  - "http://www.w3.org/2000/09/xmldsig#DigestValue"
  - "urn:schemas-microsoft-com:asm.v2#assemblyIdentity"
  - "http://www.w3.org/2000/09/xmldsig#DigestMethod"
  - "http://www.w3.org/2000/09/xmldsig#Transforms"
  - "urn:schemas-microsoft-com:asm.v2#hash"
  - "urn:schemas-microsoft-com:asm.v2#dependentAssembly"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<dependency> element [ClickOnce deployment manifest]"
ms.assetid: 9b4d2082-0347-4922-ac70-85f11b913039
caps.latest.revision: 31
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;dependency&gt; Element (ClickOnce Deployment)
Identifies the version of the application to install, and the location of the application manifest.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element is required. It has no attributes. A deployment manifest can have multiple <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> elements.  
  
 The <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element usually expresses dependencies for the main application on assemblies contained within a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. If your Main.exe application consumes an assembly called DotNetAssembly.dll, then that assembly must be listed in a dependency section. Dependency, however, can also express other types of dependencies, such as dependencies on a specific version of the common language runtime, on an assembly in the global assembly cache (GAC), or on a COM object. Because it is a no-touch deployment technology, [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] cannot initiate download and installation of these types of dependencies, but it does prevent the application from running if one or more of the specified dependencies do not exist.  
  
## dependentAssembly  
 Required. This element contains the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element. The following table shows the attributes the <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> supports.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional. Specifies that this assembly should already exist in the GAC. Valid values are <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>. If <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>, and the specified assembly does not exist in the GAC, the application fails to run.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. Identifies the top-level application identity, including its dependencies. Used internally by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] to manage application storage and activation.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Required. The relationship between this dependency and the application. Valid values are:\<br />\<br /> -   <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. Component represents a separate installation from the current application.\<br />-   <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>. Component is required by the current application.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional. The full path to the application manifest.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional. The size of the application manifest, in bytes.|  
  
## assemblyIdentity  
 Required. This element is a child of the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> element. The content of <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> must be the same as described in the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest. The following table shows the attributes of the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Required. Identifies the name of the application.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Required. Specifies the version number of the application, in the following format: <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Required. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the SHA-1 hash of the public key under which the application or assembly is signed. The public key used to sign must be 2048 bits or greater.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Required. Specifies the microprocessor. The valid values are <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> for 32-bit Windows and <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> for 64-bit Windows.|  
|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Optional. Identifies the two part language codes of the assembly. For example, EN-US, which stands for English (U.S.). The default is <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>. This element is in the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> namespace.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Optional. For backwards compatibility with Windows side-by-side install technology. The only allowed value is <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>.|  
  
## hash  
 The <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> element has no attributes.  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] uses an algorithmic hash of all the files in an application as a security check to ensure that none of the files were changed after deployment. If the <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> element is not included, this check will not be performed. Therefore, omitting the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> element is not recommended.  
  
## dsig:Transforms  
 The <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> element has no attributes.  
  
## dsig:Transform  
 The <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> element. The following table shows the attributes of the <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.|  
  
## dsig:DigestMethod  
 The <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> element. The following table shows the attributes of the <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> element.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>.|  
  
## dsig:DigestValue  
 The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element has no attributes. Its text value is the computed hash for the specified file.  
  
## Remarks  
 Deployment manifests typically have a single <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> element that identifies the name and version of the application manifest.  
  
## Example  
 The following code example shows a <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> element in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] deployment manifest.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example  
 The following code example specifies a dependency on an assembly already installed in the GAC.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## Example  
 The following code example specifies a dependency on a specific version of the common language runtime.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## Example  
 The following code example specifies an operating system dependency.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Deployment Manifest](../vs140/clickonce-deployment-manifest.md)   
 [\<dependency> Element (ClickOnce Application)](../vs140/-dependency--element--clickonce-application-.md)