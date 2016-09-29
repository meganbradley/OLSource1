---
title: "Installing Database Support (MFC-ATL)"
ms.custom: na
ms.date: "09/22/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "devlang-cpp"
ms.tgt_pltfrm: na
ms.topic: "article"
H1: "Installing Database Support (MFC/ATL)"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "data access [C++], installing database support"
  - "installing database support"
  - "ATL [C++], database support"
  - "databases [C++], installing database support"
ms.assetid: 3820ba96-4fb8-4405-83dd-bb3bc5998667
caps.latest.revision: 14
translation.priority.ht: 
  - "de-de"
  - "ja-jp"
---
# Installing Database Support (MFC-ATL)
When you run Setup for Visual C++ .NET, the following database components are installed automatically:  
  
-   All the necessary ATL OLE DB components. For more information, see [Installing ATL Database Support](../vs140/installing-atl-database-support.md).  
  
-   A set of ODBC drivers with the ODBC driver manager and the ODBC administrator program. For more information, see "ODBC Drivers Installed" and "ODBC SDK Components Installed" in [Installing MFC Database Support](../vs140/installing-mfc-database-support.md).  
  
-   Necessary components from the DAO software development kit (SDK). This includes Help files, which are not integrated with this documentation. However, if you work with DAO, you need to install a version of Jet compatible with your operating system. For more information, see "DAO SDK Components Installed" in [Installing MFC Database Support](../vs140/installing-mfc-database-support.md).  
  
 As part of the baseline installation, Setup also installs Microsoft Data Access Components (MDAC), which are necessary to support data access programming in Visual C++ .NET.  
  
 Visual C++ .NET installs the MDAC 2.7 SDK. You should check the Microsoft Universal Data Access Web site at [http://go.microsoft.com/fwlink/?LinkId=121548](http://go.microsoft.com/fwlink/?LinkId=121548) for updates to and news about the MDAC SDK.  
  
 If you are redistributing data access applications, you should also have the MDAC 2.7 redistribution program. The MDAC 2.7 SDK is designed for use with the MDAC 2.7 redistribution program (Mdac_typ.exe) included in the MDAC directory on the Visual Studio .NET Prerequisites CD-ROM. You can also download Mdac_typ.exe from the MDAC 2.7 SDK download link previously listed. For more information about redistributing components, see [Redistributing Controls](../vs140/redistributing-controls.md).  
  
## See Also  
 [Data Access](../vs140/data-access-in-visual-c--.md)