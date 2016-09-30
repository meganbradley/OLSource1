---
title: "Registering a Project Type"
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
  - "projects [Visual Studio SDK], new project registry entries"
  - "registry, new project types"
  - "registration, new project types"
ms.assetid: dfc0e231-6b4e-447d-9d64-0e66dea3394a
caps.latest.revision: 25
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Registering a Project Type
When you create a new project type, you must create registry entries that enable [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] to recognize and work with your project type. You typically create these registry entries by using a registry script (.rgs) file.  
  
 In the example below, the statements from the registry provide default paths and data where applicable, followed by a table that contains entries from the registry script for each statement. The tables provide the script entries and additional information about the statements.  
  
> [!NOTE]
>  The following registry information is intended to be an example of the type and purposes of the entries in the registry scripts you will be writing to register your project type. Your actual entries and their uses might vary based on the specific requirements of your project type. You should review the samples available to find one that closely resembles the type of project you are developing, and then review the registry script for that sample.  
  
 The following examples are from HKEY_CLASSES_ROOT.  
  
## Example  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|Name and description of the project type files that have the extension .figp.|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|Content type for the project files.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>||  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Default icon used for project of this type. The %MODULE% statement is completed in the registry to the default location of the project type DLL.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Default application in which this project type will be opened.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Default command that will be run when a project of this type is opened.|  
  
 The following examples are from HKEY_LOCAL_MACHINE and are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\99.0Exp\Packages].  
  
## Example  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>20\</CodeContentPlaceHolder> (Default)|REG_SZ|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Localizable name of this registered VSPackage (project type).|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Path of the project type DLL. The IDE loads this DLL and passes the VSPackage CLSID to <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> to get \<xref:Microsoft.VisualStudio.OLE.Interop.IClassFactory*> to construct the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage*> object.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>26\</CodeContentPlaceHolder>|Name of the company that developed the project type.|  
|<CodeContentPlaceHolder>27\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>28\</CodeContentPlaceHolder>|Name for the project type.|  
|<CodeContentPlaceHolder>29\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>30\</CodeContentPlaceHolder>|Version number of the project type release.|  
|<CodeContentPlaceHolder>31\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>32\</CodeContentPlaceHolder>|Edition of the VSPackage being registered.|  
|<CodeContentPlaceHolder>33\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>34\</CodeContentPlaceHolder>|The package load key for the project VSPackage. The key is validated when a project is loaded after the environment has started.|  
|<CodeContentPlaceHolder>35\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>36\</CodeContentPlaceHolder>|File name of the satellite DLL that contains localized resources for the project type.|  
|<CodeContentPlaceHolder>37\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>38\</CodeContentPlaceHolder>|Path of the satellite DLL.|  
|<CodeContentPlaceHolder>39\</CodeContentPlaceHolder>|REG_SZ|See statement for value.|Determines the text string returned for this automation event.|  
|<CodeContentPlaceHolder>40\</CodeContentPlaceHolder>|REG_SZ|See statement for value.|Determines the text string returned for this automation event.|  
  
 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].  
  
## Example  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>41\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>42\</CodeContentPlaceHolder>|Default name of projects of this type.|  
|<CodeContentPlaceHolder>43\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>44\</CodeContentPlaceHolder>|Resource ID of the name to be retrieved from the satellite DLL registered under Packages.|  
|<CodeContentPlaceHolder>45\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>46\</CodeContentPlaceHolder>|Class ID of the VSPackage registered under Packages.|  
|<CodeContentPlaceHolder>47\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>48\</CodeContentPlaceHolder>|Default path of Project Template files. These are the files displayed by the New Project template.|  
|<CodeContentPlaceHolder>49\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>50\</CodeContentPlaceHolder>|Default path of Project Item Template files. These are the files displayed by the Add New Item template.|  
|<CodeContentPlaceHolder>51\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>52\</CodeContentPlaceHolder>|Enables the IDE to implement the **Open** dialog box.|  
|<CodeContentPlaceHolder>53\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>54\</CodeContentPlaceHolder>|Used by the IDE to determine whether the project being opened is handled by this project type (project factory). The format for more than one entry is a semicolon delimited list. For example "vdproj;vdp".|  
|<CodeContentPlaceHolder>55\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>56\</CodeContentPlaceHolder>|Used by the IDE as the default file name extension for the Save As operation.|  
|<CodeContentPlaceHolder>57\</CodeContentPlaceHolder>|REG_DWORD|Various, see statements and comments following table.|These settings are used to set the various filters for displaying files in UI dialog boxes.|  
|<CodeContentPlaceHolder>58\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>59\</CodeContentPlaceHolder>|Resource ID for Add Item templates.|  
|<CodeContentPlaceHolder>60\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>61\</CodeContentPlaceHolder>|Path of the project items displayed in the dialog box for the **Add New Item** template.|  
|<CodeContentPlaceHolder>62\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>63\</CodeContentPlaceHolder>|Determines the sort order in the tree node of files displayed in the **Add New Item** dialog box.|  
  
 The following table shows the Filters options available in the previous code segment.  
  
