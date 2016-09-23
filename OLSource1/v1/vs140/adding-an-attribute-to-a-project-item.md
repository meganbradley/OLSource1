---
title: "Adding an Attribute to a Project Item"
ms.custom: na
ms.date: 09/22/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
helpviewer_keywords: 
  - attributes [Visual Studio], adding to a project item
ms.assetid: 404a71d5-cce5-44e7-9eaf-d747c794fedb
caps.latest.revision: 8
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Adding an Attribute to a Project Item
The methods <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.GetItemAttribute?qualifyHint=False> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute?qualifyHint=False> get and set the value of the attributes of a project item. SetItemAttribute creates the attribute if it does not already exist, adding it to the project item metadata.  
  
## Adding an attribute to a project item  
  
#### To add an attribute to a project item  
  
-   The following code uses the <xref:EnvDTE.DTE?qualifyHint=False> automation object and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetItemAttribute?qualifyHint=False> method to add an attribute to a project item. The project item ID is obtained from the project item name "program.cs". The attribute "MyAttribute" is added to this project item and given the value "MyValue".  
  
    ```  
    EnvDTE.DTE dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));  
    EnvDTE.Project project = dte.Solution.Projects.Item(1);  
  
    string uniqueName = project.UniqueName;  
    IVsSolution solution =     (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));  
    IVsHierarchy hierarchy;  
    solution.GetProjectOfUniqueName(uniqueName, out hierarchy);  
    IVsBuildPropertyStorage buildPropertyStorage = hierarchy as IVsBuildPropertyStorage;  
    if (buildPropertyStorage != null)  
    {  
        uint itemId;  
        string fullPath =         (string)project.ProjectItems.Item("Program.cs").Properties.Item("FullPath").Value;  
        hierarchy.ParseCanonicalName(fullPath, out itemId);  
        buildPropertyStorage.SetItemAttribute(  
            itemId, "MyAttribute", "MyValue");  
    }  
  
    ```  
  
## See Also  
 [Persisting Data in the MSBuild Project File](../vs140/persisting-data-in-the-msbuild-project-file.md)