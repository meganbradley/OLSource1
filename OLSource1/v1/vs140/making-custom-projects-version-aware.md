---
title: "Making Custom Projects Version-Aware"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 5233d3ff-6e89-4401-b449-51b4686becca
caps.latest.revision: 37
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Making Custom Projects Version-Aware
In your custom project system, you can allow projects of that type to load in multiple versions of Visual Studio. You can also prevent projects of that type from loading in an earlier version of Visual Studio. You can also enable that project to identify itself to a later version in case the project requires repair, conversion, or deprecation.  
  
## Allowing Projects to Load in Multiple Versions  
 You can modify most projects that were created in [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)] with SP1 or later to work in multiple versions.  
  
 Before a project is loaded, Visual Studio calls the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory4.UpgradeProject_CheckOnly*> method to determine whether the project can be upgraded. If the project can be upgraded, the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> method sets a flag that causes a later call to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject*> method to upgrade the project. Because incompatible projects can’t be upgraded, <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> must first check for project compatibility, as described in the earlier section.  
  
 You, as the author of a project system, implement <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> (from the <CodeContentPlaceHolder>7\</CodeContentPlaceHolder> interface) to provide users of your project system with an upgrade check. When users open a project, this method is called to determine whether a project must be repaired before it is loaded. The possible upgrade requirements are enumerated in <CodeContentPlaceHolder>8\</CodeContentPlaceHolder>, and they include the following possibilities:  
  
1.  <CodeContentPlaceHolder>9\</CodeContentPlaceHolder>: Requires no repair.  
  
2.  <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>: Makes the project compatible with an earlier version without the issues that you might have encounter with the previous versions of the product.  
  
3.  <CodeContentPlaceHolder>11\</CodeContentPlaceHolder>: Makes the project backwards-compatible but with some risk of the issues that you might have encountered with previous versions of the product. For example, the project won’t be compatible if it depended on different SDK versions.  
  
4.  <CodeContentPlaceHolder>12\</CodeContentPlaceHolder>: Makes the project incompatible with an earlier version.  
  
5.  <CodeContentPlaceHolder>13\</CodeContentPlaceHolder>: Indicates that the current version doesn’t support this project.  
  
6.  <CodeContentPlaceHolder>14\</CodeContentPlaceHolder>: Indicates that this project is no longer supported.  
  
