---
title: "COM Interoperability in .NET Framework Applications (Visual Basic)"
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
  - "interoperability, COM and .NET framework objects"
  - "COM interop"
  - "shared components"
ms.assetid: f5a72143-c268-4dff-a019-974ad940e17d
caps.latest.revision: 19
author: ""
ms.author: ""
manager: ""
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# COM Interoperability in .NET Framework Applications (Visual Basic)
When you want to use COM objects and .NET Framework objects in the same application, you need to address the differences in how the objects exist in memory. A .NET Framework object is located in managed memory—the memory controlled by the common language runtime—and may be moved by the runtime as needed. A COM object is located in unmanaged memory and is not expected to move to another memory location. [!INCLUDE[vsprvs](../vs140/includes/vsprvs_md.md)] and the [!INCLUDE[dnprdnshort](../vs140/includes/dnprdnshort_md.md)] provide tools to control the interaction of these managed and unmanaged components. For more information about managed code, see [Common Language Runtime](assetId:///059a624e-f7db-4134-ba9f-08b676050482).  
  
 In addition to using COM objects in .NET applications, you may also want to use [!INCLUDE[vbprvb](../vs140/includes/vbprvb_md.md)] to develop objects accessible from unmanaged code through COM.  
  
 The links on this page provide details on the interactions between COM and .NET Framework objects.  
  
## Related Sections  
 [COM Interop](../vs140/com-interop--visual-basic-.md)  
 Provides links to topics covering COM interoperability in Visual Basic, including COM objects, ActiveX controls, Win32 DLLs, managed objects, and inheritance of COM objects.  
  
 [COM Interop Wrapper Error](../vs140/com-interop-wrapper-error.md)  
 Describes the consequences and options if the project system cannot create a COM interoperability wrapper for a particular component.  
  
 [Interoperating with Unmanaged Code](assetId:///ccb68ce7-b0e9-4ffb-839d-03b1cd2c1258)  
 Briefly describes some of the interaction issues between managed and unmanaged code, and provides links for further study.  
  
 [COM Wrappers](assetId:///e56c485b-6b67-4345-8e66-fd21835a6092)  
 Discusses runtime callable wrappers, which allow managed code to call COM methods, and COM callable wrappers, which allow COM clients to call .NET object methods.  
  
 [Advanced COM Interoperability](assetId:///3ada36e5-2390-4d70-b490-6ad8de92f2fb)  
 Provides links to topics covering COM interoperability with respect to wrappers, exceptions, inheritance, threading, events, conversions, and marshaling.  
  
 [Type Library Importer (Tlbimp.exe)](assetId:///ec0a8d63-11b3-4acd-b398-da1e37e97382)  
 Discusses the tool you can use to convert the type definitions found within a COM type library into equivalent definitions in a common language runtime assembly.