|Filter option|Description|  
|-------------------|-----------------|  
|<CodeContentPlaceHolder>64\</CodeContentPlaceHolder>|Indicates that the filter is one of the common filters in the **Find in Files** dialog box. The common filters are listed in the filter list before the filters not marked as common.|  
|<CodeContentPlaceHolder>65\</CodeContentPlaceHolder>|Indicates that the filter is one of the common filters in the **Open File** dialog box. The common filters are listed in the filter list before the filters not marked as common.|  
|<CodeContentPlaceHolder>66\</CodeContentPlaceHolder>|Indicates that the filter will be one of the filters in the **Find in Files** dialog box and will be listed after the common filters.|  
|<CodeContentPlaceHolder>67\</CodeContentPlaceHolder>|Indicates that the filter will not be used in the **Open File** dialog box.|  
|<CodeContentPlaceHolder>68\</CodeContentPlaceHolder>|Indicates that the filter will not be used in the Add **Existing Item** dialog box.|  
  
 By default, if a filter does not have one or more of these flags set, the filter is used in the **Add Existing Item** dialog box and the **Open File** dialog box after the common filters are listed. The filter is not used in the **Find in Files** dialog box.  
  
 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].  
  
## Example  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>69\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>70\</CodeContentPlaceHolder>|Resource ID for New Project templates.|  
|<CodeContentPlaceHolder>71\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>72\</CodeContentPlaceHolder>|Default path for projects of the registered project type.|  
|<CodeContentPlaceHolder>73\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>74\</CodeContentPlaceHolder>|Sets sort order of projects displayed in the New Projects wizard dialog box.|  
|<CodeContentPlaceHolder>75\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>76\</CodeContentPlaceHolder>|0 indicates that projects of this type are displayed only in the New Project dialog box.|  
  
 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].  
  
## Example  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>77\</CodeContentPlaceHolder>|REG_SZ|None|Default value that indicates that the following entries are for the Miscellaneous Files projects entries.|  
|<CodeContentPlaceHolder>78\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>79\</CodeContentPlaceHolder>|Resource ID value for the Add New Items template files.|  
|<CodeContentPlaceHolder>80\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>81\</CodeContentPlaceHolder>|Default path of the items that will be displayed in the **Add New Item** dialog box.|  
|<CodeContentPlaceHolder>82\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>83\</CodeContentPlaceHolder>|Establishes sort order for display in the tree node of the **Add New Item** dialog box.|  
  
 The following example is located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Menus].  
  
## Example  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
 The menu entry points the IDE to the resource used to retrieve the menu information. When this data has been merged into the menu database, the same key will be added in the MenusMerged section of the registry. The VSPackage should not modify anything under the MenusMerged section directly. In the Data field in the following table, there are three comma-separated-fields. The first field identifies a full path of a menu resource file:  
  
-   If the first field is omitted, the menu resource is loaded from the satellite DLL identified by the VSPackage GUID.  
  
 The second field identifies a menu resource ID of the type CTMENU:  
  
-   If the resource ID is specified, and the file path is supplied by the first parameter, a menu resource is loaded from the full file path.  
  
-   If the resource ID is provided, but the file path is not, the menu resource is loaded from the satellite DLL.  
  
-   If the full file path is provided and the resource ID omitted, the file to be loaded is expected to be a CTO file.  
  
 The last field identifies the version number for the CTMENU resource. You can merge the menu again by changing the version number.  
  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|%CLSID_Package%|REG_SZ|<CodeContentPlaceHolder>84\</CodeContentPlaceHolder>|The resource to retrieve the menu information.|  
  
 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\NewProjectTemplates].  
  
<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>85\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>86\</CodeContentPlaceHolder>|Resource ID value for the Figures Project New Project templates.|  
|<CodeContentPlaceHolder>87\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>88\</CodeContentPlaceHolder>|Default path of the New Projects directory. Items in this directory will be displayed in the **New Project wizard** dialog box.|  
|<CodeContentPlaceHolder>89\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>90\</CodeContentPlaceHolder>|Establishes the order in which projects will be displayed in the tree node of the **New Project** dialog box.|  
|<CodeContentPlaceHolder>91\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>92\</CodeContentPlaceHolder>|0 indicates that projects of this type are displayed only in the **New Project** dialog box.|  
  
 The following example is located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\InstalledProducts].  
  
<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|<CodeContentPlaceHolder>93\</CodeContentPlaceHolder>|REG_SZ|<CodeContentPlaceHolder>94\</CodeContentPlaceHolder>|Class ID of the registered VSPackage.|  
|<CodeContentPlaceHolder>95\</CodeContentPlaceHolder>|REG_DWORD|<CodeContentPlaceHolder>96\</CodeContentPlaceHolder>|1 indicates that the UI will be used to interact with this project. 0 indicates that there is no UI interface.|  
  
 The.vsz files that control new project types frequently contain a RELATIVE_PATH entry. This path is relative to path specified under \ProductDir entry of the project type in the following Setup key:  
  
 HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\7.0Exp\Setup  
  
 For example, the Enterprise Frameworks project templates add the following registry entries:  
  
 HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\7.0Exp\Setup\EF\ProductDir = C:\Program Files\Microsoft Visual Studio\EnterpriseFrameworks\  
  
 That means if you include a PROJECT_TYPE=EF entry in the .vsz file, the environment finds your .vsz files in the ProductDir directory specified previously.  
  
## See Also  
 [Checklist: Creating New Project Types](../vs140/checklist--creating-new-project-types.md)   
 [Elements of a Project Model](../vs140/elements-of-a-project-model.md)   
 [Creating Project Instances By Using Project Factories](../vs140/creating-project-instances-by-using-project-factories.md)