---
title: "ATL Module Classes"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "CComModule class, what's changed"
  - "ATL, module classes"
  - "module classes"
ms.assetid: fd75382d-c955-46ba-a38e-37728b7fa00f
caps.latest.revision: 12
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# ATL Module Classes
This topic discusses the module classes that were new in ATL 7.0.  
  
## CComModule Replacement Classes  
 Earlier versions of ATL used <CodeContentPlaceHolder>0\</CodeContentPlaceHolder>. In ATL 7.0, <CodeContentPlaceHolder>1\</CodeContentPlaceHolder> functionality is replaced by several classes:  
  
-   [CAtlBaseModule](../vs140/catlbasemodule-class.md) Contains information required by most applications that use ATL. Contains the HINSTANCE of the module and the resource instance.  
  
-   [CAtlComModule](../vs140/catlcommodule-class.md) Contains information required by the COM classes in ATL.  
  
-   [CAtlWinModule](../vs140/catlwinmodule-class.md) Contains information required by the windowing classes in ATL.  
  
-   [CAtlDebugInterfacesModule](../vs140/catldebuginterfacesmodule-class.md) Contains support for interface debugging.  
  
-   [CAtlModule](../vs140/catlmodule-class.md) The following <CodeContentPlaceHolder>2\</CodeContentPlaceHolder>-derived classes are customized to contain information required in a particular application type. Most members in these classes can be overridden:  
  
    -   [CAtlDllModuleT](../vs140/catldllmodulet-class.md) Used in DLL applications. Provides code for the standard exports.  
  
    -   [CAtlExeModuleT](../vs140/catlexemodulet-class.md) Used in EXE applications. Provides code required in an EXE.  
  
    -   [CAtlServiceModuleT](../vs140/catlservicemodulet-class.md) Provides support to create Windows NT and Windows 2000 Services.  
  
 <CodeContentPlaceHolder>3\</CodeContentPlaceHolder> is still available for backward compatibility.  
  
## Reasons for Distributing CComModule Functionality  
 The functionality of <CodeContentPlaceHolder>4\</CodeContentPlaceHolder> was distributed into several new classes for the following reasons:  
  
-   Make the functionality in <CodeContentPlaceHolder>5\</CodeContentPlaceHolder> granular.  
  
     Support for COM, windowing, interface debugging, and application-specific (DLL or EXE) features is now in separate classes.  
  
-   Automatically declare global instance of each of these modules.  
  
     A global instance of the required module classes is linked into the project.  
  
-   Remove the necessity of calling Init and Term methods.  
  
     Init and Term methods have moved into the constructors and destructors for the module classes; there is no longer a need to call Init and Term.  
  
## See Also  
 [Concepts](../vs140/active-template-library--atl--concepts.md)   
 [Class Overview](../vs140/atl-class-overview.md)