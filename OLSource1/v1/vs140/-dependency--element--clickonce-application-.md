---
title: "&lt;dependency&gt; Element (ClickOnce Application)"
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
  - "manifests [ClickOnce], dependency element"
  - "<dependency> element [ClickOnce application manifest]"
ms.assetid: 09d6a1e0-60f8-4fbd-843b-8e49ee3115a3
caps.latest.revision: 38
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;dependency&gt; Element (ClickOnce Application)
Identifies a platform or assembly dependency that is required for the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is required. There may be multiple instances of <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> in the same application manifest.  
  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element has no attributes, and contains the following child elements.  
  
### dependentOS  
 Optional. Contains the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> elements are mutually exclusive: one or the other must exist for a <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element, but not both.  
  
 <CodeContentPlaceHolder>9\</CodeContentPlaceHolder> supports the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional. Specifies a support URL for the dependent platform. This URL is shown to the user if the required platform is found.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Optional. Describes, in human-readable form, the operating system described by the <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element.|  
  
### osVersionInfo  
 Required. This element is a child of the <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> element and contains the <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> element. This element has no attributes.  
  
### os  
 Required. This element is a child of the <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> element. This element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|Required. Specifies the major version number of the OS.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Required. Specifies the minor version number of the OS.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Required. Specifies the build number of the OS.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Required. Specifies the service pack major number of the OS.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional. Specifies the service pack minor number of the OS.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional. Identifies the product type value. Valid values are <CodeContentPlaceHolder>22\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>24\</CodeContentPlaceHolder>. For example, for Windows 2000 Professional, this attribute value is <CodeContentPlaceHolder>25\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Optional. Identifies a product suite available on the system, or the system's configuration type. Valid values are <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>29\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>34\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>35\</CodeContentPlaceHolder>. For example, for Windows 2000 Professional, this attribute value is <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>.|  
  
### dependentAssembly  
 Optional. Contains the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> elements are mutually exclusive: one or the other must exist for a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> element, but not both.  
  
 <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Required. Specifies the dependency type. Valid values are <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. An <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> assembly is installed as part of the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application. A <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> assembly must be present in the global assembly cache (GAC) before the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application can install.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|Required. Specifies whether the assembly can be loaded programmatically at runtime.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Optional. If the <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>50\</CodeContentPlaceHolder>, designates a named group of assemblies that only install on demand. For more information, see [Walkthrough: Downloading Assemblies On Demand with the ClickOnce Deployment API](../vs140/walkthrough--downloading-assemblies-on-demand-with-the-clickonce-deployment-api-using-the-designer.md).\<br />\<br /> If set to <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> and the <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, designates the assembly as part of the .NET Framework. The global assemby cache (GAC) is not checked for this assembly when installing on [!INCLUDE[net_v40_short](../vs140/includes/net_v40_short_md.md)] and later versions.|  
|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Required when the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>56\</CodeContentPlaceHolder>. The path to the dependent assembly. May be either an absolute path, or a path relative to the manifest's code base. This path must be a valid URI in order for the assembly manifest to be valid.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Required when the <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> attribute is set to <CodeContentPlaceHolder>59\</CodeContentPlaceHolder>. The size of the dependent assembly, in bytes.|  
  
### assemblyIdentity  
 Required. This element is a child of the <CodeContentPlaceHolder>60\</CodeContentPlaceHolder> element and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Required. Identifies the name of the application.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|Required. Specifies the version number of the application in the following format: <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Optional. Specifies a 16-character hexadecimal string that represents the last 8 bytes of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> hash value of the public key under which the application or assembly is signed. The public key used to sign the catalog must be 2048 bits or more.|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Optional. Specifies the processor. The valid values are <CodeContentPlaceHolder>67\</CodeContentPlaceHolder> for 32-bit Windows and <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> for 64-bit Windows.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Optional. Identifies the two part language codes, such as EN-US, of the assembly.|  
  
### hash  
 The <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> element has no attributes.  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] uses an algorithmic hash of all the files in an application as a security check, to ensure that none of the files were changed after deployment. If the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> element is not included, this check will not be performed. Therefore, omitting the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> element is not recommended.  
  
### dsig:Transforms  
 The <CodeContentPlaceHolder>75\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> element has no attributes.  
  
### dsig:Transform  
 The <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>82\</CodeContentPlaceHolder>.|  
  
### dsig:DigestMethod  
 The <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>87\</CodeContentPlaceHolder>.|  
  
### dsig:DigestValue  
 The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> element has no attributes. Its text value is the computed hash for the specified file.  
  
## Remarks  
 All assemblies used by your application must have a corresponding <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> element. Dependent assemblies do not include assemblies that must be preinstalled in the global assembly cache as platform assemblies.  
  
## Example  
 The following code example illustrates <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> elements in a [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application manifest. This code example is part of a larger example provided for the [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md) topic.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)   
 [\<dependency> Element (ClickOnce Deployment)](../vs140/-dependency--element--clickonce-deployment-.md)