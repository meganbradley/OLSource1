---
title: "&lt;Commands&gt; Element (Bootstrapper)"
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
  - "<Commands> element [bootstrapper]"
ms.assetid: e61d5787-fe1f-4ebf-b0cf-0d7909be7ffb
caps.latest.revision: 17
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# &lt;Commands&gt; Element (Bootstrapper)
The <CodeContentPlaceHolder>2\</CodeContentPlaceHolder> element implements tests described by the elements underneath the <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> element, and declares which package the [!INCLUDE[ndptecclick](../vs140/includes/ndptecclick_md.md)] bootstrapper should install if the test fails.  
  
## Syntax  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Elements and Attributes  
 The <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element is required. The element has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Optional. Determines whether the system should restart if any of the packages return a restart exit code. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>. The restart is deferred until some future time.\<br />\<br /> <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. Causes an immediate restart if one of the packages returned a restart exit code.\<br />\<br /> <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>. Causes any restart requests to be ignored.\<br />\<br /> The default is <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>.|  
  
## Command  
 The <CodeContentPlaceHolder>10\</CodeContentPlaceHolder> element is a child element of the <CodeContentPlaceHolder>11\</CodeContentPlaceHolder> element. A <CodeContentPlaceHolder>12\</CodeContentPlaceHolder> element can have one or more <CodeContentPlaceHolder>13\</CodeContentPlaceHolder> elements. The element has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Required. The name of the package to install should one or more of the conditions specified by <CodeContentPlaceHolder>15\</CodeContentPlaceHolder> return false. The package must be defined in the same file by using a <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> element.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Optional. A set of command line arguments to pass into the package file.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|Optional. The estimated time, in seconds, it will take to install the package. This value determines the size of the progress bar the bootstrapper displays to the user. The default is 0, in which case no time estimate is specified.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Optional. The estimated amount of disk space, in bytes, that the package will occupy after the installation is finished. This value is used in hard disk space requirements that the bootstrapper displays to the user. The default is 0, in which case the bootstrapper does not display any hard disk space requirements.|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>|Optional. The estimated amount of temporary disk space, in bytes, that the package will require.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Optional. The path to the log file that the package generates, relative to the root directory of the package.|  
  
## InstallConditions  
 The <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>23\</CodeContentPlaceHolder> element. Each <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> element can have at most one <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> element. If no <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> element exists, the package specified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> will always run.  
  
## BypassIf  
 The <CodeContentPlaceHolder>28\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> element, and describes a positive condition under which the command should not be executed. Each <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> element can have zero or more <CodeContentPlaceHolder>31\</CodeContentPlaceHolder> elements.  
  
 <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|Required. The name of the property to test. The property must previously have been defined by a child of the <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> element. For more information, see [\<InstallChecks> Element (ClickOnce BootStrapper)](../vs140/-installchecks--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|Required. The type of comparison to perform. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>36\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>37\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>38\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>39\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>40\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>41\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>44\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>46\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>48\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Required. The value to compare with the property.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|Optional. The name of a <CodeContentPlaceHolder>52\</CodeContentPlaceHolder> tag that defines when this rule should be evaluated.|  
  
## FailIf  
 The <CodeContentPlaceHolder>53\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> element, and describes a positive condition under which the installation should stop. Each <CodeContentPlaceHolder>55\</CodeContentPlaceHolder> element can have zero or more <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> elements.  
  
 <CodeContentPlaceHolder>57\</CodeContentPlaceHolder> has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|Required. The name of the property to test. The property must previously have been defined by a child of the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> element. For more information, see [\<InstallChecks> Element (ClickOnce BootStrapper)](../vs140/-installchecks--element--bootstrapper-.md).|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|Required. The type of comparison to perform. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>62\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>64\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>65\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>66\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>68\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>69\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>70\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>71\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>72\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>73\</CodeContentPlaceHolder>, <CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|Required. The value to compare with the property.|  
|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|Optional. The text to display to the user upon failure.|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|Optional. The name of a <CodeContentPlaceHolder>78\</CodeContentPlaceHolder> tag that defines when this rule should be evaluated.|  
  
## ExitCodes  
 The <CodeContentPlaceHolder>79\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>80\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>81\</CodeContentPlaceHolder> element contains one or more <CodeContentPlaceHolder>82\</CodeContentPlaceHolder> elements, which determine what the installation should do in response to an exit code from a package. There can be one optional <CodeContentPlaceHolder>83\</CodeContentPlaceHolder> element underneath a <CodeContentPlaceHolder>84\</CodeContentPlaceHolder> element. <CodeContentPlaceHolder>85\</CodeContentPlaceHolder> has no attributes.  
  
## ExitCode  
 The <CodeContentPlaceHolder>86\</CodeContentPlaceHolder> element is a child of the <CodeContentPlaceHolder>87\</CodeContentPlaceHolder> element. The <CodeContentPlaceHolder>88\</CodeContentPlaceHolder> element determines what the installation should do in response to an exit code from a package. <CodeContentPlaceHolder>89\</CodeContentPlaceHolder> contains no child elements, and has the following attributes.  
  
|Attribute|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Required. The exit code value to which this <CodeContentPlaceHolder>91\</CodeContentPlaceHolder> element applies.|  
|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|Required. How the installation should react to this exit code. The following list shows the valid values:\<br />\<br /> <CodeContentPlaceHolder>93\</CodeContentPlaceHolder>. Flags the package as successfully installed.\<br />\<br /> <CodeContentPlaceHolder>94\</CodeContentPlaceHolder>. Flags the package as successfully installed, and instructs the system to restart.\<br />\<br /> <CodeContentPlaceHolder>95\</CodeContentPlaceHolder>. Flags the package as failed.\<br />\<br /> <CodeContentPlaceHolder>96\</CodeContentPlaceHolder>. Flags the package as failed, and instructs the system to restart.|  
|<CodeContentPlaceHolder>97\</CodeContentPlaceHolder>|Optional. The value to display to the user in response to this exit code.|  
|<CodeContentPlaceHolder>98\</CodeContentPlaceHolder>|Optional. Determines whether to use the system-provided error message corresponding to the exit code, or use the value provided in <CodeContentPlaceHolder>99\</CodeContentPlaceHolder>. Valid values are <CodeContentPlaceHolder>100\</CodeContentPlaceHolder>, which means to use the system-provided error, and <CodeContentPlaceHolder>101\</CodeContentPlaceHolder>, which means to use the string provided by <CodeContentPlaceHolder>102\</CodeContentPlaceHolder>. The default is <CodeContentPlaceHolder>103\</CodeContentPlaceHolder>. If this property is <CodeContentPlaceHolder>104\</CodeContentPlaceHolder>, but <CodeContentPlaceHolder>105\</CodeContentPlaceHolder> is not set, the system-provided error will be used.|  
  
## Example  
 The following code example defines commands for installing the .NET Framework 2.0.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 [Product and Package Schema Reference](../vs140/product-and-package-schema-reference.md)   
 [\<InstallChecks> Element (ClickOnce BootStrapper)](../vs140/-installchecks--element--bootstrapper-.md)