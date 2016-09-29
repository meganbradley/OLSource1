---
title: "Introduction to COM Interop (Visual Basic)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-visual-basic"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "VB"
helpviewer_keywords: 
  - "interop assemblies"
  - "COM interop, about COM interop"
ms.assetid: 8bd62e68-383d-407f-998b-29aa0ce0fd67
caps.latest.revision: 16
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Introduction to COM Interop (Visual Basic)
The Component Object Model (COM) lets an object expose its functionality to other components and to host applications. While COM objects have been fundamental to Windows programming for many years, applications designed for the common language runtime (CLR) offer many advantages.  
  
 [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] applications will eventually replace those developed with COM. Until then, you may have to use or create COM objects by using [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)]. Interoperability with COM, or *COM interop*, enables you to use existing COM objects while transitioning to the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] at your own pace.  
  
 By using the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] to create COM components, you can use registration-free COM interop. This lets you control which DLL version is enabled when more than one version is installed on a computer, and lets end users use XCOPY or FTP to copy your application to an appropriate directory on their computer where it can be run. For more information, see [Registration-Free COM Interop](assetId:///90f308b9-82dc-414a-bce1-77e0155e56bd).  
  
## Managed Code and Data  
 Code developed for the [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] is referred to as *managed code*, and contains metadata that is used by CLR. Data used by [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] applications is called *managed data* because the runtime manages data-related tasks such as allocating and reclaiming memory and performing type checking. By default, [!INCLUDE[vbprvblong](../VS_csharp/includes/vbprvblong_md.md)] uses managed code and data, but you can access the unmanaged code and data of COM objects using interop assemblies (described later on this page).  
  
## Assemblies  
 An assembly is the primary building block of a [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] application. It is a collection of functionality that is built, versioned, and deployed as a single implementation unit containing one or more files. Each assembly contains an assembly manifest.  
  
## Type Libraries and Assembly Manifests  
 Type libraries describe characteristics of COM objects, such as member names and data types. Assembly manifests perform the same function for [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] applications. They include information about the following:  
  
-   Assembly identity, version, culture, and digital signature.  
  
-   Files that make up the assembly implementation.  
  
-   Types and resources that make up the assembly. This includes those that are exported from it.  
  
-   Compile-time dependencies on other assemblies.  
  
-   Permissions required for the assembly to run correctly.  
  
 For more information about assemblies and assembly manifests, see [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../VS_csharp/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md).  
  
### Importing and Exporting Type Libraries  
 [!INCLUDE[vsprvs](../VS_csharp/includes/vsprvs_md.md)] contains a utility, Tlbimp, that lets you import information from a type library into a [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] application. You can generate type libraries from assemblies by using the Tlbexp utility.  
  
 For information about Tlbimp and Tlbexp, see [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382) and [Type Library Exporter (Tlbexp.exe)](assetId:///a487d61b-d166-467b-a7ca-d8b52fbff42d).  
  
## Interop Assemblies  
 Interop assemblies are [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] assemblies that bridge between managed and unmanaged code, mapping COM object members to equivalent [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] managed members. Interop assemblies created by [!INCLUDE[vbprvblong](../VS_csharp/includes/vbprvblong_md.md)] handle many of the details of working with COM objects, such as interoperability marshaling.  
  
## Interoperability Marshaling  
 All [!INCLUDE[dnprdnshort](../VS_csharp/includes/dnprdnshort_md.md)] applications share a set of common types that enable interoperability of objects, regardless of the programming language that is used. The parameters and return values of COM objects sometimes use data types that differ from those used in managed code. *Interoperability marshaling* is the process of packaging parameters and return values into equivalent data types as they move to and from COM objects. For more information, see [Interop Marshaling Overview](assetId:///115f7a2f-d422-4605-ab36-13a8dd28142a).  
  
## See Also  
 [COM Interop](../VS_csharp/com-interop--visual-basic-.md)   
 [Walkthrough: Implementing Inheritance with COM Objects](../VS_csharp/walkthrough--implementing-inheritance-with-com-objects--visual-basic-.md)   
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)   
 [Troubleshooting Interoperability](../VS_csharp/troubleshooting-interoperability--visual-basic-.md)   
 [Assemblies and the Global Assembly Cache (C# and Visual Basic)](../VS_csharp/assemblies-and-the-global-assembly-cache--csharp-and-visual-basic-.md)   
 [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382)   
 [Type Library Exporter (Tlbexp.exe)](assetId:///a487d61b-d166-467b-a7ca-d8b52fbff42d)   
 [Interop Marshaling Overview](assetId:///115f7a2f-d422-4605-ab36-13a8dd28142a)   
 [Registration-Free COM Interop](assetId:///90f308b9-82dc-414a-bce1-77e0155e56bd)