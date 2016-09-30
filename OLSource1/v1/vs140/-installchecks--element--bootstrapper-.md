---
title: "&lt;InstallChecks&gt; Element (Bootstrapper)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<InstallChecks> element [bootstrapper]"
ms.assetid: ad329c87-b0ad-4304-84de-ae9496514c42
caps.latest.revision: 27
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;InstallChecks&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element supports starting a variety of tests against the local computer to make sure that all of the appropriate prerequisites for an application have been installed.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## AssemblyCheck  
 This element is an optional child element of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>, the bootstrapper will make sure that the assembly identified by the element exists in the global assembly cache (GAC). It contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>8\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Required. The fully qualified name of the assembly to check.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Required. The abbreviated form of the public key associated with this strongly named assembly. All assemblies stored in the GAC must have a name, a version, and a public key.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Required. The version of the assembly.\<br />\<br /> The version number has the format \<*major version*>.\<*minor version*>.\<*build version*>.\<*revision version*>.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Optional. The language of a localized assembly. Default is <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Optional. The computer processor targeted by this installation. Default is <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.|  
  
## ExternalCheck  
 This element is an optional child element of <CodeContentPlaceHolder>16\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>17\</CodeContentPlaceHolder>, the bootstrapper will execute the named external program in a separate process, and store its exit code in the property indicated by <CodeContentPlaceHolder>18\</CodeContentPlaceHolder>. <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> is useful for implementing complex dependency checks, or when the only way to check for the existence of a component is to instantiate it.  
  
 <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Required. The external program to execute. The program must be part of the setup distribution package.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|Optional. Supplies command-line arguments to the executable named by <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>.|  
  
## FileCheck  
 This element is an optional child element of <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>, the bootstrapper will determine whether the named file exists, and return the version number of the file. If the file does not have a version number, the bootstrapper sets the property named by <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> to 0. If the file does not exist, <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> is not set to any value.  
  
 <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Required. The name of the file to find.|  
|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|Required. The disk or folder in which to look for the file. This must be a relative path if <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> is assigned; otherwise, it must be an absolute path.|  
|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Optional. A folder that has special significance either to Windows or to [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)]. The default is to interpret <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> as an absolute path. Valid values include the following:\<br />\<br /> <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>. The application data folder for this [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] application; specific to the current user.\<br />\<br /> <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>. The application data folder used by all users.\<br />\<br /> <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>. The Common Files folder for the current user.\<br />\<br /> <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>. The data folder for non-roaming applications.\<br />\<br /> <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>. The standard Program Files folder for 32-bit applications.\<br />\<br /> <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. The folder that contains all applications launched at system startup.\<br />\<br /> <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>. The folder that contains 32-bit system DLLs.\<br />\<br /> <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>. The folder that contains the Windows system installation.\<br />\<br /> <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>. The drive or partition that contains the Windows system installation.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|Optional. The depth at which to search sub-folders for the named file. The search is depth-first. The default is 0, which restricts the search to the top-level folder specified by <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> and **SearchPath**.|  
  
## MsiProductCheck  
 This element is an optional child element of <CodeContentPlaceHolder>51\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, the bootstrapper checks to see whether the specified Microsoft Windows Installer installation has run until it is completed. The property value is set depending on the state of that installed product. A positive value indicates the product is installed, 0 or -1 indicates it is not installed. (Please see the Windows Installer SDK function MsiQueryFeatureState for more information.) . If Windows Installer is not installed on the computer, <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> is not set.  
  
 <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Required. The GUID for the installed product.|  
|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Optional. The GUID for a specific feature of the installed application.|  
  
## RegistryCheck  
 This element is an optional child element of <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, the bootstrapper checks to see whether the specified registry key exists, or whether it has the indicated value.  
  
 <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Required. The name of the registry key.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Optional. The name of the registry value to retrieve. The default is to return the text of the default value. <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> must be either a String or a DWORD.|  
  
## RegistryFileCheck  
 This element is an optional child element of <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>. For each instance of <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, the bootstrapper retrieves the version of the specified file, first attempting to retrieve the path to the file from the specified registry key. This is particularly useful if you want to look up a file in a directory specified as a value in the registry.  
  
 <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> contains no elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|Required. The name of the property to store the result. This property can be referenced from a test underneath the <CodeContentPlaceHolder>73\</CodeContentPlaceHolder> element, which is a child of the <CodeContentPlaceHolder>74\</CodeContentPlaceHolder> element. For more information, see [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Required. The name of the registry key. Its value is interpreted as the path to a file, unless the <CodeContentPlaceHolder>76\</CodeContentPlaceHolder> attribute is set. If this key does not exist, <CodeContentPlaceHolder>77\</CodeContentPlaceHolder> is not set.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|Optional. The name of the registry value to retrieve. The default is to return the text of the default value. <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> must be a String.|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|Optional. The name of a file. If specified, the value obtained from the registry key is assumed to be a directory path, and this name is appended to it. If not specified, the value returned from the registry is assumed to be the full path to a file.|  
|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Optional. The depth at which to search sub-folders for the named file. The search is depth-first. The default is 0, which restricts the search to the top-level folder specified by the registry key's value.|  
  
## Remarks  
 While the elements underneath <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> define the tests to run, they do not execute them. To execute the tests, you must create <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> elements underneath the <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element.  
  
## Example  
 The following code example demonstrates the <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> element as it is used in the product file for the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)].  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## InstallConditions  
 When <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> are evaluated, they produce properties. The properties are then used by <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> to determine whether a package should install, bypass, or fail. The following table lists the <CodeContentPlaceHolder>88\</CodeContentPlaceHolder>:  
  
|||  
|-|-|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|If any <CodeContentPlaceHolder>90\</CodeContentPlaceHolder> condition evaluates to true, the package will fail. The rest of the conditions will not be evaluated.|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|If any <CodeContentPlaceHolder>92\</CodeContentPlaceHolder> condition evaluates to true, the package will be bypassed. The rest of the conditions will not be evaluated.|  
  
## Predefined Properties  
 The following table lists the <CodeContentPlaceHolder>93\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>94\</CodeContentPlaceHolder> elements:  
  
|Property|Notes|Possible Values|  
|--------------|-----------|---------------------|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|Version number of a Windows 9X operating system.|4.10 = Windows 98|  
|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|Version number of a Windows NT-based operating system.|Major.Minor.ServicePack\<br />\<br /> 5.0 = Windows 2000\<br />\<br /> 5.1.0 = Windows XP\<br />\<br /> 5.1.2 = Windows XP Professional SP2\<br />\<br /> 5.2.0 = Windows Server 2003|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Version number of a 64-bit Windows NT-based operating system.|Same as mentioned earlier.|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|Version number of the Windows Installer service.|2.0 = Windows Installer 2.0|  
|<CodeContentPlaceHolder>99\</CodeContentPlaceHolder>|Specifies whether a user has administrator privileges on a Windows NT-based operating system.|0 = no administrator privileges\<br />\<br /> 1 = administrator privileges|  
  
 For example, to block installation on a computer running Windows 95, use code such as the following:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [\<Commands> Element (ClickOnce Bootstrapper)](../vs140/-commands--element--bootstrapper-.md)   
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)