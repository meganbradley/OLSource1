---
title: "Initialization Sequence of Project Subtypes"
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
  - "project subtypes, initialization sequence"
ms.assetid: f657f8c3-5e68-4308-9971-e81e3099ba29
caps.latest.revision: 19
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Initialization Sequence of Project Subtypes
The environment constructs a project by calling the base project factory implementation of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject*>. The construction of a project subtype starts when the environment determines that the project type GUID list for a project file's extension is not empty. The project file extension and project GUID specify whether the project is a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] or [!INCLUDE[csprcs](../vs140/includes/csprcs_md.md)] project type. For example, the .vbproj extension and {F184B08F-C81C-45F6-A57F-5ABD9991F28F} identify a [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] project.  
  
## Environment's Initialization of Project Subtypes  
 The following procedure details the initialization sequence for a project system aggregated by multiple project subtypes.  
  
1.  The environment calls the base project's \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CreateProject*>, and while the project parses its project file it discovers that the aggregate project type GUIDs list is not <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>. The project discontinues directly creating its project.  
  
2.  The project calls <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> on \<xref:Microsoft.VisualStudio.Shell.Interop.SVsCreateAggregateProject*> service to create a project subtype using the environment's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject*> method. Within this method the environment makes recursive function calls to your implementations of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProjectFactory.PreCreateForOuter*>, <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> and \<xref:Microsoft.VisualStudio.Shell.Interop.IVsAggregatableProject.InitializeForOuter*> methods while it is walking the list of project type GUIDs, starting with the outermost project subtype.  
  
     The following details the initialization steps.  
  
    1.  The environment's implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject*> method calls <CodeContentPlaceHolder>5\</CodeContentPlaceHolder>pOuter<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>pOwner<CodeContentPlaceHolder>7\</CodeContentPlaceHolder>null<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>IUnknown<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>pOuter<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>HrCreateInnerProj<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>pOuter<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>IUnknown<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>HrCreateInnerProj<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>IUnknown<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>pOuter<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>IUnknown<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>HrCreateInnerProj<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>HrCreateInnerProj<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>pOuter<CodeContentPlaceHolder>20\</CodeContentPlaceHolder>IUnknown` for each level of aggregation.  
  
 The following example details the programmatic process in an approximate representation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsCreateAggregateProject.CreateAggregateProject*> method as it is implemented by the environment. The code is just an example; it is not intended to be compiled and all error checking was removed for clarity.  
  
## Example  
  
### Code  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Flavor*>   
 [Project Subtype Overview](../vs140/project-subtypes.md)