---
title: "Context Parameters"
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
  - "wizards, context parameters"
  - "context parameters"
ms.assetid: 1a062dcb-8a8f-40dd-bea9-3d10f9448966
caps.latest.revision: 17
ms.author: "gregvanl"
translation.priority.mt: 
  - "de-de"
  - "ja-jp"
---
# Context Parameters
In the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] integrated development environment (IDE), you can add wizards to the **New Project**, **Add New Item**, or **Add Sub Project** dialog boxes. The added wizards are available on the **File** menu or by right-clicking a project in **Solution Explorer**. The IDE passes context parameters to the implementation of the wizard. The context parameters define the state of the project when the IDE calls the wizard.  
  
 The IDE starts wizards by setting the \<xref:Microsoft.VisualStudio.Shell.Interop.VSADDITEMOPERATION.VSADDITEMOP_RUNWIZARD*> flag in the IDE's call to the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.AddItem*> method for the project. When set, the project must cause the <CodeContentPlaceHolder>0\</CodeContentPlaceHolder> method to be executed by using the registered wizard name or GUID and other context parameters that the IDE passes to it.  
  
## Context Parameters for New Project  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>|Registered wizard type (\<xref:EnvDTE.Constants.vsWizardNewProject*>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D0-4999-11D1-B6D1-00A0C90F2744}.|  
|<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>|A string that is the unique [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project name.|  
|<CodeContentPlaceHolder>3\</CodeContentPlaceHolder>|Local location of working project files.|  
|<CodeContentPlaceHolder>4\</CodeContentPlaceHolder>|Directory path of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is installation.|  
|<CodeContentPlaceHolder>5\</CodeContentPlaceHolder>|Boolean flag which indicates that the project should close open solutions.|  
|<CodeContentPlaceHolder>6\</CodeContentPlaceHolder>|Name of the solution file without the directory portion or the .sln extension. The .suo file name is also created by using <CodeContentPlaceHolder>7\</CodeContentPlaceHolder>. When this argument is not an empty string, the wizard uses \<xref:EnvDTE._Solution.Create*> before adding the project with \<xref:EnvDTE._Solution.AddFromTemplate*>. If this name is an empty string, use \<xref:EnvDTE._Solution.AddFromTemplate*> without calling \<xref:EnvDTE._Solution.Create*>.|  
|<CodeContentPlaceHolder>8\</CodeContentPlaceHolder>|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (<CodeContentPlaceHolder>9\</CodeContentPlaceHolder>).|  
  
## Context Parameters for Add New Item  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>10\</CodeContentPlaceHolder>|Registered wizard type (\<xref:EnvDTE.Constants.vsWizardAddItem*>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D1-4999-11D1-B6D1-00A0C90F2744}.|  
|<CodeContentPlaceHolder>11\</CodeContentPlaceHolder>|A string that is the unique [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project name.|  
|<CodeContentPlaceHolder>12\</CodeContentPlaceHolder>|Local location that contains working project files.|  
|<CodeContentPlaceHolder>13\</CodeContentPlaceHolder>|Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the .vsdir file. The name can be a null value.|  
|<CodeContentPlaceHolder>14\</CodeContentPlaceHolder>|Directory path of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is installation.|  
|<CodeContentPlaceHolder>15\</CodeContentPlaceHolder>|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (<CodeContentPlaceHolder>16\</CodeContentPlaceHolder>).|  
  
## Context Parameters for Add Sub Project  
  
|Parameter|Description|  
|---------------|-----------------|  
|<CodeContentPlaceHolder>17\</CodeContentPlaceHolder>|Registered wizard type (\<xref:EnvDTE.Constants.vsWizardAddSubProject*>) or the GUID that indicates the type of wizard. In the [!INCLUDE[vsipsdk](../vs140/includes/vsipsdk_md.md)] implementation, the GUID for the wizard is {0F90E1D2-4999-11D1-B6D1-00A0C90F2744}.|  
|<CodeContentPlaceHolder>18\</CodeContentPlaceHolder>|A string that is the unique [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] project name.|  
|<CodeContentPlaceHolder>19\</CodeContentPlaceHolder>|Pointer to the <CodeContentPlaceHolder>20\</CodeContentPlaceHolder> collection on which the wizard operates. This pointer is passed to the wizard based on the project hierarchy selection. A user typically selects a folder in which to put the item and then calls the project's **Add Item** dialog box.|  
|<CodeContentPlaceHolder>21\</CodeContentPlaceHolder>|Local location of working project files.|  
|<CodeContentPlaceHolder>22\</CodeContentPlaceHolder>|Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the .vsdir file. The name can be a null value.|  
|<CodeContentPlaceHolder>23\</CodeContentPlaceHolder>|Directory path of the [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] is installation.|  
|<CodeContentPlaceHolder>24\</CodeContentPlaceHolder>|Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (<CodeContentPlaceHolder>25\</CodeContentPlaceHolder>).|  
  
## See Also  
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject*>   
 \<xref:Microsoft.VisualStudio.Shell.Interop.IVsProject2*>   
 [Custom Parameters](../vs140/custom-parameters.md)   
 [Wizards](../vs140/wizards.md)   
 [Wizard (.Vsz) File](../vs140/wizard--.vsz--file.md)   
 [Context Parameters for Launching Wizards](assetId:///051a10f4-9e45-4604-b344-123044f33a24)