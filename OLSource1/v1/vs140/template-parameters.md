---
title: "Template Parameters"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio templates, parameters"
  - "template parameters [Visual Studio]"
  - "project templates, parameters"
  - "item templates, parameters"
ms.assetid: 1b567143-08c6-4d7a-b484-49f0671754fe
caps.latest.revision: 28
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Template Parameters
By using parameters in your templates, you can replace the values of key portions of the template, such as class names and namespaces, when the template is instantiated. These parameters are replaced by the template wizard that runs in the background when a user clicks **OK** in the **New Project** or **Add New Item** dialog boxes.  
  
## Declaring and Enabling Template Parameters  
 Template parameters are declared in the format $*parameter*$. For example:  
  
-   $safeprojectname$  
  
-   $guid1$  
  
-   $guid5$  
  
#### To enable parameter substitution in templates  
  
1.  In the .vstemplate file of the template, locate the <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> element that corresponds to the item for which you want to enable parameter replacement.  
  
2.  Set the <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> attribute of the <CodeContentPlaceHolder>6\</CodeContentPlaceHolder> element to <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>.  
  
3.  In the code file for the project item, include parameters where appropriate. For example, the following parameter specifies that the safe project name be used for the namespace in a file:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
## Reserved Template Parameters  
 The following table lists the reserved template parameters that can be used by any template.  
  
> [!NOTE]
>  Template parameters are case-sensitive.  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Current version of the common language runtime (CLR).|  
|<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>|A GUID used to replace the project GUID in a project file. You can specify up to 10 unique GUIDs (for example, <CodeContentPlaceHolder>10\</CodeContentPlaceHolder>.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|The name provided by the user in the **Add New Item** dialog box.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|The current computer name (for example, Computer01).|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|The name provided by the user in the **New Project** dialog box.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|The registry key value from HKLM\Software\Microsoft\Windows NT\CurrentVersion\RegisteredOrganization.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|The root namespace of the current project. This parameter applies only to item templates.|  
|<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>|The name provided by the user in the **Add New Item** dialog box, with all unsafe characters and spaces removed.|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|The name provided by the user in the **New Project** dialog box, with all unsafe characters and spaces removed.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|The current time in the format DD/MM/YYYY 00:00:00.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|The name of the solution. When "create solution directory" is checked, <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> has the solution name. When "create solution directory" is not checked, <CodeContentPlaceHolder>21\</CodeContentPlaceHolder> is blank.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|The current user domain.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|The current user name.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|The name of the current Web site. This parameter is used in the Web form template to guarantee unique class names. If the Web site is at the root directory of the Web server, this template parameter resolves to the root directory of the Web Server.|  
|<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>|The current year in the format YYYY.|  
  
## Custom Template Parameters  
 You can specify your own template parameters and values, in addition to the default reserved template parameters that are used during parameter replacement.For more information, see [CustomParameters Element (Visual Studio Templates)](../vs140/customparameters-element--visual-studio-templates-.md)  
  
## Example: Replacing Files Names  
 You can specify variable file names for project items by using a parameter with the <CodeContentPlaceHolder>26\</CodeContentPlaceHolder> attribute. For example, you could specify that the .exe file use the project name, specified by <CodeContentPlaceHolder>27\</CodeContentPlaceHolder>, as the file name.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Example: Using the Project Name for the Namespace Name  
 To use the project name for the namespace in a Visual C# class file, Class1.cs, use the following syntax:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
 In the .vstemplate file for the project template, include the following XML when you reference the file Class1.cs:  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
## See Also  
 [Customizing Project and Item Templates](../vs140/customizing-project-and-item-templates.md)