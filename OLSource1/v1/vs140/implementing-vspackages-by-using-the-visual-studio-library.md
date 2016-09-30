---
title: "Implementing VSPackages By Using the Visual Studio Library"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio Library, implementing VSPackages"
ms.assetid: 4cbac13f-2a9d-4955-b411-dad79081fdeb
caps.latest.revision: 11
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Implementing VSPackages By Using the Visual Studio Library
The <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> class in the Visual Studio Library provides a minimal implementation of the \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage*> interface. <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> takes care of most of the maintenance methods of \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage*>. Other methods you might need to override to provide a meaningful implementation include:  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetAutomationObject*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.CreateTool*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.ResetDefaults*>  
  
-   \<xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage*>  
  
    > [!NOTE]
    >  The [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] Package Template generates all the code discussed here. You can save time by using the template to generate a VSPackage for you.  
  
 Packages that are implemented by using the Visual Studio Library typically inherit a VSPackage class from ATL's [CComObjectRootEx Class](../vs140/ccomobjectrootex-class.md) and [CComCoClass Class](../vs140/ccomcoclass-class.md) and Visual Studio Library's IVsPackageImpl. For example, following is the VSPackage class declaration from the Reference.Package sample:  
  
<CodeContentPlaceHolder>0\</CodeContentPlaceHolder>  
 The <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> template parameters shown are the VSPackage class itself and a pointer to the GUID identifying the VSPackage.  
  
## Supporting QueryInterface with COM maps  
 To get ATL's support for <CodeContentPlaceHolder>6\</CodeContentPlaceHolder>, its COM map must list the interfaces that the class implements. For example, following is the COM map for the VSPackage class in the Reference.Package sample:  
  
<CodeContentPlaceHolder>1\</CodeContentPlaceHolder>  
 For more information about COM maps, see [Implementing CComObjectRootEx](../vs140/implementing-ccomobjectrootex.md) and [COM_INTERFACE_ENTRY](../vs140/com_interface_entry-macros.md).  
  
## Supporting Registration with Registry Maps  
 Visual Studio Library uses ATL-style .RGS files to support registration of COM objects. To support token replacement in the .RGS file, Visual Studio Library uses registry maps. Registry maps list symbols to be replaced and support the use of IDs for string table resources.  
  
 For example, following is the registry map for the VSPackage class in the Reference.Package sample:  
  
<CodeContentPlaceHolder>2\</CodeContentPlaceHolder>  
## See Also  
 [Visual Studio Extensibility Samples](../vs140/vssdk-samples.md)