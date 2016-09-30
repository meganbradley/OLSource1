---
title: "Saving Data in Project Files"
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
  - "data [Visual Studio], saving in project files"
  - "project files"
  - "project files, saving data"
ms.assetid: a3d4b15b-a91e-41ba-b235-e62632d11bc5
caps.latest.revision: 32
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Saving Data in Project Files
A project subtype can save and retrieve subtype-specific data in the project file. The Managed Package Framework (MPF) provides two interfaces to accomplish this task:  
  
-   The \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage*> interface allows to access property values from the **MSBuild** section of the project file. The methods provided by \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage*> can be called by any user whenever the user needs to load or save build related data.  
  
-   The \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment*> is used to persist non-build related data in free-form XML. The methods provided by \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment*> are called by [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] whenever [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] needs to persist non-build related data in the project file.  
  
 For more information on how to persist build and non-build related data, see [Persisting Data in the MSBuild Project File](../vs140/persisting-data-in-the-msbuild-project-file.md).  
  
## Saving and retrieving build related data  
  
#### To save a build related data in the project file  
  
-   Call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.SetPropertyValue*> method to save a full path of the project file.  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
#### To retrieve build related data from the project file  
  
-   Call the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsBuildPropertyStorage.GetPropertyValue*> method to retrieve a full path of the project file.  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## Saving and retrieving non-build related data  
  
#### To save non-build related data in the project file  
  
1.  Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment.IsFragmentDirty*> method to determine whether an XML fragment has changed since it was last saved to its current file.  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
2.  Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment.Save*> method to save the XML data in the project file.  
  
<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>  
#### To retrieve non-build related data in the project file  
  
1.  Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment.InitNew*> method to initialize the project extension properties and other build-independent data. This method is called if there is no XML configuration data present in the project file.  
  
<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>  
2.  Implement the \<xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment.Load*> method to load the XML data from the project file.  
  
<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>  
> [!NOTE]
>  All code examples provided in this topic are parts of a larger example, [Visual Studio Extensibility Samples](../vs140/vssdk-samples.md).  
  
## See Also  
 [Persisting Data in the MSBuild Project File](../vs140/persisting-data-in-the-msbuild-project-file.md)