---
title: "&lt;file&gt; Element (ClickOnce Application)"
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
  - "http://www.w3.org/2000/09/xmldsig#Transform"
  - "urn:schemas-microsoft-com:asm.v2#file"
  - "http://www.w3.org/2000/09/xmldsig#DigestValue"
  - "http://www.w3.org/2000/09/xmldsig#DigestMethod"
  - "http://www.w3.org/2000/09/xmldsig#Transforms"
  - "urn:schemas-microsoft-com:asm.v2#hash"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<file> element [ClickOnce application manifest]"
  - "manifests [ClickOnce], file element"
ms.assetid: 56e3490c-eed5-4841-b1bf-eefe778b6ac9
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;file&gt; Element (ClickOnce Application)
Identifies all nonassembly files downloaded and used by the application.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element is optional. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Required. Identifies the name of the file.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Required. Specifies the size, in bytes, of the file.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional, if the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> attribute is not specified or set to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>; required if <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>. The name of the group to which this file belongs. The name can be any Unicode string value chosen by the developer, and is used for downloading files on demand with the \<xref:System.Deployment.Application.ApplicationDeployment*> class.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Optional. Specifies whether this file must download when the application is first run, or whether the file should reside only on the server until the application requests it on demand. If <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> or undefined, the file is downloaded when the application is first run or installed. If <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>, a <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> must be specified for the application manifest to be valid. <CodeContentPlaceHolder>14\</CodeContentPlaceHolder> cannot be true if <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> is specified with the value <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional. Specifies that this file is a data file. Currently the only valid value is <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>.|  
  
## typelib  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> element is an optional child of the file element. The element describes the type library that belongs to the COM component. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Required. The GUID assigned to the type library.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Required. The version number of the type library.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Required. The directory that contains the Help files for the component. May be zero-length.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Optional. The hexadecimal string representation of the locale identifier (LCID). It is one to four hexadecimal digits without a 0x prefix and without leading zeros. The LCID may have a neutral sublanguage identifier.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Optional. The string representation of the type library flags for this type library. Specifically, it should be one of "RESTRICTED", "CONTROL", "HIDDEN" and "HASDISKIMAGE".|  
  
## comClass  
 The <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element, but is required if the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|Required. The class ID of the COM component expressed as a GUID.|  
|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Optional. The class name.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|Optional. The threading model used by in-process COM classes. If this property is null, no threading model is used. The component is created on the main thread of the client and calls from other threads are marshaled to this thread. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>30\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>32\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>33\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|Optional. GUID for the type library for this COM component.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Optional. Version-dependent programmatic identifier associated with the COM component. The format of a <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> is <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional. Duplicates in the assembly manifest the information provided by the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> registry key. If values for the <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, or <CodeContentPlaceHolder>43\</CodeContentPlaceHolder> attributes are not found, the corresponding default value listed in <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> is used for the missing attributes. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires <CodeContentPlaceHolder>45\</CodeContentPlaceHolder> registry key values.|  
|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_ICON. It can provide an icon of an object. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires <CodeContentPlaceHolder>47\</CodeContentPlaceHolder> registry key values.|  
|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_CONTENT. It can provide a compound document displayable for a screen or printer. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> registry key values.|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Optional. Duplicates in the assembly manifest the information provided by DVASPECT_DOCPRINT. It can provide an object representation displayable on the screen as if printed to a printer. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> registry key values.|  
|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Optional. Duplicates in an assembly manifest the information provided by DVASPECT_THUMBNAIL. It can provide a thumbnail of an object displayable in a browsing tool. The value can be a comma-delimited list of the attribute values from the following table. You can use this attribute if the COM class is an OCX class that requires <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> registry key values.|  
  
## comInterfaceExternalProxyStub  
 The <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element, but may be required if the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element contains the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Required. The interface ID (IID) which is served by this proxy. The IID must have braces surrounding it.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|Optional. The IID of the interface from which the interface referenced by <CodeContentPlaceHolder>58\</CodeContentPlaceHolder> is derived.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Optional. The number of methods implemented by the interface.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Optional. The name of the interface as it will appear in code.|  
|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Optional. The type library that contains the description of the interface specified by the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> attribute.|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Optional. Maps an IID to a CLSID in 32-bit proxy DLLs.|  
  
## comInterfaceProxyStub  
 The <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element, but may be required if the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element contains the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Required. The interface ID (IID) which is served by this proxy. The IID must have braces surrounding it.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Optional. The IID of the interface from which the interface referenced by <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> is derived.|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|Optional. The number of methods implemented by the interface.|  
|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Optional. The name of the interface as it will appear in code.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|Optional. The type library that contains the description of the interface specified by the <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> attribute.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|Optional. Maps an IID to a CLSID in 32-bit proxy DLLs.|  
|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Optional. Optional. The threading model used by in-process COM classes. If this property is null, no threading model is used. The component is created on the main thread of the client and calls from other threads are marshaled to this thread. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>75\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>76\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>78\</CodeContentPlaceHolder>.|  
  
## windowClass  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> element, but may be required if the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application contains a COM component it intends to deploy using registration-free COM. The element refers to a window class defined by the COM component that must have a version applied to it. The element contains the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Optional. Controls whether the internal window class name used in registration contains the version of the assembly that contains the window class. The value of this attribute can be <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> or <CodeContentPlaceHolder>83\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>84\</CodeContentPlaceHolder>. The value <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> should only be used if the same window class is defined by a side-by-side component and an equivalent non-side-by-side component and you want to treat them as the same window class. Note that the usual rules about window class registration apply—only the first component that registers the window class will be able to register it, because it does not have a version applied to it.|  
  
## hash  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> element is an optional child of the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> element has no attributes.  
  
 [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] uses an algorithmic hash of all the files in an application as a security check, to ensure that none of the files were changed after deployment. If the <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> element is not included, this check will not be performed. Therefore, omitting the <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> element is not recommended.  
  
 If a manifest contains a file that is not hashed, that manifest cannot be digitally signed, because users cannot verify the contents of an unhashed file.  
  
## dsig:Transforms  
 The <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> element has no attributes.  
  
## dsig:Transform  
 The <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>95\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>96\</CodeContentPlaceHolder> element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>98\</CodeContentPlaceHolder>.|  
  
## dsig:DigestMethod  
 The <CodeContentPlaceHolder>99\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>100\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>101\</CodeContentPlaceHolder> element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>102\</CodeContentPlaceHolder>|The algorithm used to calculate the digest for this file. Currently the only value used by [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] is <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>.|  
  
## dsig:DigestValue  
 The <CodeContentPlaceHolder>104\</CodeContentPlaceHolder> element is a required child of the <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>106\</CodeContentPlaceHolder> element has no attributes. Its text value is the computed hash for the specified file.  
  
## Remarks  
 This element identifies all the nonassembly files that make up the application and, in particular, the hash values for file verification. This element can also include Component Object Model (COM) isolation data associated with the file. If a file changes, the application manifest file also must be updated to reflect the change.  
  
## Example  
 The following code example illustrates <CodeContentPlaceHolder>107\</CodeContentPlaceHolder> elements in an application manifest for an application deployed using [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [ClickOnce Application Manifest](../vs140/clickonce-application-manifest.md)