---
title: "Verifying Subtypes of a Project at Run Time"
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
  - project subtypes
  - check subtypes
ms.assetid: b87780ec-36a3-4e9a-9ee2-7abdc26db739
caps.latest.revision: 15
translation.priority.mt: 
  - de-de
  - ja-jp
---
# Verifying Subtypes of a Project at Run Time
A VSPackage that depends on a custom project subtype should include logic to look for that subtype so that it can fail gracefully if the subtype is not present. The following procedure shows how to verify the presence of a specified subtype.  
  
### To verify the presence of a subtype  
  
1.  Obtain the project hierarchy from the project and solution objects as a <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy?qualifyHint=False> object by adding the following code to your VSPackage.  
  
    ```  
    EnvDTE.DTE dte;  
    dte = (EnvDTE.DTE)Package.GetGlobalService(typeof(EnvDTE.DTE));  
  
    EnvDTE.Project project;  
    project = dte.Solution.Projects.Item(1);  
  
    IVsSolution solution;  
    solution = (IVsSolution)Package.GetGlobalService(typeof(SVsSolution));  
  
    IVsHierarchy hierarchy;  
    hierarchy = solution.GetProjectOfUniqueName(project.UniqueName);  
  
    ```  
  
2.  Cast the hierarchy to the <xref:Microsoft.VisualStudio.Shell.Flavor.IVsAggregatableProjectCorrected?qualifyHint=False> interface.  
  
    ```  
    IVsAggregatableProjectCorrected AP;  
    AP = hierarchy as IVsAggregatableProjectCorrected;  
  
    ```  
  
3.  Get the list of project type GUIDs by invoking the <xref:Microsoft.VisualStudio.Shell.Flavor.IVsAggregatableProjectCorrected.GetAggregateProjectTypeGuids?qualifyHint=False>.  
  
    ```  
    string projTypeGuids = AP.GetAggregateProjectTypeGuids().ToUpper();  
  
    ```  
  
4.  Check the list for the GUID of the specified subtype.  
  
    ```  
    // Replace the string "MyGUID" with the GUID of the subtype.  
    string guidMySubtype = "MyGUID";  
    if (projTypeGuids.IndexOf(guidMySubtype) > 0)  
    {  
        // The specified subtype is present.  
    }  
    ```  
  
## See Also  
 [Project Subtypes](../vs140/project-subtypes.md)   
 [Project Subtypes Design](../vs140/project-subtypes-design.md)   
 [Properties and Methods Extended by Project Subtypes](../vs140/properties-and-methods-extended-by-project-subtypes.md)