> [!NOTE]
>  To avoid confusion, don’t combine upgrade flags when you set them. For example, don't create an ambiguous upgrade status such as <CodeContentPlaceHolder>15\</CodeContentPlaceHolder>.  
  
 Project flavors may implement the function <CodeContentPlaceHolder>16\</CodeContentPlaceHolder> from the <CodeContentPlaceHolder>17\</CodeContentPlaceHolder> interface. To make this function work, the <CodeContentPlaceHolder>18\</CodeContentPlaceHolder> implementation mentioned earlier must call it. This call is already implemented in the Visual Basic or C# base project system. The effect of this function enables project flavors to also determine the upgrade requirements of a project, in addition to what the base project system has determined. The compatibility dialog box shows the most severe of the two requirements.  
  
 When Visual Studio performs an upgrade check, it provides a logger instead of a NULL value as in previous versions of Visual Studio. The logger enables project systems and flavors to provide additional information that can help you understand the nature of the changes that are needed to make your older projects load properly. We recommend that you use the logger to provide more information instead of using dialog boxes. For more information, see [The Upgrade Logger](../vs140/making-custom-projects-version-aware.md#BKMK_UpgradeLogger) later in this topic.  
  
 For Managed implementations, the project upgrade interfaces are available in the Microsoft.VisualStudio.Shell.Interop.11.0.dll interop assembly.  
  
 The <CodeContentPlaceHolder>19\</CodeContentPlaceHolder> method can determine whether the changes it makes would prevent the project from loading in an previous version of Visual Studio. If so, the method marks the project as incompatible. To understand how a project is marked as incompatible, see [Marking a Project as Incompatible](../vs140/making-custom-projects-version-aware.md#BKMK_Incompat) earlier in this topic. We recommend that, after this dialog box appears, you mark the project as incompatible by calling the method <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> directly, instead of first calling the <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> method because the dialog box doesn’t need to appear twice.  
  
 Here is an example to help summarize the compatibility user experience. If a project was created in an earlier version, and the current version determines that an upgrade is required, Visual Studio displays a dialog box to ask the user for permission to make the changes. If the user agrees, the project is modified and then loaded. If the solution is then closed and reopened in the earlier version, the one-way-upgraded project will be incompatible and not loaded. If the project had only required a repair (instead of an upgrade), the repaired project will still open in both versions.  
  
##  \<a name="BKMK_Incompat">\</a> Marking a Project as Incompatible  
 You can mark a project as incompatible with earlier versions of Visual Studio.  For example, suppose you create a project that uses a .NET Framework 4.5 feature. Because this project can’t be built in [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)], you can mark it as incompatible to prevent that version from trying to load it.  
  
 The component that adds the incompatible feature is responsible for marking the project as incompatible. The component must have access to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy*> interface that represents the projects of interest.  
  
#### To mark a project as incompatible  
  
1.  In the component, get an <CodeContentPlaceHolder>22\</CodeContentPlaceHolder> interface from the global service SVsSolution.  
  
     For more information, see \<xref:Microsoft.VisualStudio.Shell.Interop.SVsSolution*>.  
  
2.  In the component, call <CodeContentPlaceHolder>23\</CodeContentPlaceHolder>, and pass it an array of <CodeContentPlaceHolder>24\</CodeContentPlaceHolder> interfaces that represent the projects of interest.  
  
     This method has the following signature:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
     If you implement this code, a project compatibility dialog box will appear. The dialog box will asks the user for permission to mark all specified projects as incompatible. If the user agrees, <CodeContentPlaceHolder>25\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>26\</CodeContentPlaceHolder>; otherwise, <CodeContentPlaceHolder>27\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>28\</CodeContentPlaceHolder>.  
  
    > [!WARNING]
    >  In most common scenarios, the <CodeContentPlaceHolder>29\</CodeContentPlaceHolder> array will contain only one item.  
  
3.  If <CodeContentPlaceHolder>30\</CodeContentPlaceHolder> returns <CodeContentPlaceHolder>31\</CodeContentPlaceHolder>, the component makes or accepts the changes that break compatibility.  
  
4.  In your component, call the <CodeContentPlaceHolder>32\</CodeContentPlaceHolder> method for each project that you want to mark as incompatible. The component can set the value of the parameter <CodeContentPlaceHolder>33\</CodeContentPlaceHolder> to a specific minimum version instead of having Visual Studio look up the current version string in the registry. This approach minimizes the risk of the component inadvertently setting a higher value in the future, based on what is in the registry at that time. If that higher value were set, Visual Studio couldn't open the project.  
  
     This method has the following signature:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
     If the component sets <CodeContentPlaceHolder>34\</CodeContentPlaceHolder> to NULL, the <CodeContentPlaceHolder>35\</CodeContentPlaceHolder> method calls the <CodeContentPlaceHolder>36\</CodeContentPlaceHolder> method to obtain a string that represents the current version of Visual Studio.  
  
     This method has the following signature:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
     The BreakAssetCompatibility method then calls the <CodeContentPlaceHolder>37\</CodeContentPlaceHolder> method to set the root <CodeContentPlaceHolder>38\</CodeContentPlaceHolder> property to the value of the version string that you obtained in the previous step.  
  
     For more information, see \<xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.SetProperty*>.  
  
> [!IMPORTANT]
>  You must implement the <CodeContentPlaceHolder>39\</CodeContentPlaceHolder> property to mark a project as compatible or incompatible. For example, if the project system uses an MSBuild project file, add to the project file a <CodeContentPlaceHolder>40\</CodeContentPlaceHolder> build property that has a value equal to the corresponding <CodeContentPlaceHolder>41\</CodeContentPlaceHolder> property value.  
  
## Detecting Whether a Project is Incompatible  
 A project that is incompatible with the current version of Visual Studio must be kept from loading. Furthermore, a project that is incompatible can’t be upgraded or repaired. Therefore, a project must be checked for compatibility twice: first, when it is being considered for upgrade or repair, and second, before it is loaded.  
  
 To enable the detection of project incompatibility, you must implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory4.UpgradeProject_CheckOnly*> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject*> methods. If a project is incompatible, <CodeContentPlaceHolder>42\</CodeContentPlaceHolder> must return the success code <CodeContentPlaceHolder>43\</CodeContentPlaceHolder>, and <CodeContentPlaceHolder>44\</CodeContentPlaceHolder> must return the error code <CodeContentPlaceHolder>45\</CodeContentPlaceHolder>. For flavored projects, you must implement <CodeContentPlaceHolder>46\</CodeContentPlaceHolder> instead of <CodeContentPlaceHolder>47\</CodeContentPlaceHolder>.  
  
 A project system is referred to as flavored if it has a web, Office (VSTO), Silverlight, or other project type built on top of it. Older project systems that already implement <CodeContentPlaceHolder>48\</CodeContentPlaceHolder> and flavored project systems that already implement <CodeContentPlaceHolder>49\</CodeContentPlaceHolder> continue to be supported. The older version of <CodeContentPlaceHolder>50\</CodeContentPlaceHolder> has the following implementation signature:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
 If this method sets <CodeContentPlaceHolder>51\</CodeContentPlaceHolder> to TRUE and returns <CodeContentPlaceHolder>52\</CodeContentPlaceHolder>, the result is treated as “Upgrade” and as though the method set an upgrade flag to the value <CodeContentPlaceHolder>53\</CodeContentPlaceHolder>, which is described later in this topic. The following return values are supported by using this older method but only when <CodeContentPlaceHolder>54\</CodeContentPlaceHolder> is set to TRUE:  
  
1.  <CodeContentPlaceHolder>55\</CodeContentPlaceHolder>. This return value translates the <CodeContentPlaceHolder>56\</CodeContentPlaceHolder> value to TRUE as equivalent to <CodeContentPlaceHolder>57\</CodeContentPlaceHolder>, which is described later in this topic.  
  
2.  <CodeContentPlaceHolder>58\</CodeContentPlaceHolder>. This return value translates the <CodeContentPlaceHolder>59\</CodeContentPlaceHolder> value to TRUE as equivalent to <CodeContentPlaceHolder>60\</CodeContentPlaceHolder>, which is described later in this topic  
  
3.  <CodeContentPlaceHolder>61\</CodeContentPlaceHolder>. This return value translates the <CodeContentPlaceHolder>62\</CodeContentPlaceHolder> value to TRUE as equivalent to <CodeContentPlaceHolder>63\</CodeContentPlaceHolder>, which is described later in this topic.  
  
 The new implementations in <CodeContentPlaceHolder>64\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>65\</CodeContentPlaceHolder> enable specifying the migration type more precisely.  
  
> [!NOTE]
>  You can cache the result of the compatibility check by the <CodeContentPlaceHolder>66\</CodeContentPlaceHolder> method so that it can also be used by the subsequent call to <CodeContentPlaceHolder>67\</CodeContentPlaceHolder>.  
  
 For example, if the <CodeContentPlaceHolder>68\</CodeContentPlaceHolder> and <CodeContentPlaceHolder>69\</CodeContentPlaceHolder> methods that are written for a [!INCLUDE[vs_dev10_long](../vs140/includes/vs_dev10_long_md.md)] with SP1 project system examine a project file and find that the <CodeContentPlaceHolder>70\</CodeContentPlaceHolder> build property is "11.0", Visual Studio 2010 with SP1 won’t load the project. In addition, **Solution Navigator** would indicate that the project is “incompatible” and won’t load it.  
  
##  \<a name="BKMK_UpgradeLogger">\</a> The Upgrade Logger  
 The call to <CodeContentPlaceHolder>71\</CodeContentPlaceHolder> contains an <CodeContentPlaceHolder>72\</CodeContentPlaceHolder> logger, which project systems and flavors should use to provide detailed upgrade tracing for troubleshooting. If a warning or an error is logged, Visual Studio shows the upgrade report.  
  
 When you write to the upgrade logger, consider the following guidelines:  
  
-   Visual Studio will call Flush after all projects have finished upgrading. Don’t call it in your project system.  
  
-   The LogMessage function has the following ErrorLevels:  
  
    -   0 is for any information that you’d like to trace.  
  
    -   1 is for a warning.  
  
    -   2 is for an error  
  
    -   3 is for the Report formatter. When your project is upgraded, log the word “Converted” once, and don’t localize the word.  
  
-   If a project doesn’t require any repair or upgrade, Visual Studio will generate the log file only if the project system had logged a warning or an error during UpgradeProject_CheckOnly or UpgradeProjectFlavor_CheckOnly methods.